using Facturacion_Electronica.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Electronica
{
    public partial class RegistroClientes : Form
    {
        BLLClientes objetoCN = new BLLClientes();

        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal frm = new Principal();
            frm.Show();
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            viewAllClientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objetoCN.Create(cbxRipoDocumento.Text, int.Parse(txtDocumento.Text), txtNombreComercial.Text, txtDireccion.Text, txtTelefono.Text,txtCorreo.Text);
            MessageBox.Show("Se guardo correctamente el cliente :)");
            viewAllClientes();
            Limpiar();
        }
        private void viewAllClientes()
        {
            BLLClientes Objeto = new BLLClientes();
            DgvRegistroClientes.DataSource = Objeto.View();
        }
        public void Limpiar()
        {
            txtDocumento.Clear();
            txtNombreComercial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objetoCN.Update(cbxRipoDocumento.Text, int.Parse(txtDocumento.Text), txtNombreComercial.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
            MessageBox.Show("Se actualizo correctamente el cliente :)");
            viewAllClientes();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objetoCN.Delete(int.Parse(txtDocumento.Text));
            MessageBox.Show("Se elimino correctamente el cliente :)");
            viewAllClientes();
            Limpiar();
        }
    }
}
