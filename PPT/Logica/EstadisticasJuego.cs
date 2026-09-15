using System.Collections.Generic;

namespace PPT
{
    public class EstadisticasJuego
    {
        private readonly HistorialAprendizaje historial;

        public EstadisticasJuego(HistorialAprendizaje historialRecibido)
        {
            historial = historialRecibido;
        }

        public int ObtenerTotalPartidas()
        {
            return historial.Cantidad;
        }

        public int ObtenerVictorias()
        {
            int total = 0;

            foreach (Ronda ronda in historial.ObtenerRondas())
            {
                if (ronda.Resultado == ResultadoRonda.GanaJugador)
                {
                    total++;
                }
            }

            return total;
        }

        public int ObtenerDerrotas()
        {
            int total = 0;

            foreach (Ronda ronda in historial.ObtenerRondas())
            {
                if (ronda.Resultado == ResultadoRonda.GanaIA)
                {
                    total++;
                }
            }

            return total;
        }

        public int ObtenerEmpates()
        {
            int total = 0;

            foreach (Ronda ronda in historial.ObtenerRondas())
            {
                if (ronda.Resultado == ResultadoRonda.Empate)
                {
                    total++;
                }
            }

            return total;
        }

        public int ObtenerEntrenamientos()
        {
            int total = 0;

            foreach (Ronda ronda in historial.ObtenerRondas())
            {
                if (ronda.Modo == ModoBatalla.Entrenamiento)
                {
                    total++;
                }
            }

            return total;
        }

        public int ObtenerPartidasJuego()
        {
            int total = 0;

            foreach (Ronda ronda in historial.ObtenerRondas())
            {
                if (ronda.Modo == ModoBatalla.Juego)
                {
                    total++;
                }
            }

            return total;
        }
    }
}