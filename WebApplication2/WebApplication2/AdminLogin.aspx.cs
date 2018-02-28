using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\Dell\Documents\Lab04.accdb";
            conn.Open();

            String my_querry1 = "Select* From Users where Username = '" + username + "'and Passwrd = '" + password + "'";
            System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand(my_querry1, conn);

            var dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                MessageBox.Show("hi");
                Server.Transfer("AdminView.aspx");
            }

            else
            {
                MessageBox.Show("Please Check Your Username and Password.");
                Response.Redirect("AdminLogin.aspx");
            }
        }
    }
}