
namespace Form1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            usuariotxt = new TextBox();
            contrasenatxt = new TextBox();
            bEntrar = new Button();
            usuarioimg = new PictureBox();
            btc = new Button();
            bminimizar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioimg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 607);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 221);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // usuariotxt
            // 
            usuariotxt.BackColor = Color.Gainsboro;
            usuariotxt.BorderStyle = BorderStyle.None;
            usuariotxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuariotxt.ForeColor = SystemColors.WindowFrame;
            usuariotxt.Location = new Point(417, 290);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(500, 30);
            usuariotxt.TabIndex = 0;
            usuariotxt.Text = "                             Usuario";
            usuariotxt.Click += usuario_Click_1;
            usuariotxt.TextChanged += usuario_TextChanged;
            // 
            // contrasenatxt
            // 
            contrasenatxt.BackColor = Color.Gainsboro;
            contrasenatxt.BorderStyle = BorderStyle.None;
            contrasenatxt.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contrasenatxt.ForeColor = SystemColors.WindowFrame;
            contrasenatxt.Location = new Point(417, 376);
            contrasenatxt.Name = "contrasenatxt";
            contrasenatxt.Size = new Size(500, 30);
            contrasenatxt.TabIndex = 1;
            contrasenatxt.Text = "                          Contrasena";
            contrasenatxt.Click += contrasena_Click_1;
            contrasenatxt.TextChanged += contrasena_TextChanged;
            // 
            // bEntrar
            // 
            bEntrar.BackColor = SystemColors.ControlDarkDark;
            bEntrar.Cursor = Cursors.AppStarting;
            bEntrar.FlatAppearance.BorderColor = Color.AliceBlue;
            bEntrar.FlatAppearance.BorderSize = 0;
            bEntrar.FlatAppearance.MouseDownBackColor = Color.Black;
            bEntrar.FlatAppearance.MouseOverBackColor = Color.Black;
            bEntrar.FlatStyle = FlatStyle.Flat;
            bEntrar.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bEntrar.ForeColor = SystemColors.ButtonHighlight;
            bEntrar.Location = new Point(417, 486);
            bEntrar.Name = "bEntrar";
            bEntrar.Size = new Size(500, 40);
            bEntrar.TabIndex = 2;
            bEntrar.Text = "LOGIN";
            bEntrar.UseVisualStyleBackColor = false;
            bEntrar.Click += bEntrar_Click;
            // 
            // usuarioimg
            // 
            usuarioimg.Image = (Image)resources.GetObject("usuarioimg.Image");
            usuarioimg.Location = new Point(600, 116);
            usuarioimg.Name = "usuarioimg";
            usuarioimg.Size = new Size(178, 134);
            usuarioimg.TabIndex = 7;
            usuarioimg.TabStop = false;
            // 
            // btc
            // 
            btc.BackColor = SystemColors.Control;
            btc.FlatAppearance.BorderSize = 0;
            btc.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btc.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btc.FlatStyle = FlatStyle.Flat;
            btc.Image = (Image)resources.GetObject("btc.Image");
            btc.Location = new Point(968, 16);
            btc.Name = "btc";
            btc.Size = new Size(72, 66);
            btc.TabIndex = 8;
            btc.UseVisualStyleBackColor = false;
            btc.Click += btc_Click;
            // 
            // bminimizar
            // 
            bminimizar.BackColor = SystemColors.Control;
            bminimizar.FlatAppearance.BorderSize = 0;
            bminimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            bminimizar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            bminimizar.FlatStyle = FlatStyle.Flat;
            bminimizar.Image = (Image)resources.GetObject("bminimizar.Image");
            bminimizar.Location = new Point(874, 11);
            bminimizar.Name = "bminimizar";
            bminimizar.Size = new Size(70, 71);
            bminimizar.TabIndex = 9;
            bminimizar.UseVisualStyleBackColor = false;
            bminimizar.Click += bminimizar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 607);
            Controls.Add(bminimizar);
            Controls.Add(btc);
            Controls.Add(usuarioimg);
            Controls.Add(bEntrar);
            Controls.Add(contrasenatxt);
            Controls.Add(usuariotxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "n ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Panel panel1;
        private TextBox usuariotxt;
        private TextBox contrasenatxt;
        private Button bEntrar;
        private PictureBox usuarioimg;
        private Button btc;
        private Button bminimizar;
        private PictureBox pictureBox1;
    }
}
