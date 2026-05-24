using GIMNASIO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using view;

namespace GIMNASIO.Vistas
{
    public partial class pconexion : Form
    {
        public pconexion()
        {
            InitializeComponent();
        }

        private void bconectar_Click(object sender, EventArgs e)
        {

            conexion con = new conexion();

            try
            {
                con.Conectarse();
                MessageBox.Show("Conexión exitosa");
                con.Desconectarse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            Login vn = new Login();
            vn.Show();

            // Ocultar login
            this.Hide();
        }
    }
}
