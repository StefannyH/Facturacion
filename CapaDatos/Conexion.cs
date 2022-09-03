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
        private SqlConnection Con = new
            SqlConnection("Data Source=DESKTOP-4PMJGRE;Integrated Security=True");

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
    }
}
