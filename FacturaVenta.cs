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
            comando.Connection = con.OpenConnection();
            comando.CommandText = ("select * from Tbl_Vendedor where Documento = '10245785'");
            SqlDataReader dataReader = comando.ExecuteReader();

            txtTipoDocumento.Text = dataReader["TipoDocumento"].ToString();
            txtDocumento.Text = dataReader["Documento"].ToString();
            txtNombreComercial.Text = dataReader["NombreComercial"].ToString();
            txtDireccion.Text = dataReader["Direccion"].ToString();
            txtTelefono.Text = dataReader["Telefono"].ToString();
            txtCorreo.Text = dataReader["Correo"].ToString();

        }
      
    }
}
