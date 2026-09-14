namespace PPT
{
    public class ContextoJuego
    {
        public HistorialAprendizaje Historial { get; private set; }
        public ModeloMarkov Markov { get; private set; }

        public ContextoJuego()
        {
            Historial = new HistorialAprendizaje();
            Markov = new ModeloMarkov(Historial);
        }
    }
}