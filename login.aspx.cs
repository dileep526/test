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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
           
          
            SqlConnection con = new SqlConnection("data source= venus\\dev2012;database = Training ; Integrated Security= SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from loginn where username='" + txtusername.Text + "' and pwd ='" + txtpassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("To write Exam please Register");
            }
        }

        protected void btnsubmit_Clickk(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source= venus\\dev2012;database = Training ; Integrated Security= SSPI");
            con.Open();
            SqlCommand scom = new SqlCommand("INSERT INTO loginn(username,pwd) values(@kname,@ksurname)", con);
            //  SqlCommand cmd = new SqlCommand("select * from login", con);

                Response.Write("Now Please Register With your Credentials and Write Exam");
          

            scom.Parameters.AddWithValue("@kname", txtusername.Text);
            scom.Parameters.AddWithValue("@ksurname", txtpassword.Text);


            scom.ExecuteNonQuery();


            con.Close();


        }

        protected void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Admin_Click(object sender, EventArgs e)
        {

        }

     
        protected void admin_Click2(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }


    }
}