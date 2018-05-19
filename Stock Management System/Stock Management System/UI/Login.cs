using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StockManagementSystemApp.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userNameTextBox.Text = "";
            passwordTextBox.Clear();
            userNameTextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // To do check username and password
            string connectionString = @"Data Source=DESKTOP-TE5S7KC\SQLEXPRESS;Initial Catalog=StockManagementSystemApp;     
                                                            Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * 
            FROM [dbo].[Login] where UserName='" + userNameTextBox.Text + "' and Password='" + passwordTextBox.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password...! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1_Click(sender, e);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
