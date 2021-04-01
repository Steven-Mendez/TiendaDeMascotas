using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascota.Modelo;

namespace Tienda_Mascota.Controlador
{
    class CProducto
    {
        public static DataTable MostrarProductos()
        {
            return new MProducto().MostrarProductos();
        }

        public static DataTable BuscarProducto(string dato)
        {
            return new MProducto().BuscarProducto(dato);
        }

        public static int NuevoProducto(string nombreProducto, string descripcionCorta, int inventario, float precio, float costo, int unidadesVendidas, DateTime fechaIngreso)
        {
            var obj = new MProducto()
            {
                NombreProducto = nombreProducto,
                DescripcionCorta = descripcionCorta,
                Inventario = inventario,
                Precio = precio,
                Costo = costo,
                UnidadesVendidas = unidadesVendidas,
                FechaIngreso = fechaIngreso
            };
            return obj.NuevoProducto();
        }

        public static int ModificarProducto(int id, string nombreProducto, string descripcionCorta, int inventario, float precio, float costo, int unidadesVendidas, DateTime fechaIngreso)
        {
            var obj = new MProducto()
            {
                IdProducto = id,
                NombreProducto = nombreProducto,
                DescripcionCorta = descripcionCorta,
                Inventario = inventario,
                Precio = precio,
                Costo = costo,
                UnidadesVendidas = unidadesVendidas,
                FechaIngreso = fechaIngreso
            };
            return obj.ModificarProducto();
        }

        public static int HabilitarProducto(int id)
        {
            return new MProducto().HabilitarProducto(id);
        }

        public static int DeshabilitarProducto(int id)
        {
            return new MProducto().DeshabilitarProducto(id);
        }
    }
}
