using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT.Forms
{
    public partial class FrmResultados : Form
    {
        private readonly ContextoJuego contexto;
        public FrmResultados(ContextoJuego contextoRecibido)
        {
            InitializeComponent();

            contexto = contextoRecibido;

            CargarResultados();
        }
        private void CargarResultados()
        {
            lblTotal.Text =
                "Partidas totales: " +
                contexto.Estadisticas.ObtenerTotalPartidas();

            lblEntrenamientos.Text =
                "Entrenamientos: " +
                contexto.Estadisticas.ObtenerEntrenamientos();

            lblJuego.Text =
                "Partidas contra IA: " +
                contexto.Estadisticas.ObtenerPartidasJuego();

            lblVictorias.Text =
                "Victorias: " +
                contexto.Estadisticas.ObtenerVictorias();

            lblDerrotas.Text =
                "Derrotas: " +
                contexto.Estadisticas.ObtenerDerrotas();

            lblEmpates.Text =
                "Empates: " +
                contexto.Estadisticas.ObtenerEmpates();

            MostrarVector();
            MostrarMatriz();
        }
        private void MostrarVector()
        {
            List<Jugada> vector =
                contexto.Historial.ObtenerVector();

            string texto = "";

            foreach (Jugada jugada in vector)
            {
                if (jugada == Jugada.Piedra)
                {
                    texto += "F ";
                }
                else if (jugada == Jugada.Papel)
                {
                    texto += "A ";
                }
                else
                {
                    texto += "P ";
                }
            }

            txtVector.Text = texto;
        }
        private void MostrarMatriz()
        {
            double[,] matriz =
                contexto.Markov.ObtenerMatrizProbabilidades();

            DataTable tabla = new DataTable();

            tabla.Columns.Add("Anterior");
            tabla.Columns.Add("Fuego");
            tabla.Columns.Add("Agua");
            tabla.Columns.Add("Planta");

            tabla.Rows.Add(
                "Fuego",
                matriz[0, 0].ToString("P2"),
                matriz[0, 1].ToString("P2"),
                matriz[0, 2].ToString("P2"));

            tabla.Rows.Add(
                "Agua",
                matriz[1, 0].ToString("P2"),
                matriz[1, 1].ToString("P2"),
                matriz[1, 2].ToString("P2"));

            tabla.Rows.Add(
                "Planta",
                matriz[2, 0].ToString("P2"),
                matriz[2, 1].ToString("P2"),
                matriz[2, 2].ToString("P2"));

            dgvMatriz.DataSource = tabla;
        }

        private void btnSalirResultados_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
