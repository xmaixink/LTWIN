using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagerment
{
    internal class Db_connect
    {
        internal SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAIVUNG\\SQLEXPRESS;database=myHotel;integrated security=True;TrustServerCertificate=True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query,String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show(" '" + message + " '", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
