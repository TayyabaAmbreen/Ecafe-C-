using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WebApplication2
{
    public partial class AdminView : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);

            if (!IsPostBack)
            {
                OleDbConnection dbcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\\Users\\Dell\\Documents\\Lab04.accdb; Persist Security Info=False;");
                dbcon.Open();

                OleDbCommand sqlcommand = new OleDbCommand("select * from Users where Type = 'User'", dbcon);
                OleDbDataReader rd = sqlcommand.ExecuteReader(); // Execute the sql command and store the results in a reader object

                // MessageBox.Show("Query executed");
                while (rd.Read())
                {
                    ListBox1.Items.Add(rd[1].ToString());
                    ListBox2.Items.Add(rd[2].ToString());
                    ListBox3.Items.Add(rd[3].ToString());
                    ListBox4.Items.Add(rd[4].ToString());

                }

            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}