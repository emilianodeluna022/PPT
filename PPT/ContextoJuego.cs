using System.Collections.Generic;

namespace PPT
{
    public class ContextoJuego
    {
        private RepositorioAprendizaje repositorio;

        public HistorialAprendizaje Historial { get; private set; }
        public ModeloMarkov Markov { get; private set; }

        public ContextoJuego()
        {
            Historial = new HistorialAprendizaje();
            repositorio = new RepositorioAprendizaje();

            CargarAprendizaje();

            Markov = new ModeloMarkov(Historial);
        }

        private void CargarAprendizaje()
        {
            List<Ronda> rondas = repositorio.Cargar();

            foreach (Ronda ronda in rondas)
            {
                Historial.Registrar(ronda);
            }
        }

        public void GuardarAprendizaje()
        {
            repositorio.Guardar(Historial);
        }
    }
}