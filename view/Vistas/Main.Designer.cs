namespace view
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pmain = new Panel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            lblHora = new Label();
            lblDia = new Label();
            lblFecha = new Label();
            btc = new Button();
            bminimizar = new Button();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pmain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pmain
            // 
            pmain.BackColor = Color.Gray;
            pmain.Controls.Add(panel1);
            pmain.Controls.Add(btc);
            pmain.Controls.Add(bminimizar);
            pmain.Controls.Add(panel4);
            pmain.Controls.Add(panel3);
            pmain.Controls.Add(panel2);
            pmain.Dock = DockStyle.Fill;
            pmain.ForeColor = Color.SteelBlue;
            pmain.Location = new Point(0, 0);
            pmain.Name = "pmain";
            pmain.Size = new Size(1200, 607);
            pmain.TabIndex = 0;
            pmain.Paint += panel1_Paint;
            pmain.PreviewKeyDown += pmain_PreviewKeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblHora);
            panel1.Controls.Add(lblDia);
            panel1.Controls.Add(lblFecha);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 604);
            panel1.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(283, 146);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe MDL2 Assets", 50F);
            lblHora.ForeColor = Color.LightSeaGreen;
            lblHora.Location = new Point(0, 273);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(205, 100);
            lblHora.TabIndex = 11;
            lblHora.Text = "Hora";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 15F);
            lblDia.ForeColor = SystemColors.ButtonHighlight;
            lblDia.Location = new Point(119, 209);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(61, 41);
            lblDia.TabIndex = 12;
            lblDia.Text = "Dia";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(85, 430);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(95, 41);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
            // 
            // btc
            // 
            btc.BackColor = Color.Gray;
            btc.FlatAppearance.BorderSize = 0;
            btc.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btc.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btc.FlatStyle = FlatStyle.Flat;
            btc.Image = (Image)resources.GetObject("btc.Image");
            btc.Location = new Point(1106, 5);
            btc.Name = "btc";
            btc.Size = new Size(72, 66);
            btc.TabIndex = 9;
            btc.UseVisualStyleBackColor = false;
            btc.Click += btc_Click;
            // 
            // bminimizar
            // 
            bminimizar.BackColor = Color.Gray;
            bminimizar.FlatAppearance.BorderSize = 0;
            bminimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            bminimizar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            bminimizar.FlatStyle = FlatStyle.Flat;
            bminimizar.ForeColor = Color.Snow;
            bminimizar.Image = (Image)resources.GetObject("bminimizar.Image");
            bminimizar.Location = new Point(1014, 0);
            bminimizar.Name = "bminimizar";
            bminimizar.Size = new Size(70, 71);
            bminimizar.TabIndex = 10;
            bminimizar.UseVisualStyleBackColor = false;
            bminimizar.Click += bminimizar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(957, 161);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 390);
            panel4.TabIndex = 2;
            panel4.Leave += panel4_Leave;
            panel4.MouseClick += panel4_MouseClick;
            panel4.MouseEnter += panel4_MouseEnter;
            panel4.MouseLeave += panel4_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(57, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 135);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Artifakt Element Heavy", 15F);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(-3, 349);
            label2.Name = "label2";
            label2.Size = new Size(235, 41);
            label2.TabIndex = 1;
            label2.Text = "      Reportes      ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(687, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 390);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            panel3.MouseClick += panel3_MouseClick;
            panel3.MouseEnter += panel3_MouseEnter;
            panel3.MouseLeave += panel3_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 148);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Artifakt Element Heavy", 15F);
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(0, 349);
            label3.Name = "label3";
            label3.Size = new Size(250, 41);
            label3.TabIndex = 2;
            label3.Text = "  Nuevo Cliente  ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(415, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 390);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            panel2.Paint += panel2_Paint;
            panel2.MouseEnter += panel2_MouseEnter;
            panel2.MouseLeave += panel2_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(56, 128);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 148);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Artifakt Element Heavy", 15F);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(-14, 348);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 0;
            label1.Text = "     Membresías    ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 607);
            Controls.Add(pmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            pmain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel pmain;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btc;
        private Button bminimizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblHora;
        private Label lblFecha;
        private Label lblDia;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pictureBox4;
    }
}