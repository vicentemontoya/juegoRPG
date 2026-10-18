namespace juegoRPG
{
    public partial class Form1 : Form
    {
        // ----------------- Estado de la partida -----------------

        private Personaje? jugador;
        private Personaje? enemigo;

        private readonly Random azar = new Random();
        private readonly List<string> bitacora = new List<string>();

        private bool turnoDelJugador = true;
        private bool partidaEnCurso = false;
        private int numeroDeTurno = 0;

        // Se ponen en true al crear cada personaje y vuelven a false al terminar la pelea,
        // asi la siguiente partida exige crear a los dos de nuevo.
        private bool jugadorListo = false;
        private bool enemigoListo = false;

        // ----------------- Inventario -----------------

        private readonly Inventario mochila = new Inventario();
        private readonly Item pocionVida = new Item("Poción de vida", "Consumible", 50, 3);
        private readonly Item anilloPoder = new Item("Anillo de poder", "Accesorio", 10, 1);

        public Form1()
        {
            InitializeComponent();
            PrepararCombos();
            PrepararCamposDeEstadisticas();
            PrepararDeslizadores();
            ActualizarBotones();

            mochila.AgregarItem(pocionVida);
            mochila.AgregarItem(anilloPoder);
            lstInventarioJugador.Visible = false;
            lstInventarioEnemigo.Visible = false;
        }

        // ----------------- Preparacion -----------------

        private void PrepararCombos()
        {
            cboTipoJugador.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEnemigo.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipoJugador.Items.Clear();
            cboTipoEnemigo.Items.Clear();

            foreach (string tipo in Personaje.TiposPersonaje)
            {
                cboTipoJugador.Items.Add(tipo);
            }

            foreach (string tipo in Personaje.TiposEnemigo)
            {
                cboTipoEnemigo.Items.Add(tipo);
            }
        }

        private void PrepararCamposDeEstadisticas()
        {
            TextBox[] vidas = { txtVidaJugador, txtVidaEnemigo };
            TextBox[] ataques = { txtAtaqueJugador, txtAtaqueEnemigo };
            TextBox[] defensas = { txtDefensaJugador, txtDefensaEnemigo };

            foreach (TextBox caja in vidas) caja.PlaceholderText = "1 a 100";
            foreach (TextBox caja in ataques) caja.PlaceholderText = "1 a 50";
            foreach (TextBox caja in defensas) caja.PlaceholderText = "0 a 40";
        }

        // ----------------- Deslizadores de Nivel y Pociones -----------------

        /// <summary>
        ///  El Nivel y las Pociones se eligen con TrackBar: el propio control
        ///  no deja salir del rango, asi que no necesitan validacion.
        /// </summary>
        private void PrepararDeslizadores()
        {
            TrackBar[] niveles = { tbNivelJugador, tbNivelEnemigo };
            TrackBar[] pociones = { tbPocionesJugador, tbPocionesEnemigo };

            foreach (TrackBar barra in niveles)
            {
                barra.Minimum = 1;
                barra.Maximum = 5;
                barra.TickFrequency = 1;
                barra.SmallChange = 1;
                barra.LargeChange = 1;
                barra.Value = 1;
            }

            foreach (TrackBar barra in pociones)
            {
                barra.Minimum = 0;
                barra.Maximum = Personaje.MaximoPociones;
                barra.TickFrequency = 1;
                barra.SmallChange = 1;
                barra.LargeChange = 1;
                barra.Value = Personaje.MaximoPociones;
            }

            MostrarValorDeslizador(tbNivelJugador, lblValorNivelJugador);
            MostrarValorDeslizador(tbNivelEnemigo, lblValorNivelEnemigo);
            MostrarValorDeslizador(tbPocionesJugador, lblValorPocionesJugador);
            MostrarValorDeslizador(tbPocionesEnemigo, lblValorPocionesEnemigo);
        }

        private void MostrarValorDeslizador(TrackBar barra, Label etiqueta)
        {
            etiqueta.Text = barra.Value + " de " + barra.Maximum;
        }

        private void tbNivelJugador_ValueChanged(object sender, EventArgs e)
        {
            MostrarValorDeslizador(tbNivelJugador, lblValorNivelJugador);
        }

        private void tbNivelEnemigo_ValueChanged(object sender, EventArgs e)
        {
            MostrarValorDeslizador(tbNivelEnemigo, lblValorNivelEnemigo);
        }

        private void tbPocionesJugador_ValueChanged(object sender, EventArgs e)
        {
            MostrarValorDeslizador(tbPocionesJugador, lblValorPocionesJugador);
        }

        private void tbPocionesEnemigo_ValueChanged(object sender, EventArgs e)
        {
            MostrarValorDeslizador(tbPocionesEnemigo, lblValorPocionesEnemigo);
        }

        // ----------------- Adelanto de la imagen -----------------

        private void cboTipoJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarVistaPrevia(cboTipoJugador, picJugador);
            txtVidaJugador.Focus();
        }

        private void cboTipoEnemigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarVistaPrevia(cboTipoEnemigo, picEnemigo);
            txtVidaEnemigo.Focus();
        }

        private void MostrarVistaPrevia(ComboBox combo, PictureBox recuadro)
        {
            if (combo.SelectedIndex < 0)
            {
                recuadro.Image = null;
                return;
            }

            recuadro.Image = ImagenesPersonaje.ObtenerVistaPrevia(combo.Text);
        }

        // ----------------- Crear personajes -----------------

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            Personaje? creado = LeerPersonajeDeLaPantalla(
                txtNombreJugador, cboTipoJugador, tbNivelJugador, txtVidaJugador,
                txtAtaqueJugador, txtDefensaJugador, tbPocionesJugador);

            if (creado == null)
            {
                return; // error de validacion, ya se le aviso al usuario
            }

            jugador = creado;
            jugadorListo = true;
            MostrarJugador();
            IntentarIniciarCombate();
        }

        private void btnCrearEnemigo_Click(object sender, EventArgs e)
        {
            Personaje? creado = LeerPersonajeDeLaPantalla(
                txtNombreEnemigo, cboTipoEnemigo, tbNivelEnemigo, txtVidaEnemigo,
                txtAtaqueEnemigo, txtDefensaEnemigo, tbPocionesEnemigo);

            if (creado == null)
            {
                return;
            }

            enemigo = creado;
            enemigoListo = true;
            MostrarEnemigo();
            IntentarIniciarCombate();
        }

        private void btnEnemigoAzar_Click(object sender, EventArgs e)
        {
            Personaje sorteado = Personaje.CrearEnemigoAleatorio(azar);

            MostrarEnLaFicha(sorteado, txtNombreEnemigo, cboTipoEnemigo, tbNivelEnemigo,
                txtVidaEnemigo, txtAtaqueEnemigo, txtDefensaEnemigo, tbPocionesEnemigo);

            // Se usa el objeto sorteado tal cual, no uno rearmado desde la ficha:
            // asi conserva la probabilidad de critico propia de ese enemigo.
            enemigo = sorteado;
            enemigoListo = true;

            MostrarEnemigo();
            IntentarIniciarCombate();
        }

        private void MostrarEnLaFicha(Personaje personaje, TextBox txtNombre, ComboBox cboTipo,
            TrackBar tbNivel, TextBox txtVida, TextBox txtAtaque, TextBox txtDefensa,
            TrackBar tbPociones)
        {
            txtNombre.Text = personaje.Nombre;
            cboTipo.SelectedItem = personaje.TipoPersonaje;
            tbNivel.Value = personaje.Nivel;
            txtVida.Text = personaje.VidaMaxima.ToString();
            txtAtaque.Text = personaje.Ataque.ToString();
            txtDefensa.Text = personaje.Defensa.ToString();
            tbPociones.Value = personaje.Pociones;
        }

        /// <summary>
        ///  Lee y valida los controles de un lado de la pantalla.
        ///  Devuelve null si algun dato esta malo (y muestra el mensaje correspondiente).
        /// </summary>
        private Personaje? LeerPersonajeDeLaPantalla(TextBox txtNombre, ComboBox cboTipo,
            TrackBar tbNivel, TextBox txtVida, TextBox txtAtaque, TextBox txtDefensa,
            TrackBar tbPociones)
        {
            string nombre = txtNombre.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Escribe un nombre para el personaje.", "Falta el nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return null;
            }

            if (cboTipo.SelectedIndex < 0)
            {
                MessageBox.Show("Elige un tipo de personaje.", "Falta el tipo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
                return null;
            }

            int vida;
            int ataque;
            int defensa;

            if (!LeerNumero(txtVida, "Vida", 1, 100, out vida)) return null;
            if (!LeerNumero(txtAtaque, "Ataque", 1, 50, out ataque)) return null;
            if (!LeerNumero(txtDefensa, "Defensa", 0, 40, out defensa)) return null;

            int nivel = tbNivel.Value;
            int pociones = tbPociones.Value;

            return new Personaje(nombre, cboTipo.Text, nivel, vida, ataque, defensa,
                                 Personaje.CriticoPorDefecto, pociones);
        }

        private bool LeerNumero(TextBox caja, string campo, int minimo, int maximo, out int valor)
        {
            if (!int.TryParse(caja.Text.Trim(), out valor))
            {
                MessageBox.Show("El campo " + campo + " debe ser un numero entero.",
                    "Dato invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                caja.Focus();
                caja.SelectAll();
                return false;
            }

            if (valor < minimo || valor > maximo)
            {
                MessageBox.Show("El campo " + campo + " debe estar entre " + minimo + " y " + maximo + ".",
                    "Dato fuera de rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                caja.Focus();
                caja.SelectAll();
                return false;
            }

            return true;
        }

        // ----------------- Combate por turnos -----------------

        /// <summary>
        ///  Arranca la pelea solo cuando los dos personajes fueron creados para esta partida.
        /// </summary>
        private void IntentarIniciarCombate()
        {
            if (!jugadorListo || !enemigoListo)
            {
                // Uno de los dos viene de la partida anterior: hay que crearlo de nuevo.
                if (jugador != null && enemigo != null)
                {
                    MessageBox.Show(
                        "Para empezar una pelea nueva hay que crear a los DOS personajes.\n" +
                        "Falta crear a " + (jugadorListo ? "el enemigo" : "el jugador") + ".",
                        "Falta crear al otro personaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            partidaEnCurso = true;
            turnoDelJugador = true;
            numeroDeTurno = 1;

            bitacora.Clear();
            bitacora.Add(jugador!.Nombre + " (" + jugador.TipoPersonaje + ", nivel " + jugador.Nivel +
                         ") se enfrenta a " + enemigo!.Nombre + " (" + enemigo.TipoPersonaje +
                         ", nivel " + enemigo.Nivel + ").");

            ActualizarBotones();

            MessageBox.Show("Comienza la pelea. Parte atacando " + jugador.Nombre + ".",
                "A pelear", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtacarJugador_Click(object sender, EventArgs e)
        {
            if (!EsTurnoValido(true)) return;
            Atacar(jugador!, enemigo!);
        }

        private void btnAtacarEnemigo_Click(object sender, EventArgs e)
        {
            if (!EsTurnoValido(false)) return;
            Atacar(enemigo!, jugador!);
        }

        private bool EsTurnoValido(bool esElJugador)
        {
            if (!partidaEnCurso)
            {
                MessageBox.Show("Primero tienes que crear los dos personajes.",
                    "Todavia no empieza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (esElJugador != turnoDelJugador)
            {
                MessageBox.Show("No es tu turno. Espera al otro jugador.",
                    "Turno equivocado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Atacar(Personaje atacante, Personaje defensor)
        {
            ResultadoAtaque golpe = atacante.Atacar(defensor, azar);

            string aviso = golpe.FueCritico ? "GOLPE CRITICO! " : "";

            bitacora.Add("Turno " + numeroDeTurno + ": " + aviso + atacante.Nombre +
                         " golpeo a " + defensor.Nombre + " por " + golpe.Danio +
                         " de dano (le quedan " + defensor.Vida + " de vida).");

            RefrescarPantalla();

            if (golpe.FueCritico)
            {
                MessageBox.Show(
                    atacante.Nombre + " ataca a " + defensor.Nombre + ".\n\n" +
                    "GOLPE CRITICO!\n\n" +
                    "Dano causado: " + golpe.Danio,
                    "Golpe critico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (!defensor.EstaVivo)
            {
                TerminarPartida(atacante, defensor);
                return;
            }

            CambiarTurno();
        }

        private void btnPocionJugador_Click(object sender, EventArgs e)
        {
            if (!EsTurnoValido(true)) return;
            BeberPocion(jugador!);
        }

        private void btnPocionEnemigo_Click(object sender, EventArgs e)
        {
            if (!EsTurnoValido(false)) return;
            BeberPocion(enemigo!);
        }

        /// <summary>Cura al personaje. Gastar una pocion consume el turno.</summary>
        private void BeberPocion(Personaje personaje)
        {
            if (personaje.Pociones <= 0)
            {
                MessageBox.Show(personaje.Nombre + " ya no tiene pociones.",
                    "Sin pociones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (personaje.Vida == personaje.VidaMaxima)
            {
                MessageBox.Show(personaje.Nombre + " tiene la vida llena, no necesita una pocion.",
                    "Vida llena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int curado = personaje.UsarPocion();

            bitacora.Add("Turno " + numeroDeTurno + ": " + personaje.Nombre +
                         " bebio una pocion y recupero " + curado + " de vida (le quedan " +
                         personaje.Pociones + " pociones).");

            RefrescarPantalla();
            CambiarTurno();
        }

        private void CambiarTurno()
        {
            turnoDelJugador = !turnoDelJugador;
            numeroDeTurno = numeroDeTurno + 1;
            ActualizarBotones();
        }

        // ----------------- Fin de la partida -----------------

        private void TerminarPartida(Personaje ganador, Personaje perdedor)
        {
            partidaEnCurso = false;
            jugadorListo = false;
            enemigoListo = false;
            ActualizarBotones();

            bitacora.Add(perdedor.Nombre + " cayo derrotado. Gana " + ganador.Nombre + ".");

            MessageBox.Show(ganador.Nombre + " gano la pelea!", "Fin de la partida",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            MostrarBitacora();
        }

        private void MostrarBitacora()
        {
            if (bitacora.Count == 0)
            {
                MessageBox.Show("Todavia no hay nada en la bitacora.",
                    "Bitacora vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string historia = string.Join(Environment.NewLine, bitacora);
            MessageBox.Show(historia, "Bitacora de la pelea", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>Deja el juego como recien abierto: sin personajes, fichas vacias y sin bitacora.</summary>
        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            if (partidaEnCurso)
            {
                DialogResult respuesta = MessageBox.Show(
                    "Hay una pelea en curso. Quieres abandonarla y empezar de cero?",
                    "Nueva partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    return;
                }
            }

            jugador = null;
            enemigo = null;
            jugadorListo = false;
            enemigoListo = false;
            partidaEnCurso = false;
            turnoDelJugador = true;
            numeroDeTurno = 0;
            bitacora.Clear();

            LimpiarFicha(txtNombreJugador, cboTipoJugador, tbNivelJugador, txtVidaJugador,
                txtAtaqueJugador, txtDefensaJugador, tbPocionesJugador);
            LimpiarFicha(txtNombreEnemigo, cboTipoEnemigo, tbNivelEnemigo, txtVidaEnemigo,
                txtAtaqueEnemigo, txtDefensaEnemigo, tbPocionesEnemigo);

            RefrescarPantalla();
            ActualizarBotones();
            txtNombreJugador.Focus();
        }

        private void LimpiarFicha(TextBox txtNombre, ComboBox cboTipo, TrackBar tbNivel,
            TextBox txtVida, TextBox txtAtaque, TextBox txtDefensa, TrackBar tbPociones)
        {
            txtNombre.Clear();
            cboTipo.SelectedIndex = -1;
            tbNivel.Value = tbNivel.Minimum;
            txtVida.Clear();
            txtAtaque.Clear();
            txtDefensa.Clear();
            tbPociones.Value = tbPociones.Maximum;
        }

        // ----------------- Mostrar en pantalla -----------------

        private void RefrescarPantalla()
        {
            MostrarJugador();
            MostrarEnemigo();
        }

        private void MostrarJugador()
        {
            MostrarPersonaje(jugador, picJugador, pbVidaJugador, lblNombreJugador,
                lblVidaJugador, lblNivelJugador, lblAtaqueJugador, lblDefensaJugador,
                lblCriticoJugador, lblPocionesJugador);
        }

        private void MostrarEnemigo()
        {
            MostrarPersonaje(enemigo, picEnemigo, pbVidaEnemigo, lblNombreEnemigo,
                lblVidaEnemigo, lblNivelEnemigo, lblAtaqueEnemigo, lblDefensaEnemigo,
                lblCriticoEnemigo, lblPocionesEnemigo);
        }

        /// <summary>
        ///  Vuelca los datos de un personaje en los controles de su lado.
        ///  Si no hay personaje, deja el lado vacio.
        /// </summary>
        private void MostrarPersonaje(Personaje? personaje, PictureBox recuadro,
            ProgressBar barraVida, Label lblNombre, Label lblVida, Label lblNivel,
            Label lblAtaque, Label lblDefensa, Label lblCritico, Label lblPociones)
        {
            if (personaje == null)
            {
                foreach (Label etiqueta in new[] { lblNombre, lblVida, lblNivel, lblAtaque,
                                                   lblDefensa, lblCritico, lblPociones })
                {
                    etiqueta.Text = "-";
                }
                barraVida.Value = 0;
                recuadro.Image = null;
                return;
            }

            lblNombre.Text = personaje.Nombre + "  (" + personaje.TipoPersonaje + ")";
            lblVida.Text = "Vida: " + personaje.Vida + " / " + personaje.VidaMaxima +
                           "   (" + personaje.CalcularPorcentajeVida() + "%)";
            lblNivel.Text = "Nivel: " + personaje.Nivel;
            lblAtaque.Text = "Ataque: " + personaje.Ataque;
            lblDefensa.Text = "Defensa: " + personaje.Defensa;
            lblCritico.Text = "Critico: " + personaje.ProbabilidadCritico + "%";
            lblPociones.Text = "Pociones: " + personaje.Pociones + " / " + Personaje.MaximoPociones;

            barraVida.Maximum = personaje.VidaMaxima;
            barraVida.Value = personaje.Vida;

            // La imagen cambia segun el tramo de vida en que quedo el personaje.
            recuadro.Image = ImagenesPersonaje.Obtener(personaje.TipoPersonaje, personaje.Estado);
        }

        /// <summary>Habilita solo los botones de quien tiene el turno.</summary>
        private void ActualizarBotones()
        {
            btnAtacarJugador.Enabled = partidaEnCurso && turnoDelJugador;
            btnPocionJugador.Enabled = partidaEnCurso && turnoDelJugador;

            btnAtacarEnemigo.Enabled = partidaEnCurso && !turnoDelJugador;
            btnPocionEnemigo.Enabled = partidaEnCurso && !turnoDelJugador;

            btnCrearJugador.Enabled = !partidaEnCurso;
            btnCrearEnemigo.Enabled = !partidaEnCurso;
            btnEnemigoAzar.Enabled = !partidaEnCurso;
        }

        // ----------------- Inventario -----------------

        private void btnInventarioJugador_Click(object sender, EventArgs e)
        {
            AlternarInventario(lstInventarioJugador);
        }

        private void btnInventarioEnemigo_Click(object sender, EventArgs e)
        {
            AlternarInventario(lstInventarioEnemigo);
        }

        /// <summary>Muestra u oculta la lista y la rellena con los objetos de la mochila.</summary>
        private void AlternarInventario(ListBox lista)
        {
            lista.Items.Clear();
            foreach (Item item in mochila.Objetos)
            {
                lista.Items.Add($"{item.Nombre} x{item.Cantidad}");
            }
            lista.Visible = !lista.Visible;
        }
    }
}
