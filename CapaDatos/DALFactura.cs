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
        SqlDataReader dataReader;
        DataTable table = new DataTable();

        public DataTable DatosVendedor()
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "DatosVendedor";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);            
            con.CloseConnection();
            return table;
        }

        public DataTable DatosCliente(string Documento)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "DatosClienteBuscar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", Documento);
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);
            con.CloseConnection();
            return table;
        }

        public DataTable DatosConsultarProductosView(string Referencia)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "ConsultarProductosDataGridView";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Referencia", Referencia);            
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);
            con.CloseConnection();
            return table;
        }

        public void CrearFactura(int CantidadProductos,int ValorTotal, string IdProducto, string IdCliente, string CodigoFactura)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "GuardarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CantidadProducto", CantidadProductos);
            comando.Parameters.AddWithValue("@ValorTotal", ValorTotal);            
            comando.Parameters.AddWithValue("@IdProducto", IdProducto);
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@CodigoFactura", CodigoFactura);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public DataTable Datosagregarlista(string Referencia,string Codigo)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "Consultarlistaproductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Referencia", Referencia);
            comando.Parameters.AddWithValue("@CodigoFactura", Codigo);
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);
            con.CloseConnection();
            return table;
        }


    }
}
