namespace juegoRPG
{
    /// <summary>
    ///  Recupera la partida guardada en disco.
    ///
    ///  Primero comprueba que el archivo exista, despues lo valida y lo reconstruye,
    ///  y recien entonces muestra un resumen para que el usuario confirme.
    ///  Si el archivo no existe, esta vacio o viene danado, lo dice y no deja continuar.
    /// </summary>
    public partial class FrmCargarPartida : Form
    {
        /// <summary>La partida recuperada. Queda en null si no se pudo cargar o si se cancela.</summary>
        public EstadoPartida? Partida { get; private set; }

        private EstadoPartida? cargada;

        public FrmCargarPartida()
        {
            InitializeComponent();
            lblRuta.Text = GestorPartida.Ruta;
            IntentarCargar();
        }

        private void IntentarCargar()
        {
            string mensaje;
            cargada = GestorPartida.Cargar(out mensaje);

            if (cargada == null)
            {
                // Archivo inexistente, vacio o invalido: se avisa y no se deja continuar.
                lblEstado.ForeColor = Color.FromArgb(150, 40, 36);
                lblEstado.Text = mensaje;
                lblResumen.Text = "No hay nada que mostrar.";
                picClase.Image = null;
                btnContinuar.Enabled = false;
                return;
            }

            lblEstado.ForeColor = Color.FromArgb(28, 100, 64);
            lblEstado.Text = mensaje;
            btnContinuar.Enabled = true;
            MostrarResumen(cargada);
        }

        private void MostrarResumen(EstadoPartida partida)
        {
            Personaje j = partida.Jugador;

            string texto =
                j.Nombre + "  (" + j.TipoPersonaje + ")" + Environment.NewLine + Environment.NewLine +
                "Vida:     " + j.Vida + " / " + j.VidaMaxima +
                "   (" + j.CalcularPorcentajeVida() + "%)" + Environment.NewLine +
                "Ataque:   " + j.Ataque + Environment.NewLine +
                "Defensa:  " + j.Defensa + Environment.NewLine +
                "Critico:  " + j.ProbabilidadCritico + "%" + Environment.NewLine + Environment.NewLine +
                "Mochila:" + Environment.NewLine;

            if (partida.Inventario.Count == 0)
            {
                texto = texto + "   (vacia)";
            }
            else
            {
                foreach (Item item in partida.Inventario)
                {
                    texto = texto + "   - " + item.Descripcion() + Environment.NewLine;
                }
            }

            lblResumen.Text = texto;
            picClase.Image = ImagenesPersonaje.Obtener(j.TipoPersonaje, j.Estado);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cargada == null)
            {
                return;
            }

            Partida = cargada;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Partida = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
