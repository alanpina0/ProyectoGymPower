namespace view
{
    partial class pReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pReportes));
            btcerrar = new Button();
            btvolver = new PictureBox();
            bminimizar = new Button();
            r1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            r2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            r3 = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            r4 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btvolver).BeginInit();
            r1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            r2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            r3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            r4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btcerrar
            // 
            btcerrar.BackColor = SystemColors.ScrollBar;
            btcerrar.FlatAppearance.BorderSize = 0;
            btcerrar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btcerrar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btcerrar.FlatStyle = FlatStyle.Flat;
            btcerrar.Image = (Image)resources.GetObject("btcerrar.Image");
            btcerrar.Location = new Point(1108, 19);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(72, 66);
            btcerrar.TabIndex = 14;
            btcerrar.UseVisualStyleBackColor = false;
            btcerrar.Click += btcerrar_Click;
            // 
            // btvolver
            // 
            btvolver.Image = (Image)resources.GetObject("btvolver.Image");
            btvolver.Location = new Point(1031, 23);
            btvolver.Name = "btvolver";
            btvolver.Size = new Size(66, 67);
            btvolver.TabIndex = 15;
            btvolver.TabStop = false;
            btvolver.Click += btvolver_Click;
            // 
            // bminimizar
            // 
            bminimizar.BackColor = Color.Silver;
            bminimizar.FlatAppearance.BorderSize = 0;
            bminimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            bminimizar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            bminimizar.FlatStyle = FlatStyle.Flat;
            bminimizar.ForeColor = Color.Snow;
            bminimizar.Image = (Image)resources.GetObject("bminimizar.Image");
            bminimizar.Location = new Point(941, 19);
            bminimizar.Name = "bminimizar";
            bminimizar.Size = new Size(70, 71);
            bminimizar.TabIndex = 16;
            bminimizar.UseVisualStyleBackColor = false;
            bminimizar.Click += bminimizar_Click;
            // 
            // r1
            // 
            r1.BackColor = Color.SteelBlue;
            r1.Controls.Add(pictureBox1);
            r1.Controls.Add(label3);
            r1.Location = new Point(108, 180);
            r1.Name = "r1";
            r1.Size = new Size(215, 279);
            r1.TabIndex = 17;
            r1.Click += r1_Click;
            r1.MouseEnter += r1_MouseEnter;
            r1.MouseLeave += r1_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 136);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MidnightBlue;
            label3.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(-13, 0);
            label3.Name = "label3";
            label3.Size = new Size(239, 34);
            label3.TabIndex = 2;
            label3.Text = "     Miembros     ";
            // 
            // r2
            // 
            r2.BackColor = Color.Crimson;
            r2.Controls.Add(pictureBox2);
            r2.Controls.Add(label2);
            r2.Location = new Point(358, 180);
            r2.Name = "r2";
            r2.Size = new Size(215, 279);
            r2.TabIndex = 18;
            r2.Click += r2_Click;
            r2.MouseEnter += r2_MouseEnter;
            r2.MouseLeave += r2_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(51, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 118);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkRed;
            label2.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 34);
            label2.TabIndex = 1;
            label2.Text = "  Membresías  ";
            label2.Click += label2_Click;
            // 
            // r3
            // 
            r3.BackColor = Color.YellowGreen;
            r3.Controls.Add(pictureBox4);
            r3.Controls.Add(label1);
            r3.Location = new Point(634, 180);
            r3.Name = "r3";
            r3.Size = new Size(215, 279);
            r3.TabIndex = 19;
            r3.Click += r3_Click;
            r3.MouseEnter += r3_MouseEnter;
            r3.MouseLeave += r3_MouseLeave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(36, 82);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 135);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOliveGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 34);
            label1.TabIndex = 0;
            label1.Text = "   Asistencias   ";
            // 
            // r4
            // 
            r4.BackColor = Color.Gold;
            r4.Controls.Add(pictureBox3);
            r4.Controls.Add(label4);
            r4.Location = new Point(894, 180);
            r4.Name = "r4";
            r4.Size = new Size(215, 279);
            r4.TabIndex = 20;
            r4.Click += r4_Click;
            r4.MouseEnter += r4_MouseEnter;
            r4.MouseLeave += r4_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(41, 82);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 135);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGoldenrod;
            label4.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 34);
            label4.TabIndex = 2;
            label4.Text = "     Ingresos     ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 15F);
            label5.Location = new Point(377, 77);
            label5.Name = "label5";
            label5.Size = new Size(0, 41);
            label5.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Artifakt Element Heavy", 18F);
            label6.Location = new Point(471, 54);
            label6.Name = "label6";
            label6.Size = new Size(254, 51);
            label6.TabIndex = 22;
            label6.Text = "     Reportes    ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(r4);
            panel1.Controls.Add(r3);
            panel1.Controls.Add(r2);
            panel1.Controls.Add(r1);
            panel1.Controls.Add(bminimizar);
            panel1.Controls.Add(btvolver);
            panel1.Controls.Add(btcerrar);
            panel1.Font = new Font("Segoe UI", 15F);
            panel1.Location = new Point(-7, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 563);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 551);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pReportes";
            ((System.ComponentModel.ISupportInitialize)btvolver).EndInit();
            r1.ResumeLayout(false);
            r1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            r2.ResumeLayout(false);
            r2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            r3.ResumeLayout(false);
            r3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            r4.ResumeLayout(false);
            r4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btcerrar;
        private PictureBox btvolver;
        private Button bminimizar;
        private Panel r1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel r2;
        private Label label2;
        private Panel r3;
        private Label label1;
        private Panel r4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}