namespace juegoRPG
{
    /// <summary>
    ///  Administra los objetos del personaje.
    ///
    ///  Recibe el MISMO EstadoPartida que usa el combate, no una copia: por eso
    ///  beber una pocion o equipar la espada aqui se nota alla al volver.
    /// </summary>
    public partial class FrmInventario : Form
    {
        private readonly EstadoPartida partida;

        public FrmInventario(EstadoPartida partidaActual)
        {
            InitializeComponent();
            partida = partidaActual;

            lblPersonaje.Text = partida.Jugador.Nombre + " (" + partida.Jugador.TipoPersonaje + ")";
            RefrescarTodo();
        }

        // ----------------- Mostrar -----------------

        private void RefrescarTodo()
        {
            RefrescarLista();
            RefrescarPersonaje();
            ActualizarBotones();
        }

        /// <summary>Recorre la lista de objetos y la vuelca en el ListBox.</summary>
        private void RefrescarLista()
        {
            int seleccionado = lstObjetos.SelectedIndex;

            lstObjetos.Items.Clear();
            foreach (Item item in partida.Inventario)
            {
                lstObjetos.Items.Add(item.Descripcion());
            }

            // Deja seleccionada la misma fila para que no salte sola al usar un objeto.
            if (seleccionado >= 0 && seleccionado < lstObjetos.Items.Count)
            {
                lstObjetos.SelectedIndex = seleccionado;
            }
        }

        private void RefrescarPersonaje()
        {
            Personaje j = partida.Jugador;

            lblStats.Text =
                "Vida" + Environment.NewLine +
                j.Vida + " / " + j.VidaMaxima + Environment.NewLine + Environment.NewLine +
                "Ataque:  " + j.Ataque + Environment.NewLine + Environment.NewLine +
                "Defensa: " + j.Defensa + Environment.NewLine + Environment.NewLine +
                "Critico: " + j.ProbabilidadCritico + "%";

            pbVida.Maximum = j.VidaMaxima;
            pbVida.Value = j.Vida;

            picJugador.Image = ImagenesPersonaje.Obtener(j.TipoPersonaje, j.Estado);
        }

        /// <summary>El objeto que esta seleccionado en la lista, o null si no hay ninguno.</summary>
        private Item? ItemSeleccionado()
        {
            int i = lstObjetos.SelectedIndex;

            if (i < 0 || i >= partida.Inventario.Count)
            {
                return null;
            }
            return partida.Inventario[i];
        }

        /// <summary>Habilita solo las acciones que tienen sentido para el objeto elegido.</summary>
        private void ActualizarBotones()
        {
            Item? item = ItemSeleccionado();

            if (item == null)
            {
                btnUsar.Enabled = false;
                btnEquipar.Enabled = false;
                btnDesequipar.Enabled = false;
                return;
            }

            // Un consumible agotado no se puede usar.
            btnUsar.Enabled = item.EsConsumible && item.Cantidad > 0;

            // Equipar solo si es equipable y NO esta ya equipado (asi el bono no se acumula).
            btnEquipar.Enabled = item.EsEquipable && item.Cantidad > 0 && !item.Equipado;
            btnDesequipar.Enabled = item.EsEquipable && item.Equipado;
        }

        private void lstObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item? item = ItemSeleccionado();

            if (item == null)
            {
                lblDetalle.Text = "Elige un objeto de la lista.";
            }
            else if (item.EsConsumible)
            {
                lblDetalle.Text = item.Cantidad > 0
                    ? item.Nombre + ": recupera " + item.Valor + " de vida. Te quedan " + item.Cantidad + "."
                    : item.Nombre + ": se te acabaron.";
            }
            else if (item.Tipo == Item.Arma)
            {
                lblDetalle.Text = item.Nombre + ": suma " + item.Valor + " al ataque mientras lo lleves puesto.";
            }
            else
            {
                lblDetalle.Text = item.Nombre + ": suma " + item.Valor + " a la defensa mientras lo lleves puesto.";
            }

            ActualizarBotones();
        }

        // ----------------- Acciones -----------------

        private void btnUsar_Click(object sender, EventArgs e)
        {
            Item? item = ItemSeleccionado();
            if (item == null) return;

            if (item.Cantidad <= 0)
            {
                MessageBox.Show("Ya no te quedan " + item.Nombre + ".", "Objeto agotado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (partida.Jugador.Vida >= partida.Jugador.VidaMaxima)
            {
                MessageBox.Show("Tienes la vida llena: no vale la pena gastar la pocion.",
                    "Vida completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int curado = partida.UsarConsumible(item);

            if (curado <= 0)
            {
                MessageBox.Show("No se pudo usar " + item.Nombre + ".", "Sin efecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RefrescarTodo();
            MessageBox.Show(partida.Jugador.Nombre + " recupera " + curado + " de vida.\n" +
                            "Te quedan " + item.Cantidad + " " + item.Nombre + ".",
                "Objeto usado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEquipar_Click(object sender, EventArgs e)
        {
            Item? item = ItemSeleccionado();
            if (item == null) return;

            int ataqueAntes = partida.Jugador.Ataque;
            int defensaAntes = partida.Jugador.Defensa;

            if (!partida.Equipar(item))
            {
                MessageBox.Show("No se pudo equipar " + item.Nombre + ".", "Sin efecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RefrescarTodo();
            MessageBox.Show(item.Nombre + " equipado.\n\n" +
                            "Ataque:  " + ataqueAntes + " -> " + partida.Jugador.Ataque + "\n" +
                            "Defensa: " + defensaAntes + " -> " + partida.Jugador.Defensa,
                "Equipado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDesequipar_Click(object sender, EventArgs e)
        {
            Item? item = ItemSeleccionado();
            if (item == null) return;

            if (!partida.Desequipar(item))
            {
                return;
            }

            RefrescarTodo();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
