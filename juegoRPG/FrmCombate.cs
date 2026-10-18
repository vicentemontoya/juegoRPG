namespace juegoRPG
{
    /// <summary>
    ///  Ventana de combate.
    ///
    ///  Recibe la partida por constructor y trabaja siempre sobre ese objeto.
    ///  Desde aqui se abre el inventario, se guarda el progreso y se vuelve al menu.
    ///
    ///  El rival lo elige el juego al azar entre los tres enemigos disponibles,
    ///  y responde solo despues de cada accion del jugador.
    /// </summary>
    public partial class FrmCombate : Form
    {
        private readonly EstadoPartida partida;
        private readonly Random azar = new Random();

        private Personaje enemigo;
        private bool combateTerminado = false;
        private int numeroDeTurno = 1;

        public FrmCombate(EstadoPartida partidaActual)
        {
            InitializeComponent();

            partida = partidaActual;
            enemigo = Personaje.CrearEnemigoAleatorio(azar);

            Registrar(partida.Jugador.Nombre + " se enfrenta a " + enemigo.Nombre +
                      " (" + enemigo.TipoPersonaje + ").");

            RefrescarTodo();
        }

        // ----------------- Historial -----------------

        /// <summary>Guarda la linea en la partida y la muestra en el ListBox.</summary>
        private void Registrar(string linea)
        {
            partida.Historial.Add(linea);
            lstHistorial.Items.Add(linea);
            lstHistorial.TopIndex = lstHistorial.Items.Count - 1;
        }

        // ----------------- Mostrar en pantalla -----------------

        /// <summary>
        ///  Vuelve a pintar toda la pantalla con los datos actuales.
        ///  Es el metodo que se llama al volver del inventario.
        /// </summary>
        private void ActualizarInterfaz()
        {
            RefrescarTodo();
        }

        private void RefrescarTodo()
        {
            MostrarPersonaje(partida.Jugador, picJugador, pbVidaJugador,
                lblNombreJugador, lblVidaJugador, lblStatsJugador);

            MostrarPersonaje(enemigo, picEnemigo, pbVidaEnemigo,
                lblNombreEnemigo, lblVidaEnemigo, lblStatsEnemigo);

            int pociones = partida.PocionesDisponibles();
            lblPociones.Text = "Pociones en la mochila: " + pociones;

            if (combateTerminado)
            {
                lblTurno.Text = partida.Jugador.EstaVivo ? "Has ganado el combate" : "Has sido derrotado";
            }
            else
            {
                lblTurno.Text = "Turno " + numeroDeTurno + " - es tu turno";
            }

            ActualizarBotones();
        }

        private void MostrarPersonaje(Personaje p, PictureBox recuadro, ProgressBar barra,
            Label lblNombre, Label lblVida, Label lblStats)
        {
            lblNombre.Text = p.Nombre + "  (" + p.TipoPersonaje + ")";
            lblVida.Text = "Vida: " + p.Vida + " / " + p.VidaMaxima +
                           "  (" + p.CalcularPorcentajeVida() + "%)";

            lblStats.Text =
                "Ataque:  " + p.Ataque + Environment.NewLine + Environment.NewLine +
                "Defensa: " + p.Defensa + Environment.NewLine + Environment.NewLine +
                "Critico: " + p.ProbabilidadCritico + "%";

            barra.Maximum = p.VidaMaxima;
            barra.Value = p.Vida;

            // La imagen cambia sola segun el tramo de vida en que quedo.
            recuadro.Image = ImagenesPersonaje.Obtener(p.TipoPersonaje, p.Estado);
        }

        private void ActualizarBotones()
        {
            btnAtacar.Enabled = !combateTerminado;
            btnPocion.Enabled = !combateTerminado && partida.PocionesDisponibles() > 0;
            btnInventario.Enabled = !combateTerminado;
        }

        // ----------------- Turnos -----------------

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            if (combateTerminado) return;

            ResultadoAtaque golpe = partida.Jugador.Atacar(enemigo, azar);

            Registrar("Turno " + numeroDeTurno + ": " + (golpe.FueCritico ? "GOLPE CRITICO! " : "") +
                      partida.Jugador.Nombre + " golpea a " + enemigo.Nombre +
                      " por " + golpe.Danio + " (le quedan " + enemigo.Vida + ").");

            RefrescarTodo();

            if (!enemigo.EstaVivo)
            {
                TerminarCombate(true);
                return;
            }

            TurnoDelEnemigo();
        }

        private void btnPocion_Click(object sender, EventArgs e)
        {
            if (combateTerminado) return;

            // La pocion sale del inventario: es la misma lista que ve FrmInventario.
            Item? pocion = PrimeraPocionDisponible();

            if (pocion == null)
            {
                MessageBox.Show("No te quedan pociones en la mochila.", "Sin pociones",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (partida.Jugador.Vida >= partida.Jugador.VidaMaxima)
            {
                MessageBox.Show("Tienes la vida llena.", "Vida completa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int curado = partida.UsarConsumible(pocion);

            Registrar("Turno " + numeroDeTurno + ": " + partida.Jugador.Nombre +
                      " bebe " + pocion.Nombre + " y recupera " + curado +
                      " (quedan " + pocion.Cantidad + ").");

            RefrescarTodo();
            TurnoDelEnemigo();
        }

        private Item? PrimeraPocionDisponible()
        {
            foreach (Item item in partida.Inventario)
            {
                if (item.EsConsumible && item.Cantidad > 0)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>El rival responde solo: ataca, o bebe si esta muy herido y le quedan pociones.</summary>
        private void TurnoDelEnemigo()
        {
            if (combateTerminado || !enemigo.EstaVivo)
            {
                return;
            }

            if (enemigo.Pociones > 0 && enemigo.CalcularPorcentajeVida() <= 30)
            {
                int curado = enemigo.UsarPocion();
                Registrar("Turno " + numeroDeTurno + ": " + enemigo.Nombre +
                          " bebe una pocion y recupera " + curado +
                          " (le quedan " + enemigo.Pociones + ").");
            }
            else
            {
                ResultadoAtaque golpe = enemigo.Atacar(partida.Jugador, azar);
                Registrar("Turno " + numeroDeTurno + ": " + (golpe.FueCritico ? "GOLPE CRITICO! " : "") +
                          enemigo.Nombre + " golpea a " + partida.Jugador.Nombre +
                          " por " + golpe.Danio + " (te quedan " + partida.Jugador.Vida + ").");
            }

            numeroDeTurno = numeroDeTurno + 1;
            RefrescarTodo();

            if (!partida.Jugador.EstaVivo)
            {
                TerminarCombate(false);
            }
        }

        private void TerminarCombate(bool ganoElJugador)
        {
            combateTerminado = true;

            Registrar(ganoElJugador
                ? enemigo.Nombre + " cae derrotado. Gana " + partida.Jugador.Nombre + "."
                : partida.Jugador.Nombre + " cae derrotado. Gana " + enemigo.Nombre + ".");

            RefrescarTodo();

            MessageBox.Show(
                ganoElJugador
                    ? "Has ganado el combate contra " + enemigo.Nombre + "."
                    : enemigo.Nombre + " te ha derrotado.",
                "Fin del combate", MessageBoxButtons.OK,
                ganoElJugador ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation);
        }

        // ----------------- Botones de la barra superior -----------------

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Se le pasa la MISMA partida: el inventario modifica este personaje,
            // no una copia. Por eso al volver hay que repintar la pantalla.
            using (FrmInventario ventana = new FrmInventario(partida))
            {
                ventana.ShowDialog(this);
            }

            ActualizarInterfaz();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool ok = GestorPartida.Guardar(partida, out mensaje);

            MessageBox.Show(mensaje, ok ? "Partida guardada" : "No se pudo guardar",
                MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok)
            {
                Registrar("Partida guardada en " + GestorPartida.NombreArchivo + ".");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!combateTerminado)
            {
                DialogResult respuesta = MessageBox.Show(
                    "Si vuelves al menu se pierde el combate en curso.\n" +
                    "Guardaste tu partida?",
                    "Volver al menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    return;
                }
            }

            Close();
        }
    }
}
