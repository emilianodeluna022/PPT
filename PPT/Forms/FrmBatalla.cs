using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PPT
{
    public partial class FrmBatalla : Form
    {
        Random rnd = new Random();
        private ModoBatalla modoActual;
        private EstadoBatalla estadoActual;
        private ContextoJuego contexto;
        private Size tamanoBaseBatalla;
        private ResultadoRonda resultadoActual;
        private Dictionary<Control, Rectangle> posicionesBaseBatalla;
        public FrmBatalla() : this(new ContextoJuego(), ModoBatalla.Juego)
        {
        }

        public FrmBatalla(
    ContextoJuego contextoRecibido,
    ModoBatalla modoRecibido)
        {
            InitializeComponent();

            AutoScaleMode = AutoScaleMode.None;

            contexto = contextoRecibido;
            modoActual = modoRecibido;
            estadoActual = EstadoBatalla.TurnoJugador;

            picZonaFuego.Tag = Jugada.Piedra;
            picZonaAgua.Tag = Jugada.Papel;
            picZonaPlanta.Tag = Jugada.Tijera;

            picZonaFuego.Click += ZonaJugada_Click;
            picZonaAgua.Click += ZonaJugada_Click;
            picZonaPlanta.Click += ZonaJugada_Click;
            picZonaSalir.Click += ZonaSalir_Click;

            GuardarPosicionesBaseBatalla();

            pnlEscena.Resize += PnlEscena_Resize;

            MostrarEstadoVisual();
        }
        private void GuardarPosicionesBaseBatalla()
        {
            tamanoBaseBatalla = pnlEscena.ClientSize;

            posicionesBaseBatalla =
                new Dictionary<Control, Rectangle>();

            posicionesBaseBatalla.Add(
                picZonaFuego,
                picZonaFuego.Bounds);

            posicionesBaseBatalla.Add(
                picZonaAgua,
                picZonaAgua.Bounds);

            posicionesBaseBatalla.Add(
                picZonaPlanta,
                picZonaPlanta.Bounds);

            posicionesBaseBatalla.Add(
                picZonaSalir,
                picZonaSalir.Bounds);

            posicionesBaseBatalla.Add(
                picSeleccionIA,
                picSeleccionIA.Bounds);

            posicionesBaseBatalla.Add(
                picResultadoRonda,
                picResultadoRonda.Bounds);
        }
        private void PnlEscena_Resize(object sender, EventArgs e)
        {
            AjustarControlesBatalla();
        }
        private void AjustarControlesBatalla()
        {
            if (tamanoBaseBatalla.Width == 0 ||
                tamanoBaseBatalla.Height == 0)
            {
                return;
            }

            double escalaX =
                (double)pnlEscena.ClientSize.Width /
                tamanoBaseBatalla.Width;

            double escalaY =
                (double)pnlEscena.ClientSize.Height /
                tamanoBaseBatalla.Height;

            EscalarControlBatalla(
                picZonaFuego,
                escalaX,
                escalaY);

            EscalarControlBatalla(
                picZonaAgua,
                escalaX,
                escalaY);

            EscalarControlBatalla(
                picZonaPlanta,
                escalaX,
                escalaY);

            EscalarControlBatalla(
                picZonaSalir,
                escalaX,
                escalaY);

            EscalarControlBatalla(
                picSeleccionIA,
                escalaX,
                escalaY);

            EscalarControlBatalla(
                picResultadoRonda,
                escalaX,
                escalaY);
        }
        private void EscalarControlBatalla(
    Control control,
    double escalaX,
    double escalaY)
        {
            Rectangle original =
                posicionesBaseBatalla[control];

            control.SetBounds(
                (int)Math.Round(original.X * escalaX),
                (int)Math.Round(original.Y * escalaY),
                (int)Math.Round(original.Width * escalaX),
                (int)Math.Round(original.Height * escalaY));
        }
        private void MostrarEstadoVisual()
        {
            if (estadoActual == EstadoBatalla.TurnoJugador)
            {
                picSeleccionIA.Visible = false;
                picResultadoRonda.Visible = false;
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

            resultadoActual =
                VerificarGanador(jugador, ia);

            Ronda ronda = new Ronda();

            ronda.Jugador = jugador;
            ronda.IA = ia;
            ronda.Resultado = resultadoActual;
            ronda.Modo = modoActual;

            contexto.Historial.Registrar(ronda);
            contexto.GuardarAprendizaje();

            estadoActual =
                EstadoBatalla.MostrarSeleccion;

            picResultadoRonda.Visible = false;

            MostrarEstadoVisual();
            MostrarSeleccionIA(ia);

            tmrRonda.Interval = 1000;
            tmrRonda.Start();
        }
        private void MostrarResultadoRonda(
    ResultadoRonda resultado)
        {
            if (resultado == ResultadoRonda.GanaJugador)
            {
                picResultadoRonda.Image =
                    Properties.Resources.ResultadoGanaste;
            }
            else if (resultado == ResultadoRonda.GanaIA)
            {
                picResultadoRonda.Image =
                    Properties.Resources.ResultadoPerdiste;
            }
            else
            {
                picResultadoRonda.Image =
                    Properties.Resources.ResultadoEmpate;
            }

            picResultadoRonda.Visible = true;
            picResultadoRonda.BringToFront();
        }

        private Jugada MovimientoIA()
        {
            if (modoActual == ModoBatalla.Entrenamiento)
            {
                return (Jugada)rnd.Next(1, 4);
            }

            Jugada prediccion =
                contexto.Markov.PredecirSiguiente();

            return Contrarrestar(prediccion);
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

        private void tmrRonda_Tick(
    object sender,
    EventArgs e)
        {
            if (estadoActual ==
                EstadoBatalla.MostrarSeleccion)
            {
                estadoActual =
                    EstadoBatalla.MostrarResultado;

                MostrarResultadoRonda(
                    resultadoActual);

                tmrRonda.Interval = 1300;

                return;
            }

            if (estadoActual ==
                EstadoBatalla.MostrarResultado)
            {
                tmrRonda.Stop();

                estadoActual =
                    EstadoBatalla.TurnoJugador;

                picResultadoRonda.Visible = false;
                picSeleccionIA.Visible = false;

                MostrarEstadoVisual();

                HabilitarJugadas(true);
            }
        }
        private void HabilitarJugadas(bool habilitar)
        {
            picZonaFuego.Enabled = habilitar;
            picZonaAgua.Enabled = habilitar;
            picZonaPlanta.Enabled = habilitar;
        }
        private Jugada Contrarrestar(Jugada prediccion)
        {
            if (prediccion == Jugada.Piedra)
            {
                return Jugada.Papel;
            }

            if (prediccion == Jugada.Papel)
            {
                return Jugada.Tijera;
            }

            return Jugada.Piedra;
        }
    }
}
