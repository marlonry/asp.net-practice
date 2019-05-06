using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Week2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DatabaseServer;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Inser into Table(username, email,phone,message) values(@name, @email, @message, @phone )", conn);
            cmd.Parameters.AddWithValue("@email", txtName.Text);
            cmd.Parameters.AddWithValue("@email", txtMessage.Text);
            cmd.Parameters.AddWithValue("@email", txtPhone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);

            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    lblStatus.Text = "Your message is succesfully added! thank you";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.ToString();
            }
        }
    }
}