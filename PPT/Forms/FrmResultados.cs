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

            picZonaMarkov.Click += ZonaMarkov_Click;
            picZonaVolverResumen.Click += ZonaVolverResumen_Click;
            picZonaSalirResultados.Click += ZonaSalir_Click;
            picZonaSalirMarkov.Click += ZonaSalir_Click;

            CargarResultados();
            MostrarResumen();
        }
        private void CargarResultados()
        {
            lblTotal.Text =
    contexto.Estadisticas.ObtenerTotalPartidas().ToString();

            lblEntrenamientos.Text =
                contexto.Estadisticas.ObtenerEntrenamientos().ToString();

            lblJuego.Text =
                contexto.Estadisticas.ObtenerPartidasJuego().ToString();

            lblVictorias.Text =
                contexto.Estadisticas.ObtenerVictorias().ToString();

            lblDerrotas.Text =
                contexto.Estadisticas.ObtenerDerrotas().ToString();

            lblEmpates.Text =
                contexto.Estadisticas.ObtenerEmpates().ToString();

            MostrarVector();
            MostrarMatriz();
        }
        private void MostrarVector()
        {
            flpVector.Controls.Clear();

            List<Jugada> vector = contexto.Historial.ObtenerVector();

            int inicio = Math.Max(0, vector.Count - 8);

            for (int i = inicio; i < vector.Count; i++)
            {
                PictureBox icono = new PictureBox();

                icono.Image = ObtenerImagenJugada(vector[i]);
                icono.SizeMode = PictureBoxSizeMode.Zoom;
                icono.Width = 45;
                icono.Height = 45;
                icono.Margin = new Padding(3);
                icono.BackColor = Color.Transparent;

                flpVector.Controls.Add(icono);
            }
        }
        private void MostrarMatriz()
        {
            double[,] matriz = contexto.Markov.ObtenerMatrizProbabilidades();

            lblFuegoFuego.Text = matriz[0, 0].ToString("P1");
            lblFuegoAgua.Text = matriz[0, 1].ToString("P1");
            lblFuegoPlanta.Text = matriz[0, 2].ToString("P1");

            lblAguaFuego.Text = matriz[1, 0].ToString("P1");
            lblAguaAgua.Text = matriz[1, 1].ToString("P1");
            lblAguaPlanta.Text = matriz[1, 2].ToString("P1");

            lblPlantaFuego.Text = matriz[2, 0].ToString("P1");
            lblPlantaAgua.Text = matriz[2, 1].ToString("P1");
            lblPlantaPlanta.Text = matriz[2, 2].ToString("P1");
        }

        private void ZonaMarkov_Click(object sender, EventArgs e)
        {
            MostrarMarkov();
        }

        private void ZonaVolverResumen_Click(object sender, EventArgs e)
        {
            MostrarResumen();
        }

        private void ZonaSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostrarResumen()
        {
            pnlResumen.Visible = true;
            pnlMarkov.Visible = false;
            pnlResumen.BringToFront();
        }

        private void MostrarMarkov()
        {
            pnlResumen.Visible = false;
            pnlMarkov.Visible = true;
            pnlMarkov.BringToFront();
        }
        private Image ObtenerImagenJugada(Jugada jugada)
        {
            if (jugada == Jugada.Piedra)
            {
                return Properties.Resources.SeleccionFuego;
            }

            if (jugada == Jugada.Papel)
            {
                return Properties.Resources.SeleccionAgua;
            }

            return Properties.Resources.SeleccionPlanta;
        }
    }
}
