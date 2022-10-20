using Facturacion_Electronica.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Electronica.CapaNegocio
{
    public class BLLFactura
    {
        private DALFactura objetoCD = new DALFactura();
        
        public DataTable Datos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.DatosVendedor();
            return tabla;
        }
        public DataTable DatosBuscarcliente(string Documento)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.DatosCliente(Documento);
            return tabla;
        }

        public DataTable DatosConsultarPro(string Referencia )
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.DatosConsultarProductosView(Referencia);
            return tabla;
        }

        public void CrearFactura(int CantidadProductos, int ValorTotal, string IdProducto, string IdCliente, string CodigoFactura)
        {
            objetoCD.CrearFactura(CantidadProductos, ValorTotal,  IdProducto, IdCliente, CodigoFactura);
        }

        public DataTable AgregarData(string Referencia, string Codigo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Datosagregarlista(Referencia, Codigo);
            return tabla;
        }
    }
}
