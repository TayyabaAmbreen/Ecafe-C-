using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\Dell\Documents\Lab04.accdb";
            conn.Open();

            string fname = TextBox1.Text;
            string lname = TextBox2.Text;
            string ph = TextBox3.Text;
            string addr = TextBox4.Text;

            String sql = "insert into Users ([FirstName], [LastName],[Address],[PhoneNo],[Type]) values ('" + fname + "','" + lname + "','" + addr + "','" + Convert.ToInt64(ph) + "','User')";
            System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand(sql, conn);

            var dr1 = cmd1.ExecuteNonQuery();

            MessageBox.Show("Data Entered Successfully");
            Response.Redirect("MainPage.aspx");
        }
    }
}