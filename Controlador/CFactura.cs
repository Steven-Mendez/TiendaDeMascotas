using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascota.Modelo;

namespace Tienda_Mascota.Controlador
{
    class CFactura
    {
        public static DataTable InsertarFactura(int idCliente, string nombreVendedor)
        {
            var obj = new MFactura()
            {
                IdCliente = idCliente,
                NombreVendedor = nombreVendedor
            };
            return obj.InsertarFactura();
        }

        public static int InsertarDetalleFactura(int idFactura, int idProducto, double precio, int cantidad)
        {
            var obj = new MFactura()
            {
                IdFactura = idFactura,
                IdProducto = idProducto,
                Precio = precio,
                Cantidad = cantidad
            };
            return obj.InsertarDetalleFactura();
        }
    }
}
