namespace view
{
    partial class pPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pPago));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtCambio = new TextBox();
            label1 = new Label();
            txtPago = new TextBox();
            l2 = new Label();
            btnCancelar = new Button();
            letrero1 = new Label();
            btnConfirmar = new Button();
            txtMonMem = new TextBox();
            txtMembresia = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtCambio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPago);
            panel1.Controls.Add(l2);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(letrero1);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(txtMonMem);
            panel1.Controls.Add(txtMembresia);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 447);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(415, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 131);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtCambio
            // 
            txtCambio.Enabled = false;
            txtCambio.Location = new Point(230, 244);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(150, 31);
            txtCambio.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 246);
            label1.Name = "label1";
            label1.Size = new Size(85, 29);
            label1.TabIndex = 7;
            label1.Text = "Cambio";
            // 
            // txtPago
            // 
            txtPago.Location = new Point(230, 177);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(150, 31);
            txtPago.TabIndex = 1;
            txtPago.TextChanged += txtPago_TextChanged;
            txtPago.KeyPress += txtPago_KeyPress;
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l2.Location = new Point(44, 177);
            l2.Name = "l2";
            l2.Size = new Size(61, 29);
            l2.TabIndex = 5;
            l2.Text = "Pago";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderColor = Color.Black;
            btnCancelar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(42, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // letrero1
            // 
            letrero1.AutoSize = true;
            letrero1.Font = new Font("Tw Cen MT Condensed Extra Bold", 15F);
            letrero1.Location = new Point(157, 23);
            letrero1.Name = "letrero1";
            letrero1.Size = new Size(141, 35);
            letrero1.TabIndex = 3;
            letrero1.Text = "Membresía";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Green;
            btnConfirmar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(237, 303);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(145, 48);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtMonMem
            // 
            txtMonMem.BackColor = SystemColors.ControlLight;
            txtMonMem.BorderStyle = BorderStyle.None;
            txtMonMem.Enabled = false;
            txtMonMem.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMonMem.ForeColor = Color.Black;
            txtMonMem.Location = new Point(237, 107);
            txtMonMem.Name = "txtMonMem";
            txtMonMem.Size = new Size(143, 33);
            txtMonMem.TabIndex = 0;
            txtMonMem.TextChanged += txtMonMem_TextChanged;
            // 
            // txtMembresia
            // 
            txtMembresia.BackColor = Color.Silver;
            txtMembresia.BorderStyle = BorderStyle.None;
            txtMembresia.Enabled = false;
            txtMembresia.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMembresia.ForeColor = Color.Black;
            txtMembresia.Location = new Point(44, 107);
            txtMembresia.Name = "txtMembresia";
            txtMembresia.Size = new Size(143, 33);
            txtMembresia.TabIndex = 0;
            // 
            // pPago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pPago";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pPago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtMembresia;
        private TextBox txtMonMem;
        private Label letrero1;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox txtPago;
        private Label l2;
        private PictureBox pictureBox1;
        private TextBox txtCambio;
        private Label label1;
    }
}