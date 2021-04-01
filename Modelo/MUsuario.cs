using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascota.Modelo
{
    public class MUsuario
    {
        public int idUsuario { get; set; }

        public string nombre { get; set; }

        public string contraseña { get; set; }

        public string rol { get; set; }

        public string estado { get; set; }

        public DataTable ValidarAcceso(string usuario, string contraseña)
        {
            var dtRes = new DataTable("Inicio Sesión");
            try
            {
                // Crear Comando
                var sqlCmd = new SqlCommand()
                {
                    // Establecer Conexion
                    Connection = new SqlConnection(Conexion.Cn),

                    // Especificar tipo y nombre del comando
                    CommandText = "Validar_Acceso",
                    CommandType = CommandType.StoredProcedure
                };

                // Añadir Parametros
                sqlCmd.Parameters.Add(new SqlParameter()
                {
                    // Establcer tipo, nombre, tamaño y valor
                    SqlDbType = SqlDbType.NVarChar,
                    ParameterName = "@usuario",
                    Size = 50,
                    Value = usuario
                });
                sqlCmd.Parameters.Add(new SqlParameter()
                {
                    SqlDbType = SqlDbType.NVarChar,
                    ParameterName = "@contraseña",
                    Size = 50,
                    Value = contraseña
                });

                // Ejecutar comando
                var sqlAdap = new SqlDataAdapter(sqlCmd);
                sqlAdap.Fill(dtRes);
            }
            catch (Exception)
            {
                return null;
            }
            return dtRes;
        }

        public DataTable MostrarUsuarios()
        {
            var dtRes = new DataTable("Usuarios");
            var sqlCon = new SqlConnection(Conexion.Cn);
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandText = "MostrarUsuarios",
                    CommandType = CommandType.StoredProcedure,
                };
                new SqlDataAdapter(sqlCmd).Fill(dtRes);
            }
            catch (Exception)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public DataTable BuscarUsuario(string dato)
        {
            var dtRes = new DataTable("Usuarios");
            var sqlCon = new SqlConnection(Conexion.Cn);
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandText = "BuscarUsuario",
                    CommandType = CommandType.StoredProcedure,
                };
                sqlCmd.Parameters.Add(new SqlParameter("@dato", SqlDbType.NVarChar, 100)).Value = dato;
                new SqlDataAdapter(sqlCmd).Fill(dtRes);
            }
            catch (Exception)
            {
                dtRes = null;
            }
            return dtRes;
        }

        public int HabilitarUsuario(int id)
        {
            int res;
            var sqlCon = new SqlConnection(Conexion.Cn);
            sqlCon.Open();
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "HabilitarUsuario"
                };

                sqlCmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                res = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                res = 0;
            }
            finally
            {
                sqlCon.Close();
            }
            return res;
        }

        public int DeshabilitarUsuario(int id)
        {
            int res;
            var sqlCon = new SqlConnection(Conexion.Cn);
            sqlCon.Open();
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "DeshabilitarUsuario"
                };

                sqlCmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                res = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                res = 0;
            }
            finally
            {
                sqlCon.Close();
            }
            return res;
        }

        public int NuevoUsuario()
        {
            int res;
            var sqlCon = new SqlConnection(Conexion.Cn);
            sqlCon.Open();
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "Insertar_Usuario"
                };

                sqlCmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = nombre;
                sqlCmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 50).Value = contraseña;
                sqlCmd.Parameters.Add("@rol", SqlDbType.VarChar, 50).Value = rol;
                res = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                res = 0;
            }
            finally
            {
                sqlCon.Close();
            }
            return res;
        }

        public int ModificarUsuario()
        {
            int res;
            var sqlCon = new SqlConnection(Conexion.Cn);
            sqlCon.Open();
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "ModificarUsuario"
                };

                sqlCmd.Parameters.Add("@Id", SqlDbType.Int).Value = idUsuario;
                sqlCmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 50).Value = contraseña;
                sqlCmd.Parameters.Add("@rol", SqlDbType.VarChar, 50).Value = rol;
                res = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                res = 0;
            }
            finally
            {
                sqlCon.Close();
            }
            return res;
        }
    }
}
