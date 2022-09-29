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
    public partial class RegistroProductos : Form
    {
        BLLProductos objetoCN = new BLLProductos();

        public RegistroProductos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal frm = new Principal();
            frm.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objetoCN.Create(int.Parse(txtReferencia.Text), txtDescripcion.Text, float.Parse(txtValorUnitario.Text));
            MessageBox.Show("Se guardo correctamente el producto :)");
            viewAllProducts();
            Limpiar();
        }

        private void viewAllProducts()
        {
            BLLProductos Objeto = new BLLProductos();
            DgvRegistroProductos.DataSource = Objeto.View();
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {
            viewAllProducts();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objetoCN.Delete(int.Parse(txtReferencia.Text));
            MessageBox.Show("Se elimino correctamente el producto :)");
            viewAllProducts();
            Limpiar();
        }

        public void Limpiar()
        {
            txtReferencia.Clear();
            txtDescripcion.Clear();
            txtValorUnitario.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objetoCN.Update(int.Parse(txtReferencia.Text), txtDescripcion.Text, float.Parse(txtValorUnitario.Text));
            MessageBox.Show("Se actualizo correctamente el producto :)");
            viewAllProducts();
            Limpiar();
        }
    }
}
