using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms;

namespace view
{
    public partial class Main : Form
    {

        Color colorPanel2;
        Color colorPanel3;
        Color colorPanel4;

        Panel[] paneles;
        int indiceSeleccionado = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            colorPanel2 = panel2.BackColor;
            colorPanel3 = panel3.BackColor;
            colorPanel4 = panel4.BackColor;

            RedondearPanel(panel2, 40);
            RedondearPanel(panel3, 40);
            RedondearPanel(panel4, 40);

            paneles = new Panel[] { panel2, panel3, panel4 };

            this.KeyPreview = true;


            SeleccionarPanel(0);


        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // Flecha derecha
            if (e.KeyCode == Keys.Right)
            {
                indiceSeleccionado++;

                // Si pasa del último, vuelve al primero
                if (indiceSeleccionado >= paneles.Length)
                {
                    indiceSeleccionado = 0;
                }

                SeleccionarPanel(indiceSeleccionado);
            }

            // Flecha izquierda
            if (e.KeyCode == Keys.Left)
            {
                indiceSeleccionado--;

                // Si baja de 0, va al último
                if (indiceSeleccionado < 0)
                {
                    indiceSeleccionado = paneles.Length - 1;
                }

                SeleccionarPanel(indiceSeleccionado);
            }

            // ENTER para abrir el panel seleccionado
            if (e.KeyCode == Keys.Enter)
            {
                switch (indiceSeleccionado)
                {
                    case 0:
                        panel2_Click(panel2, EventArgs.Empty);
                        break;

                    case 1:
                        panel3_MouseClick(panel3, null);
                        break;

                    case 2:
                        panel4_MouseClick(panel4, null);
                        break;
                }
            }
        }
        private void SeleccionarPanel(int indice)
        {
            // Restaurar colores originales
            panel2.BackColor = colorPanel2;
            panel3.BackColor = colorPanel3;
            panel4.BackColor = colorPanel4;

            // Resaltar panel seleccionado
            paneles[indice].BackColor = Color.Gold;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue; // el color que quieras

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = colorPanel2;

        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.DarkGray; // el color que quieras

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = colorPanel3;

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red; // el color que quieras

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = colorPanel4;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = DateTime.Now.ToString("dddd");
            lblFecha.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            pMembresias nuevaVentana = new pMembresias();
            nuevaVentana.Show();

            // Ocultar login
            this.Hide();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            pCrearMiembro nuevaVentana = new pCrearMiembro();
            nuevaVentana.Show();

            // Ocultar login
            this.Hide();

        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            pReportes nuevaVentana = new pReportes();
            nuevaVentana.Show();

            // Ocultar login
            this.Hide();
        }

        private void panel4_Leave(object sender, EventArgs e)
        {

        }

        private void pmain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Flecha derecha
            if (keyData == Keys.Right)
            {
                indiceSeleccionado++;

                if (indiceSeleccionado >= paneles.Length)
                {
                    indiceSeleccionado = 0;
                }

                SeleccionarPanel(indiceSeleccionado);
                return true;
            }

            // Flecha izquierda
            if (keyData == Keys.Left)
            {
                indiceSeleccionado--;

                if (indiceSeleccionado < 0)
                {
                    indiceSeleccionado = paneles.Length - 1;
                }

                SeleccionarPanel(indiceSeleccionado);
                return true;
            }

            // ENTER
            if (keyData == Keys.Enter)
            {
                switch (indiceSeleccionado)
                {
                    case 0:
                        panel2_Click(panel2, EventArgs.Empty);
                        break;

                    case 1:
                        panel3_MouseClick(panel3, null);
                        break;

                    case 2:
                        panel4_MouseClick(panel4, null);
                        break;
                }

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
