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
    class CompanyGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["StockMangementDbConString"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        string query;
        public int SaveCompany(CompanyAdd aCompany)
        {

            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "INSERT INTO Company (CompanyName) VALUES (@CompanyName)";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("CompanyName", SqlDbType.NVarChar);
            cmd.Parameters["CompanyName"].Value = aCompany.CompanyName;
            //cmd.Parameters.AddWithValue("CompanyName", aCompany.CompanyName);
            int rowAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool IsNameExist(string name)
        {
            connection.ConnectionString = connectionString;
            query = "SELECT * FROM Company WHERE CompanyName = @CompanyName";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("CompanyName", SqlDbType.NVarChar);
            cmd.Parameters["CompanyName"].Value = name;
            connection.Open();
            reader = cmd.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }

        public List<CompanyAdd> GetAllCompanies()
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Company";
            cmd.Connection = connection;
            connection.Open();
            reader = cmd.ExecuteReader();


            List<CompanyAdd> companies = new List<CompanyAdd>();
            while (reader.Read())
            {
                CompanyAdd company = new CompanyAdd();

                company.Id = (int)reader["Id"];
                company.CompanyName = reader["CompanyName"].ToString();

                companies.Add(company);
            }
            reader.Close();
            connection.Close();
            return companies;
        }
        public int UpdateCompany(CompanyAdd aCompany)
        {
            query = "UPDATE Company SET CompanyName = @CompanyName WHERE Id = @Id";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("CompanyName", SqlDbType.NVarChar);
            cmd.Parameters["CompanyName"].Value = aCompany.CompanyName;
            cmd.Parameters.Add("Id", SqlDbType.Int);
            cmd.Parameters["Id"].Value = aCompany.Id;
            connection.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }
    }
}
