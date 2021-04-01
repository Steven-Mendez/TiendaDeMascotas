using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascota.Modelo
{
    class MCliente
    {
        public int IdCliente { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public string Correo { get; set; }

        public int Celular { get; set; }

        public string estado { get; set; }

        public DataTable MostrarCliente()
        {
            var dtRes = new DataTable("Clientes");
            var sqlCon = new SqlConnection(Conexion.Cn);
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandText = "MostrarClientes",
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

        public DataTable BuscarCliente(string dato)
        {
            var dtRes = new DataTable($"Clientes");
            var sqlCon = new SqlConnection(Conexion.Cn);
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "BuscarCliente"
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

        public int NuevoCliente()
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
                    CommandText = "NuevoCliente"
                };

                sqlCmd.Parameters.Add("@PrimerNombre", SqlDbType.VarChar, 50).Value = PrimerNombre;
                sqlCmd.Parameters.Add("@SegundoNombre", SqlDbType.VarChar, 50).Value = SegundoNombre;
                sqlCmd.Parameters.Add("@PrimerApellido", SqlDbType.VarChar, 50).Value = PrimerApellido;
                sqlCmd.Parameters.Add("@SegundoApellido", SqlDbType.NChar, 10).Value = SegundoApellido;
                sqlCmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = Correo;
                sqlCmd.Parameters.Add("@Celular", SqlDbType.Int).Value = Celular;
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

        public int ModificarCliente()
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
                    CommandText = "ModificarCliente"
                };

                sqlCmd.Parameters.Add("@id", SqlDbType.Int).Value = IdCliente;
                sqlCmd.Parameters.Add("@PrimerNombre", SqlDbType.VarChar, 50).Value = PrimerNombre;
                sqlCmd.Parameters.Add("@SegundoNombre", SqlDbType.VarChar, 50).Value = SegundoNombre;
                sqlCmd.Parameters.Add("@PrimerApellido", SqlDbType.VarChar, 50).Value = PrimerApellido;
                sqlCmd.Parameters.Add("@SegundoApellido", SqlDbType.NChar, 10).Value = SegundoApellido;
                sqlCmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = Correo;
                sqlCmd.Parameters.Add("@Celular", SqlDbType.Int).Value = Celular;
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

        public int HabilitarCliente(int id)
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
                    CommandText = "HabilitarCliente"
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

        public int DeshabilitarCliente(int id)
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
                    CommandText = "DeshabilitarCliente"
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
    }
}
