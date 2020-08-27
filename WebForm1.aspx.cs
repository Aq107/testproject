using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            //conn.Open();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();

            if (TXTName.Text == "" || TXTPassword.Text == "")
            {
                return;
            }

            string query = "insert into [test].[dbo].[testtable] (name,password) values ('" + TXTName.Text + "','" + TXTPassword.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();

            string delete = "delete from [test].[dbo].[testtable] where name = '"+TXTName.Text+"';";
            SqlCommand cmddelete = new SqlCommand(delete, conn);
            cmddelete.ExecuteNonQuery();
        }

        protected void BtnGV_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();

            SqlDataAdapter sqlda = new SqlDataAdapter("select * from [test].[dbo].[testtable]", conn);
            DataTable dt1 = new DataTable();
            sqlda.Fill(dt1);

            gvdetails.DataSource = dt1;
            gvdetails.DataBind();
        }
    }
}