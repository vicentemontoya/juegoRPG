namespace juegoRPG
{
    /// <summary>
    ///  Primera ventana del juego. Desde aqui se empieza una partida nueva,
    ///  se recupera una guardada o se cierra la aplicacion.
    ///
    ///  Las ventanas se abren con ShowDialog(), asi que no se pueden abrir dos
    ///  veces al mismo tiempo ni quedan ventanas sueltas dando vueltas.
    /// </summary>
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            MostrarPortada();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActualizarAvisoDePartida();
        }

        /// <summary>Carga la imagen de portada; si falta el archivo, el recuadro queda vacio.</summary>
        private void MostrarPortada()
        {
            string ruta = Path.Combine(AppContext.BaseDirectory,
                                       ImagenesPersonaje.Carpeta, "menu", "portada.jpg");

            if (!File.Exists(ruta))
            {
                return;
            }

            try
            {
                using (MemoryStream memoria = new MemoryStream(File.ReadAllBytes(ruta)))
                using (Image original = Image.FromStream(memoria))
                {
                    picPortada.Image = new Bitmap(original);
                }
            }
            catch (Exception)
            {
                picPortada.Image = null;
            }
        }

        /// <summary>Avisa si hay o no una partida guardada, para que Cargar no sea una sorpresa.</summary>
        private void ActualizarAvisoDePartida()
        {
            if (GestorPartida.ExistePartida())
            {
                lblAvisoPartida.Text = "Hay una partida guardada en " + GestorPartida.NombreArchivo + ".";
                btnCargarPartida.Enabled = true;
            }
            else
            {
                lblAvisoPartida.Text = "Todavia no hay ninguna partida guardada.";
                btnCargarPartida.Enabled = false;
            }
        }

        // ----------------- Botones -----------------

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            EstadoPartida? partida;

            using (FrmNuevaPartida ventana = new FrmNuevaPartida())
            {
                if (ventana.ShowDialog(this) != DialogResult.OK)
                {
                    return; // el usuario se arrepintio
                }
                partida = ventana.Partida;
            }

            if (partida != null)
            {
                Combatir(partida);
            }
        }

        private void btnCargarPartida_Click(object sender, EventArgs e)
        {
            EstadoPartida? partida;

            using (FrmCargarPartida ventana = new FrmCargarPartida())
            {
                if (ventana.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
                partida = ventana.Partida;
            }

            if (partida != null)
            {
                Combatir(partida);
            }
        }

        /// <summary>
        ///  Abre el combate con la partida recibida. El menu se esconde mientras tanto
        ///  y vuelve a aparecer cuando el combate se cierra.
        /// </summary>
        private void Combatir(EstadoPartida partida)
        {
            Hide();

            using (FrmCombate combate = new FrmCombate(partida))
            {
                combate.ShowDialog(this);
            }

            Show();
            ActualizarAvisoDePartida();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicacion completa, sin dejar procesos abiertos.
            Application.Exit();
        }
    }
}
