using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion_Electronica.CapaDatos
{
    public class DALProductos
    {
        private Conexion con = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader dataReader;
        DataTable table = new DataTable();

        public void CrearProducto(int referencia, string descripcion, float valorunitario, int Cantidad)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_insertar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Referencia", referencia);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@ValorUnitario", valorunitario);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable ReadAllProducts()
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_consultar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);

            con.CloseConnection();
            return table;
        }

        public void DeleteProducto(int referencia)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_eliminar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Referencia", referencia);            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void UpdateProducto(int referencia, string descripcion, float valorunitario)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_modificar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Referencia", referencia);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@ValorUnitario", valorunitario);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
