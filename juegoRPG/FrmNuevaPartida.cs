namespace juegoRPG
{
    /// <summary>
    ///  Ventana de creacion del personaje.
    ///
    ///  No abre el combate por su cuenta: arma el EstadoPartida, lo deja en la
    ///  propiedad Partida y devuelve DialogResult.OK. El menu es el que decide
    ///  que hacer con el. Asi esta ventana no necesita saber nada del combate.
    /// </summary>
    public partial class FrmNuevaPartida : Form
    {
        /// <summary>La partida recien creada. Queda en null si el usuario cancela.</summary>
        public EstadoPartida? Partida { get; private set; }

        public FrmNuevaPartida()
        {
            InitializeComponent();
            PrepararClases();
        }

        private void PrepararClases()
        {
            cboClase.Items.Clear();
            foreach (string clase in Personaje.TiposPersonaje)
            {
                cboClase.Items.Add(clase);
            }
        }

        /// <summary>Al elegir clase se muestran sus estadisticas y su imagen.</summary>
        private void cboClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClase.SelectedIndex < 0)
            {
                lblStats.Text = "Elige una clase para ver sus estadisticas.";
                picClase.Image = null;
                return;
            }

            string clase = cboClase.Text;
            var datos = EstadoPartida.EstadisticasDe(clase);

            lblStats.Text =
                "Vida:      " + datos.Vida + Environment.NewLine + Environment.NewLine +
                "Ataque:    " + datos.Ataque + Environment.NewLine + Environment.NewLine +
                "Defensa:   " + datos.Defensa + Environment.NewLine + Environment.NewLine +
                "Critico:   " + datos.Critico + "%" + Environment.NewLine + Environment.NewLine +
                "Comienzas con 3 pociones, una espada y un escudo en la mochila.";

            picClase.Image = ImagenesPersonaje.ObtenerVistaPrevia(clase);
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (nombre.Length == 0)
            {
                MessageBox.Show("Escribe un nombre para tu luchador.", "Falta el nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (cboClase.SelectedIndex < 0)
            {
                MessageBox.Show("Elige una clase.", "Falta la clase",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboClase.Focus();
                return;
            }

            // La clase arma el personaje y su inventario inicial.
            Partida = EstadoPartida.Nueva(nombre, cboClase.Text);

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
