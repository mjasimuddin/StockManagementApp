using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Model;
using System.Configuration;
using System.Data;

namespace StockManagementSystemApp.Gateway
{
    class SalesGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["StockMangementDbConString"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        string query;
        public SalesGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public List<ViewSalesReport> GetSalesAllItems(DateTime fromDate, DateTime toDate)
        {

            connection.ConnectionString = connectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ViewSalesReport ";
            cmd.Connection = connection;
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate;
            cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate;
            //cmd.Parameters.AddWithValue("Item", Item);
            //cmd.Parameters.AddWithValue("Quantity", Quantity);
            connection.Open();
            reader = cmd.ExecuteReader();


            List<ViewSalesReport> salesItems = new List<ViewSalesReport>();
            while (reader.Read())
            {
                var viewSalesReport = new ViewSalesReport();
                viewSalesReport.ItemName = reader["ItemName"].ToString();
                viewSalesReport.Quantity = Convert.ToInt32(reader["Quantity"]);
                salesItems.Add(viewSalesReport);
            }
            reader.Close();
            connection.Close();
            return salesItems;
        }
    }
}
