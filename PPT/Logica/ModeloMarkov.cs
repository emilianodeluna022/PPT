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
    }
}
