using System.Collections.Generic;

namespace PPT
{
    public class HistorialAprendizaje
    {
        private const int MaximoAprendizajes = 200;

        private readonly List<Ronda> rondas = new List<Ronda>();

        public int Cantidad
        {
            get
            {
                return rondas.Count;
            }
        }

        public void Registrar(Ronda ronda)
        {
            if (rondas.Count == MaximoAprendizajes)
            {
                rondas.RemoveAt(0);
            }

            rondas.Add(ronda);
        }

        public List<Jugada> ObtenerVector()
        {
            List<Jugada> vector = new List<Jugada>();

            foreach (Ronda ronda in rondas)
            {
                vector.Add(ronda.Jugador);
            }

            return vector;
        }

        public List<Ronda> ObtenerRondas()
        {
            return new List<Ronda>(rondas);
        }
        public Jugada? ObtenerUltimaJugada()
        {
            if (rondas.Count == 0)
            {
                return null;
            }

            return rondas[rondas.Count - 1].Jugador;
        }
    }
}