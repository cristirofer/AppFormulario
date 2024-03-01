namespace AppFormulario
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
            NombreTextBox = new TextBox();
            label1 = new Label();
            PaisTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            NacimientoTextBox = new TextBox();
            ProvinciaTextBox = new TextBox();
            MunicipioTextBox = new TextBox();
            DireccionTextBox = new TextBox();
            PostalTextBox = new TextBox();
            TelefonoTextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            EmailTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            DNITextBox = new TextBox();
            NIFTextBox = new TextBox();
            NumeroAfiliacionTextBox = new TextBox();
            LetraAfiliacionTextBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            EntidadTextBox = new TextBox();
            DireccionAgenciaTextBox = new TextBox();
            IBANTextBox = new TextBox();
            AgenciaTextBox = new TextBox();
            MunicipioTextBox2 = new TextBox();
            CCTextBox = new TextBox();
            ContinuarButton = new Button();
            CancelarButton = new Button();
            menuStrip1 = new MenuStrip();
            eToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            label21 = new Label();
            titulacionComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            CCLabel = new Label();
            IBANLabel = new Label();
            groupBox4 = new GroupBox();
            DNIlabel = new Label();
            postalLabel = new Label();
            emailLabel = new Label();
            fechaLabel = new Label();
            telefonoLabel = new Label();
            NUSSLabel = new Label();
            NIETextBox = new TextBox();
            NIELabel = new Label();
            label22 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(255, 155);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(727, 23);
            NombreTextBox.TabIndex = 0;
            NombreTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(443, 24);
            label1.Name = "label1";
            label1.Size = new Size(192, 32);
            label1.TabIndex = 1;
            label1.Text = "Datos Alumno";
            label1.Click += label1_Click;
            // 
            // PaisTextBox
            // 
            PaisTextBox.Location = new Point(255, 236);
            PaisTextBox.Name = "PaisTextBox";
            PaisTextBox.Size = new Size(241, 23);
            PaisTextBox.TabIndex = 2;
            PaisTextBox.TextChanged += PaisTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 155);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre y Apellidos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 195);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 236);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 6;
            label4.Text = "País";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(609, 240);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 8;
            label6.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(656, 281);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 9;
            label7.Text = "Provincia";
            // 
            // NacimientoTextBox
            // 
            NacimientoTextBox.Location = new Point(741, 240);
            NacimientoTextBox.Name = "NacimientoTextBox";
            NacimientoTextBox.Size = new Size(241, 23);
            NacimientoTextBox.TabIndex = 14;
            NacimientoTextBox.TextChanged += NacimientoTextBox_TextChanged;
            // 
            // ProvinciaTextBox
            // 
            ProvinciaTextBox.Location = new Point(741, 281);
            ProvinciaTextBox.Name = "ProvinciaTextBox";
            ProvinciaTextBox.Size = new Size(241, 23);
            ProvinciaTextBox.TabIndex = 15;
            ProvinciaTextBox.TextChanged += ProvinciaTextBox_TextChanged;
            // 
            // MunicipioTextBox
            // 
            MunicipioTextBox.Location = new Point(741, 322);
            MunicipioTextBox.Name = "MunicipioTextBox";
            MunicipioTextBox.Size = new Size(241, 23);
            MunicipioTextBox.TabIndex = 16;
            MunicipioTextBox.TextChanged += MunicipioTextBox_TextChanged;
            // 
            // DireccionTextBox
            // 
            DireccionTextBox.Location = new Point(255, 277);
            DireccionTextBox.Name = "DireccionTextBox";
            DireccionTextBox.Size = new Size(241, 23);
            DireccionTextBox.TabIndex = 17;
            DireccionTextBox.TextChanged += DireccionTextBox_TextChanged;
            // 
            // PostalTextBox
            // 
            PostalTextBox.Location = new Point(255, 318);
            PostalTextBox.Name = "PostalTextBox";
            PostalTextBox.Size = new Size(241, 23);
            PostalTextBox.TabIndex = 18;
            PostalTextBox.TextChanged += PostalTextBox_TextChanged;
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Location = new Point(741, 363);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(241, 23);
            TelefonoTextBox.TabIndex = 19;
            TelefonoTextBox.TextChanged += TelefonoTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(151, 277);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 20;
            label8.Text = "Dirección";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(158, 318);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 21;
            label9.Text = "C.Postal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(660, 363);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 22;
            label10.Text = "Teléfono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(651, 322);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 23;
            label11.Text = "Municipio";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(255, 359);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(241, 23);
            EmailTextBox.TabIndex = 24;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(587, 404);
            label12.Name = "label12";
            label12.Size = new Size(125, 15);
            label12.TabIndex = 26;
            label12.Text = "Número Afilicación SS";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(103, 359);
            label13.Name = "label13";
            label13.Size = new Size(105, 15);
            label13.TabIndex = 27;
            label13.Text = "Correo Electrónico";
            // 
            // DNITextBox
            // 
            DNITextBox.Location = new Point(255, 195);
            DNITextBox.Name = "DNITextBox";
            DNITextBox.Size = new Size(191, 23);
            DNITextBox.TabIndex = 29;
            DNITextBox.TextChanged += DNITextBox_TextChanged;
            // 
            // NIFTextBox
            // 
            NIFTextBox.Location = new Point(468, 195);
            NIFTextBox.Name = "NIFTextBox";
            NIFTextBox.Size = new Size(28, 23);
            NIFTextBox.TabIndex = 30;
            NIFTextBox.TextChanged += NIFTextBox_TextChanged;
            // 
            // NumeroAfiliacionTextBox
            // 
            NumeroAfiliacionTextBox.Location = new Point(741, 404);
            NumeroAfiliacionTextBox.Name = "NumeroAfiliacionTextBox";
            NumeroAfiliacionTextBox.Size = new Size(191, 23);
            NumeroAfiliacionTextBox.TabIndex = 31;
            NumeroAfiliacionTextBox.TextChanged += NumeroAfiliacionTextBox_TextChanged;
            // 
            // LetraAfiliacionTextBox
            // 
            LetraAfiliacionTextBox.Location = new Point(954, 404);
            LetraAfiliacionTextBox.Name = "LetraAfiliacionTextBox";
            LetraAfiliacionTextBox.Size = new Size(28, 23);
            LetraAfiliacionTextBox.TabIndex = 32;
            LetraAfiliacionTextBox.TextChanged += LetraAfiliacionTextBox_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(83, 433);
            label14.Name = "label14";
            label14.Size = new Size(0, 21);
            label14.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(158, 541);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 34;
            label15.Text = "Entidad ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(105, 583);
            label16.Name = "label16";
            label16.Size = new Size(103, 15);
            label16.TabIndex = 35;
            label16.Text = "Dirección Agencia";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(613, 541);
            label17.Name = "label17";
            label17.Size = new Size(99, 15);
            label17.TabIndex = 36;
            label17.Text = "Agencia - Oficina";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(651, 583);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 37;
            label18.Text = "Municipio";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(174, 625);
            label19.Name = "label19";
            label19.Size = new Size(34, 15);
            label19.TabIndex = 38;
            label19.Text = "IBAN";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(585, 625);
            label20.Name = "label20";
            label20.Size = new Size(127, 15);
            label20.TabIndex = 39;
            label20.Text = "Número Libreta o C/C ";
            // 
            // EntidadTextBox
            // 
            EntidadTextBox.Location = new Point(255, 541);
            EntidadTextBox.Name = "EntidadTextBox";
            EntidadTextBox.Size = new Size(241, 23);
            EntidadTextBox.TabIndex = 40;
            EntidadTextBox.TextChanged += EntidadTextBox_TextChanged;
            // 
            // DireccionAgenciaTextBox
            // 
            DireccionAgenciaTextBox.Location = new Point(255, 583);
            DireccionAgenciaTextBox.Name = "DireccionAgenciaTextBox";
            DireccionAgenciaTextBox.Size = new Size(241, 23);
            DireccionAgenciaTextBox.TabIndex = 41;
            DireccionAgenciaTextBox.TextChanged += DireccionAgenciaTextBox_TextChanged;
            // 
            // IBANTextBox
            // 
            IBANTextBox.Location = new Point(255, 625);
            IBANTextBox.Name = "IBANTextBox";
            IBANTextBox.Size = new Size(241, 23);
            IBANTextBox.TabIndex = 42;
            IBANTextBox.TextChanged += IBANTextBox_TextChanged;
            // 
            // AgenciaTextBox
            // 
            AgenciaTextBox.Location = new Point(741, 541);
            AgenciaTextBox.Name = "AgenciaTextBox";
            AgenciaTextBox.Size = new Size(241, 23);
            AgenciaTextBox.TabIndex = 43;
            AgenciaTextBox.TextChanged += AgenciaTextBox_TextChanged;
            // 
            // MunicipioTextBox2
            // 
            MunicipioTextBox2.Location = new Point(741, 583);
            MunicipioTextBox2.Name = "MunicipioTextBox2";
            MunicipioTextBox2.Size = new Size(241, 23);
            MunicipioTextBox2.TabIndex = 44;
            MunicipioTextBox2.TextChanged += MunicipioTextBox2_TextChanged;
            // 
            // CCTextBox
            // 
            CCTextBox.Location = new Point(741, 625);
            CCTextBox.Name = "CCTextBox";
            CCTextBox.Size = new Size(241, 23);
            CCTextBox.TabIndex = 45;
            CCTextBox.TextChanged += CCTextBox_TextChanged;
            // 
            // ContinuarButton
            // 
            ContinuarButton.Location = new Point(973, 764);
            ContinuarButton.Name = "ContinuarButton";
            ContinuarButton.Size = new Size(75, 23);
            ContinuarButton.TabIndex = 46;
            ContinuarButton.Text = "Continuar";
            ContinuarButton.UseVisualStyleBackColor = true;
            ContinuarButton.Click += ContinuarButton_Click;
            ContinuarButton.MouseClick += ContinuarButton_Click2;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(870, 764);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(75, 23);
            CancelarButton.TabIndex = 47;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1102, 24);
            menuStrip1.TabIndex = 48;
            menuStrip1.Text = "menuStrip1";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(38, 20);
            eToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(128, 404);
            label21.Name = "label21";
            label21.Size = new Size(78, 15);
            label21.TabIndex = 49;
            label21.Text = "Titulación(es)";
            // 
            // titulacionComboBox
            // 
            titulacionComboBox.FormattingEnabled = true;
            titulacionComboBox.Location = new Point(255, 404);
            titulacionComboBox.Name = "titulacionComboBox";
            titulacionComboBox.Size = new Size(241, 23);
            titulacionComboBox.TabIndex = 50;
            titulacionComboBox.SelectedIndexChanged += TitulacionComboBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(51, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 339);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 341);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(997, 197);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Personales";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CCLabel);
            groupBox3.Controls.Add(IBANLabel);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(51, 501);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(997, 170);
            groupBox3.TabIndex = 53;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Bancarios";
            // 
            // CCLabel
            // 
            CCLabel.AutoSize = true;
            CCLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CCLabel.ForeColor = Color.Red;
            CCLabel.Location = new Point(690, 108);
            CCLabel.Name = "CCLabel";
            CCLabel.Size = new Size(101, 13);
            CCLabel.TabIndex = 68;
            CCLabel.Text = "Formato no válido";
            // 
            // IBANLabel
            // 
            IBANLabel.AutoSize = true;
            IBANLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IBANLabel.ForeColor = Color.Red;
            IBANLabel.Location = new Point(204, 108);
            IBANLabel.Name = "IBANLabel";
            IBANLabel.Size = new Size(101, 13);
            IBANLabel.TabIndex = 69;
            IBANLabel.Text = "Formato no válido";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(0, 341);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(997, 197);
            groupBox4.TabIndex = 52;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Personales";
            // 
            // DNIlabel
            // 
            DNIlabel.AutoSize = true;
            DNIlabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DNIlabel.ForeColor = Color.Red;
            DNIlabel.Location = new Point(255, 181);
            DNIlabel.Name = "DNIlabel";
            DNIlabel.Size = new Size(101, 13);
            DNIlabel.TabIndex = 55;
            DNIlabel.Text = "Formato no válido";
            // 
            // postalLabel
            // 
            postalLabel.AutoSize = true;
            postalLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postalLabel.ForeColor = Color.Red;
            postalLabel.Location = new Point(255, 303);
            postalLabel.Name = "postalLabel";
            postalLabel.Size = new Size(101, 13);
            postalLabel.TabIndex = 58;
            postalLabel.Text = "Formato no válido";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = Color.Red;
            emailLabel.Location = new Point(255, 344);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(101, 13);
            emailLabel.TabIndex = 59;
            emailLabel.Text = "Formato no válido";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaLabel.ForeColor = Color.Red;
            fechaLabel.Location = new Point(741, 226);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(101, 13);
            fechaLabel.TabIndex = 61;
            fechaLabel.Text = "Formato no válido";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoLabel.ForeColor = Color.Red;
            telefonoLabel.Location = new Point(741, 348);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(101, 13);
            telefonoLabel.TabIndex = 64;
            telefonoLabel.Text = "Formato no válido";
            // 
            // NUSSLabel
            // 
            NUSSLabel.AutoSize = true;
            NUSSLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NUSSLabel.ForeColor = Color.Red;
            NUSSLabel.Location = new Point(741, 389);
            NUSSLabel.Name = "NUSSLabel";
            NUSSLabel.Size = new Size(101, 13);
            NUSSLabel.TabIndex = 65;
            NUSSLabel.Text = "Formato no válido";
            // 
            // NIETextBox
            // 
            NIETextBox.Location = new Point(741, 195);
            NIETextBox.Name = "NIETextBox";
            NIETextBox.Size = new Size(241, 23);
            NIETextBox.TabIndex = 66;
            NIETextBox.TextChanged += NIETextBox_TextChanged_1;
            // 
            // NIELabel
            // 
            NIELabel.AutoSize = true;
            NIELabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NIELabel.ForeColor = Color.Red;
            NIELabel.Location = new Point(741, 181);
            NIELabel.Name = "NIELabel";
            NIELabel.Size = new Size(101, 13);
            NIELabel.TabIndex = 67;
            NIELabel.Text = "Formato no válido";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(687, 195);
            label22.Name = "label22";
            label22.Size = new Size(25, 15);
            label22.TabIndex = 68;
            label22.Text = "NIE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 816);
            Controls.Add(label22);
            Controls.Add(NIELabel);
            Controls.Add(NIETextBox);
            Controls.Add(NUSSLabel);
            Controls.Add(telefonoLabel);
            Controls.Add(fechaLabel);
            Controls.Add(emailLabel);
            Controls.Add(postalLabel);
            Controls.Add(DNIlabel);
            Controls.Add(titulacionComboBox);
            Controls.Add(label21);
            Controls.Add(CancelarButton);
            Controls.Add(ContinuarButton);
            Controls.Add(CCTextBox);
            Controls.Add(MunicipioTextBox2);
            Controls.Add(AgenciaTextBox);
            Controls.Add(IBANTextBox);
            Controls.Add(DireccionAgenciaTextBox);
            Controls.Add(EntidadTextBox);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(LetraAfiliacionTextBox);
            Controls.Add(NumeroAfiliacionTextBox);
            Controls.Add(NIFTextBox);
            Controls.Add(DNITextBox);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(EmailTextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TelefonoTextBox);
            Controls.Add(PostalTextBox);
            Controls.Add(DireccionTextBox);
            Controls.Add(MunicipioTextBox);
            Controls.Add(ProvinciaTextBox);
            Controls.Add(NacimientoTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PaisTextBox);
            Controls.Add(label1);
            Controls.Add(NombreTextBox);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Rellenar Datos Alumno";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreTextBox;
        private Label label1;
        private TextBox PaisTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox NacimientoTextBox;
        private TextBox ProvinciaTextBox;
        private TextBox MunicipioTextBox;
        private TextBox DireccionTextBox;
        private TextBox PostalTextBox;
        private TextBox TelefonoTextBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox EmailTextBox;
        private Label label12;
        private Label label13;
        private TextBox DNITextBox;
        private TextBox NIFTextBox;
        private TextBox NumeroAfiliacionTextBox;
        private TextBox LetraAfiliacionTextBox;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox EntidadTextBox;
        private TextBox DireccionAgenciaTextBox;
        private TextBox IBANTextBox;
        private TextBox AgenciaTextBox;
        private TextBox MunicipioTextBox2;
        private TextBox CCTextBox;
        private Button ContinuarButton;
        private Button CancelarButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label label21;
        private ComboBox titulacionComboBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label DNIlabel;
        private Label postalLabel;
        private Label emailLabel;
        private Label fechaLabel;
        private Label telefonoLabel;
        private Label NUSSLabel;
        private Label CCLabel;
        private Label IBANLabel;
        private TextBox NIETextBox;
        private Label NIELabel;
        private Label label22;
    }
}
