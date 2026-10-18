namespace juegoRPG
{
    partial class FrmCargarPartida
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
            lblRuta = new Label();
            lblEstado = new Label();
            grpResumen = new GroupBox();
            lblResumen = new Label();
            picClase = new PictureBox();
            btnContinuar = new Button();
            btnCancelar = new Button();
            grpResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClase).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 36, 32);
            lblTitulo.Location = new Point(24, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cargar partida";
            //
            // lblRuta
            //
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 8.5F);
            lblRuta.ForeColor = Color.FromArgb(120, 115, 110);
            lblRuta.Location = new Point(26, 56);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(200, 14);
            lblRuta.TabIndex = 1;
            lblRuta.Text = "-";
            //
            // lblEstado
            //
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.Location = new Point(26, 84);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(520, 44);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "-";
            //
            // grpResumen
            //
            grpResumen.Controls.Add(lblResumen);
            grpResumen.Controls.Add(picClase);
            grpResumen.Font = new Font("Segoe UI", 9F);
            grpResumen.Location = new Point(26, 136);
            grpResumen.Name = "grpResumen";
            grpResumen.Size = new Size(520, 266);
            grpResumen.TabIndex = 3;
            grpResumen.TabStop = false;
            grpResumen.Text = "Partida guardada";
            //
            // picClase
            //
            picClase.BackColor = Color.Transparent;
            picClase.BorderStyle = BorderStyle.FixedSingle;
            picClase.Location = new Point(16, 24);
            picClase.Name = "picClase";
            picClase.Size = new Size(150, 226);
            picClase.SizeMode = PictureBoxSizeMode.Zoom;
            picClase.TabIndex = 0;
            picClase.TabStop = false;
            //
            // lblResumen
            //
            lblResumen.Font = new Font("Segoe UI", 10F);
            lblResumen.Location = new Point(184, 28);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(320, 222);
            lblResumen.TabIndex = 1;
            lblResumen.Text = "-";
            //
            // btnContinuar
            //
            btnContinuar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnContinuar.Location = new Point(316, 418);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(230, 46);
            btnContinuar.TabIndex = 4;
            btnContinuar.Text = "Continuar la partida";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(26, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 46);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Volver al menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // FrmCargarPartida
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 236);
            ClientSize = new Size(572, 486);
            Controls.Add(lblTitulo);
            Controls.Add(lblRuta);
            Controls.Add(lblEstado);
            Controls.Add(grpResumen);
            Controls.Add(btnContinuar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCargarPartida";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cargar partida";
            grpResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblRuta;
        private Label lblEstado;
        private GroupBox grpResumen;
        private Label lblResumen;
        private PictureBox picClase;
        private Button btnContinuar;
        private Button btnCancelar;
    }
}
