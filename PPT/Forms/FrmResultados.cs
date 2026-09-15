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
        private Size tamanoBaseResumen;
        private Size tamanoBaseMarkov;

        private Dictionary<Control, Rectangle> posicionesBaseResumen;
        private Dictionary<Control, Rectangle> posicionesBaseMarkov;

        private Dictionary<Control, float> fuentesBaseResumen;
        private Dictionary<Control, float> fuentesBaseMarkov;
        public FrmResultados(ContextoJuego contextoRecibido)
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.None;

            contexto = contextoRecibido;

            picZonaMarkov.Click += ZonaMarkov_Click;
            picZonaVolverResumen.Click += ZonaVolverResumen_Click;
            picZonaSalirResultados.Click += ZonaSalir_Click;
            picZonaSalirMarkov.Click += ZonaSalir_Click;

            GuardarPosicionesResumen();
            GuardarPosicionesMarkov();

            pnlResumen.Resize += PnlResumen_Resize;
            pnlMarkov.Resize += PnlMarkov_Resize;

            CargarResultados();
            MostrarResumen();
        }
        private void GuardarPosicionesResumen()
        {
            tamanoBaseResumen = pnlResumen.ClientSize;

            posicionesBaseResumen =
                new Dictionary<Control, Rectangle>();

            fuentesBaseResumen =
                new Dictionary<Control, float>();

            Control[] controles =
            {
        lblTotal,
        lblVictorias,
        lblDerrotas,
        lblEmpates,
        lblEntrenamientos,
        lblJuego,
        flpVector,
        picZonaMarkov,
        picZonaSalirResultados
    };

            foreach (Control control in controles)
            {
                posicionesBaseResumen.Add(
                    control,
                    control.Bounds);
            }

            Control[] textos =
            {
        lblTotal,
        lblVictorias,
        lblDerrotas,
        lblEmpates,
        lblEntrenamientos,
        lblJuego
    };

            foreach (Control control in textos)
            {
                fuentesBaseResumen.Add(
                    control,
                    control.Font.Size);
            }
        }
        private void GuardarPosicionesMarkov()
        {
            tamanoBaseMarkov = pnlMarkov.ClientSize;

            posicionesBaseMarkov =
                new Dictionary<Control, Rectangle>();

            fuentesBaseMarkov =
                new Dictionary<Control, float>();

            Control[] controles =
            {
        lblFuegoFuego,
        lblFuegoAgua,
        lblFuegoPlanta,

        lblAguaFuego,
        lblAguaAgua,
        lblAguaPlanta,

        lblPlantaFuego,
        lblPlantaAgua,
        lblPlantaPlanta,

        picZonaVolverResumen,
        picZonaSalirMarkov
    };

            foreach (Control control in controles)
            {
                posicionesBaseMarkov.Add(
                    control,
                    control.Bounds);
            }

            Control[] textos =
            {
        lblFuegoFuego,
        lblFuegoAgua,
        lblFuegoPlanta,

        lblAguaFuego,
        lblAguaAgua,
        lblAguaPlanta,

        lblPlantaFuego,
        lblPlantaAgua,
        lblPlantaPlanta
    };

            foreach (Control control in textos)
            {
                fuentesBaseMarkov.Add(
                    control,
                    control.Font.Size);
            }
        }
        private void PnlResumen_Resize(object sender, EventArgs e)
        {
            AjustarResumen();
        }
        private void AjustarResumen()
        {
            if (tamanoBaseResumen.Width == 0 ||
                tamanoBaseResumen.Height == 0)
            {
                return;
            }

            double escalaX =
                (double)pnlResumen.ClientSize.Width /
                tamanoBaseResumen.Width;

            double escalaY =
                (double)pnlResumen.ClientSize.Height /
                tamanoBaseResumen.Height;

            foreach (Control control in posicionesBaseResumen.Keys)
            {
                EscalarControl(
                    control,
                    posicionesBaseResumen[control],
                    escalaX,
                    escalaY);
            }

            double escalaFuente =
                Math.Min(escalaX, escalaY);

            foreach (Control control in fuentesBaseResumen.Keys)
            {
                EscalarFuente(
                    control,
                    fuentesBaseResumen[control],
                    escalaFuente);
            }

            AjustarIconosVector(
                escalaX,
                escalaY);
        }
        private void PnlMarkov_Resize(object sender, EventArgs e)
        {
            AjustarMarkov();
        }
        private void AjustarMarkov()
        {
            if (tamanoBaseMarkov.Width == 0 ||
                tamanoBaseMarkov.Height == 0)
            {
                return;
            }

            double escalaX =
                (double)pnlMarkov.ClientSize.Width /
                tamanoBaseMarkov.Width;

            double escalaY =
                (double)pnlMarkov.ClientSize.Height /
                tamanoBaseMarkov.Height;

            foreach (Control control in posicionesBaseMarkov.Keys)
            {
                EscalarControl(
                    control,
                    posicionesBaseMarkov[control],
                    escalaX,
                    escalaY);
            }

            double escalaFuente =
                Math.Min(escalaX, escalaY);

            foreach (Control control in fuentesBaseMarkov.Keys)
            {
                EscalarFuente(
                    control,
                    fuentesBaseMarkov[control],
                    escalaFuente);
            }
        }
        private void EscalarControl(
    Control control,
    Rectangle original,
    double escalaX,
    double escalaY)
        {
            control.SetBounds(
                (int)Math.Round(original.X * escalaX),
                (int)Math.Round(original.Y * escalaY),
                (int)Math.Round(original.Width * escalaX),
                (int)Math.Round(original.Height * escalaY));
        }
        private void EscalarFuente(
    Control control,
    float tamanoOriginal,
    double escala)
        {
            float nuevoTamano =
                (float)(tamanoOriginal * escala);

            if (nuevoTamano < 6)
            {
                nuevoTamano = 6;
            }

            control.Font = new Font(
                control.Font.FontFamily,
                nuevoTamano,
                control.Font.Style);
        }
        private void AjustarIconosVector(
    double escalaX,
    double escalaY)
        {
            foreach (Control control in flpVector.Controls)
            {
                if (control is PictureBox)
                {
                    control.Width =
                        (int)Math.Round(45 * escalaX);

                    control.Height =
                        (int)Math.Round(45 * escalaY);

                    control.Margin = new Padding(
                        (int)Math.Round(3 * escalaX),
                        (int)Math.Round(3 * escalaY),
                        (int)Math.Round(3 * escalaX),
                        (int)Math.Round(3 * escalaY));
                }
            }
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
                AjustarResumen();
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

            AjustarResumen();
        }

        private void MostrarMarkov()
        {
            pnlResumen.Visible = false;
            pnlMarkov.Visible = true;
            pnlMarkov.BringToFront();
            AjustarMarkov();
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
