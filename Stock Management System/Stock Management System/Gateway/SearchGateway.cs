using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApp.Model;
using System.Configuration;

namespace StockManagementSystemApp.Gateway
{
    class SearchGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["StockMangementDbConString"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        string query;
        public SearchGateway()
        {
            connection = new SqlConnection(connectionString);
        }

        public List<ViewItemSummary> GetSearchAllItems(string company, string category)
        {

            connection.ConnectionString = connectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ViewItemSummary WHERE CompanyName = @CompanyName AND CategoryName = @CategoryName ";
            cmd.Connection = connection;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("CompanyName", company);
            cmd.Parameters.AddWithValue("CategoryName", category);
            connection.Open();
            reader = cmd.ExecuteReader();


            List<ViewItemSummary> seachItems = new List<ViewItemSummary>();
            while (reader.Read())
            {
                ViewItemSummary viewItemSummary = new ViewItemSummary();
                viewItemSummary.ItemName = reader["ItemName"].ToString();
                viewItemSummary.CompanyName = reader["CompanyName"].ToString();
                viewItemSummary.CategoryName = reader["CategoryName"].ToString();
                viewItemSummary.AvailableQuantity = Convert.ToInt32(reader["AvailableQuantity"]);
                viewItemSummary.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);

                seachItems.Add(viewItemSummary);
            }
            reader.Close();
            connection.Close();
            return seachItems;
        }
    }
}
