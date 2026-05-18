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

    public partial class pAMembresias : Form
    {

        private string membresiaSeleccionada;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string MembresiaSeleccionada { get; set; }




        Color colorPanelopc1;
        Color colorPanelopc2;
        Color colorPanelopc3;
        public pAMembresias()
        {
            InitializeComponent();

            RedondearPanel(opc1, 30);
            RedondearPanel(opc2, 30);
            RedondearPanel(opc3, 30);


            colorPanelopc1 = opc1.BackColor;
            colorPanelopc2 = opc2.BackColor;
            colorPanelopc3 = opc3.BackColor;


        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void opc1_Click(object sender, EventArgs e)
        {
            MembresiaSeleccionada = "Basica";
            this.Close();
        }

        private void opc2_Click(object sender, EventArgs e)
        {
            MembresiaSeleccionada = "Premium";
            this.Close();

        }

        private void opc3_Click(object sender, EventArgs e)
        {
            MembresiaSeleccionada = "VIP";
            this.Close();

        }

        private void opc2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void opc2_Paint(object sender, PaintEventArgs e)
        {

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

        private void opc1_MouseEnter(object sender, EventArgs e)
        {
            opc1.BackColor = Color.DarkGray; // el color que quieras

        }

        private void opc2_MouseEnter(object sender, EventArgs e)
        {
            opc2.BackColor = Color.DarkGray; // el color que quieras

        }

        private void opc3_MouseEnter(object sender, EventArgs e)
        {
            opc3.BackColor = Color.DarkGray; // el color que quieras

        }

        private void opc1_MouseLeave(object sender, EventArgs e)
        {
            opc1.BackColor = colorPanelopc1;

        }

        private void opc2_MouseLeave(object sender, EventArgs e)
        {
            opc2.BackColor = colorPanelopc2;

        }

        private void opc3_MouseLeave(object sender, EventArgs e)
        {
            opc3.BackColor = colorPanelopc3;

        }

        private void opc1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void opc3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
