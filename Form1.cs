using Facturacion_Electronica.CapaNegocio;
namespace Facturacion_Electronica
{
    public partial class Form1 : Form
    {
        BLLInicioSesion objetoCN = new BLLInicioSesion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Boolean login =  objetoCN.Inicio(txtUsuario.Text, txtContrasena.Text);

            if (login)
            {
                this.Hide();
                Principal frm = new Principal();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos :(");
            }
        
        }
    }
}