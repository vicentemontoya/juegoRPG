using System.Collections.Generic; // importar el espacio de nombres (namespace) que contiene las colecciones genéricas.//

namespace juegoRPG
{
    public partial class Form1 : Form
    {
        private Personajes? guerrero;
        private Personajes? enemigo;
        private readonly Random azar = new Random();
        /// <summary>
        ///  todo lo que pasa en la pelea y esto creara la historia al final de la plea
        /// </summary>
        private readonly List<string> bitacora = new List<string>();
        private bool turnoDelGuerrero = true; // de quien es el turno, si es true es del guerrero, si es false es del enemigo
        private bool partidaEnCurso = false;  // hay dos personajes peleando?
        private int numeroDeTurnos = 0;

        public Form1()
        {
            InitializeComponent();
            PrepararCombos();
            PrepararCamposDeEstadisticas();
            ActualizarBotones();
        }

        // ----------------- Preparacion -----------------

        private void PrepararCombos()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            foreach (string clase in Personajes.Clases)
            {
                comboBox1.Items.Add(clase);
            }

            foreach (string clase in Personajes.ClasesEnemigos)
            {
                comboBox2.Items.Add(clase);
            }
        }

        /// <summary>
        ///  Las estadisticas las escribe el usuario.
        ///  Cada TextBox muestra en gris el rango permitido como pista.
        /// </summary>
        private void PrepararCamposDeEstadisticas()
        {
            TextBox[] niveles = { txtNivelGuerrero, txtNivelEnemigo };
            TextBox[] ataques = { txtAtaqueGuerrero, txtAtaqueEnemigo };
            TextBox[] defensas = { txtDefensaGuerrero, txtDefensaEnemigo };
            TextBox[] vidas = { txtVidaGuerrero, txtVidaEnemigo };
            TextBox[] pociones = { txtPocionesGuerrero, txtPocionesEnemigo };

            foreach (TextBox caja in niveles) caja.PlaceholderText = "1 a 5";
            foreach (TextBox caja in ataques) caja.PlaceholderText = "1 a 50";
            foreach (TextBox caja in defensas) caja.PlaceholderText = "0 a 40";
            foreach (TextBox caja in vidas) caja.PlaceholderText = "1 a 100";
            foreach (TextBox caja in pociones) caja.PlaceholderText = "0 a " + Personajes.MaximoPociones;
        }

        // ----------------- Crear personajes -----------------

        private void btnCrearGuerrero_Click(object sender, EventArgs e)
        {
            Personajes? creado = LeerPersonajeDeLaPantalla(
                txtNombreGuerrero, comboBox1, txtNivelGuerrero, txtAtaqueGuerrero,
                txtDefensaGuerrero, txtVidaGuerrero, txtPocionesGuerrero);

            if (creado == null)
            {
                return; // hubo un error de validacion, ya se le aviso al usuario
            }

            guerrero = creado;
            MostrarGuerrero();
            IntentarIniciarCombate();
        }

        private void btnCrearEnemigo_Click(object sender, EventArgs e)
        {
            Personajes? creado = LeerPersonajeDeLaPantalla(
                txtNombreEnemigo, comboBox2, txtNivelEnemigo, txtAtaqueEnemigo,
                txtDefensaEnemigo, txtVidaEnemigo, txtPocionesEnemigo);

            if (creado == null)
            {
                return;
            }

            enemigo = creado;
            MostrarEnemigo();
            IntentarIniciarCombate();
        }

        /// <summary>
        ///  Lee y valida los controles de un lado de la pantalla.
        ///  Devuelve null si algun dato esta malo (y muestra el mensaje correspondiente).
        /// </summary>
        private Personajes? LeerPersonajeDeLaPantalla(TextBox txtNombre, ComboBox cboClase,
            TextBox txtNivel, TextBox txtAtaque, TextBox txtDefensa, TextBox txtVida, TextBox txtPociones)
        {
            string nombre = txtNombre.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Escribe un nombre para el personaje.", "Falta el nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return null;
            }

