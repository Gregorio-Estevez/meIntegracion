using System.Data.SqlClient;

namespace Integracion
{
    public class Connect
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-DCLHDO4\\MSSQLSERVER02;Initial Catalog=Integrador;Integrated Security=True"); // no e colocado el conetion
        SqlCommand cdInsert_caja = new SqlCommand();

        public void InsertCajaTrans(string nombre, string tipodocumento, string documento, double pago) 
        {
            cn.Open();

            cdInsert_caja.Connection = cn;

            cdInsert_caja.CommandText = "pp_insert_Caja";

            cdInsert_caja.Parameters.AddWithValue("@nombre", nombre);
            cdInsert_caja.Parameters.AddWithValue("@tipodocumento", tipodocumento );
            cdInsert_caja.Parameters.AddWithValue("@documento", documento);
            cdInsert_caja.Parameters.AddWithValue("@total", pago);

            cdInsert_caja.CommandType = System.Data.CommandType.StoredProcedure;
            cdInsert_caja.ExecuteNonQuery();

            cdInsert_caja.Parameters.Clear();

            cn.Close();
        }


    }
}
