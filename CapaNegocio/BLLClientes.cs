using Facturacion_Electronica.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Facturacion_Electronica.CapaNegocio
{
    public  class BLLClientes
    {
        private DALClientes objetoCD = new DALClientes();

        public void Create(string TipoDocumento, int Documento, string NombreComercial, string Direccion, string Telefono, string Correo)
        {
            objetoCD.CrearCliente(TipoDocumento, Documento, NombreComercial, Direccion, Telefono, Correo);
        }

        public DataTable View()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ReadAllClientes();
            return tabla;
        }

        public void Delete(int Documento)
        {
            objetoCD.DeleteClientes(Documento);
        }
        public void Update(string TipoDocumento, int Documento, string NombreComercial, string Direccion, string Telefono, string Correo)
        {
            objetoCD.UpdateClientes(TipoDocumento, Documento, NombreComercial, Direccion, Telefono, Correo);
        }
    }
}
