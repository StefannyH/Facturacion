using Facturacion_Electronica.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Electronica.CapaNegocio
{
    public class BLLFactura
    {
        private DALFactura objetoCD = new DALFactura();
        public void ConsultarDatosVendedor()
        {
            objetoCD.ConsultarVendedor();
            
        }
    }
}
