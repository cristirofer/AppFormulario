namespace AppFormulario.Presentacion
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            AnteriorButton = new Button();
            GenerarButton = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            eToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // AnteriorButton
            // 
            AnteriorButton.Location = new Point(873, 707);
            AnteriorButton.Name = "AnteriorButton";
            AnteriorButton.Size = new Size(75, 23);
            AnteriorButton.TabIndex = 153;
            AnteriorButton.Text = "Anterior";
            AnteriorButton.UseVisualStyleBackColor = true;
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(976, 707);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(75, 23);
            GenerarButton.TabIndex = 152;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(404, 71);
            label1.Name = "label1";
            label1.Size = new Size(316, 32);
            label1.TabIndex = 151;
            label1.Text = "Documentos Generados";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { eToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1102, 24);
            menuStrip1.TabIndex = 154;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(720, 213);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 155;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Descargar";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(720, 262);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(59, 15);
            linkLabel2.TabIndex = 156;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Descargar";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(720, 308);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(59, 15);
            linkLabel3.TabIndex = 157;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Descargar";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(720, 360);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(59, 15);
            linkLabel4.TabIndex = 158;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Descargar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 213);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 159;
            label2.Text = "ConvenioPracticas.pdf";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 262);
            label3.Name = "label3";
            label3.Size = new Size(176, 15);
            label3.TabIndex = 160;
            label3.Text = "CompromisoPresupuestario.pdf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 308);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 161;
            label4.Text = "HojaDatosPersonales.pdf";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 360);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 162;
            label5.Text = "SeguroAccidentes.pdf";
            // 
            // label6
            // 
            label6.Location = new Point(313, 495);
            label6.Name = "label6";
            label6.Size = new Size(486, 66);
            label6.TabIndex = 163;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 741);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(AnteriorButton);
            Controls.Add(GenerarButton);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form4";
            Text = "Descargar Documentos";
            Load += Form4_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}