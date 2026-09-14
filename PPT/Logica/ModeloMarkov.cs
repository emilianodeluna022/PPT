using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    public class ModeloMarkov
    {
        private readonly HistorialAprendizaje historial;
        private readonly Random rnd;

        public ModeloMarkov(HistorialAprendizaje historialRecibido)
        {
            historial = historialRecibido;
            rnd = new Random();
        }

        public int[,] ObtenerMatrizTransiciones()
        {
            int[,] matriz = new int[3, 3];

            List<Jugada> vector = historial.ObtenerVector();

            for (int i = 0; i < vector.Count - 1; i++)
            {
                int anterior = (int)vector[i] - 1;
                int siguiente = (int)vector[i + 1] - 1;

                matriz[anterior, siguiente]++;
            }

            return matriz;
        }
        public double[,] ObtenerMatrizProbabilidades()
        {
            int[,] transiciones = ObtenerMatrizTransiciones();
            double[,] probabilidades = new double[3, 3];

            for (int fila = 0; fila < 3; fila++)
            {
                int total = 0;

                for (int columna = 0; columna < 3; columna++)
                {
                    total += transiciones[fila, columna];
                }

                if (total == 0)
                {
                    continue;
                }

                for (int columna = 0; columna < 3; columna++)
                {
                    probabilidades[fila, columna] =
                        (double)transiciones[fila, columna] / total;
                }
            }

            return probabilidades;
        }
        public Jugada PredecirSiguiente()
        {
            Jugada? ultimaJugada = historial.ObtenerUltimaJugada();

            if (!ultimaJugada.HasValue)
            {
                return (Jugada)rnd.Next(1, 4);
            }

            int[,] matriz = ObtenerMatrizTransiciones();

            int fila = (int)ultimaJugada.Value - 1;

            int piedra = matriz[fila, 0];
            int papel = matriz[fila, 1];
            int tijera = matriz[fila, 2];

            int total = piedra + papel + tijera;

            if (total == 0)
            {
                return (Jugada)rnd.Next(1, 4);
            }

            int seleccion = rnd.Next(total);

            if (seleccion < piedra)
            {
                return Jugada.Piedra;
            }

            if (seleccion < piedra + papel)
            {
                return Jugada.Papel;
            }

            return Jugada.Tijera;
        }
    }
}
