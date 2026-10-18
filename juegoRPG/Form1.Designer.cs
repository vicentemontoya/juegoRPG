namespace juegoRPG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpJugador = new GroupBox();
            lstInventarioJugador = new ListBox();
            btnInventarioJugador1 = new Button();
            grpFichaJugador = new GroupBox();
            lblCapNombreJugador = new Label();
            txtNombreJugador = new TextBox();
            lblCapTipoJugador = new Label();
            cboTipoJugador = new ComboBox();
            lblCapVidaJugador = new Label();
            txtVidaJugador = new TextBox();
            lblCapAtaqueJugador = new Label();
            txtAtaqueJugador = new TextBox();
            lblCapDefensaJugador = new Label();
            txtDefensaJugador = new TextBox();
            btnCrearJugador = new Button();
            lblCapNivelJugador = new Label();
            tbNivelJugador = new TrackBar();
            lblValorNivelJugador = new Label();
            lblCapPocionesJugador = new Label();
            tbPocionesJugador = new TrackBar();
            lblValorPocionesJugador = new Label();
            picJugador = new PictureBox();
            lblNombreJugador = new Label();
            lblVidaJugador = new Label();
            pbVidaJugador = new ProgressBar();
            lblNivelJugador = new Label();
            lblAtaqueJugador = new Label();
            lblDefensaJugador = new Label();
            lblCriticoJugador = new Label();
            lblPocionesJugador = new Label();
            btnAtacarJugador = new Button();
            btnPocionJugador = new Button();
            grpEnemigo = new GroupBox();
            lstInventarioEnemigo = new ListBox();
            btnInventarioEnemigo = new Button();
            btnNuevaPartida = new Button();
            grpFichaEnemigo = new GroupBox();
            lblCapNombreEnemigo = new Label();
            txtNombreEnemigo = new TextBox();
            lblCapTipoEnemigo = new Label();
            cboTipoEnemigo = new ComboBox();
            lblCapVidaEnemigo = new Label();
            txtVidaEnemigo = new TextBox();
            lblCapAtaqueEnemigo = new Label();
            txtAtaqueEnemigo = new TextBox();
            lblCapDefensaEnemigo = new Label();
            txtDefensaEnemigo = new TextBox();
            btnCrearEnemigo = new Button();
            btnEnemigoAzar = new Button();
            lblCapNivelEnemigo = new Label();
            tbNivelEnemigo = new TrackBar();
            lblValorNivelEnemigo = new Label();
            lblCapPocionesEnemigo = new Label();
            tbPocionesEnemigo = new TrackBar();
            lblValorPocionesEnemigo = new Label();
            picEnemigo = new PictureBox();
            lblNombreEnemigo = new Label();
            lblVidaEnemigo = new Label();
            pbVidaEnemigo = new ProgressBar();
            lblNivelEnemigo = new Label();
            lblAtaqueEnemigo = new Label();
            lblDefensaEnemigo = new Label();
            lblCriticoEnemigo = new Label();
            lblPocionesEnemigo = new Label();
            btnAtacarEnemigo = new Button();
            btnPocionEnemigo = new Button();
            grpJugador.SuspendLayout();
            grpFichaJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbNivelJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPocionesJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picJugador).BeginInit();
            grpEnemigo.SuspendLayout();
            grpFichaEnemigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbNivelEnemigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbPocionesEnemigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).BeginInit();
            SuspendLayout();
            // 
            // grpJugador
            // 
            grpJugador.BackColor = SystemColors.ActiveCaption;
            grpJugador.Controls.Add(lstInventarioJugador);
            grpJugador.Controls.Add(btnInventarioJugador1);
            grpJugador.Controls.Add(grpFichaJugador);
            grpJugador.Controls.Add(picJugador);
            grpJugador.Controls.Add(lblNombreJugador);
            grpJugador.Controls.Add(lblVidaJugador);
            grpJugador.Controls.Add(pbVidaJugador);
            grpJugador.Controls.Add(lblNivelJugador);
            grpJugador.Controls.Add(lblAtaqueJugador);
            grpJugador.Controls.Add(lblDefensaJugador);
            grpJugador.Controls.Add(lblCriticoJugador);
            grpJugador.Controls.Add(lblPocionesJugador);
            grpJugador.Controls.Add(btnAtacarJugador);
            grpJugador.Controls.Add(btnPocionJugador);
            grpJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpJugador.Location = new Point(16, 16);
            grpJugador.Margin = new Padding(3, 4, 3, 4);
            grpJugador.Name = "grpJugador";
            grpJugador.Padding = new Padding(3, 4, 3, 4);
            grpJugador.Size = new Size(631, 895);
            grpJugador.TabIndex = 0;
            grpJugador.TabStop = false;
            grpJugador.Text = "Tu personaje";
            // 
            // lstInventarioJugador
            // 
            lstInventarioJugador.FormattingEnabled = true;
            lstInventarioJugador.Location = new Point(251, 800);
            lstInventarioJugador.Name = "lstInventarioJugador";
            lstInventarioJugador.Size = new Size(171, 73);
            lstInventarioJugador.TabIndex = 13;
            // 
            // btnInventarioJugador1
            // 
            btnInventarioJugador1.Location = new Point(251, 759);
            btnInventarioJugador1.Name = "btnInventarioJugador1";
            btnInventarioJugador1.Size = new Size(171, 36);
            btnInventarioJugador1.TabIndex = 12;
            btnInventarioJugador1.Text = "Inventario ";
            btnInventarioJugador1.UseVisualStyleBackColor = true;
            btnInventarioJugador1.Click += btnInventarioJugador1_Click;
            // 
            // grpFichaJugador
            // 
            grpFichaJugador.BackColor = Color.FromArgb(255, 255, 192);
            grpFichaJugador.Controls.Add(lblCapNombreJugador);
            grpFichaJugador.Controls.Add(txtNombreJugador);
            grpFichaJugador.Controls.Add(lblCapTipoJugador);
            grpFichaJugador.Controls.Add(cboTipoJugador);
            grpFichaJugador.Controls.Add(lblCapVidaJugador);
            grpFichaJugador.Controls.Add(txtVidaJugador);
            grpFichaJugador.Controls.Add(lblCapAtaqueJugador);
            grpFichaJugador.Controls.Add(txtAtaqueJugador);
            grpFichaJugador.Controls.Add(lblCapDefensaJugador);
            grpFichaJugador.Controls.Add(txtDefensaJugador);
            grpFichaJugador.Controls.Add(btnCrearJugador);
            grpFichaJugador.Controls.Add(lblCapNivelJugador);
            grpFichaJugador.Controls.Add(tbNivelJugador);
            grpFichaJugador.Controls.Add(lblValorNivelJugador);
            grpFichaJugador.Controls.Add(lblCapPocionesJugador);
            grpFichaJugador.Controls.Add(tbPocionesJugador);
            grpFichaJugador.Controls.Add(lblValorPocionesJugador);
            grpFichaJugador.Font = new Font("Segoe UI", 9F);
            grpFichaJugador.Location = new Point(16, 37);
            grpFichaJugador.Margin = new Padding(3, 4, 3, 4);
            grpFichaJugador.Name = "grpFichaJugador";
            grpFichaJugador.Padding = new Padding(3, 4, 3, 4);
            grpFichaJugador.Size = new Size(599, 307);
            grpFichaJugador.TabIndex = 0;
            grpFichaJugador.TabStop = false;
            grpFichaJugador.Text = "Estadísticas";
            // 
            // lblCapNombreJugador
            // 
            lblCapNombreJugador.AutoSize = true;
            lblCapNombreJugador.Location = new Point(18, 45);
            lblCapNombreJugador.Name = "lblCapNombreJugador";
            lblCapNombreJugador.Size = new Size(64, 20);
            lblCapNombreJugador.TabIndex = 0;
            lblCapNombreJugador.Text = "Nombre";
            // 
            // txtNombreJugador
            // 
            txtNombreJugador.Location = new Point(114, 40);
            txtNombreJugador.Margin = new Padding(3, 4, 3, 4);
            txtNombreJugador.Name = "txtNombreJugador";
            txtNombreJugador.Size = new Size(148, 27);
            txtNombreJugador.TabIndex = 1;
            // 
            // lblCapTipoJugador
            // 
            lblCapTipoJugador.AutoSize = true;
            lblCapTipoJugador.Location = new Point(286, 45);
            lblCapTipoJugador.Name = "lblCapTipoJugador";
            lblCapTipoJugador.Size = new Size(108, 20);
            lblCapTipoJugador.TabIndex = 2;
            lblCapTipoJugador.Text = "Tipo personaje";
            // 
            // cboTipoJugador
            // 
            cboTipoJugador.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoJugador.FormattingEnabled = true;
            cboTipoJugador.Location = new Point(434, 40);
            cboTipoJugador.Margin = new Padding(3, 4, 3, 4);
            cboTipoJugador.Name = "cboTipoJugador";
            cboTipoJugador.Size = new Size(148, 28);
            cboTipoJugador.TabIndex = 3;
            cboTipoJugador.SelectedIndexChanged += cboTipoJugador_SelectedIndexChanged;
            // 
            // lblCapVidaJugador
            // 
            lblCapVidaJugador.AutoSize = true;
            lblCapVidaJugador.Location = new Point(18, 104);
            lblCapVidaJugador.Name = "lblCapVidaJugador";
            lblCapVidaJugador.Size = new Size(39, 20);
            lblCapVidaJugador.TabIndex = 4;
            lblCapVidaJugador.Text = "Vida";
            // 
            // txtVidaJugador
            // 
            txtVidaJugador.Location = new Point(114, 99);
            txtVidaJugador.Margin = new Padding(3, 4, 3, 4);
            txtVidaJugador.Name = "txtVidaJugador";
            txtVidaJugador.Size = new Size(148, 27);
            txtVidaJugador.TabIndex = 5;
            // 
            // lblCapAtaqueJugador
            // 
            lblCapAtaqueJugador.AutoSize = true;
            lblCapAtaqueJugador.Location = new Point(286, 104);
            lblCapAtaqueJugador.Name = "lblCapAtaqueJugador";
            lblCapAtaqueJugador.Size = new Size(57, 20);
            lblCapAtaqueJugador.TabIndex = 6;
            lblCapAtaqueJugador.Text = "Ataque";
            // 
            // txtAtaqueJugador
            // 
            txtAtaqueJugador.Location = new Point(434, 99);
            txtAtaqueJugador.Margin = new Padding(3, 4, 3, 4);
            txtAtaqueJugador.Name = "txtAtaqueJugador";
            txtAtaqueJugador.Size = new Size(148, 27);
            txtAtaqueJugador.TabIndex = 7;
            // 
            // lblCapDefensaJugador
            // 
            lblCapDefensaJugador.AutoSize = true;
            lblCapDefensaJugador.Location = new Point(18, 163);
            lblCapDefensaJugador.Name = "lblCapDefensaJugador";
            lblCapDefensaJugador.Size = new Size(63, 20);
            lblCapDefensaJugador.TabIndex = 8;
            lblCapDefensaJugador.Text = "Defensa";
            // 
            // txtDefensaJugador
            // 
            txtDefensaJugador.Location = new Point(114, 157);
            txtDefensaJugador.Margin = new Padding(3, 4, 3, 4);
            txtDefensaJugador.Name = "txtDefensaJugador";
            txtDefensaJugador.Size = new Size(148, 27);
            txtDefensaJugador.TabIndex = 9;
            // 
            // btnCrearJugador
            // 
            btnCrearJugador.Location = new Point(434, 149);
            btnCrearJugador.Margin = new Padding(3, 4, 3, 4);
            btnCrearJugador.Name = "btnCrearJugador";
            btnCrearJugador.Size = new Size(149, 53);
            btnCrearJugador.TabIndex = 10;
            btnCrearJugador.Text = "Crear personaje";
            btnCrearJugador.UseVisualStyleBackColor = true;
            btnCrearJugador.Click += btnCrearJugador_Click;
            // 
            // lblCapNivelJugador
            // 
            lblCapNivelJugador.AutoSize = true;
            lblCapNivelJugador.Location = new Point(18, 236);
            lblCapNivelJugador.Name = "lblCapNivelJugador";
            lblCapNivelJugador.Size = new Size(43, 20);
            lblCapNivelJugador.TabIndex = 11;
            lblCapNivelJugador.Text = "Nivel";
            // 
            // tbNivelJugador
            // 
            tbNivelJugador.BackColor = Color.FromArgb(255, 255, 192);
            tbNivelJugador.LargeChange = 1;
            tbNivelJugador.Location = new Point(80, 224);
            tbNivelJugador.Margin = new Padding(3, 4, 3, 4);
            tbNivelJugador.Maximum = 5;
            tbNivelJugador.Minimum = 1;
            tbNivelJugador.Name = "tbNivelJugador";
            tbNivelJugador.Size = new Size(171, 56);
            tbNivelJugador.TabIndex = 12;
            tbNivelJugador.Value = 1;
            tbNivelJugador.ValueChanged += tbNivelJugador_ValueChanged;
            // 
            // lblValorNivelJugador
            // 
            lblValorNivelJugador.AutoSize = true;
            lblValorNivelJugador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValorNivelJugador.Location = new Point(261, 236);
            lblValorNivelJugador.Name = "lblValorNivelJugador";
            lblValorNivelJugador.Size = new Size(52, 20);
            lblValorNivelJugador.TabIndex = 13;
            lblValorNivelJugador.Text = "1 de 5";
            // 
            // lblCapPocionesJugador
            // 
            lblCapPocionesJugador.AutoSize = true;
            lblCapPocionesJugador.Location = new Point(326, 236);
            lblCapPocionesJugador.Name = "lblCapPocionesJugador";
            lblCapPocionesJugador.Size = new Size(67, 20);
            lblCapPocionesJugador.TabIndex = 14;
            lblCapPocionesJugador.Text = "Pociones";
            // 
            // tbPocionesJugador
            // 
            tbPocionesJugador.BackColor = Color.FromArgb(255, 255, 192);
            tbPocionesJugador.LargeChange = 1;
            tbPocionesJugador.Location = new Point(400, 224);
            tbPocionesJugador.Margin = new Padding(3, 4, 3, 4);
            tbPocionesJugador.Maximum = 3;
            tbPocionesJugador.Name = "tbPocionesJugador";
            tbPocionesJugador.Size = new Size(114, 56);
            tbPocionesJugador.TabIndex = 15;
            tbPocionesJugador.Value = 3;
            tbPocionesJugador.ValueChanged += tbPocionesJugador_ValueChanged;
            // 
            // lblValorPocionesJugador
            // 
            lblValorPocionesJugador.AutoSize = true;
            lblValorPocionesJugador.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValorPocionesJugador.Location = new Point(523, 236);
            lblValorPocionesJugador.Name = "lblValorPocionesJugador";
            lblValorPocionesJugador.Size = new Size(52, 20);
            lblValorPocionesJugador.TabIndex = 16;
            lblValorPocionesJugador.Text = "3 de 3";
            // 
            // picJugador
            // 
            picJugador.BackColor = Color.Transparent;
            picJugador.BorderStyle = BorderStyle.FixedSingle;
            picJugador.Location = new Point(23, 367);
            picJugador.Margin = new Padding(3, 4, 3, 4);
            picJugador.Name = "picJugador";
            picJugador.Size = new Size(205, 413);
            picJugador.SizeMode = PictureBoxSizeMode.Zoom;
            picJugador.TabIndex = 1;
            picJugador.TabStop = false;
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreJugador.Location = new Point(251, 371);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(20, 28);
            lblNombreJugador.TabIndex = 2;
            lblNombreJugador.Text = "-";
            // 
            // lblVidaJugador
            // 
            lblVidaJugador.AutoSize = true;
            lblVidaJugador.Font = new Font("Segoe UI", 10F);
            lblVidaJugador.Location = new Point(251, 417);
            lblVidaJugador.Name = "lblVidaJugador";
            lblVidaJugador.Size = new Size(17, 23);
            lblVidaJugador.TabIndex = 3;
            lblVidaJugador.Text = "-";
            // 
            // pbVidaJugador
            // 
            pbVidaJugador.Location = new Point(251, 453);
            pbVidaJugador.Margin = new Padding(3, 4, 3, 4);
            pbVidaJugador.Name = "pbVidaJugador";
            pbVidaJugador.Size = new Size(354, 27);
            pbVidaJugador.TabIndex = 4;
            // 
            // lblNivelJugador
            // 
            lblNivelJugador.AutoSize = true;
            lblNivelJugador.Font = new Font("Segoe UI", 10F);
            lblNivelJugador.Location = new Point(251, 496);
            lblNivelJugador.Name = "lblNivelJugador";
            lblNivelJugador.Size = new Size(17, 23);
            lblNivelJugador.TabIndex = 5;
            lblNivelJugador.Text = "-";
            // 
            // lblAtaqueJugador
            // 
            lblAtaqueJugador.AutoSize = true;
            lblAtaqueJugador.Font = new Font("Segoe UI", 10F);
            lblAtaqueJugador.Location = new Point(251, 531);
            lblAtaqueJugador.Name = "lblAtaqueJugador";
            lblAtaqueJugador.Size = new Size(17, 23);
            lblAtaqueJugador.TabIndex = 6;
            lblAtaqueJugador.Text = "-";
            // 
            // lblDefensaJugador
            // 
            lblDefensaJugador.AutoSize = true;
            lblDefensaJugador.Font = new Font("Segoe UI", 10F);
            lblDefensaJugador.Location = new Point(251, 565);
            lblDefensaJugador.Name = "lblDefensaJugador";
            lblDefensaJugador.Size = new Size(17, 23);
            lblDefensaJugador.TabIndex = 7;
            lblDefensaJugador.Text = "-";
            // 
            // lblCriticoJugador
            // 
            lblCriticoJugador.AutoSize = true;
            lblCriticoJugador.Font = new Font("Segoe UI", 10F);
            lblCriticoJugador.Location = new Point(251, 600);
            lblCriticoJugador.Name = "lblCriticoJugador";
            lblCriticoJugador.Size = new Size(17, 23);
            lblCriticoJugador.TabIndex = 11;
            lblCriticoJugador.Text = "-";
            // 
            // lblPocionesJugador
            // 
            lblPocionesJugador.AutoSize = true;
            lblPocionesJugador.Font = new Font("Segoe UI", 10F);
            lblPocionesJugador.Location = new Point(251, 635);
            lblPocionesJugador.Name = "lblPocionesJugador";
            lblPocionesJugador.Size = new Size(17, 23);
            lblPocionesJugador.TabIndex = 8;
            lblPocionesJugador.Text = "-";
            // 
            // btnAtacarJugador
            // 
            btnAtacarJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAtacarJugador.Location = new Point(251, 691);
            btnAtacarJugador.Margin = new Padding(3, 4, 3, 4);
            btnAtacarJugador.Name = "btnAtacarJugador";
            btnAtacarJugador.Size = new Size(171, 61);
            btnAtacarJugador.TabIndex = 9;
            btnAtacarJugador.Text = "Atacar";
            btnAtacarJugador.UseVisualStyleBackColor = true;
            btnAtacarJugador.Click += btnAtacarJugador_Click;
            // 
            // btnPocionJugador
            // 
            btnPocionJugador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPocionJugador.Location = new Point(434, 691);
            btnPocionJugador.Margin = new Padding(3, 4, 3, 4);
            btnPocionJugador.Name = "btnPocionJugador";
            btnPocionJugador.Size = new Size(171, 61);
            btnPocionJugador.TabIndex = 10;
            btnPocionJugador.Text = "Usar poción";
            btnPocionJugador.UseVisualStyleBackColor = true;
            btnPocionJugador.Click += btnPocionJugador_Click;
            // 
            // grpEnemigo
            // 
            grpEnemigo.BackColor = Color.FromArgb(255, 128, 128);
            grpEnemigo.Controls.Add(lstInventarioEnemigo);
            grpEnemigo.Controls.Add(btnInventarioEnemigo);
            grpEnemigo.Controls.Add(btnNuevaPartida);
            grpEnemigo.Controls.Add(grpFichaEnemigo);
            grpEnemigo.Controls.Add(picEnemigo);
            grpEnemigo.Controls.Add(lblNombreEnemigo);
            grpEnemigo.Controls.Add(lblVidaEnemigo);
            grpEnemigo.Controls.Add(pbVidaEnemigo);
            grpEnemigo.Controls.Add(lblNivelEnemigo);
            grpEnemigo.Controls.Add(lblAtaqueEnemigo);
            grpEnemigo.Controls.Add(lblDefensaEnemigo);
            grpEnemigo.Controls.Add(lblCriticoEnemigo);
            grpEnemigo.Controls.Add(lblPocionesEnemigo);
            grpEnemigo.Controls.Add(btnAtacarEnemigo);
            grpEnemigo.Controls.Add(btnPocionEnemigo);
            grpEnemigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpEnemigo.Location = new Point(665, 16);
            grpEnemigo.Margin = new Padding(3, 4, 3, 4);
            grpEnemigo.Name = "grpEnemigo";
            grpEnemigo.Padding = new Padding(3, 4, 3, 4);
            grpEnemigo.Size = new Size(631, 895);
            grpEnemigo.TabIndex = 1;
            grpEnemigo.TabStop = false;
            grpEnemigo.Text = "Tu enemigo";
            // 
            // lstInventarioEnemigo
            // 
            lstInventarioEnemigo.FormattingEnabled = true;
            lstInventarioEnemigo.Location = new Point(254, 800);
            lstInventarioEnemigo.Name = "lstInventarioEnemigo";
            lstInventarioEnemigo.Size = new Size(171, 73);
            lstInventarioEnemigo.TabIndex = 14;
            // 
            // btnInventarioEnemigo
            // 
            btnInventarioEnemigo.Location = new Point(254, 759);
            btnInventarioEnemigo.Name = "btnInventarioEnemigo";
            btnInventarioEnemigo.Size = new Size(171, 36);
            btnInventarioEnemigo.TabIndex = 13;
            btnInventarioEnemigo.Text = "Inventario ";
            btnInventarioEnemigo.UseVisualStyleBackColor = true;
            btnInventarioEnemigo.Click += btnInventarioEnemigo_Click;
            // 
            // btnNuevaPartida
            // 
            btnNuevaPartida.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaPartida.Location = new Point(27, 812);
            btnNuevaPartida.Name = "btnNuevaPartida";
            btnNuevaPartida.Size = new Size(190, 61);
            btnNuevaPartida.TabIndex = 12;
            btnNuevaPartida.Text = "Nueva partida";
            btnNuevaPartida.UseVisualStyleBackColor = true;
            btnNuevaPartida.Click += btnNuevaPartida_Click;
            // 
            // grpFichaEnemigo
            // 
            grpFichaEnemigo.BackColor = Color.FromArgb(255, 255, 192);
            grpFichaEnemigo.Controls.Add(lblCapNombreEnemigo);
            grpFichaEnemigo.Controls.Add(txtNombreEnemigo);
            grpFichaEnemigo.Controls.Add(lblCapTipoEnemigo);
            grpFichaEnemigo.Controls.Add(cboTipoEnemigo);
            grpFichaEnemigo.Controls.Add(lblCapVidaEnemigo);
            grpFichaEnemigo.Controls.Add(txtVidaEnemigo);
            grpFichaEnemigo.Controls.Add(lblCapAtaqueEnemigo);
            grpFichaEnemigo.Controls.Add(txtAtaqueEnemigo);
            grpFichaEnemigo.Controls.Add(lblCapDefensaEnemigo);
            grpFichaEnemigo.Controls.Add(txtDefensaEnemigo);
            grpFichaEnemigo.Controls.Add(btnCrearEnemigo);
            grpFichaEnemigo.Controls.Add(btnEnemigoAzar);
            grpFichaEnemigo.Controls.Add(lblCapNivelEnemigo);
            grpFichaEnemigo.Controls.Add(tbNivelEnemigo);
            grpFichaEnemigo.Controls.Add(lblValorNivelEnemigo);
            grpFichaEnemigo.Controls.Add(lblCapPocionesEnemigo);
            grpFichaEnemigo.Controls.Add(tbPocionesEnemigo);
            grpFichaEnemigo.Controls.Add(lblValorPocionesEnemigo);
            grpFichaEnemigo.Font = new Font("Segoe UI", 9F);
            grpFichaEnemigo.Location = new Point(16, 37);
            grpFichaEnemigo.Margin = new Padding(3, 4, 3, 4);
            grpFichaEnemigo.Name = "grpFichaEnemigo";
            grpFichaEnemigo.Padding = new Padding(3, 4, 3, 4);
            grpFichaEnemigo.Size = new Size(599, 307);
            grpFichaEnemigo.TabIndex = 0;
            grpFichaEnemigo.TabStop = false;
            grpFichaEnemigo.Text = "Estadísticas";
            // 
            // lblCapNombreEnemigo
            // 
            lblCapNombreEnemigo.AutoSize = true;
            lblCapNombreEnemigo.Location = new Point(18, 45);
            lblCapNombreEnemigo.Name = "lblCapNombreEnemigo";
            lblCapNombreEnemigo.Size = new Size(64, 20);
            lblCapNombreEnemigo.TabIndex = 0;
            lblCapNombreEnemigo.Text = "Nombre";
            // 
            // txtNombreEnemigo
            // 
            txtNombreEnemigo.Location = new Point(114, 40);
            txtNombreEnemigo.Margin = new Padding(3, 4, 3, 4);
            txtNombreEnemigo.Name = "txtNombreEnemigo";
            txtNombreEnemigo.Size = new Size(148, 27);
            txtNombreEnemigo.TabIndex = 1;
            // 
            // lblCapTipoEnemigo
            // 
            lblCapTipoEnemigo.AutoSize = true;
            lblCapTipoEnemigo.Location = new Point(286, 45);
            lblCapTipoEnemigo.Name = "lblCapTipoEnemigo";
            lblCapTipoEnemigo.Size = new Size(123, 20);
            lblCapTipoEnemigo.TabIndex = 2;
            lblCapTipoEnemigo.Text = "Tipo de enemigo";
            // 
            // cboTipoEnemigo
            // 
            cboTipoEnemigo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoEnemigo.FormattingEnabled = true;
            cboTipoEnemigo.Location = new Point(434, 40);
            cboTipoEnemigo.Margin = new Padding(3, 4, 3, 4);
            cboTipoEnemigo.Name = "cboTipoEnemigo";
            cboTipoEnemigo.Size = new Size(148, 28);
            cboTipoEnemigo.TabIndex = 3;
            cboTipoEnemigo.SelectedIndexChanged += cboTipoEnemigo_SelectedIndexChanged;
            // 
            // lblCapVidaEnemigo
            // 
            lblCapVidaEnemigo.AutoSize = true;
            lblCapVidaEnemigo.Location = new Point(18, 104);
            lblCapVidaEnemigo.Name = "lblCapVidaEnemigo";
            lblCapVidaEnemigo.Size = new Size(39, 20);
            lblCapVidaEnemigo.TabIndex = 4;
            lblCapVidaEnemigo.Text = "Vida";
            // 
            // txtVidaEnemigo
            // 
            txtVidaEnemigo.Location = new Point(114, 99);
            txtVidaEnemigo.Margin = new Padding(3, 4, 3, 4);
            txtVidaEnemigo.Name = "txtVidaEnemigo";
            txtVidaEnemigo.Size = new Size(148, 27);
            txtVidaEnemigo.TabIndex = 5;
            // 
            // lblCapAtaqueEnemigo
            // 
            lblCapAtaqueEnemigo.AutoSize = true;
            lblCapAtaqueEnemigo.Location = new Point(286, 104);
            lblCapAtaqueEnemigo.Name = "lblCapAtaqueEnemigo";
            lblCapAtaqueEnemigo.Size = new Size(57, 20);
            lblCapAtaqueEnemigo.TabIndex = 6;
            lblCapAtaqueEnemigo.Text = "Ataque";
            // 
            // txtAtaqueEnemigo
            // 
            txtAtaqueEnemigo.Location = new Point(434, 99);
            txtAtaqueEnemigo.Margin = new Padding(3, 4, 3, 4);
            txtAtaqueEnemigo.Name = "txtAtaqueEnemigo";
            txtAtaqueEnemigo.Size = new Size(148, 27);
            txtAtaqueEnemigo.TabIndex = 7;
            // 
            // lblCapDefensaEnemigo
            // 
            lblCapDefensaEnemigo.AutoSize = true;
            lblCapDefensaEnemigo.Location = new Point(18, 163);
            lblCapDefensaEnemigo.Name = "lblCapDefensaEnemigo";
            lblCapDefensaEnemigo.Size = new Size(63, 20);
            lblCapDefensaEnemigo.TabIndex = 8;
            lblCapDefensaEnemigo.Text = "Defensa";
            // 
            // txtDefensaEnemigo
            // 
            txtDefensaEnemigo.Location = new Point(114, 157);
            txtDefensaEnemigo.Margin = new Padding(3, 4, 3, 4);
            txtDefensaEnemigo.Name = "txtDefensaEnemigo";
            txtDefensaEnemigo.Size = new Size(148, 27);
            txtDefensaEnemigo.TabIndex = 9;
            // 
            // btnCrearEnemigo
            // 
            btnCrearEnemigo.Location = new Point(434, 149);
            btnCrearEnemigo.Margin = new Padding(3, 4, 3, 4);
            btnCrearEnemigo.Name = "btnCrearEnemigo";
            btnCrearEnemigo.Size = new Size(149, 53);
            btnCrearEnemigo.TabIndex = 10;
            btnCrearEnemigo.Text = "Crear enemigo";
            btnCrearEnemigo.UseVisualStyleBackColor = true;
            btnCrearEnemigo.Click += btnCrearEnemigo_Click;
            // 
            // btnEnemigoAzar
            // 
            btnEnemigoAzar.Location = new Point(274, 149);
            btnEnemigoAzar.Margin = new Padding(3, 4, 3, 4);
            btnEnemigoAzar.Name = "btnEnemigoAzar";
            btnEnemigoAzar.Size = new Size(149, 53);
            btnEnemigoAzar.TabIndex = 17;
            btnEnemigoAzar.Text = "Enemigo al azar";
            btnEnemigoAzar.UseVisualStyleBackColor = true;
            btnEnemigoAzar.Click += btnEnemigoAzar_Click;
            // 
            // lblCapNivelEnemigo
            // 
            lblCapNivelEnemigo.AutoSize = true;
            lblCapNivelEnemigo.Location = new Point(18, 236);
            lblCapNivelEnemigo.Name = "lblCapNivelEnemigo";
            lblCapNivelEnemigo.Size = new Size(43, 20);
            lblCapNivelEnemigo.TabIndex = 11;
            lblCapNivelEnemigo.Text = "Nivel";
            // 
            // tbNivelEnemigo
            // 
            tbNivelEnemigo.BackColor = Color.FromArgb(255, 255, 192);
            tbNivelEnemigo.LargeChange = 1;
            tbNivelEnemigo.Location = new Point(80, 224);
            tbNivelEnemigo.Margin = new Padding(3, 4, 3, 4);
            tbNivelEnemigo.Maximum = 5;
            tbNivelEnemigo.Minimum = 1;
            tbNivelEnemigo.Name = "tbNivelEnemigo";
            tbNivelEnemigo.Size = new Size(171, 56);
            tbNivelEnemigo.TabIndex = 12;
            tbNivelEnemigo.Value = 1;
            tbNivelEnemigo.ValueChanged += tbNivelEnemigo_ValueChanged;
            // 
            // lblValorNivelEnemigo
            // 
            lblValorNivelEnemigo.AutoSize = true;
            lblValorNivelEnemigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValorNivelEnemigo.Location = new Point(261, 236);
            lblValorNivelEnemigo.Name = "lblValorNivelEnemigo";
            lblValorNivelEnemigo.Size = new Size(52, 20);
            lblValorNivelEnemigo.TabIndex = 13;
            lblValorNivelEnemigo.Text = "1 de 5";
            // 
            // lblCapPocionesEnemigo
            // 
            lblCapPocionesEnemigo.AutoSize = true;
            lblCapPocionesEnemigo.Location = new Point(326, 236);
            lblCapPocionesEnemigo.Name = "lblCapPocionesEnemigo";
            lblCapPocionesEnemigo.Size = new Size(67, 20);
            lblCapPocionesEnemigo.TabIndex = 14;
            lblCapPocionesEnemigo.Text = "Pociones";
            // 
            // tbPocionesEnemigo
            // 
            tbPocionesEnemigo.BackColor = Color.FromArgb(255, 255, 192);
            tbPocionesEnemigo.LargeChange = 1;
            tbPocionesEnemigo.Location = new Point(400, 224);
            tbPocionesEnemigo.Margin = new Padding(3, 4, 3, 4);
            tbPocionesEnemigo.Maximum = 3;
            tbPocionesEnemigo.Name = "tbPocionesEnemigo";
            tbPocionesEnemigo.Size = new Size(114, 56);
            tbPocionesEnemigo.TabIndex = 15;
            tbPocionesEnemigo.Value = 3;
            tbPocionesEnemigo.ValueChanged += tbPocionesEnemigo_ValueChanged;
            // 
            // lblValorPocionesEnemigo
            // 
            lblValorPocionesEnemigo.AutoSize = true;
            lblValorPocionesEnemigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValorPocionesEnemigo.Location = new Point(523, 236);
            lblValorPocionesEnemigo.Name = "lblValorPocionesEnemigo";
            lblValorPocionesEnemigo.Size = new Size(52, 20);
            lblValorPocionesEnemigo.TabIndex = 16;
            lblValorPocionesEnemigo.Text = "3 de 3";
            // 
            // picEnemigo
            // 
            picEnemigo.BackColor = Color.Transparent;
            picEnemigo.BorderStyle = BorderStyle.FixedSingle;
            picEnemigo.Location = new Point(23, 367);
            picEnemigo.Margin = new Padding(3, 4, 3, 4);
            picEnemigo.Name = "picEnemigo";
            picEnemigo.Size = new Size(205, 413);
            picEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            picEnemigo.TabIndex = 1;
            picEnemigo.TabStop = false;
            // 
            // lblNombreEnemigo
            // 
            lblNombreEnemigo.AutoSize = true;
            lblNombreEnemigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreEnemigo.Location = new Point(251, 371);
            lblNombreEnemigo.Name = "lblNombreEnemigo";
            lblNombreEnemigo.Size = new Size(20, 28);
            lblNombreEnemigo.TabIndex = 2;
            lblNombreEnemigo.Text = "-";
            // 
            // lblVidaEnemigo
            // 
            lblVidaEnemigo.AutoSize = true;
            lblVidaEnemigo.Font = new Font("Segoe UI", 10F);
            lblVidaEnemigo.Location = new Point(251, 417);
            lblVidaEnemigo.Name = "lblVidaEnemigo";
            lblVidaEnemigo.Size = new Size(17, 23);
            lblVidaEnemigo.TabIndex = 3;
            lblVidaEnemigo.Text = "-";
            // 
            // pbVidaEnemigo
            // 
            pbVidaEnemigo.Location = new Point(251, 453);
            pbVidaEnemigo.Margin = new Padding(3, 4, 3, 4);
            pbVidaEnemigo.Name = "pbVidaEnemigo";
            pbVidaEnemigo.Size = new Size(354, 27);
            pbVidaEnemigo.TabIndex = 4;
            // 
            // lblNivelEnemigo
            // 
            lblNivelEnemigo.AutoSize = true;
            lblNivelEnemigo.Font = new Font("Segoe UI", 10F);
            lblNivelEnemigo.Location = new Point(251, 496);
            lblNivelEnemigo.Name = "lblNivelEnemigo";
            lblNivelEnemigo.Size = new Size(17, 23);
            lblNivelEnemigo.TabIndex = 5;
            lblNivelEnemigo.Text = "-";
            // 
            // lblAtaqueEnemigo
            // 
            lblAtaqueEnemigo.AutoSize = true;
            lblAtaqueEnemigo.Font = new Font("Segoe UI", 10F);
            lblAtaqueEnemigo.Location = new Point(251, 531);
            lblAtaqueEnemigo.Name = "lblAtaqueEnemigo";
            lblAtaqueEnemigo.Size = new Size(17, 23);
            lblAtaqueEnemigo.TabIndex = 6;
            lblAtaqueEnemigo.Text = "-";
            // 
            // lblDefensaEnemigo
            // 
            lblDefensaEnemigo.AutoSize = true;
            lblDefensaEnemigo.Font = new Font("Segoe UI", 10F);
            lblDefensaEnemigo.Location = new Point(251, 565);
            lblDefensaEnemigo.Name = "lblDefensaEnemigo";
            lblDefensaEnemigo.Size = new Size(17, 23);
            lblDefensaEnemigo.TabIndex = 7;
            lblDefensaEnemigo.Text = "-";
            // 
            // lblCriticoEnemigo
            // 
            lblCriticoEnemigo.AutoSize = true;
            lblCriticoEnemigo.Font = new Font("Segoe UI", 10F);
            lblCriticoEnemigo.Location = new Point(251, 600);
            lblCriticoEnemigo.Name = "lblCriticoEnemigo";
            lblCriticoEnemigo.Size = new Size(17, 23);
            lblCriticoEnemigo.TabIndex = 11;
            lblCriticoEnemigo.Text = "-";
            // 
            // lblPocionesEnemigo
            // 
            lblPocionesEnemigo.AutoSize = true;
            lblPocionesEnemigo.Font = new Font("Segoe UI", 10F);
            lblPocionesEnemigo.Location = new Point(251, 635);
            lblPocionesEnemigo.Name = "lblPocionesEnemigo";
            lblPocionesEnemigo.Size = new Size(17, 23);
            lblPocionesEnemigo.TabIndex = 8;
            lblPocionesEnemigo.Text = "-";
            // 
            // btnAtacarEnemigo
            // 
            btnAtacarEnemigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAtacarEnemigo.Location = new Point(251, 691);
            btnAtacarEnemigo.Margin = new Padding(3, 4, 3, 4);
            btnAtacarEnemigo.Name = "btnAtacarEnemigo";
            btnAtacarEnemigo.Size = new Size(171, 61);
            btnAtacarEnemigo.TabIndex = 9;
            btnAtacarEnemigo.Text = "Atacar";
            btnAtacarEnemigo.UseVisualStyleBackColor = true;
            btnAtacarEnemigo.Click += btnAtacarEnemigo_Click;
            // 
            // btnPocionEnemigo
            // 
            btnPocionEnemigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPocionEnemigo.Location = new Point(434, 691);
            btnPocionEnemigo.Margin = new Padding(3, 4, 3, 4);
            btnPocionEnemigo.Name = "btnPocionEnemigo";
            btnPocionEnemigo.Size = new Size(171, 61);
            btnPocionEnemigo.TabIndex = 10;
            btnPocionEnemigo.Text = "Usar poción";
            btnPocionEnemigo.UseVisualStyleBackColor = true;
            btnPocionEnemigo.Click += btnPocionEnemigo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 32);
            ClientSize = new Size(1321, 924);
            Controls.Add(grpJugador);
            Controls.Add(grpEnemigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini RPG";
            grpJugador.ResumeLayout(false);
            grpJugador.PerformLayout();
            grpFichaJugador.ResumeLayout(false);
            grpFichaJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbNivelJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPocionesJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picJugador).EndInit();
            grpEnemigo.ResumeLayout(false);
            grpEnemigo.PerformLayout();
            grpFichaEnemigo.ResumeLayout(false);
            grpFichaEnemigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbNivelEnemigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbPocionesEnemigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpJugador;
        private GroupBox grpFichaJugador;
        private Label lblCapNombreJugador;
        private TextBox txtNombreJugador;
        private Label lblCapTipoJugador;
        private ComboBox cboTipoJugador;
        private Label lblCapVidaJugador;
        private TextBox txtVidaJugador;
        private Label lblCapAtaqueJugador;
        private TextBox txtAtaqueJugador;
        private Label lblCapDefensaJugador;
        private TextBox txtDefensaJugador;
        private Button btnCrearJugador;
        private Label lblCapNivelJugador;
        private TrackBar tbNivelJugador;
        private Label lblValorNivelJugador;
        private Label lblCapPocionesJugador;
        private TrackBar tbPocionesJugador;
        private Label lblValorPocionesJugador;
        private PictureBox picJugador;
        private Label lblNombreJugador;
        private Label lblVidaJugador;
        private ProgressBar pbVidaJugador;
        private Label lblNivelJugador;
        private Label lblAtaqueJugador;
        private Label lblDefensaJugador;
        private Label lblCriticoJugador;
        private Label lblPocionesJugador;
        private Button btnAtacarJugador;
        private Button btnPocionJugador;

        private GroupBox grpEnemigo;
        private GroupBox grpFichaEnemigo;
        private Label lblCapNombreEnemigo;
        private TextBox txtNombreEnemigo;
        private Label lblCapTipoEnemigo;
        private ComboBox cboTipoEnemigo;
        private Label lblCapVidaEnemigo;
        private TextBox txtVidaEnemigo;
        private Label lblCapAtaqueEnemigo;
        private TextBox txtAtaqueEnemigo;
        private Label lblCapDefensaEnemigo;
        private TextBox txtDefensaEnemigo;
        private Button btnCrearEnemigo;
        private Button btnEnemigoAzar;
        private Label lblCapNivelEnemigo;
        private TrackBar tbNivelEnemigo;
        private Label lblValorNivelEnemigo;
        private Label lblCapPocionesEnemigo;
        private TrackBar tbPocionesEnemigo;
        private Label lblValorPocionesEnemigo;
        private PictureBox picEnemigo;
        private Label lblNombreEnemigo;
        private Label lblVidaEnemigo;
        private ProgressBar pbVidaEnemigo;
        private Label lblNivelEnemigo;
        private Label lblAtaqueEnemigo;
        private Label lblDefensaEnemigo;
        private Label lblCriticoEnemigo;
        private Label lblPocionesEnemigo;
        private Button btnAtacarEnemigo;
        private Button btnPocionEnemigo;
        private Button btnNuevaPartida;
        private Button btnInventarioJugador1;
        private Button btnInventarioEnemigo;
        private ListBox lstInventarioJugador;
        private ListBox lstInventarioEnemigo;
    }
}
