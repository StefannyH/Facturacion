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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroClientes frm = new RegistroClientes();
            frm.Show();
        }

        private void btnFacturaVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacturaVenta frm = new FacturaVenta();
            frm.Show();
        }

        private void btnRegistroProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroProductos frm = new RegistroProductos();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
