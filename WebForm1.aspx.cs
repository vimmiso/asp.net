using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace twitt2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
                con.Open();
                string insert = "insert into userdet(username,email,phonenumber) values(@username,@email,@phonenumber)";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("username", TextBox1.Text);
                cmd.Parameters.AddWithValue("email", TextBox2.Text);
                cmd.Parameters.AddWithValue("phonenumber", TextBox3.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("tweet.aspx");
                con.Close();
            }catch(Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}