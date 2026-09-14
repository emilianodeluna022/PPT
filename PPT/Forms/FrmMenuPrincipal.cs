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
            MessageBox.Show(
                "Resultados en desarrollo.\n\nAprendizajes actuales: " +
                contexto.Historial.Cantidad);
        }
        private void ZonaSalirMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
