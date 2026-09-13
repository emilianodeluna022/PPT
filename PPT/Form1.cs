using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            
            int jugador = 0;
            int ia = 0;
            bool resultado = false;
            int jugar = 0;
            
            
            //string volver;
            button1.Tag = 1;
            button2.Tag = 2;
            button3.Tag = 3;

            button1.Click += BotonJugada_Click;
            button2.Click += BotonJugada_Click;
            button3.Click += BotonJugada_Click;

        }

        private void JugarRonda(int jugador)
        {
            // AQUI SE JUEGA EL JUEGO 
            int ia = MovimientoIA();
            VerificarGanador(jugador, ia);
        }

        private int MovimientoIA()
        {
            int decisionIA = rnd.Next(1, 4); // 1 a 3 inclusive
            return decisionIA;
        }

        private bool VerificarGanador(int jugador, int ia)
        {
            if (jugador == ia)
            {
                MessageBox.Show("EMPATE IA ESCOGIO "+ NombreJugada(ia));
                return false;
            }

            // Casos en los que gana el jugador
            if ((jugador == 1 && ia == 3) || (jugador == 2 && ia == 1) || (jugador == 3 && ia == 2))
            {
                MessageBox.Show("GANASTE IA ESCOGIO " + NombreJugada(ia));
                return true;
            }
            else
            {
                MessageBox.Show("PERDISTE IA ESCOGIO " + NombreJugada(ia));
                return true;
            }
        }

        private string NombreJugada(int valor)
        {
            switch (valor)
            {
                case 1: return "Piedra";
                case 2: return "Papel";
                case 3: return "Tijera";
                default: return "Desconocido";
            }
        }

        private void BotonJugada_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            int jugador = (int)botonPresionado.Tag; // 1, 2 o 3 según el botón

            JugarRonda(jugador);
        }
    }
}
