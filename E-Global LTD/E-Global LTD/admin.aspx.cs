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
    public partial class admin : System.Web.UI.Page
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        String connStr = WebConfigurationManager.ConnectionStrings["LabTest"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginAdminButton_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            string query = "SELECT * FROM [Admin] WHERE username=@username and password=@password";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", loginAdminUsername.Text);
            cmd.Parameters.AddWithValue("@password", loginAdminPassword.Text);

            string output = Convert.ToString(cmd.ExecuteScalar());
            if (output == "")
            {
                labelResult.Text = "Incorrect username or password";
            }
            else
            {
                Session["adminUser"] = loginAdminUsername.Text;
                Session["adminPass"] = loginAdminPassword.Text;
                Response.Redirect("welcomeAdmin.aspx");
            }
            conn.Close();
        }
    }
}