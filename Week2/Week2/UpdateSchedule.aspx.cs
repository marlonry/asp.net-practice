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
    public partial class WebForm6 : System.Web.UI.Page
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        string connStr = WebConfigurationManager.ConnectionStrings["ArtSchoolDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                String id = Request.QueryString["id"];
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand("select * from timetable where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                reader = cmd.ExecuteReader();

                reader.Read();
                txtday.Text = reader["day"].ToString();
                txttime.Text = reader["time"].ToString();
                txttopic.Text = reader["topic"].ToString();
                txttutor.Text = reader["tutor"].ToString();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            string id = Request.QueryString["id"];
            cmd = new SqlCommand("update timetable set day=@day, time=@time, topic=@topic, tutor=@tutor where id=@id", conn);
            cmd.Parameters.AddWithValue("@day", txtday.Text);
            cmd.Parameters.AddWithValue("@time", txttime.Text);
            cmd.Parameters.AddWithValue("@topic", txttopic.Text);
            cmd.Parameters.AddWithValue("@tutor", txttutor.Text);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();

            if(cmd.ExecuteNonQuery()==1)
            {
                Response.Redirect("schedule.aspx");
            }
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            string id = Request.QueryString["id"];
            cmd = new SqlCommand("delete from timetable where id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                Response.Redirect("schedule.aspx");
            }
            conn.Close();
        }
    }
}