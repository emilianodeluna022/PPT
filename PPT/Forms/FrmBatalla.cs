using System;
using System.Windows.Forms;

namespace PPT
{
    public partial class FrmBatalla : Form
    {
        Random rnd = new Random();
        public FrmBatalla()
        {
            InitializeComponent();
            
            int jugador = 0;
            int ia = 0;
            bool resultado = false;
            int jugar = 0;
            
            btnPiedra.Tag = Jugada.Piedra;
            btnPapel.Tag = Jugada.Papel;
            btnTijera.Tag = Jugada.Tijera;

            btnPiedra.Click += BotonJugada_Click;
            btnPapel.Click += BotonJugada_Click;
            btnTijera.Click += BotonJugada_Click;

        }

        private void JugarRonda(Jugada jugador)
        {
            Jugada ia = MovimientoIA();
            VerificarGanador(jugador, ia);
        }

        private Jugada MovimientoIA()
        {
            return (Jugada)rnd.Next(1, 4);
        }

        private void VerificarGanador(Jugada jugador, Jugada ia)
        {
            if (jugador == ia)
            {
                MessageBox.Show(
                    "EMPATE\n\n" +
                    "Tú: " + jugador +
                    "\nIA: " + ia);

                return;
            }

            if ((jugador == Jugada.Piedra && ia == Jugada.Tijera) ||
                (jugador == Jugada.Papel && ia == Jugada.Piedra) ||
                (jugador == Jugada.Tijera && ia == Jugada.Papel))
            {
                MessageBox.Show(
                    "GANASTE\n\n" +
                    "Tú: " + jugador +
                    "\nIA: " + ia);

                return;
            }

            MessageBox.Show(
                "PERDISTE\n\n" +
                "Tú: " + jugador +
                "\nIA: " + ia);
        }

        private void BotonJugada_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            Jugada jugador = (Jugada)botonPresionado.Tag;

            JugarRonda(jugador);
        }
    }
}
