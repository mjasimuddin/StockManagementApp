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
    class CategoryGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["StockMangementDbConString"].ConnectionString;
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        string query;

        public CategoryGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public int SaveProduct(CategoryAdd aProduct)
        {

            connection.Open();
            query = "INSERT INTO Category (CategoryName) VALUES (@CategoryName)";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("CategoryName", SqlDbType.NVarChar);
            cmd.Parameters["CategoryName"].Value = aProduct.Category;
            int rowAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool IsNameExist(string name)
        {
            connection.ConnectionString = connectionString;
            query = "SELECT * FROM Category WHERE CategoryName = @CategoryName";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("CategoryName", SqlDbType.NVarChar);
            cmd.Parameters["CategoryName"].Value = name;
            connection.Open();
            reader = cmd.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }

        public List<CategoryAdd> GetAllCategory()
        {
            connection.ConnectionString = connectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Category";
            cmd.Connection = connection;
            connection.Open();
            reader = cmd.ExecuteReader();


            List<CategoryAdd> categoy = new List<CategoryAdd>();
            while (reader.Read())
            {
                CategoryAdd category = new CategoryAdd();
                category.Id = (int)reader["Id"];
                category.Category = reader["CategoryName"].ToString();

                categoy.Add(category);
            }
            reader.Close();
            connection.Close();
            return categoy;
        }

        public int UpdateCategory(CategoryAdd aCategory)
        {
            query = "UPDATE Category SET CategoryName = @CategoryName WHERE Id = @Id";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("CategoryName", SqlDbType.NVarChar);
            cmd.Parameters["CategoryName"].Value = aCategory.Category;
            cmd.Parameters.Add("Id", SqlDbType.Int);
            cmd.Parameters["Id"].Value = aCategory.Id;
            connection.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }
    }
}
