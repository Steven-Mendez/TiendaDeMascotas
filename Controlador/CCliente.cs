using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascota.Modelo;

namespace Tienda_Mascota.Controlador
{
    class CCliente
    {
        public static DataTable MostrarCliente()
        {
            return new MCliente().MostrarCliente();
        }

        public static DataTable BuscarCliente(string dato)
        {
            return new MCliente().BuscarCliente(dato);
        }

        public static int NuevoCliente(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string correo, int celular)
        {
            var obj = new MCliente()
            {
                PrimerNombre = primerNombre,
                SegundoNombre = segundoNombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Correo = correo,
                Celular = celular
            };
            return obj.NuevoCliente();
        }

        public static int ModificarCliente(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string correo, int celular)
        {
            var obj = new MCliente()
            {
                IdCliente = id,
                PrimerNombre = primerNombre,
                SegundoNombre = segundoNombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Correo = correo,
                Celular = celular
            };
            return obj.ModificarCliente();
        }

        public static int HabilitarCliente(int id)
        {
            return new MCliente().HabilitarCliente(id);
        }

        public static int DeshabilitarCliente(int id)
        {
            return new MCliente().DeshabilitarCliente(id);
        }
    }
}
