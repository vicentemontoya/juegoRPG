namespace juegoRPG
{
    partial class FrmMenuPrincipal
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
            picPortada = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnNuevaPartida = new Button();
            btnCargarPartida = new Button();
            btnSalir = new Button();
            lblAvisoPartida = new Label();
            ((System.ComponentModel.ISupportInitialize)picPortada).BeginInit();
            SuspendLayout();
            //
            // picPortada
            //
            picPortada.BackColor = Color.FromArgb(20, 18, 26);
            picPortada.Location = new Point(24, 84);
            picPortada.Name = "picPortada";
            picPortada.Size = new Size(640, 360);
            picPortada.SizeMode = PictureBoxSizeMode.Zoom;
            picPortada.TabIndex = 0;
            picPortada.TabStop = false;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(244, 206, 112);
            lblTitulo.Location = new Point(24, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(380, 54);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "TORNEO DE CELL";
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblSubtitulo.ForeColor = Color.FromArgb(188, 180, 170);
            lblSubtitulo.Location = new Point(30, 460);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 19);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Crea tu luchador, combate y guarda tu progreso.";
            //
            // btnNuevaPartida
            //
            btnNuevaPartida.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevaPartida.Location = new Point(24, 500);
            btnNuevaPartida.Name = "btnNuevaPartida";
            btnNuevaPartida.Size = new Size(200, 56);
            btnNuevaPartida.TabIndex = 3;
            btnNuevaPartida.Text = "Nueva partida";
            btnNuevaPartida.UseVisualStyleBackColor = true;
            btnNuevaPartida.Click += btnNuevaPartida_Click;
            //
            // btnCargarPartida
            //
            btnCargarPartida.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCargarPartida.Location = new Point(244, 500);
            btnCargarPartida.Name = "btnCargarPartida";
            btnCargarPartida.Size = new Size(200, 56);
            btnCargarPartida.TabIndex = 4;
            btnCargarPartida.Text = "Cargar partida";
            btnCargarPartida.UseVisualStyleBackColor = true;
            btnCargarPartida.Click += btnCargarPartida_Click;
            //
            // btnSalir
            //
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(464, 500);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 56);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            //
            // lblAvisoPartida
            //
            lblAvisoPartida.AutoSize = true;
            lblAvisoPartida.BackColor = Color.Transparent;
            lblAvisoPartida.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblAvisoPartida.ForeColor = Color.FromArgb(150, 145, 140);
            lblAvisoPartida.Location = new Point(26, 568);
            lblAvisoPartida.Name = "lblAvisoPartida";
            lblAvisoPartida.Size = new Size(200, 15);
            lblAvisoPartida.TabIndex = 6;
            lblAvisoPartida.Text = "-";
            //
            // FrmMenuPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 21, 30);
            ClientSize = new Size(688, 600);
            Controls.Add(lblTitulo);
            Controls.Add(picPortada);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnNuevaPartida);
            Controls.Add(btnCargarPartida);
            Controls.Add(btnSalir);
            Controls.Add(lblAvisoPartida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torneo de Cell";
            ((System.ComponentModel.ISupportInitialize)picPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPortada;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnNuevaPartida;
        private Button btnCargarPartida;
        private Button btnSalir;
        private Label lblAvisoPartida;
    }
}
