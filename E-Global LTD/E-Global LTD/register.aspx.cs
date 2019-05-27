using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace E_Global_LTD
{
    public partial class register : System.Web.UI.Page
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        String connStr = WebConfigurationManager.ConnectionStrings["LabTest"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signupButton_Click(object sender, EventArgs e)
        {
            // event
            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "INSERT INTO [User] (Username, Password, Email, FirstName, LastName ) values (@username, @password, @email, @firstname, @lastname)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", signupUsername.Text);
            cmd.Parameters.AddWithValue("@password", signupPassword.Text);
            cmd.Parameters.AddWithValue("@email", signupEmail.Text);
            cmd.Parameters.AddWithValue("@firstname", signupFirstName.Text);
            cmd.Parameters.AddWithValue("@lastname", signupLastName.Text);

            try
            {
                if (signupUsername.Text != "" && signupPassword.Text != "" && signupEmail.Text != "" && signupFirstName.Text != "" && signupLastName.Text != "")
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        labelResult.Text = "Your account has been succesfully created, Login and start your journey!!!";
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
    }
}