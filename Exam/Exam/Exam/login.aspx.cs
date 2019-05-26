using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;


namespace Exam
{
    public partial class login : System.Web.UI.Page
    {
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlConnection conn;
        string connString = WebConfigurationManager.ConnectionStrings["Exam"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string message = Request.QueryString["msg"];

                if(message == "confirmed_logout")
                {
                    labelResult.Text = "You have logout successfully";
                }

                if(message == "confirmed_delete")
                {
                    labelResult.Text = "You have deleted your account successfully";
                }
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            // Try this or catch the error

            conn = new SqlConnection(connString);
            string query = "SELECT username, password FROM [User] WHERE username=@username AND password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", loginUsername.Text);
            cmd.Parameters.AddWithValue("@password", loginPassword.Text);

            //string output = Convert.ToString(cmd.ExecuteScalar());
            conn.Open();
            dr = cmd.ExecuteReader();

            // if reader has no results then show this 
            if (!(dr.Read()))
            {

                labelResult.Text = "Incorrect Username or Password";
                
            }
                    
            else
            {
                Session["username"] = loginUsername.Text;
                Session["password"] = loginPassword.Text;

                Response.Redirect("welcome.aspx");
            }
            conn.Close();
        }
    }
}