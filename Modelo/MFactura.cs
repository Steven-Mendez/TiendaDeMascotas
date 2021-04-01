using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascota.Modelo
{
    class MFactura
    {
        public int IdFactura { get; set; }

        public int IdCliente { get; set; }

        public int IdProducto { get; set; }

        public double Precio { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fecha { get; set; }

        public string NombreVendedor { get; set; }

        public DataTable InsertarFactura()
        {
            var dtRes = new DataTable("Factura");
            try
            {
                var sqlCmd = new SqlCommand()
                {
                    Connection = new SqlConnection(Conexion.Cn),
                    CommandText = "InsertarFactura",
                    CommandType = CommandType.StoredProcedure
                };

                sqlCmd.Parameters.Add(new SqlParameter()
                {
                    SqlDbType = SqlDbType.Int,
                    ParameterName = "@IDCliente",
                    Value = IdCliente
                });

                sqlCmd.Parameters.Add(new SqlParameter()
                {
                    SqlDbType = SqlDbType.VarChar,
                    ParameterName = "@Vendedor",
                    Size = 100,
                    Value = NombreVendedor
                });

                var sqlAdap = new SqlDataAdapter(sqlCmd);
                sqlAdap.Fill(dtRes);
            }
            catch (Exception)
            {
                return null;
            }
            return dtRes;
        }

        public int InsertarDetalleFactura()
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
                    CommandText = "InsertarDetalleFactura"
                };

                sqlCmd.Parameters.Add("@IDFactura", SqlDbType.Int).Value = IdFactura;
                sqlCmd.Parameters.Add("@IDProducto", SqlDbType.Int).Value = IdProducto;
                sqlCmd.Parameters.Add("@Precio", SqlDbType.Float).Value = Precio;
                sqlCmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Cantidad;

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
