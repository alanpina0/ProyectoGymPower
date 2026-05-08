using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace view
{
    public partial class pReportes : Form
    {


        Color colorPanelr1;
        Color colorPanelr2;
        Color colorPanelr3;
        Color colorPanelr4;


        public pReportes()
        {
            InitializeComponent();

            colorPanelr1 = r1.BackColor;
            colorPanelr2 = r2.BackColor;
            colorPanelr3 = r3.BackColor;
            colorPanelr4 = r4.BackColor;


            RedondearPanel(r1, 40);
            RedondearPanel(r2, 40);
            RedondearPanel(r3, 40);
            RedondearPanel(r4, 40);

        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            Main nuevaVentana = new Main();
            nuevaVentana.Show();

            // Ocultar login
            this.Hide();
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

        private void r1_MouseEnter(object sender, EventArgs e)
        {
            r1.BackColor = Color.White; // el color que quieras

        }

        private void r2_MouseEnter(object sender, EventArgs e)
        {
            r2.BackColor = Color.White; // el color que quieras

        }

        private void r3_MouseEnter(object sender, EventArgs e)
        {
            r3.BackColor = Color.White; // el color que quieras

        }

        private void r4_MouseEnter(object sender, EventArgs e)
        {
            r4.BackColor = Color.White; // el color que quieras

        }

        private void r1_MouseLeave(object sender, EventArgs e)
        {
            r1.BackColor = colorPanelr1;

        }

        private void r2_MouseLeave(object sender, EventArgs e)
        {
            r2.BackColor = colorPanelr2;

        }

        private void r3_MouseLeave(object sender, EventArgs e)
        {
            r3.BackColor = colorPanelr3;

        }

        private void r4_MouseLeave(object sender, EventArgs e)
        {
            r4.BackColor = colorPanelr4;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
