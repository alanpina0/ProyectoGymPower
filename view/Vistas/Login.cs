using view;
///namespace Form1

///using GIMNASIO.Modelos;
namespace view


{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            usuariotxt.Text = "";
            contrasenatxt.Text = "";

            this.AcceptButton = bEntrar;


            usuariotxt.Focus();


        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btminimizar_Click(object sender, EventArgs e)
        {

        }

        private void btc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuariotxt.Text) ||
                 string.IsNullOrWhiteSpace(contrasenatxt.Text))
            {
                MessageBox.Show("Por favor llena todos los campos");
                return;
            }

            Main nuevaVentana = new Main();
            nuevaVentana.Show();

            // Ocultar login
            this.Hide();

        }

        private void usuario_Click_1(object sender, EventArgs e)
        {
            usuariotxt.Text = "";
        }



        
        private void contrasena_Click_1(object sender, EventArgs e)
        {
            contrasenatxt.Text = "";

        }

      



    }
}
