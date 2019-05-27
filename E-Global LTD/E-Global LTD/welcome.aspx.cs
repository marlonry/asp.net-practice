using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace E_Global_LTD
{
    public partial class welcome : System.Web.UI.Page
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        
        String connStr = WebConfigurationManager.ConnectionStrings["LabTest"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                labelWelcome.Text = "Welcome " + Session["user"].ToString();
            }
            else
            {
                Response.Redirect("login.aspx");
            }

            SqlDataReader sqlDataReader = GetData("SELECT * FROM Products");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            

            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "delete from [User] where username=@username AND password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Session["user"]);
            cmd.Parameters.AddWithValue("@password", Session["pass"]);


            if (cmd.ExecuteNonQuery() == 1)
            {
                Response.Redirect("login.aspx?msg=confirmed");
            }
            conn.Close();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("login.aspx");
        }

        protected void seeMore_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT * FROM [User] WHERE username=@username and password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Session["user"]);
            cmd.Parameters.AddWithValue("@password", Session["pass"]);

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                updateFirstName.Text = reader["FirstName"].ToString();
                updateLastName.Text = reader["LastName"].ToString();
                updateUsername.Text = reader["Username"].ToString();
                updatePassword.Text = reader["Password"].ToString();
                updateEmail.Text = reader["Email"].ToString();
            }

            conn.Close();

            if (!panel.Visible)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        protected void updateData_Click(object sender, EventArgs e)
        {
            if (updateUsername.Text == "" || updatePassword.Text == "" || updateEmail.Text == "")
            {
                labelResult.Text = "No fields can be empty";
            }
            else
            {
                // event
                conn = new SqlConnection(connStr);
                conn.Open();
                string query = "UPDATE [User] SET FirstName=@newFirstName, LastName=@newLastName, Username=@newUsername, Password=@newPassword, Email=@newEmail where username=@user and password=@pass";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newFirstName", updateFirstName.Text);
                cmd.Parameters.AddWithValue("@newLastName", updateLastName.Text);
                cmd.Parameters.AddWithValue("@newUsername", updateUsername.Text);
                cmd.Parameters.AddWithValue("@newPassword", updatePassword.Text);
                cmd.Parameters.AddWithValue("@newEmail", updateEmail.Text);
                cmd.Parameters.AddWithValue("@user", Session["user"]);
                cmd.Parameters.AddWithValue("@pass", Session["pass"]);

                Session["user"] = updateUsername.Text;
                Session["pass"] = updatePassword.Text;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    labelResult.Text = "Your details were updated";
                }
                conn.Close();
            }
        }

        public SqlDataReader GetData(string queryString)
        {

            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand command = new SqlCommand(queryString, conn);
            SqlDataReader reader = command.ExecuteReader();
            SqlDataReader sqlDataReader = reader;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Stock");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Unit");

            while (sqlDataReader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Product Name"] = sqlDataReader["ProductName"];
                row["Stock"] = sqlDataReader["Stock"];
                row["Price"] = sqlDataReader["Price"];
                row["Description"] = sqlDataReader["Description"];
                row["Unit"] = sqlDataReader["Unit"];
                dataTable.Rows.Add(row);
            }
            productsList.DataSource = dataTable;
            productsList.DataBind();
            conn.Close();
            return reader;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {   
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Products Where ProductName=@productName", conn);
                cmd.Parameters.AddWithValue("@productName", productSearch.Text);
                reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Product Name");
                dataTable.Columns.Add("Stock");
                dataTable.Columns.Add("Price");
                dataTable.Columns.Add("Description");
                dataTable.Columns.Add("Unit");

                while (reader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Product Name"] = reader["ProductName"];
                    row["Stock"] = reader["Stock"];
                    row["Price"] = reader["Price"];
                    row["Description"] = reader["Description"];
                    row["Unit"] = reader["Unit"];
                    dataTable.Rows.Add(row);
                }
                productsList.DataSource = dataTable;
                productsList.DataBind();
                conn.Close();
            }
            catch (Exception err)
            {
                resultSearch.Text = "Item not found";
            }
        }
    }
}