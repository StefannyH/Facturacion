using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Facturacion_Electronica.CapaDatos
{
    public class DALInicioSesion
    {
        private Conexion con = new Conexion();
        SqlCommand comando = new SqlCommand();
        
        public Boolean IniciarSesion(string usuario, string contrasena)
        {    
            comando.Connection = con.OpenConnection();
            comando.CommandText = "sp_inicio_sesion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contrasena", contrasena);
            DataTable Dt = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(Dt);

            int i = comando.ExecuteNonQuery();
            con.CloseConnection();

            Boolean login = false;
            if (Dt.Rows.Count > 0)
            {               
                login = true;                
            }
            return login;
        }
    }
}


