namespace juegoRPG
{
    partial class FrmInventario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblPersonaje = new Label();
            lstObjetos = new ListBox();
            lblDetalle = new Label();
            btnUsar = new Button();
            btnEquipar = new Button();
            btnDesequipar = new Button();
            btnVolver = new Button();
            grpPersonaje = new GroupBox();
            lblStats = new Label();
            pbVida = new ProgressBar();
            picJugador = new PictureBox();
            grpPersonaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picJugador).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 36, 32);
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(160, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mochila";
            //
            // lblPersonaje
            //
            lblPersonaje.AutoSize = true;
            lblPersonaje.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblPersonaje.ForeColor = Color.FromArgb(110, 104, 98);
            lblPersonaje.Location = new Point(26, 52);
            lblPersonaje.Name = "lblPersonaje";
            lblPersonaje.Size = new Size(200, 19);
            lblPersonaje.TabIndex = 1;
            lblPersonaje.Text = "-";
            //
            // lstObjetos
            //
            lstObjetos.Font = new Font("Consolas", 10F);
            lstObjetos.FormattingEnabled = true;
            lstObjetos.ItemHeight = 17;
            lstObjetos.Location = new Point(26, 84);
            lstObjetos.Name = "lstObjetos";
            lstObjetos.Size = new Size(430, 174);
            lstObjetos.TabIndex = 2;
            lstObjetos.SelectedIndexChanged += lstObjetos_SelectedIndexChanged;
            //
            // lblDetalle
            //
            lblDetalle.Font = new Font("Segoe UI", 9.5F);
            lblDetalle.ForeColor = Color.FromArgb(70, 65, 60);
            lblDetalle.Location = new Point(26, 266);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(430, 44);
            lblDetalle.TabIndex = 3;
            lblDetalle.Text = "Elige un objeto de la lista.";
            //
            // btnUsar
            //
            btnUsar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUsar.Location = new Point(26, 318);
            btnUsar.Name = "btnUsar";
            btnUsar.Size = new Size(136, 44);
            btnUsar.TabIndex = 4;
            btnUsar.Text = "Usar";
            btnUsar.UseVisualStyleBackColor = true;
            btnUsar.Click += btnUsar_Click;
            //
            // btnEquipar
            //
            btnEquipar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEquipar.Location = new Point(172, 318);
            btnEquipar.Name = "btnEquipar";
            btnEquipar.Size = new Size(136, 44);
            btnEquipar.TabIndex = 5;
            btnEquipar.Text = "Equipar";
            btnEquipar.UseVisualStyleBackColor = true;
            btnEquipar.Click += btnEquipar_Click;
            //
            // btnDesequipar
            //
            btnDesequipar.Font = new Font("Segoe UI", 10F);
            btnDesequipar.Location = new Point(318, 318);
            btnDesequipar.Name = "btnDesequipar";
            btnDesequipar.Size = new Size(138, 44);
            btnDesequipar.TabIndex = 6;
            btnDesequipar.Text = "Quitar";
            btnDesequipar.UseVisualStyleBackColor = true;
            btnDesequipar.Click += btnDesequipar_Click;
            //
            // grpPersonaje
            //
            grpPersonaje.Controls.Add(picJugador);
            grpPersonaje.Controls.Add(lblStats);
            grpPersonaje.Controls.Add(pbVida);
            grpPersonaje.Font = new Font("Segoe UI", 9F);
            grpPersonaje.Location = new Point(476, 84);
            grpPersonaje.Name = "grpPersonaje";
            grpPersonaje.Size = new Size(280, 278);
            grpPersonaje.TabIndex = 7;
            grpPersonaje.TabStop = false;
            grpPersonaje.Text = "Tu luchador";
            //
            // picJugador
            //
            picJugador.BackColor = Color.Transparent;
            picJugador.BorderStyle = BorderStyle.FixedSingle;
            picJugador.Location = new Point(14, 24);
            picJugador.Name = "picJugador";
            picJugador.Size = new Size(120, 180);
            picJugador.SizeMode = PictureBoxSizeMode.Zoom;
            picJugador.TabIndex = 0;
            picJugador.TabStop = false;
            //
            // lblStats
            //
            lblStats.Font = new Font("Segoe UI", 10F);
            lblStats.Location = new Point(146, 28);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(126, 176);
            lblStats.TabIndex = 1;
            lblStats.Text = "-";
            //
            // pbVida
            //
            pbVida.Location = new Point(14, 218);
            pbVida.Name = "pbVida";
            pbVida.Size = new Size(252, 20);
            pbVida.TabIndex = 2;
            //
            // btnVolver
            //
            btnVolver.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVolver.Location = new Point(476, 318);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(280, 44);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver al combate";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            //
            // FrmInventario
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 236);
            ClientSize = new Size(784, 386);
            Controls.Add(lblTitulo);
            Controls.Add(lblPersonaje);
            Controls.Add(lstObjetos);
            Controls.Add(lblDetalle);
            Controls.Add(btnUsar);
            Controls.Add(btnEquipar);
            Controls.Add(btnDesequipar);
            Controls.Add(grpPersonaje);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInventario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inventario";
            grpPersonaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picJugador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblPersonaje;
        private ListBox lstObjetos;
        private Label lblDetalle;
        private Button btnUsar;
        private Button btnEquipar;
        private Button btnDesequipar;
        private GroupBox grpPersonaje;
        private Label lblStats;
        private ProgressBar pbVida;
        private PictureBox picJugador;
        private Button btnVolver;
    }
}
