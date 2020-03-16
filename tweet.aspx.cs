using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace twitt2
{
    public partial class tweet : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            show();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string insert = "insert into Tweettable(name,tweet_content,time) values(@name,@tweet_content,@time)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@tweet_content", TextBox2.Text);
            cmd.Parameters.AddWithValue("@time", DateTime.Now);
            cmd.ExecuteNonQuery();
            Response.Redirect(Request.Url.AbsoluteUri);

        }

        protected void show()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            cmd.CommandText = "select * from Tweettable order by time desc";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Tweettable");
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
    }
}