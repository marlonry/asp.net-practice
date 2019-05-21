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

    

    public partial class WebForm4 : System.Web.UI.Page
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        string connStr = WebConfigurationManager.ConnectionStrings["ArtSchoolDB"].ConnectionString;



        protected void Page_Load(object sender, EventArgs e)
        {

            conn = new SqlConnection(connStr);
            conn.Open();
            cmd = new SqlCommand("select * from timetable order by day", conn);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataList1.DataSource = dt;
            DataList1.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            String key = (sender as LinkButton).CommandArgument;
            Response.Redirect("UpdateSchedule.aspx?id=" + key);
        }
    }
}