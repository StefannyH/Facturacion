using Facturacion_Electronica.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion_Electronica.CapaNegocio
{
    public class BLLProductos
    {
        private DALProductos objetoCD = new DALProductos();

        public void Create(int referencia, string descripcion, float valorunitario, int Cantidad)
        {
            objetoCD.CrearProducto(referencia, descripcion, valorunitario, Cantidad);
        }

        public DataTable View()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ReadAllProducts();
            return tabla;
        }

        public void Delete(int referencia)
        {
            objetoCD.DeleteProducto(referencia);
        }
        public void Update(int referencia, string descripcion, float valorunitario)
        {
            objetoCD.UpdateProducto(referencia, descripcion, valorunitario);
        }
    }
}
