using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data.Sql;

namespace Week_5___Login
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        String connStr = WebConfigurationManager.ConnectionStrings["ArtSchool"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signupButton_Click(object sender, EventArgs e)
        {
            // event
            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "insert into Register values (@username, @password, @email)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", signupUsername.Text);
            cmd.Parameters.AddWithValue("@password", signupPassword.Text);
            cmd.Parameters.AddWithValue("@email", signupEmail.Text);

            try
            {
                if(signupUsername.Text != "" && signupPassword.Text != "" && signupEmail.Text != "")
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        labelResult.Text = "Your account has been succesfully created, Login and start your journey!!!";
                    }
                    conn.Close();
                } else
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