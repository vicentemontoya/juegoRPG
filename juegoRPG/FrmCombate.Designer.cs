namespace juegoRPG
{
    partial class FrmCombate
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
            btnInventario = new Button();
            btnGuardar = new Button();
            btnMenu = new Button();
            grpJugador = new GroupBox();
            picJugador = new PictureBox();
            lblNombreJugador = new Label();
            lblVidaJugador = new Label();
            pbVidaJugador = new ProgressBar();
            lblStatsJugador = new Label();
            grpEnemigo = new GroupBox();
            picEnemigo = new PictureBox();
            lblNombreEnemigo = new Label();
            lblVidaEnemigo = new Label();
            pbVidaEnemigo = new ProgressBar();
            lblStatsEnemigo = new Label();
            lblTurno = new Label();
            btnAtacar = new Button();
            btnPocion = new Button();
            lblPociones = new Label();
            lblCapHistorial = new Label();
            lstHistorial = new ListBox();
            grpJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picJugador).BeginInit();
            grpEnemigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(244, 206, 112);
            lblTitulo.Location = new Point(18, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "TORNEO DE CELL";
            //
            // btnInventario
            //
            btnInventario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInventario.Location = new Point(566, 12);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(140, 38);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            //
            // btnGuardar
            //
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.Location = new Point(716, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 38);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar partida";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnMenu
            //
            btnMenu.Font = new Font("Segoe UI", 10F);
            btnMenu.Location = new Point(866, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(140, 38);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Volver al menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            //
            // grpJugador
            //
            grpJugador.BackColor = SystemColors.ActiveCaption;
            grpJugador.Controls.Add(picJugador);
            grpJugador.Controls.Add(lblNombreJugador);
            grpJugador.Controls.Add(lblVidaJugador);
            grpJugador.Controls.Add(pbVidaJugador);
            grpJugador.Controls.Add(lblStatsJugador);
            grpJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpJugador.Location = new Point(18, 62);
            grpJugador.Name = "grpJugador";
            grpJugador.Size = new Size(330, 372);
            grpJugador.TabIndex = 4;
            grpJugador.TabStop = false;
            grpJugador.Text = "Tu luchador";
            //
            // picJugador
            //
            picJugador.BackColor = Color.Transparent;
            picJugador.BorderStyle = BorderStyle.FixedSingle;
            picJugador.Location = new Point(16, 28);
            picJugador.Name = "picJugador";
            picJugador.Size = new Size(140, 326);
            picJugador.SizeMode = PictureBoxSizeMode.Zoom;
            picJugador.TabIndex = 0;
            picJugador.TabStop = false;
            //
            // lblNombreJugador
            //
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreJugador.Location = new Point(168, 34);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(19, 21);
            lblNombreJugador.TabIndex = 1;
            lblNombreJugador.Text = "-";
            //
            // lblVidaJugador
            //
            lblVidaJugador.AutoSize = true;
            lblVidaJugador.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblVidaJugador.Location = new Point(168, 66);
            lblVidaJugador.Name = "lblVidaJugador";
            lblVidaJugador.Size = new Size(16, 19);
            lblVidaJugador.TabIndex = 2;
            lblVidaJugador.Text = "-";
            //
            // pbVidaJugador
            //
            pbVidaJugador.Location = new Point(168, 90);
            pbVidaJugador.Name = "pbVidaJugador";
            pbVidaJugador.Size = new Size(146, 18);
            pbVidaJugador.TabIndex = 3;
            //
            // lblStatsJugador
            //
            lblStatsJugador.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblStatsJugador.Location = new Point(168, 120);
            lblStatsJugador.Name = "lblStatsJugador";
            lblStatsJugador.Size = new Size(150, 234);
            lblStatsJugador.TabIndex = 4;
            lblStatsJugador.Text = "-";
            //
            // grpEnemigo
            //
            grpEnemigo.BackColor = Color.FromArgb(255, 128, 128);
            grpEnemigo.Controls.Add(picEnemigo);
            grpEnemigo.Controls.Add(lblNombreEnemigo);
            grpEnemigo.Controls.Add(lblVidaEnemigo);
            grpEnemigo.Controls.Add(pbVidaEnemigo);
            grpEnemigo.Controls.Add(lblStatsEnemigo);
            grpEnemigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEnemigo.Location = new Point(676, 62);
            grpEnemigo.Name = "grpEnemigo";
            grpEnemigo.Size = new Size(330, 372);
            grpEnemigo.TabIndex = 5;
            grpEnemigo.TabStop = false;
            grpEnemigo.Text = "Tu rival";
            //
            // picEnemigo
            //
            picEnemigo.BackColor = Color.Transparent;
            picEnemigo.BorderStyle = BorderStyle.FixedSingle;
            picEnemigo.Location = new Point(174, 28);
            picEnemigo.Name = "picEnemigo";
            picEnemigo.Size = new Size(140, 326);
            picEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            picEnemigo.TabIndex = 0;
            picEnemigo.TabStop = false;
            //
            // lblNombreEnemigo
            //
            lblNombreEnemigo.AutoSize = true;
            lblNombreEnemigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreEnemigo.Location = new Point(16, 34);
            lblNombreEnemigo.Name = "lblNombreEnemigo";
            lblNombreEnemigo.Size = new Size(19, 21);
            lblNombreEnemigo.TabIndex = 1;
            lblNombreEnemigo.Text = "-";
            //
            // lblVidaEnemigo
            //
            lblVidaEnemigo.AutoSize = true;
            lblVidaEnemigo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblVidaEnemigo.Location = new Point(16, 66);
            lblVidaEnemigo.Name = "lblVidaEnemigo";
            lblVidaEnemigo.Size = new Size(16, 19);
            lblVidaEnemigo.TabIndex = 2;
            lblVidaEnemigo.Text = "-";
            //
            // pbVidaEnemigo
            //
            pbVidaEnemigo.Location = new Point(16, 90);
            pbVidaEnemigo.Name = "pbVidaEnemigo";
            pbVidaEnemigo.Size = new Size(146, 18);
            pbVidaEnemigo.TabIndex = 3;
            //
            // lblStatsEnemigo
            //
            lblStatsEnemigo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblStatsEnemigo.Location = new Point(16, 120);
            lblStatsEnemigo.Name = "lblStatsEnemigo";
            lblStatsEnemigo.Size = new Size(150, 234);
            lblStatsEnemigo.TabIndex = 4;
            lblStatsEnemigo.Text = "-";
            //
            // lblTurno
            //
            lblTurno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTurno.ForeColor = Color.FromArgb(240, 236, 228);
            lblTurno.Location = new Point(360, 70);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(304, 48);
            lblTurno.TabIndex = 6;
            lblTurno.Text = "-";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnAtacar
            //
            btnAtacar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnAtacar.Location = new Point(360, 128);
            btnAtacar.Name = "btnAtacar";
            btnAtacar.Size = new Size(304, 64);
            btnAtacar.TabIndex = 7;
            btnAtacar.Text = "ATACAR";
            btnAtacar.UseVisualStyleBackColor = true;
            btnAtacar.Click += btnAtacar_Click;
            //
            // btnPocion
            //
            btnPocion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPocion.Location = new Point(360, 204);
            btnPocion.Name = "btnPocion";
            btnPocion.Size = new Size(304, 56);
            btnPocion.TabIndex = 8;
            btnPocion.Text = "Usar pocion";
            btnPocion.UseVisualStyleBackColor = true;
            btnPocion.Click += btnPocion_Click;
            //
            // lblPociones
            //
            lblPociones.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblPociones.ForeColor = Color.FromArgb(206, 200, 190);
            lblPociones.Location = new Point(360, 268);
            lblPociones.Name = "lblPociones";
            lblPociones.Size = new Size(304, 24);
            lblPociones.TabIndex = 9;
            lblPociones.Text = "-";
            lblPociones.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblCapHistorial
            //
            lblCapHistorial.AutoSize = true;
            lblCapHistorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCapHistorial.ForeColor = Color.FromArgb(206, 200, 190);
            lblCapHistorial.Location = new Point(18, 444);
            lblCapHistorial.Name = "lblCapHistorial";
            lblCapHistorial.Size = new Size(140, 19);
            lblCapHistorial.TabIndex = 10;
            lblCapHistorial.Text = "Historial del combate";
            //
            // lstHistorial
            //
            lstHistorial.BackColor = Color.FromArgb(36, 33, 42);
            lstHistorial.BorderStyle = BorderStyle.FixedSingle;
            lstHistorial.ForeColor = Color.FromArgb(226, 220, 210);
            lstHistorial.Font = new Font("Consolas", 9.5F);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 16;
            lstHistorial.Location = new Point(18, 468);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(988, 162);
            lstHistorial.TabIndex = 11;
            //
            // FrmCombate
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 21, 30);
            ClientSize = new Size(1024, 648);
            Controls.Add(lblTitulo);
            Controls.Add(btnInventario);
            Controls.Add(btnGuardar);
            Controls.Add(btnMenu);
            Controls.Add(grpJugador);
            Controls.Add(grpEnemigo);
            Controls.Add(lblTurno);
            Controls.Add(btnAtacar);
            Controls.Add(btnPocion);
            Controls.Add(lblPociones);
            Controls.Add(lblCapHistorial);
            Controls.Add(lstHistorial);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCombate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torneo de Cell - Combate";
            grpJugador.ResumeLayout(false);
            grpJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picJugador).EndInit();
            grpEnemigo.ResumeLayout(false);
            grpEnemigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnInventario;
        private Button btnGuardar;
        private Button btnMenu;
        private GroupBox grpJugador;
        private PictureBox picJugador;
        private Label lblNombreJugador;
        private Label lblVidaJugador;
        private ProgressBar pbVidaJugador;
        private Label lblStatsJugador;
        private GroupBox grpEnemigo;
        private PictureBox picEnemigo;
        private Label lblNombreEnemigo;
        private Label lblVidaEnemigo;
        private ProgressBar pbVidaEnemigo;
        private Label lblStatsEnemigo;
        private Label lblTurno;
        private Button btnAtacar;
        private Button btnPocion;
        private Label lblPociones;
        private Label lblCapHistorial;
        private ListBox lstHistorial;
    }
}
