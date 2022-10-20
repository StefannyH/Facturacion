using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion_Electronica.CapaDatos
{
    public class DALClientes
    {
        private Conexion con = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader dataReader;
        DataTable table = new DataTable();

        public void CrearCliente(string TipoDocumento, int Documento, string NombreComercial, string Direccion, string Telefono, string Correo)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_insertar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoDocumento", TipoDocumento);
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.Parameters.AddWithValue("@NombreComercial", NombreComercial);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Correo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable ReadAllClientes()
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_consultar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);

            con.CloseConnection();
            return table;
        }

        public void DeleteClientes(int Documento)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_eliminar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void UpdateClientes(string TipoDocumento, int Documento, string NombreComercial, string Direccion, string Telefono, string Correo)
        {
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_modificar_clientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@TipoDocumento", TipoDocumento);
            comando.Parameters.AddWithValue("@Documento", Documento);
            comando.Parameters.AddWithValue("@NombreComercial", NombreComercial);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Correo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void llenarTipoDocumetoCliente(ComboBox cb)
        {
            try
            {
                comando = new SqlCommand("select TipoDocumento from Tbl_Clientes");
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    cb.Items.Add(dataReader["TipoDocumento"].ToString());
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se lleno el combobox" + ex.ToString());
            }
        }

    }
}
