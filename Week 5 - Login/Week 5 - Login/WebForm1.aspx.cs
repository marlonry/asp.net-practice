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
    public partial class WebForm1 : System.Web.UI.Page
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        String connStr = WebConfigurationManager.ConnectionStrings["ArtSchool"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string message = Request.QueryString["msg"];
                //labelResult.Text = message;

                string message = Request.QueryString["msg"];

                if (message == "confirmed")
                {
                    labelResult.Text = "Your account was deleted";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // event
            conn = new SqlConnection(connStr);
            conn.Open();
            //string query = "select * from register where username='" + txtUser + "' and username = '" + txtPass + "'";
            string query = "select * from Register where username=@user and password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);

            string output = Convert.ToString(cmd.ExecuteScalar());
            //SqlDataReader output = cmd.ExecuteReader();
            if (output == "")
            {
                //Response.Write("Login Fail");
                labelResult.Text = "Incorrect username or password";
            }
            else
            {
                Session["user"] = txtUser.Text;
                Session["pass"] = txtPass.Text;
                Response.Redirect("WebForm2.aspx");
            }
            conn.Close();
        }
    }
}