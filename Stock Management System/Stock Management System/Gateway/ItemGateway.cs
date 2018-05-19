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
    class ItemGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["StockMangementDbConString"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        string query;

        public ItemGateway()
        {
            connection = new SqlConnection(connectionString);
        }

        public List<ItemWithCompany> GetAllItems(string company)
        {

            connection.ConnectionString = connectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ItemWithCompany WHERE CompanyName = @CompanyName";
            cmd.Connection = connection;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("CompanyName", company);
            connection.Open();
            reader = cmd.ExecuteReader();


            List<ItemWithCompany> items = new List<ItemWithCompany>();
            while (reader.Read())
            {
                ItemWithCompany itemWithCompany = new ItemWithCompany();
                itemWithCompany.Id = Convert.ToInt32(reader["Id"]);
                itemWithCompany.CompanyId = (int)reader["CompanyId"];
                itemWithCompany.CompanyName = reader["CompanyName"].ToString();
                itemWithCompany.ItemName = reader["ItemName"].ToString();
                itemWithCompany.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);

                items.Add(itemWithCompany);
            }
            reader.Close();
            connection.Close();
            return items;
        }


        public int SaveItem(ItemAdd aItem)
        {
            connection.Open();
            query = "INSERT INTO Items (CategoryId,CompanyId,ItemName,ReorderLevel) VALUES (@CategoryId ,@CompanyId ,@ItemName,@ReorderLevel)";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("CategoryId", aItem.CategoryId);
            cmd.Parameters.AddWithValue("CompanyId", aItem.CompanyId);
            cmd.Parameters.AddWithValue("ItemName", aItem.ItemName);
            cmd.Parameters.AddWithValue("ReorderLevel", aItem.ReorderLevel);
            //cmd.Parameters.AddWithValue("CreatedBy", aItem.CreatedBy);
            //cmd.Parameters.AddWithValue(DateTime.Parse("CreationDate", aItem.CreatedBy));
            //cmd.Parameters.Add
            int rowAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool IsItemNameExist(string itemName)
        {
            connection.ConnectionString = connectionString;
            query = "SELECT * FROM Items WHERE ItemName = @ItemName";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("ItemName", itemName);
            connection.Open();
            reader = cmd.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }
    }
}
