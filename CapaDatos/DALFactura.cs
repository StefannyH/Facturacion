using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion_Electronica.CapaDatos
{
    public class DALFactura
    {
        private Conexion con = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader? dataReader;
        DataTable table = new DataTable();

        public void ConsultarVendedor()
        {
            //comando.Connection = con.OpenConnection();
            //comando.CommandText = ("select * from Tbl_Vendedor where Documento = '10245785'");
            //SqlDataReader dataReader = comando.ExecuteReader();
            //comando.CommandText = "DatosVendedor";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@Documento", Documento);
            //comando.Parameters.AddWithValue("@NombreComercial", NombreComercial);
            //comando.Parameters.AddWithValue("@Direccion", Direccion);
            //comando.Parameters.AddWithValue("@Telefono", Telefono);
            //comando.Parameters.AddWithValue("@Correo", Correo);

            //comando.ExecuteNonQuery();
            //comando.Parameters.Clear();
        }
    }
}
