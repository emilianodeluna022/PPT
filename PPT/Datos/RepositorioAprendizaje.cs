using System;
using System.Collections.Generic;
using System.IO;

namespace PPT
{
    public class RepositorioAprendizaje
    {
        private readonly string rutaArchivo;

        public RepositorioAprendizaje()
        {
            string carpeta = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos");

            Directory.CreateDirectory(carpeta);

            rutaArchivo = Path.Combine(
                carpeta,
                "aprendizaje.txt");
        }

        public void Guardar(HistorialAprendizaje historial)
        {
            List<Ronda> rondas = historial.ObtenerRondas();
            List<string> lineas = new List<string>();

            foreach (Ronda ronda in rondas)
            {
                string linea =
                    ronda.Jugador + "|" +
                    ronda.IA + "|" +
                    ronda.Resultado + "|" +
                    ronda.Modo;

                lineas.Add(linea);
            }

            File.WriteAllLines(rutaArchivo, lineas);
        }

        public List<Ronda> Cargar()
        {
            List<Ronda> rondas = new List<Ronda>();

            if (!File.Exists(rutaArchivo))
            {
                return rondas;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');

                if (datos.Length != 4)
                {
                    continue;
                }

                Jugada jugador;
                Jugada ia;
                ResultadoRonda resultado;
                ModoBatalla modo;

                bool jugadorValido =
                    Enum.TryParse(datos[0], out jugador);

                bool iaValida =
                    Enum.TryParse(datos[1], out ia);

                bool resultadoValido =
                    Enum.TryParse(datos[2], out resultado);

                bool modoValido =
                    Enum.TryParse(datos[3], out modo);

                if (jugadorValido &&
                    iaValida &&
                    resultadoValido &&
                    modoValido)
                {
                    Ronda ronda = new Ronda();

                    ronda.Jugador = jugador;
                    ronda.IA = ia;
                    ronda.Resultado = resultado;
                    ronda.Modo = modo;

                    rondas.Add(ronda);
                }
            }

            return rondas;
        }
    }
}