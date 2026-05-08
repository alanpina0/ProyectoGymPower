using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view
{
    public partial class pPago : Form
    {
        public bool confirmacion;

        public pPago(string membresia)
        {
            InitializeComponent();
            txtMembresia.Text = membresia;

            if (membresia == "Basica")
            {
                txtMonMem.Text = "19.99";
            }
            else if (membresia == "Premium")
            {
                txtMonMem.Text = "199.99";
            }
            else if (membresia == "VIP")
            {
                txtMonMem.Text = "499.99";
            }

            confirmacion = false;

        }

        private void txtMonMem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            confirmacion = false;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
            confirmacion = true;

        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, control y punto decimal
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Evitar más de un punto
            if (e.KeyChar == '.' && txtPago.Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            double pago, costo;

            if (double.TryParse(txtPago.Text, out pago) &&
                double.TryParse(txtMonMem.Text, out costo))
            {
                double cambio = pago - costo;

                if (cambio < 0)
                {
                    double falta = Math.Abs(cambio);
                    txtCambio.Text = "Faltan $" + falta.ToString("0.00");
                    btnConfirmar.Visible = false;
                }
                else
                {
                    txtCambio.Text = cambio.ToString("0.00");
                    btnConfirmar.Visible = true;
                }
            }
            else
            {
                txtCambio.Text = "";
                btnConfirmar.Visible = false;
            }
        }


    }
    }

