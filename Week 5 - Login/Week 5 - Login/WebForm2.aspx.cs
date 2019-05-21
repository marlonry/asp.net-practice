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
    public partial class WebForm2 : System.Web.UI.Page
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        String connStr = WebConfigurationManager.ConnectionStrings["ArtSchool"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                txtUser.Text = "Welcome " + Session["user"].ToString();
            }
            else
            {
                Response.Redirect("WebForm1.aspx");
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("WebForm1.aspx");

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "delete from Register where username=@username AND password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Session["user"]);
            cmd.Parameters.AddWithValue("@password", Session["pass"]);


            if (cmd.ExecuteNonQuery() == 1)
            {
                //string Key = "Your account was deleted";
                Response.Redirect("WebForm1.aspx?msg=confirmed");
            }
            conn.Close();
        }

        protected void seeMore_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "select * from Register where username=@username and password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Session["user"]);
            cmd.Parameters.AddWithValue("@password", Session["pass"]);

            reader = cmd.ExecuteReader();
            
            if(reader.Read())
            {
                updateUsername.Text = reader["username"].ToString();
                updatePassword.Text = reader["password"].ToString();
                updateEmail.Text = reader["email"].ToString();
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
            if(updateUsername.Text == "" || updatePassword.Text == "" || updateEmail.Text == "")
            {
                labelResult.Text = "No fields can be empty";
            } else
            {
                // event
                conn = new SqlConnection(connStr);
                conn.Open();
                string query = "update Register set username=@newUsername, password=@newPassword, email=@newEmail where username=@user and password=@pass";
                cmd = new SqlCommand(query, conn);
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
    }
}