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
    public partial class welcomeAdmin : System.Web.UI.Page
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        String connStr = WebConfigurationManager.ConnectionStrings["LabTest"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminUser"] != null)
            {
                labelWelcome.Text = "Welcome " + Session["adminUser"].ToString() + " you are logged in as an Administrator";
                SqlDataReader sqlDataReader = GetData("SELECT * FROM Products");
            }
            else
            {
                Response.Redirect("admin.aspx");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("admin.aspx");
        }

        protected void add_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "INSERT INTO [Products] (ProductName, Stock, Price, Description, Unit) values (@productName, @stock, @price, @description, @unit)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@productName", productName.Text);
            cmd.Parameters.AddWithValue("@stock", productStock.Text);
            cmd.Parameters.AddWithValue("@price", productPrice.Text);
            cmd.Parameters.AddWithValue("@description", productDescription.Text);
            cmd.Parameters.AddWithValue("@unit", productUnit.Text);

            try
            {
                if (productName.Text != "" && productStock.Text != "" && productPrice.Text != "" && productDescription.Text != "" && productUnit.Text != "")
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        labelResult.Text = "The Product has been successfully added!";
                        SqlDataReader sqlDataReader = GetData("SELECT * FROM Products");
                    }
                    conn.Close();
                }
                else
                {
                    labelResult.Text = "All fields are mandatory";
                }
            }

            catch (Exception err)
            {
                labelResult.Text = err.ToString();
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
    }
}