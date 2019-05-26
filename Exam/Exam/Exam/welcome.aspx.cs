using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Exam
{
    public partial class welcome : System.Web.UI.Page
    {
        public SqlCommand cmd;
        public SqlConnection conn;
        public string connString = WebConfigurationManager.ConnectionStrings["Exam"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"] != null)
            {
                labelResult.Text = "Welcome " + Session["username"].ToString();
            } else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("username");
            Response.Redirect("login.aspx?msg=confirmed_logout");
        }

        protected void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            string query = "DELETE [User] where username=@username AND password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", Session["username"]);
            cmd.Parameters.AddWithValue("@password", Session["password"]);

            conn.Open();

            if(cmd.ExecuteNonQuery() == 1)
            {
                Response.Redirect("login.aspx?msg=confirmed_delete");
            }

            conn.Close();
        }
    }
}