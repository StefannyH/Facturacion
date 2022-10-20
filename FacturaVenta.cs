using Facturacion_Electronica.CapaDatos;
using Facturacion_Electronica.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion_Electronica
{
    public partial class FacturaVenta : Form
    {
        private Conexion con = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader dataReader;
        DataTable table = new DataTable();
        private BLLFactura NG = new BLLFactura();            
       
        string Codigo = "";

        public FacturaVenta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal frm = new Principal();
            frm.Show();
        }

        private void FacturaVenta_Load(object sender, EventArgs e)
        {           
            DatosVendedor();
        }

        public void  DatosVendedor()
        {           
            BLLFactura Factura = new BLLFactura();            
            DataTable agua = new DataTable();
            agua = Factura.Datos();
            for (int i = 0; i < agua.Rows.Count; i++)
            {
                txtTipoDocumento.Text = agua.Rows[i]["TipoDocumento"].ToString();
                txtDocumento.Text = agua.Rows[i]["Documento"].ToString();
                txtNombreComercial.Text = agua.Rows[i]["NombreComercial"].ToString();
                txtDireccion.Text = agua.Rows[i]["Direccion"].ToString();
                txtTelefono.Text = agua.Rows[i]["Telefono"].ToString();
                txtCorreo.Text = agua.Rows[i]["Correo"].ToString();
            }
        }

        private void txtDocumentoCliente_TextChanged(object sender, EventArgs e)
        {
            BLLFactura Factura = new BLLFactura();
            //Factura.Datos();
            DataTable agua = new DataTable();
            agua = Factura.DatosBuscarcliente(txtDocumentoCliente.Text);
            for (int i = 0; i < agua.Rows.Count; i++)
            {
                txtTipoDocumentoCliente.Text = agua.Rows[i]["TipoDocumento"].ToString();
                txtDocumentoCliente.Text = agua.Rows[i]["Documento"].ToString();
                txtNombrecliente.Text = agua.Rows[i]["NombreComercial"].ToString();
                txtDireccionCliente.Text = agua.Rows[i]["Direccion"].ToString();
                txtTelefonoCliente.Text = agua.Rows[i]["Telefono"].ToString();
                txtCorreoCliente.Text = agua.Rows[i]["Correo"].ToString();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            BLLFactura Factura = new BLLFactura();
            //Factura.Datos();
            DataTable ListaProductos = new DataTable();
            ListaProductos = Factura.DatosConsultarPro(txtReferencia.Text);
            for (int i = 0; i < ListaProductos.Rows.Count; i++)
            {
                txtReferencia.Text = ListaProductos.Rows[i]["Referencia"].ToString();
                txtDescripcion.Text = ListaProductos.Rows[i]["Descripcion"].ToString();
                txtValorUnitario.Text = ListaProductos.Rows[i]["ValorUnitario"].ToString();                
            }
        }

        public void Calculo()
        {
            int Cantidad = 0;
            float Valor = 0;
            float resultado = 0;
            if (txtCan.Text != "")
            {                
                Cantidad = int.Parse(txtCan.Text);
            }
            
            
            Valor = float.Parse(txtValorUnitario.Text);
            resultado = Cantidad * Valor;
            txtValorTotal.Text = Convert.ToString(resultado);

        }
        private void AgregarDataGridWiew()
        {
            dgvListaProductos.DataSource = NG.AgregarData(txtReferencia.Text, Codigo);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string Doc = txtDocumentoCliente.Text;
            string Fecha = DateTime.UtcNow.ToString();
            Codigo = Doc + Fecha;
            NG.CrearFactura(int.Parse(txtCan.Text), int.Parse(txtValorTotal.Text),txtReferencia.Text,txtDocumentoCliente.Text, Codigo);
            MessageBox.Show("Se inserto producto :)");            
            AgregarDataGridWiew();
            //Limpiar();
        }

        public void Limpiar()
        {
            txtReferencia.Clear();
            txtDescripcion.Clear();
            txtCan.Clear();
            txtValorUnitario.Clear();
            txtValorTotal.Clear();
        }

        private void txtCan_TextChanged(object sender, EventArgs e)
        {
            Calculo();           
        }
    }
}
