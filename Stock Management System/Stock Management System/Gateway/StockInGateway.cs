using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Model;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace StockManagementSystemApp.Gateway
{
    class StockInGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["StockMangementDbConString"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        string query;

        public StockInGateway()
        {
            connection = new SqlConnection(connectionString);
        }

        public int SaveStockIn(StockIn aStockIn)
        {
            connection.Open();
            query = "INSERT INTO StockIn (ItemId,StokInQuantity) VALUES (@ItemId ,@StokInQuantity)";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("ItemId", aStockIn.ItemId);
            cmd.Parameters.AddWithValue("StokInQuantity", aStockIn.StokInQuantity);
            int rowAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public DataTable SearchReorderLevel(string itemName)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            DataTable dt = new DataTable();
            string sql = "Select * from Items where ItemName= @ItemName ";
            SqlCommand cmd = new SqlCommand(sql,connection);
            SqlDataAdapter dataAdapter;
            cmd.Parameters.AddWithValue("@ItemName", itemName);
            try
            {
                dataAdapter = new SqlDataAdapter(cmd);
                connection.Open();
                dataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable SearchAvailableQuantity(int ItemId)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            DataTable dt = new DataTable();
            string sql = "(SELECT(SELECT ISNULL(SUM(StokInQuantity),0) from StockIn where ItemId=@ItemId)-(Select ISNULL(SUM(Quantity),0) from StockOut where ItemId=@ItemId) as result)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter;
            cmd.Parameters.AddWithValue("@ItemId", ItemId);
            try
            {
                dataAdapter = new SqlDataAdapter(cmd);
                connection.Open();
                dataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
