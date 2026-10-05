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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            txtNivelGuerrero = new TextBox();
            txtAtaqueGuerrero = new TextBox();
            txtPocionesGuerrero = new TextBox();
            txtDefensaGuerrero = new TextBox();
            label7 = new Label();
            txtVidaGuerrero = new TextBox();
            txtVidaEnemigo = new TextBox();
            label8 = new Label();
            txtDefensaEnemigo = new TextBox();
            txtPocionesEnemigo = new TextBox();
            txtAtaqueEnemigo = new TextBox();
            txtNivelEnemigo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnCrearGuerrero = new Button();
            btnCrearEnemigo = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblNombreGuerrero = new Label();
            lblVidaGuerrero = new Label();
            lblNivelGuerrero = new Label();
            lblAtaqueGuerrero = new Label();
            lblDefensaGuerrero = new Label();
            lblDefensaEnemigo = new Label();
            lblAtaqueEnemigo = new Label();
            lblNivelEnemigo = new Label();
            lblVidaEnemigo = new Label();
            lblNombreEnemigo = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            btnAtacarGuerrero = new Button();
            btnPocionesGuerrero = new Button();
            btnPocionesEnemigo = new Button();
            btnAtacarEnemigo = new Button();
            txtNombreGuerrero = new TextBox();
            comboBox1 = new ComboBox();
            txtNombreEnemigo = new TextBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnPocionesGuerrero);
            groupBox1.Controls.Add(btnAtacarGuerrero);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(lblDefensaGuerrero);
            groupBox1.Controls.Add(lblAtaqueGuerrero);
            groupBox1.Controls.Add(lblNivelGuerrero);
            groupBox1.Controls.Add(lblVidaGuerrero);
            groupBox1.Controls.Add(lblNombreGuerrero);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(40, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 606);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crea Tu Guerrero";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 255, 192);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(txtNombreGuerrero);
            groupBox3.Controls.Add(btnCrearGuerrero);
            groupBox3.Controls.Add(txtVidaGuerrero);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtDefensaGuerrero);
            groupBox3.Controls.Add(txtPocionesGuerrero);
            groupBox3.Controls.Add(txtAtaqueGuerrero);
            groupBox3.Controls.Add(txtNivelGuerrero);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(15, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 277);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Estadisticas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 161);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Defensa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 158);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Pociones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Ataque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 102);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Nivel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 28);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de clase";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 128, 128);
            groupBox2.Controls.Add(btnPocionesEnemigo);
            groupBox2.Controls.Add(progressBar2);
            groupBox2.Controls.Add(btnAtacarEnemigo);
            groupBox2.Controls.Add(lblDefensaEnemigo);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(lblAtaqueEnemigo);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(lblNivelEnemigo);
            groupBox2.Controls.Add(lblNombreEnemigo);
            groupBox2.Controls.Add(lblVidaEnemigo);
            groupBox2.Location = new Point(540, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 615);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crea Tu Enemigo";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(255, 255, 192);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(txtNombreEnemigo);
            groupBox4.Controls.Add(btnCrearEnemigo);
            groupBox4.Controls.Add(txtVidaEnemigo);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(txtDefensaEnemigo);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(txtPocionesEnemigo);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtAtaqueEnemigo);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtNivelEnemigo);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(19, 50);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(382, 277);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Estadisticas";
            // 
            // txtNivelGuerrero
            // 
            txtNivelGuerrero.Location = new Point(77, 104);
            txtNivelGuerrero.Name = "txtNivelGuerrero";
            txtNivelGuerrero.Size = new Size(109, 27);
            txtNivelGuerrero.TabIndex = 6;
            // 
            // txtAtaqueGuerrero
            // 
            txtAtaqueGuerrero.Location = new Point(250, 104);
            txtAtaqueGuerrero.Name = "txtAtaqueGuerrero";
            txtAtaqueGuerrero.Size = new Size(109, 27);
            txtAtaqueGuerrero.TabIndex = 7;
            // 
            // txtPocionesGuerrero
            // 
            txtPocionesGuerrero.Location = new Point(77, 158);
            txtPocionesGuerrero.Name = "txtPocionesGuerrero";
            txtPocionesGuerrero.Size = new Size(109, 27);
            txtPocionesGuerrero.TabIndex = 8;
            // 
            // txtDefensaGuerrero
            // 
            txtDefensaGuerrero.Location = new Point(255, 161);
            txtDefensaGuerrero.Name = "txtDefensaGuerrero";
            txtDefensaGuerrero.Size = new Size(109, 27);
            txtDefensaGuerrero.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 206);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 10;
            label7.Text = "Vida";
            // 
            // txtVidaGuerrero
            // 
            txtVidaGuerrero.Location = new Point(77, 222);
            txtVidaGuerrero.Name = "txtVidaGuerrero";
            txtVidaGuerrero.Size = new Size(109, 27);
            txtVidaGuerrero.TabIndex = 11;
            // 
            // txtVidaEnemigo
            // 
            txtVidaEnemigo.Location = new Point(79, 214);
            txtVidaEnemigo.Name = "txtVidaEnemigo";
            txtVidaEnemigo.Size = new Size(109, 27);
            txtVidaEnemigo.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 214);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 22;
            label8.Text = "Vida";
            // 
            // txtDefensaEnemigo
            // 
            txtDefensaEnemigo.Location = new Point(257, 169);
            txtDefensaEnemigo.Name = "txtDefensaEnemigo";
            txtDefensaEnemigo.Size = new Size(109, 27);
            txtDefensaEnemigo.TabIndex = 21;
            // 
            // txtPocionesEnemigo
            // 
            txtPocionesEnemigo.Location = new Point(79, 166);
            txtPocionesEnemigo.Name = "txtPocionesEnemigo";
            txtPocionesEnemigo.Size = new Size(109, 27);
            txtPocionesEnemigo.TabIndex = 20;
            // 
            // txtAtaqueEnemigo
            // 
            txtAtaqueEnemigo.Location = new Point(252, 112);
            txtAtaqueEnemigo.Name = "txtAtaqueEnemigo";
            txtAtaqueEnemigo.Size = new Size(109, 27);
            txtAtaqueEnemigo.TabIndex = 19;
            // 
            // txtNivelEnemigo
            // 
            txtNivelEnemigo.Location = new Point(79, 112);
            txtNivelEnemigo.Name = "txtNivelEnemigo";
            txtNivelEnemigo.Size = new Size(109, 27);
            txtNivelEnemigo.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(188, 169);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 17;
            label9.Text = "Defensa";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 166);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 16;
            label10.Text = "Pociones";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(194, 110);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 15;
            label11.Text = "Ataque";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 110);
            label12.Name = "label12";
            label12.Size = new Size(43, 20);
            label12.TabIndex = 14;
            label12.Text = "Nivel";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(194, 36);
            label13.Name = "label13";
            label13.Size = new Size(97, 20);
            label13.TabIndex = 13;
            label13.Text = "Tipo de clase";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 36);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 12;
            label14.Text = "Nombre";
            // 
            // btnCrearGuerrero
            // 
            btnCrearGuerrero.Location = new Point(222, 210);
            btnCrearGuerrero.Name = "btnCrearGuerrero";
            btnCrearGuerrero.Size = new Size(117, 54);
            btnCrearGuerrero.TabIndex = 12;
            btnCrearGuerrero.Text = "Crear Guerrero";
            btnCrearGuerrero.UseVisualStyleBackColor = true;
            btnCrearGuerrero.Click += btnCrearGuerrero_Click;
            // 
            // btnCrearEnemigo
            // 
            btnCrearEnemigo.Location = new Point(232, 214);
            btnCrearEnemigo.Name = "btnCrearEnemigo";
            btnCrearEnemigo.Size = new Size(117, 54);
            btnCrearEnemigo.TabIndex = 13;
            btnCrearEnemigo.Text = "Crear Enemigo";
            btnCrearEnemigo.UseVisualStyleBackColor = true;
            btnCrearEnemigo.Click += btnCrearEnemigo_Click;
            //
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(30, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 166);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.Location = new Point(58, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 166);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblNombreGuerrero
            // 
            lblNombreGuerrero.AutoSize = true;
            lblNombreGuerrero.Location = new Point(189, 352);
            lblNombreGuerrero.Name = "lblNombreGuerrero";
            lblNombreGuerrero.Size = new Size(15, 20);
            lblNombreGuerrero.TabIndex = 2;
            lblNombreGuerrero.Text = "-";
            // 
            // lblVidaGuerrero
            // 
            lblVidaGuerrero.AutoSize = true;
            lblVidaGuerrero.Location = new Point(189, 389);
            lblVidaGuerrero.Name = "lblVidaGuerrero";
            lblVidaGuerrero.Size = new Size(15, 20);
            lblVidaGuerrero.TabIndex = 3;
            lblVidaGuerrero.Text = "-";
            // 
            // lblNivelGuerrero
            // 
            lblNivelGuerrero.AutoSize = true;
            lblNivelGuerrero.Location = new Point(189, 424);
            lblNivelGuerrero.Name = "lblNivelGuerrero";
            lblNivelGuerrero.Size = new Size(15, 20);
            lblNivelGuerrero.TabIndex = 4;
            lblNivelGuerrero.Text = "-";
            // 
            // lblAtaqueGuerrero
            // 
            lblAtaqueGuerrero.AutoSize = true;
            lblAtaqueGuerrero.Location = new Point(189, 455);
            lblAtaqueGuerrero.Name = "lblAtaqueGuerrero";
            lblAtaqueGuerrero.Size = new Size(15, 20);
            lblAtaqueGuerrero.TabIndex = 5;
            lblAtaqueGuerrero.Text = "-";
            // 
            // lblDefensaGuerrero
            // 
            lblDefensaGuerrero.AutoSize = true;
            lblDefensaGuerrero.Location = new Point(189, 495);
            lblDefensaGuerrero.Name = "lblDefensaGuerrero";
            lblDefensaGuerrero.Size = new Size(15, 20);
            lblDefensaGuerrero.TabIndex = 6;
            lblDefensaGuerrero.Text = "-";
            // 
            // lblDefensaEnemigo
            // 
            lblDefensaEnemigo.AutoSize = true;
            lblDefensaEnemigo.Location = new Point(255, 499);
            lblDefensaEnemigo.Name = "lblDefensaEnemigo";
            lblDefensaEnemigo.Size = new Size(15, 20);
            lblDefensaEnemigo.TabIndex = 11;
            lblDefensaEnemigo.Text = "-";
            // 
            // lblAtaqueEnemigo
            // 
            lblAtaqueEnemigo.AutoSize = true;
            lblAtaqueEnemigo.Location = new Point(255, 459);
            lblAtaqueEnemigo.Name = "lblAtaqueEnemigo";
            lblAtaqueEnemigo.Size = new Size(15, 20);
            lblAtaqueEnemigo.TabIndex = 10;
            lblAtaqueEnemigo.Text = "-";
            // 
            // lblNivelEnemigo
            // 
            lblNivelEnemigo.AutoSize = true;
            lblNivelEnemigo.Location = new Point(255, 428);
            lblNivelEnemigo.Name = "lblNivelEnemigo";
            lblNivelEnemigo.Size = new Size(15, 20);
            lblNivelEnemigo.TabIndex = 9;
            lblNivelEnemigo.Text = "-";
            // 
            // lblVidaEnemigo
            // 
            lblVidaEnemigo.AutoSize = true;
            lblVidaEnemigo.Location = new Point(255, 393);
            lblVidaEnemigo.Name = "lblVidaEnemigo";
            lblVidaEnemigo.Size = new Size(15, 20);
            lblVidaEnemigo.TabIndex = 8;
            lblVidaEnemigo.Text = "-";
            // 
            // lblNombreEnemigo
            // 
            lblNombreEnemigo.AutoSize = true;
            lblNombreEnemigo.Location = new Point(255, 356);
            lblNombreEnemigo.Name = "lblNombreEnemigo";
            lblNombreEnemigo.Size = new Size(15, 20);
            lblNombreEnemigo.TabIndex = 7;
            lblNombreEnemigo.Text = "-";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 536);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(156, 47);
            progressBar1.TabIndex = 7;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(22, 542);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(194, 47);
            progressBar2.TabIndex = 12;
            // 
            // btnAtacarGuerrero
            // 
            btnAtacarGuerrero.Location = new Point(201, 542);
            btnAtacarGuerrero.Name = "btnAtacarGuerrero";
            btnAtacarGuerrero.Size = new Size(71, 41);
            btnAtacarGuerrero.TabIndex = 8;
            btnAtacarGuerrero.Text = "Atacar";
            btnAtacarGuerrero.UseVisualStyleBackColor = true;
            btnAtacarGuerrero.Click += btnAtacarGuerrero_Click;
            // 
            // btnPocionesGuerrero
            // 
            btnPocionesGuerrero.Location = new Point(298, 539);
            btnPocionesGuerrero.Name = "btnPocionesGuerrero";
            btnPocionesGuerrero.Size = new Size(81, 46);
            btnPocionesGuerrero.TabIndex = 9;
            btnPocionesGuerrero.Text = "pociones";
            btnPocionesGuerrero.UseVisualStyleBackColor = true;
            btnPocionesGuerrero.Click += btnPocionesGuerrero_Click;
            // 
            // btnPocionesEnemigo
            // 
            btnPocionesEnemigo.Location = new Point(319, 545);
            btnPocionesEnemigo.Name = "btnPocionesEnemigo";
            btnPocionesEnemigo.Size = new Size(81, 46);
            btnPocionesEnemigo.TabIndex = 11;
            btnPocionesEnemigo.Text = "Pociones";
            btnPocionesEnemigo.UseVisualStyleBackColor = true;
            btnPocionesEnemigo.Click += btnPocionesEnemigo_Click;
            // 
            // btnAtacarEnemigo
            // 
            btnAtacarEnemigo.Location = new Point(222, 548);
            btnAtacarEnemigo.Name = "btnAtacarEnemigo";
            btnAtacarEnemigo.Size = new Size(71, 41);
            btnAtacarEnemigo.TabIndex = 10;
            btnAtacarEnemigo.Text = "Atacar";
            btnAtacarEnemigo.UseVisualStyleBackColor = true;
            btnAtacarEnemigo.Click += btnAtacarEnemigo_Click;
            //
            // txtNombreGuerrero
            //
            txtNombreGuerrero.Location = new Point(15, 55);
            txtNombreGuerrero.Name = "txtNombreGuerrero";
            txtNombreGuerrero.Size = new Size(160, 27);
            txtNombreGuerrero.TabIndex = 0;
            //
            // comboBox1
            //
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Location = new Point(192, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 1;
            //
            // txtNombreEnemigo
            //
            txtNombreEnemigo.Location = new Point(17, 62);
            txtNombreEnemigo.Name = "txtNombreEnemigo";
            txtNombreEnemigo.Size = new Size(160, 27);
            txtNombreEnemigo.TabIndex = 0;
            //
            // comboBox2
            //
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Location = new Point(194, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 28);
            comboBox2.TabIndex = 1;
            //
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 639);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox txtVidaGuerrero;
        private Label label7;
        private TextBox txtDefensaGuerrero;
        private TextBox txtPocionesGuerrero;
        private TextBox txtAtaqueGuerrero;
        private TextBox txtNivelGuerrero;
        private TextBox txtVidaEnemigo;
        private Label label14;
        private Label label8;
        private Label label13;
        private TextBox txtDefensaEnemigo;
        private Label label12;
        private TextBox txtPocionesEnemigo;
        private Label label11;
        private TextBox txtAtaqueEnemigo;
        private Label label10;
        private TextBox txtNivelEnemigo;
        private Label label9;
        private Button btnPocionesGuerrero;
        private Button btnAtacarGuerrero;
        private ProgressBar progressBar1;
        private Label lblDefensaGuerrero;
        private Label lblAtaqueGuerrero;
        private Label lblNivelGuerrero;
        private Label lblVidaGuerrero;
        private Label lblNombreGuerrero;
        private PictureBox pictureBox1;
        private Button btnCrearGuerrero;
        private ProgressBar progressBar2;
        private Label lblDefensaEnemigo;
        private PictureBox pictureBox2;
        private Label lblAtaqueEnemigo;
        private Button btnCrearEnemigo;
        private Label lblNivelEnemigo;
        private Label lblNombreEnemigo;
        private Label lblVidaEnemigo;
        private Button btnPocionesEnemigo;
        private Button btnAtacarEnemigo;
        private TextBox txtNombreGuerrero;
        private ComboBox comboBox1;
        private TextBox txtNombreEnemigo;
        private ComboBox comboBox2;
    }
}
