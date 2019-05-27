using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Exam
{
    public partial class update : System.Web.UI.Page
    {
        public SqlCommand cmd;
        public SqlConnection conn;
        public SqlDataReader dr;
        public string connString = WebConfigurationManager.ConnectionStrings["Exam"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] != null)
            {
                conn = new SqlConnection(connString);
                string query = "SELECT * FROM [User] WHERE username=@username AND password=@password";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", Session["username"]);
                cmd.Parameters.AddWithValue("@password", Session["password"]);
                conn.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    updateUsername.Text = dr["username"].ToString();
                    updatePassword.Text = dr["password"].ToString();
                    updateEmail.Text = dr["email"].ToString();
                }

                conn.Close();
            } else
            {
                Response.Redirect("login.aspx");
            }
            
        }

        protected void save_Click(object sender, EventArgs e)
        {
            if(updateUsername.Text == "" || updatePassword.Text == "" || updateEmail.Text == "")
            {
                labelResult.Text = "No fields can be empty";
            }

            else
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string query = "UPDATE [User] SET username=@newUsername, password=@newPassword, email=@newEmail WHERE username=@username AND password=@password";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newUsername", updateUsername.Text);
                cmd.Parameters.AddWithValue("@newPassword", updatePassword.Text);
                cmd.Parameters.AddWithValue("@newEmail", updateEmail.Text);
                cmd.Parameters.AddWithValue("@username", Session["username"]);
                cmd.Parameters.AddWithValue("@password", Session["password"]);

                Session["username"] = updateUsername.Text;
                Session["password"] = updatePassword.Text;


                if (cmd.ExecuteNonQuery() == 1)
                {
                    labelResult.Text = "Your Details Were updated";
                }
                conn.Close();

            }
        }
    }
}