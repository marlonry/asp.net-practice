using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Week3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlCommand cmd;
        string connString = WebConfigurationManager.ConnectionStrings["Week-3"].ConnectionString;
        private SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            cmd = new SqlCommand(@"INSERT INTO Users(username, email, password) VALUES(@username, @email, @password)", conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblResult.Text = "Successfully Registered";
                }
                conn.Close();
            } catch (Exception err)
            {
                lblResult.Text = err.ToString();
            }
        }
    }
}