            if (cboClase.SelectedIndex < 0)
            {
                MessageBox.Show("Elige un tipo de clase.", "Falta la clase",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboClase.Focus();
                return null;
            }

            int nivel;
            int ataque;
            int defensa;
            int vida;
            int pociones;

            if (!LeerNumero(txtNivel, "Nivel", 1, 5, out nivel)) return null;
            if (!LeerNumero(txtAtaque, "Ataque", 1, 50, out ataque)) return null;
            if (!LeerNumero(txtDefensa, "Defensa", 0, 40, out defensa)) return null;
            if (!LeerNumero(txtVida, "Vida", 1, 100, out vida)) return null;
            if (!LeerNumero(txtPociones, "Pociones", 0, 20, out pociones)) return null;

            // ---- Regla: maximo 3 pociones por partida ----
            if (pociones > Personajes.MaximoPociones)
            {
                MessageBox.Show(
                    "Solo se permiten " + Personajes.MaximoPociones + " pociones por partida.",
                    "Limite de pociones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pociones = Personajes.MaximoPociones;
                txtPociones.Text = pociones.ToString();
            }

            // Ojo con el orden: asi esta escrito el constructor de Personajes.
            return new Personajes(nombre, cboClase.Text, nivel, defensa, vida, ataque, pociones);
        }

        /// <summary>Convierte el texto de un TextBox a numero y revisa que este en rango.</summary>
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
        ///  Arranca la pelea solo cuando existen los dos personajes y ambos estan vivos
        ///  (el que perdio la partida anterior hay que crearlo de nuevo).
        /// </summary>
        private void IntentarIniciarCombate()
        {
            if (guerrero == null || enemigo == null || !guerrero.EstaVivo || !enemigo.EstaVivo)
            {
                ActualizarBotones();
                return;
            }

            partidaEnCurso = true;
            turnoDelGuerrero = true;
            numeroDeTurnos = 1;

            bitacora.Clear();
            bitacora.Add(guerrero.Nombre + " (" + guerrero.ClasePersonaje + ", nivel " + guerrero.Nivel +
                         ") se enfrenta a " + enemigo.Nombre + " (" + enemigo.ClasePersonaje + ", nivel " +
                         enemigo.Nivel + ").");

            ActualizarBotones();

            MessageBox.Show("Comienza la pelea. Parte atacando " + guerrero.Nombre + ".",
                "A pelear", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAtacarGuerrero_Click(object sender, EventArgs e)
        {
            if (!partidaEnCurso || !turnoDelGuerrero) return;
            Atacar(guerrero!, enemigo!);
        }

        private void btnAtacarEnemigo_Click(object sender, EventArgs e)
        {
            if (!partidaEnCurso || turnoDelGuerrero) return;
            Atacar(enemigo!, guerrero!);
        }

        /// <summary>Aplica un ataque, revisa si alguien murio y pasa el turno.</summary>
        private void Atacar(Personajes atacante, Personajes defensor)
        {
            int dano = atacante.CalcularDano(defensor, azar);
            defensor.RecibirDano(dano);

            bitacora.Add("Turno " + numeroDeTurnos + ": " + atacante.Nombre + " golpeo a " +
                         defensor.Nombre + " por " + dano + " de dano (le quedan " +
                         defensor.Vida + " de vida).");

            RefrescarPantalla();

            if (!defensor.EstaVivo)
            {
                TerminarPartida(atacante, defensor);
                return;
            }

            CambiarTurno();
        }

        private void btnPocionesGuerrero_Click(object sender, EventArgs e)
        {
            if (!partidaEnCurso || !turnoDelGuerrero) return;
            UsarPocion(guerrero!);
        }

        private void btnPocionesEnemigo_Click(object sender, EventArgs e)
        {
            if (!partidaEnCurso || turnoDelGuerrero) return;
            UsarPocion(enemigo!);
        }

        /// <summary>Cura al personaje. Gastar una pocion consume el turno.</summary>
        private void UsarPocion(Personajes personaje)
        {
            if (personaje.Pociones <= 0)
            {
                MessageBox.Show(personaje.Nombre + " ya no tiene pociones.",
                    "Sin pociones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int curado = personaje.UsarPocion();

            bitacora.Add("Turno " + numeroDeTurnos + ": " + personaje.Nombre +
                         " bebio una pocion y recupero " + curado + " de vida (le quedan " +
                         personaje.Pociones + " pociones).");

            RefrescarPantalla();
            CambiarTurno();
        }

        private void CambiarTurno()
        {
            turnoDelGuerrero = !turnoDelGuerrero;
            numeroDeTurnos = numeroDeTurnos + 1;
            ActualizarBotones();
        }

        // ----------------- Fin de la partida -----------------

        private void TerminarPartida(Personajes ganador, Personajes perdedor)
        {
            partidaEnCurso = false;
            ActualizarBotones();

            bitacora.Add(perdedor.Nombre + " cayo derrotado. Gana " + ganador.Nombre + ".");

            MessageBox.Show(ganador.Nombre + " gano la pelea!", "Fin de la partida",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ===== TODO (esta parte la haces tu) =====
            // 1) Mostrar la historia de la pelea usando la lista "bitacora",
            //    que ya tiene guardado turno por turno todo lo que paso.
            // 2) Dejar el tablero limpio para crear personajes nuevos.
            //    (Primero la historia y despues limpiar, o se pierden los datos.)
            // poner imagenes de los personajes en la pantalla de victoria y derrota, si quieres puedes poner un boton para reiniciar la partida y crear nuevos personajes.
        }

        // ----------------- Mostrar en pantalla -----------------

        private void RefrescarPantalla()
        {
            MostrarGuerrero();
            MostrarEnemigo();
        }

        private void MostrarGuerrero()
        {
            if (guerrero == null) return;

            lblNombreGuerrero.Text = guerrero.Nombre + " (" + guerrero.ClasePersonaje + ")";
            lblVidaGuerrero.Text = "Vida: " + guerrero.Vida + " / " + guerrero.VidaMaxima;
            lblNivelGuerrero.Text = "Nivel: " + guerrero.Nivel + "  |  Pociones: " + guerrero.Pociones;
            lblAtaqueGuerrero.Text = "Ataque: " + guerrero.Ataque;
            lblDefensaGuerrero.Text = "Defensa: " + guerrero.Defensa;

            progressBar1.Maximum = guerrero.VidaMaxima;
            progressBar1.Value = guerrero.Vida;
        }

        private void MostrarEnemigo()
        {
            if (enemigo == null) return;

            lblNombreEnemigo.Text = enemigo.Nombre + " (" + enemigo.ClasePersonaje + ")";
            lblVidaEnemigo.Text = "Vida: " + enemigo.Vida + " / " + enemigo.VidaMaxima;
            lblNivelEnemigo.Text = "Nivel: " + enemigo.Nivel + "  |  Pociones: " + enemigo.Pociones;
            lblAtaqueEnemigo.Text = "Ataque: " + enemigo.Ataque;
            lblDefensaEnemigo.Text = "Defensa: " + enemigo.Defensa;

            progressBar2.Maximum = enemigo.VidaMaxima;
            progressBar2.Value = enemigo.Vida;
        }

        /// <summary>
        ///  Habilita solo los botones de quien tiene el turno.
        ///  Esto es lo que hace que el juego sea realmente por turnos.
        /// </summary>
        private void ActualizarBotones()
        {
            btnAtacarGuerrero.Enabled = partidaEnCurso && turnoDelGuerrero;
            btnPocionesGuerrero.Enabled = partidaEnCurso && turnoDelGuerrero;

            btnAtacarEnemigo.Enabled = partidaEnCurso && !turnoDelGuerrero;
            btnPocionesEnemigo.Enabled = partidaEnCurso && !turnoDelGuerrero;

            // Mientras hay pelea no se pueden crear personajes nuevos.
            btnCrearGuerrero.Enabled = !partidaEnCurso;
            btnCrearEnemigo.Enabled = !partidaEnCurso;
        }
    }
}
