namespace PPT
{
    public class ContextoJuego
    {
        public HistorialAprendizaje Historial { get; private set; }

        public ContextoJuego()
        {
            Historial = new HistorialAprendizaje();
        }
    }
}