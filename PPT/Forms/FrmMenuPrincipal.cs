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
        private Size tamanoBaseMenu;
        private Dictionary<Control, Rectangle> posicionesBaseMenu;

        public FrmMenuPrincipal(ContextoJuego contextoRecibido)
        {
            InitializeComponent();

            contexto = contextoRecibido;

            tamanoBaseMenu = pnlMenu.ClientSize;

            posicionesBaseMenu = new Dictionary<Control, Rectangle>();

            posicionesBaseMenu.Add(picZonaEntrenar, picZonaEntrenar.Bounds);
            posicionesBaseMenu.Add(picZonaJugar, picZonaJugar.Bounds);
            posicionesBaseMenu.Add(picZonaResultados, picZonaResultados.Bounds);
            posicionesBaseMenu.Add(picZonaSalirMenu, picZonaSalirMenu.Bounds);

            picZonaEntrenar.Click += ZonaEntrenar_Click;
            picZonaJugar.Click += ZonaJugar_Click;
            picZonaResultados.Click += ZonaResultados_Click;
            picZonaSalirMenu.Click += ZonaSalirMenu_Click;

            pnlMenu.Resize += PnlMenu_Resize;
        }
        private void PnlMenu_Resize(object sender, EventArgs e)
        {
            AjustarZonasMenu();
        }
        private void EscalarZona(
    Control control,
    double escalaX,
    double escalaY)
        {
            Rectangle original =
                posicionesBaseMenu[control];

            control.SetBounds(
                (int)Math.Round(original.X * escalaX),
                (int)Math.Round(original.Y * escalaY),
                (int)Math.Round(original.Width * escalaX),
                (int)Math.Round(original.Height * escalaY));
        }
        private void AjustarZonasMenu()
        {
            if (tamanoBaseMenu.Width == 0 || tamanoBaseMenu.Height == 0)
            {
                return;
            }

            double escalaX =
                (double)pnlMenu.ClientSize.Width /
                tamanoBaseMenu.Width;

            double escalaY =
                (double)pnlMenu.ClientSize.Height /
                tamanoBaseMenu.Height;

            EscalarZona(picZonaEntrenar, escalaX, escalaY);
            EscalarZona(picZonaJugar, escalaX, escalaY);
            EscalarZona(picZonaResultados, escalaX, escalaY);
            EscalarZona(picZonaSalirMenu, escalaX, escalaY);
        }
        private void ZonaEntrenar_Click(object sender, EventArgs e)
        {
            Hide();

            using (FrmBatalla batalla =
                new FrmBatalla(
                    contexto,
                    ModoBatalla.Entrenamiento))
            {
                batalla.ShowDialog();
            }

            Show();
        }
        private void ZonaJugar_Click(object sender, EventArgs e)
        {
            Hide();

            using (FrmBatalla batalla =
                new FrmBatalla(
                    contexto,
                    ModoBatalla.Juego))
            {
                batalla.ShowDialog();
            }

            Show();
        }
        private void ZonaResultados_Click(object sender, EventArgs e)
        {
            Hide();

            using (FrmResultados resultados =
                new FrmResultados(contexto))
            {
                resultados.ShowDialog();
            }

            Show();
        }
        private void ZonaSalirMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
