using PPT.Forms;
using System;
using System.Windows.Forms;

namespace PPT
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ContextoJuego contexto = new ContextoJuego();

            Application.Run(
                new FrmMenuPrincipal(contexto));
        }
    }
}