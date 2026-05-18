using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace view
{
    public partial class pMembresias : Form
    {
        public pMembresias()
        {
            InitializeComponent();

            tablaMiembros.Rows.Add("1", "Juan", "Pérez", "Basica", 0);
            tablaMiembros.Rows.Add("2", "María", "López", "Premiun", 30);
            tablaMiembros.Rows.Add("3", "Pedro", "Paramo", "VIP", 60);

            monthCalendar1.MaxDate = DateTime.Today;
            RedondearBoton(btnFecha, 25);
            RedondearBoton(btnRenovarM, 25);
            RedondearBoton(btnBuscar, 25);
            RedondearBoton(btnModificar, 25);
            RedondearBoton(btnEliminar, 25);
            RedondearBoton(btnGuardar, 25);

            RedondearBoton(btnActivo, 99);



        }



        private void bminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            Main nuevaVentana = new Main();
            nuevaVentana.Show();

            // Ocultar 
            this.Hide();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void tablaMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscado = txtBuscador.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow fila in tablaMiembros.Rows)
            {
                if (fila.Cells[0].Value != null) // evitar errores
                {
                    string id = fila.Cells[0].Value.ToString();
                    string nombre = fila.Cells[1].Value.ToString().ToLower();
                    string membresia = fila.Cells[3].Value.ToString();
                    int dias = Convert.ToInt32(fila.Cells[4].Value);

                    // Buscar por ID o Nombre
                    if (id == valorBuscado || nombre == valorBuscado)
                    {
                        // Mostrar datos
                        txtId.Text = id;
                        txtMembresia.Text = membresia;
                        txtDias.Text = dias.ToString();

                        // Mostrar botones y checkbox
                        btnEliminar.Visible = true;
                        btnModificar.Visible = true;
                        btnRenovarM.Visible = true;
                        cAsistencia.Visible = true;

                        cAsistencia.Checked = false;


                        // Lógica del botón Activo
                        if (dias <= 0)
                        {
                            btnActivo.BackColor = Color.Red;
                        }
                        else if (dias >= 1 && dias <= 30)
                        {
                            btnActivo.BackColor = Color.Green;
                        }
                        else if (dias >= 31)
                        {
                            btnActivo.BackColor = Color.Blue;
                        }

                        encontrado = true;
                        break;
                    }
                }
            }

            // Si no encuentra nada
            if (!encontrado)
            {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnRenovarM.Visible = false;
                cAsistencia.Visible = false;


                txtId.Text = "";
                txtMembresia.Text = "";
                txtDias.Text = "";

                btnActivo.BackColor = Color.Gray;

            }
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

        private void cAsistencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btregresar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRenovarM_Click(object sender, EventArgs e)
        {
            pAMembresias ventana = new pAMembresias();
            ventana.ShowDialog();
            txtMembresia.Text = ventana.MembresiaSeleccionada;
            btnPagar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Labels
            lbNombre.Visible = true;
            lbApellido.Visible = true;
            lbSexo.Visible = true;
            lbFecha.Visible = true;
            Telefono.Visible = true;
            lbCorreo.Visible = true;

            // TextBox
            nombrebx.Visible = true;
            apellidobx.Visible = true;
            txtFecha.Visible = true;
            telefonotxt.Visible = true;
            txtCorreo.Visible = true;

            // Botón
            btnFecha.Visible = true;
            btnGuardar.Visible = true;
            btnModificar.Visible = false;

            // RadioButton
            hombre.Visible = true;
            mujer.Visible = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void LimpiarCampos()
        {
            nombrebx.Text = "";
            apellidobx.Text = "";
            txtFecha.Text = "";
            textBox1.Text = ""; // teléfono
            txtCorreo.Text = "";
            txtMembresia.Text = "";

            hombre.Checked = false;
            mujer.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Labels
            lbNombre.Visible = false;
            lbApellido.Visible = false;
            lbSexo.Visible = false;
            lbFecha.Visible = false;
            Telefono.Visible = false;
            lbCorreo.Visible = false;

            // TextBox
            nombrebx.Visible = false;
            apellidobx.Visible = false;
            txtFecha.Visible = false;
            telefonotxt.Visible = false;
            txtCorreo.Visible = false;

            // Botón
            btnFecha.Visible = false;
            btnGuardar.Visible = false;
            btnModificar.Visible = true;
            btnPagar.Visible = false;


            // RadioButton
            hombre.Visible = false;
            mujer.Visible = false;



            LimpiarCampos();




        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            pPago ventana = new pPago(txtMembresia.Text);
            ventana.ShowDialog();

            if (ventana.confirmacion == true)
            {
                btnGuardar.Visible = true;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
