namespace juegoRPG
{
    partial class FrmNuevaPartida
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
            lblCapNombre = new Label();
            txtNombre = new TextBox();
            lblCapClase = new Label();
            cboClase = new ComboBox();
            grpVistaPrevia = new GroupBox();
            picClase = new PictureBox();
            lblStats = new Label();
            btnComenzar = new Button();
            btnCancelar = new Button();
            grpVistaPrevia.SuspendLayout();
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
            lblTitulo.Size = new Size(280, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crea tu luchador";
            //
            // lblCapNombre
            //
            lblCapNombre.AutoSize = true;
            lblCapNombre.Font = new Font("Segoe UI", 10F);
            lblCapNombre.Location = new Point(26, 76);
            lblCapNombre.Name = "lblCapNombre";
            lblCapNombre.Size = new Size(60, 19);
            lblCapNombre.TabIndex = 1;
            lblCapNombre.Text = "Nombre";
            //
            // txtNombre
            //
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(26, 100);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Como se llama tu luchador";
            txtNombre.Size = new Size(280, 25);
            txtNombre.TabIndex = 2;
            //
            // lblCapClase
            //
            lblCapClase.AutoSize = true;
            lblCapClase.Font = new Font("Segoe UI", 10F);
            lblCapClase.Location = new Point(26, 142);
            lblCapClase.Name = "lblCapClase";
            lblCapClase.Size = new Size(40, 19);
            lblCapClase.TabIndex = 3;
            lblCapClase.Text = "Clase";
            //
            // cboClase
            //
            cboClase.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClase.Font = new Font("Segoe UI", 10F);
            cboClase.FormattingEnabled = true;
            cboClase.Location = new Point(26, 166);
            cboClase.Name = "cboClase";
            cboClase.Size = new Size(280, 25);
            cboClase.TabIndex = 4;
            cboClase.SelectedIndexChanged += cboClase_SelectedIndexChanged;
            //
            // lblStats
            //
            lblStats.Font = new Font("Segoe UI", 10F);
            lblStats.ForeColor = Color.FromArgb(60, 56, 52);
            lblStats.Location = new Point(26, 212);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(280, 150);
            lblStats.TabIndex = 5;
            lblStats.Text = "Elige una clase para ver sus estadisticas.";
            //
            // grpVistaPrevia
            //
            grpVistaPrevia.Controls.Add(picClase);
            grpVistaPrevia.Font = new Font("Segoe UI", 9F);
            grpVistaPrevia.Location = new Point(330, 70);
            grpVistaPrevia.Name = "grpVistaPrevia";
            grpVistaPrevia.Size = new Size(230, 330);
            grpVistaPrevia.TabIndex = 6;
            grpVistaPrevia.TabStop = false;
            grpVistaPrevia.Text = "Tu luchador";
            //
            // picClase
            //
            picClase.BackColor = Color.Transparent;
            picClase.BorderStyle = BorderStyle.FixedSingle;
            picClase.Location = new Point(16, 24);
            picClase.Name = "picClase";
            picClase.Size = new Size(198, 290);
            picClase.SizeMode = PictureBoxSizeMode.Zoom;
            picClase.TabIndex = 0;
            picClase.TabStop = false;
            //
            // btnComenzar
            //
            btnComenzar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnComenzar.Location = new Point(330, 416);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(230, 46);
            btnComenzar.TabIndex = 7;
            btnComenzar.Text = "Comenzar el combate";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(26, 416);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 46);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Volver al menu";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // FrmNuevaPartida
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 243, 236);
            ClientSize = new Size(588, 484);
            Controls.Add(lblTitulo);
            Controls.Add(lblCapNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblCapClase);
            Controls.Add(cboClase);
            Controls.Add(lblStats);
            Controls.Add(grpVistaPrevia);
            Controls.Add(btnComenzar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevaPartida";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva partida";
            grpVistaPrevia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picClase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCapNombre;
        private TextBox txtNombre;
        private Label lblCapClase;
        private ComboBox cboClase;
        private Label lblStats;
        private GroupBox grpVistaPrevia;
        private PictureBox picClase;
        private Button btnComenzar;
        private Button btnCancelar;
    }
}
