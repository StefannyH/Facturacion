using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facturacion_Electronica.CapaDatos
{
    public  class Conexion
    {
        //private Conexion con = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader dataReader;

        private SqlConnection Con = new
            SqlConnection("Data Source=DESKTOP-4PMJGRE;Initial Catalog=Facturacion;Integrated Security=True");

        /// <summary>
        /// Abrir la conexión hacia la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            return Con;
        }

        /// <summary>
        /// Cerrar la conexión hacia la base de datos
        /// </summary>
        /// <returns></returns>
        public SqlConnection CloseConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            return Con;
        }
        public void llenarTipoDocumetoCliente(ComboBox cb)
        {
            try
            {
                comando = new SqlCommand("select TipoDocumento from Tbl_Clientes", Con);
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    cb.Items.Add(dataReader["TipoDocumento"].ToString());
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se lleno el combobox" + ex.Message);
            }
        }

    }
}
