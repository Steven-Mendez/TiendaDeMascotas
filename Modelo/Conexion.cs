using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascota.Modelo
{
    class Conexion
    {
        private static readonly string dataSource = @"localhost";
        private static readonly string initialCatalog = @"TiendaMascotas";
        private static readonly string user = @"ProductoMascotas";
        private static readonly string password = @"123";
        public static readonly string Cn = $"Data Source = {dataSource}; Initial Catalog = {initialCatalog}; user = {user}; password = {password}";
    }
}
