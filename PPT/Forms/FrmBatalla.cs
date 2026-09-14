using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PPT
{
    public partial class FrmBatalla : Form
    {
        Random rnd = new Random();
        private ModoBatalla modoActual;
        private EstadoBatalla estadoActual;
        private ContextoJuego contexto;
        public FrmBatalla() : this(new ContextoJuego(), ModoBatalla.Juego)
        {
        }

        public FrmBatalla(ContextoJuego contextoRecibido, ModoBatalla modoRecibido)
        {
            InitializeComponent();

            contexto = contextoRecibido;
            modoActual = modoRecibido;
            estadoActual = EstadoBatalla.TurnoJugador;

            MostrarEstadoVisual();
            picZonaFuego.Tag = Jugada.Piedra;
            picZonaAgua.Tag = Jugada.Papel;
            picZonaPlanta.Tag = Jugada.Tijera;

            picZonaFuego.Click += ZonaJugada_Click;
            picZonaAgua.Click += ZonaJugada_Click;
            picZonaPlanta.Click += ZonaJugada_Click;
            picZonaSalir.Click += ZonaSalir_Click;
        }
        private void MostrarEstadoVisual()
        {
            if (estadoActual == EstadoBatalla.TurnoJugador)
            {
                picSeleccionIA.Visible = false;
            }
            if (modoActual == ModoBatalla.Juego)
            {
                if (estadoActual == EstadoBatalla.TurnoJugador)
                {
                    pnlEscena.BackgroundImage =
                        Properties.Resources.BatallaJuegoTurno;
                }
                else
                {
                    pnlEscena.BackgroundImage =
                        Properties.Resources.BatallaJuegoSeleccion;
                }
            }
            else
            {
                if (estadoActual == EstadoBatalla.TurnoJugador)
                {
                    pnlEscena.BackgroundImage =
                        Properties.Resources.BatallaEntrenamientoTurno;
                }
                else
                {
                    pnlEscena.BackgroundImage =
                        Properties.Resources.BatallaEntrenamientoSeleccion;
                }
            }
        }
        private void ZonaJugada_Click(object sender, EventArgs e)
        {
            PictureBox zonaPresionada = (PictureBox)sender;
            Jugada jugador = (Jugada)zonaPresionada.Tag;

            JugarRonda(jugador);
        }

        private void ZonaSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JugarRonda(Jugada jugador)
        {
            HabilitarJugadas(false);

            Jugada ia = MovimientoIA();
            ResultadoRonda resultado = VerificarGanador(jugador, ia);

            
            Ronda ronda = new Ronda();

            ronda.Jugador = jugador;
            ronda.IA = ia;
            ronda.Resultado = resultado;
            ronda.Modo = modoActual;

            contexto.Historial.Registrar(ronda);
            List<Jugada> vector = contexto.Historial.ObtenerVector();

            Text = "Aprendizajes: " +
                   contexto.Historial.Cantidad +
                   " | Última: " +
                   jugador;
            estadoActual = EstadoBatalla.MostrarSeleccion;
            MostrarEstadoVisual();
            MostrarSeleccionIA(ia);

            tmrRonda.Start();
        }

        private Jugada MovimientoIA()
        {
            return (Jugada)rnd.Next(1, 4);
        }

        private ResultadoRonda VerificarGanador(Jugada jugador, Jugada ia)
        {
            if (jugador == ia)
            {
                return ResultadoRonda.Empate;
            }

            if ((jugador == Jugada.Piedra && ia == Jugada.Tijera) ||
                (jugador == Jugada.Papel && ia == Jugada.Piedra) ||
                (jugador == Jugada.Tijera && ia == Jugada.Papel))
            {
                return ResultadoRonda.GanaJugador;
            }

            return ResultadoRonda.GanaIA;
        }
        private void MostrarSeleccionIA(Jugada ia)
        {
            if (ia == Jugada.Piedra)
            {
                picSeleccionIA.Image =
                    Properties.Resources.SeleccionFuego;
            }
            else if (ia == Jugada.Papel)
            {
                picSeleccionIA.Image =
                    Properties.Resources.SeleccionAgua;
            }
            else
            {
                picSeleccionIA.Image =
                    Properties.Resources.SeleccionPlanta;
            }

            picSeleccionIA.Visible = true;
        }

        private void tmrRonda_Tick(object sender, EventArgs e)
        {
            tmrRonda.Stop();

            estadoActual = EstadoBatalla.TurnoJugador;

            MostrarEstadoVisual();

            HabilitarJugadas(true);
        }
        private void HabilitarJugadas(bool habilitar)
        {
            picZonaFuego.Enabled = habilitar;
            picZonaAgua.Enabled = habilitar;
            picZonaPlanta.Enabled = habilitar;
        }
    }
}
