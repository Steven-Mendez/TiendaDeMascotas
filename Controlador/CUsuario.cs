using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascota.Modelo;

namespace Tienda_Mascota.Controlador
{
    class CUsuario
    {
        public static DataTable ValidarAcceso(string usuario, string contraseña)
        {
            return new MUsuario().ValidarAcceso(usuario, contraseña);
        }

        public static DataTable MostarUsuarios()
        {
            return new MUsuario().MostrarUsuarios();
        }

        public static DataTable BuscarUsuarios(string dato)
        {
            return new MUsuario().BuscarUsuario(dato);
        }

        public static int NuevoUsuario(string usuario, string contraseña, string rol)
        {
            var obj = new MUsuario()
            {
                nombre = usuario,
                contraseña = contraseña,
                rol = rol
            };
            return obj.NuevoUsuario();
        }

        public static int ModificarUsuario(int idUsuario, string contraseña, string rol)
        {
            var obj = new MUsuario()
            {
                idUsuario = idUsuario,
                contraseña = contraseña,
                rol = rol
            };
            return obj.ModificarUsuario();
        }

        public static int HabilitarUsuario(int id)
        {
            return new MUsuario().HabilitarUsuario(id);
        }

        public static int DeshabilitarUsuario(int id)
        {
            return new MUsuario().DeshabilitarUsuario(id);
        }
    }
}
