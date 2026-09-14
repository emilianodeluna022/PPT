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
    public partial class FrmMenuPrincipal : Form
    {
        private ContextoJuego contexto;
     
        public FrmMenuPrincipal(ContextoJuego contextoRecibido)
        {
            InitializeComponent();

            contexto = contextoRecibido;

            picZonaEntrenar.Click += ZonaEntrenar_Click;
            picZonaJugar.Click += ZonaJugar_Click;
            picZonaResultados.Click += ZonaResultados_Click;
            picZonaSalirMenu.Click += ZonaSalirMenu_Click;
        }
        private void ZonaEntrenar_Click(object sender, EventArgs e)
        {
            using (FrmBatalla batalla =
                new FrmBatalla(contexto, ModoBatalla.Entrenamiento))
            {
                batalla.ShowDialog();
            }
        }
        private void ZonaJugar_Click(object sender, EventArgs e)
        {
            using (FrmBatalla batalla =
                new FrmBatalla(contexto, ModoBatalla.Juego))
            {
                batalla.ShowDialog();
            }
        }
        private void ZonaResultados_Click(object sender, EventArgs e)
        {
            double[,] matriz =
                contexto.Markov.ObtenerMatrizProbabilidades();

            string texto =
                "              Piedra   Papel   Tijera\n" +
                "Piedra     " +
                matriz[0, 0].ToString("P2") + "   " +
                matriz[0, 1].ToString("P2") + "   " +
                matriz[0, 2].ToString("P2") + "\n" +

                "Papel       " +
                matriz[1, 0].ToString("P2") + "   " +
                matriz[1, 1].ToString("P2") + "   " +
                matriz[1, 2].ToString("P2") + "\n" +

                "Tijera      " +
                matriz[2, 0].ToString("P2") + "   " +
                matriz[2, 1].ToString("P2") + "   " +
                matriz[2, 2].ToString("P2");

            MessageBox.Show(texto);
        }
        private void ZonaSalirMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
