using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Test
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source= venus\\dev2012;database = Training ; Integrated Security= SSPI");
            con.Open();
            SqlCommand scom = new SqlCommand("INSERT INTO exam(name, college, roll) values(@name,@college,@roll)", con);



            scom.Parameters.AddWithValue("@name", TextBox1.Text);
            scom.Parameters.AddWithValue("@college", TextBox2.Text);
            scom.Parameters.AddWithValue("@roll", TextBox3.Text);


            try
            {
                scom.ExecuteNonQuery();
            }
            catch (Exception)
            {


            }
            Session["name"] = TextBox1.Text;
            Session["college"] = TextBox2.Text;
            Session["roll"] = TextBox3.Text;
            Response.Redirect("exam.aspx");




            con.Close();

        }
    }
}