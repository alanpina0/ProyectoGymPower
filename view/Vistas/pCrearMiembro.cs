using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using GIMNASIO.DAO;
using GIMNASIO.Modelos;


namespace view
{
    public partial class pCrearMiembro : Form
    {
        public pCrearMiembro()
        {
            InitializeComponent();
            txtMembresia.Text = "Básica";


            monthCalendar1.MaxDate = DateTime.Today;
            RedondearBoton(btnFecha, 35);
            RedondearBoton(btnmembresia, 30);
            RedondearBoton(btnCrear, 15);



        }

        private void btcerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            Main nuevaVentana = new Main();
            nuevaVentana.Show();
            // Ocultar 
            this.Hide();

        }

        private void bminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lbApellido_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFecha.Text = e.Start.ToShortDateString();
            monthCalendar1.Visible = false; // se oculta después de elegi
        }

        private void RedondearBoton(Button btn, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);

            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        private void btnmembresia_Click(object sender, EventArgs e)
        {
            pAMembresias ventana = new pAMembresias();
            ventana.ShowDialog();
            txtMembresia.Text = ventana.MembresiaSeleccionada;
            btnPagar.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nombrebx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void apellidobx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                           !char.IsControl(e.KeyChar) &&
                           !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Solo permitir números y teclas de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limitar a 10 números
            if (txt.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No permitir espacios
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Limitar a 30 caracteres
            if (txtCorreo.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.com$"))
            {
                MessageBox.Show("El correo debe contener @ y terminar en .com");
                txtCorreo.Focus();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            pPago ventana = new pPago(txtMembresia.Text);
            ventana.ShowDialog();

            if (ventana.confirmacion == true)
            {
                btnCrear.Visible = true;

            }
        }

        private void LimpiarCampos()
        {
            nombrebx.Text = "";
            apellidopbx.Text = "";
            apellidombx.Text = "";
            txtFecha.Text = "";
            telefonobx.Text = ""; // teléfono
            txtCorreo.Text = "";
            txtMembresia.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombrebx.Text) ||
        string.IsNullOrWhiteSpace(apellidopbx.Text) ||
        string.IsNullOrWhiteSpace(txtFecha.Text) ||
        string.IsNullOrWhiteSpace(telefonobx.Text) ||
        string.IsNullOrWhiteSpace(txtCorreo.Text) ||
        string.IsNullOrWhiteSpace(txtMembresia.Text) ||
        (!radioButton2.Checked && !radioButton1.Checked))
            {
                MessageBox.Show("Por favor, completa todos los campos");
                return;
            }

            Cliente cliente = new Cliente();

            cliente.Nombre = nombrebx.Text;
            cliente.ApellidoPaterno = apellidopbx.Text;
            cliente.ApellidoMaterno = apellidombx.Text;

            cliente.Fechanacimiento = Convert.ToDateTime(txtFecha.Text);

            cliente.Telefono = telefonobx.Text;

            cliente.CorreoE = txtCorreo.Text;

            cliente.sexo = radioButton1.Checked ? "Masculino" : "Femenino";

            clienteDAO dao = new clienteDAO();

            dao.Insertar(cliente);

            MessageBox.Show("Cliente insertado");

            LimpiarCampos();

            btnCrear.Visible = false;
            btnPagar.Visible = false;

        }

        private void txtMembresia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
