namespace AppFormulario.Presentacion
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AnteriorButton = new Button();
            GenerarButton = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            eToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            NombreBeneficiarioTextBox = new TextBox();
            NIFBeneficiarioTextBox = new TextBox();
            ParentescoBeneficiarioTextBox = new TextBox();
            PorcentajeBeneficiarioTextBox = new TextBox();
            AñadirButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AnteriorButton
            // 
            AnteriorButton.Location = new Point(873, 696);
            AnteriorButton.Name = "AnteriorButton";
            AnteriorButton.Size = new Size(75, 23);
            AnteriorButton.TabIndex = 148;
            AnteriorButton.Text = "Anterior";
            AnteriorButton.UseVisualStyleBackColor = true;
            AnteriorButton.Click += AnteriorButton_Click;
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(976, 696);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(75, 23);
            GenerarButton.TabIndex = 147;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            GenerarButton.Click += GenerarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(431, 38);
            label1.Name = "label1";
            label1.Size = new Size(248, 32);
            label1.TabIndex = 119;
            label1.Text = "Seguro Accidentes";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1102, 24);
            menuStrip1.TabIndex = 149;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(153, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(795, 336);
            dataGridView1.TabIndex = 150;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Orden";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre y Apellidos";
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "NIF";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Parentesco";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Porcentaje";
            Column5.Name = "Column5";
            // 
            // NombreBeneficiarioTextBox
            // 
            NombreBeneficiarioTextBox.Location = new Point(153, 191);
            NombreBeneficiarioTextBox.Name = "NombreBeneficiarioTextBox";
            NombreBeneficiarioTextBox.Size = new Size(289, 23);
            NombreBeneficiarioTextBox.TabIndex = 151;
            NombreBeneficiarioTextBox.TextChanged += textBox1_TextChanged;
            // 
            // NIFBeneficiarioTextBox
            // 
            NIFBeneficiarioTextBox.Location = new Point(462, 191);
            NIFBeneficiarioTextBox.Name = "NIFBeneficiarioTextBox";
            NIFBeneficiarioTextBox.Size = new Size(111, 23);
            NIFBeneficiarioTextBox.TabIndex = 152;
            NIFBeneficiarioTextBox.TextChanged += NIFBeneficiarioTextBox_TextChanged;
            // 
            // ParentescoBeneficiarioTextBox
            // 
            ParentescoBeneficiarioTextBox.Location = new Point(592, 191);
            ParentescoBeneficiarioTextBox.Name = "ParentescoBeneficiarioTextBox";
            ParentescoBeneficiarioTextBox.Size = new Size(105, 23);
            ParentescoBeneficiarioTextBox.TabIndex = 153;
            ParentescoBeneficiarioTextBox.TextChanged += ParentescoBeneficiarioTextBox_TextChanged;
            // 
            // PorcentajeBeneficiarioTextBox
            // 
            PorcentajeBeneficiarioTextBox.Location = new Point(715, 191);
            PorcentajeBeneficiarioTextBox.Name = "PorcentajeBeneficiarioTextBox";
            PorcentajeBeneficiarioTextBox.Size = new Size(115, 23);
            PorcentajeBeneficiarioTextBox.TabIndex = 154;
            PorcentajeBeneficiarioTextBox.TextChanged += PorcentajeBeneficiarioTextBox_TextChanged;
            // 
            // AñadirButton
            // 
            AñadirButton.Location = new Point(873, 190);
            AñadirButton.Name = "AñadirButton";
            AñadirButton.Size = new Size(75, 23);
            AñadirButton.TabIndex = 155;
            AñadirButton.Text = "Añadir";
            AñadirButton.UseVisualStyleBackColor = true;
            AñadirButton.Click += AñadirButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 161);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 156;
            label2.Text = "Nombre y Apellidos Beneficiario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 161);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 157;
            label3.Text = "NIF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(592, 161);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 158;
            label4.Text = "Parentesco";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(715, 161);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 159;
            label5.Text = "Porcentaje";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 741);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AñadirButton);
            Controls.Add(PorcentajeBeneficiarioTextBox);
            Controls.Add(ParentescoBeneficiarioTextBox);
            Controls.Add(NIFBeneficiarioTextBox);
            Controls.Add(NombreBeneficiarioTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(AnteriorButton);
            Controls.Add(GenerarButton);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form3";
            Text = "Rellenar Formulario";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AnteriorButton;
        private Button GenerarButton;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox NombreBeneficiarioTextBox;
        private TextBox NIFBeneficiarioTextBox;
        private TextBox ParentescoBeneficiarioTextBox;
        private TextBox PorcentajeBeneficiarioTextBox;
        private Button AñadirButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}