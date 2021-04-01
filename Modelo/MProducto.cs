using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascota.Modelo
{
    class MProducto
    {
        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public string DescripcionCorta { get; set; }

        public int Inventario { get; set; }

        public float Precio { get; set; }

        public float Costo { get; set; }

        public int UnidadesVendidas { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DataTable MostrarProductos()
        {
            var dtRes = new DataTable("Productos");
            var sqlCon = new SqlConnection(Conexion.Cn);
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandText = "MostrarProductos",
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

        public DataTable BuscarProducto(string dato)
        {
            var dtRes = new DataTable($"Productos");
            var sqlCon = new SqlConnection(Conexion.Cn);
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = sqlCon,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "BuscarProducto"
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

        public int NuevoProducto()
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
                    CommandText = "NuevoProducto"
                };

                sqlCmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 50).Value = NombreProducto;
                sqlCmd.Parameters.Add("@DescripcionCorta", SqlDbType.VarChar, 50).Value = DescripcionCorta;
                sqlCmd.Parameters.Add("@Inventario", SqlDbType.Int).Value = Inventario;
                sqlCmd.Parameters.Add("@Precio", SqlDbType.Float).Value = Precio;
                sqlCmd.Parameters.Add("@Costo", SqlDbType.Float).Value = Costo;
                sqlCmd.Parameters.Add("@UnidadesVendidas", SqlDbType.Int).Value = UnidadesVendidas;
                sqlCmd.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = FechaIngreso;
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

        public int ModificarProducto()
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
                    CommandText = "ModificarProducto"
                };

                sqlCmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = IdProducto;
                sqlCmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar, 50).Value = NombreProducto;
                sqlCmd.Parameters.Add("@DescripcionCorta", SqlDbType.VarChar, 50).Value = DescripcionCorta;
                sqlCmd.Parameters.Add("@Inventario", SqlDbType.Int).Value = Inventario;
                sqlCmd.Parameters.Add("@Precio", SqlDbType.Float).Value = Precio;
                sqlCmd.Parameters.Add("@Costo", SqlDbType.Float).Value = Costo;
                sqlCmd.Parameters.Add("@UnidadesVendidas", SqlDbType.Int).Value = UnidadesVendidas;
                sqlCmd.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = FechaIngreso;
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

        public int HabilitarProducto(int id)
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
                    CommandText = "HabilitarProducto"
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

        public int DeshabilitarProducto(int id)
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
                    CommandText = "DeshabilitarProducto"
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
