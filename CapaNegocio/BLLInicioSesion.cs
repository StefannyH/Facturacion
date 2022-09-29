using Facturacion_Electronica.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Electronica.CapaNegocio
{
    public class BLLInicioSesion
    {
        private DALInicioSesion objetoCD = new DALInicioSesion();
        Boolean login = false;
        public Boolean Inicio(string usuario, string contrasena)
        {            
            login = objetoCD.IniciarSesion(usuario, contrasena);

            return login;
        }
    }
}
