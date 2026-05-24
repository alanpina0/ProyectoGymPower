namespace GIMNASIO.Vistas
{
    partial class pconexion
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
            bconectar = new Button();
            SuspendLayout();
            // 
            // bconectar
            // 
            bconectar.Location = new Point(326, 190);
            bconectar.Name = "bconectar";
            bconectar.Size = new Size(112, 34);
            bconectar.TabIndex = 0;
            bconectar.Text = "Conectar";
            bconectar.UseVisualStyleBackColor = true;
            bconectar.Click += bconectar_Click;
            // 
            // pconexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bconectar);
            Name = "pconexion";
            Text = "pconexion";
            ResumeLayout(false);
        }

        #endregion

        private Button bconectar;
    }
}