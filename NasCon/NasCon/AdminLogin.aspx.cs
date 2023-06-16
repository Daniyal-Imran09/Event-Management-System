using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminLogin :  System.Web.UI.Page
{
    public string msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;
        
        string un = TextBox1.Text;
        string pass = TextBox2.Text;
        string query = "Select * from Admins where Email= '" + un + "' and A_Password= '" + pass + "'";
        cm = new SqlCommand(query, conn);
        string count = Convert.ToString(cm.ExecuteScalar());
        if (count == "")
        {
            msg = "Incorrect Username or Password";
        }
        else
        {
            Response.Redirect("Admin.aspx");
        }
        cm.Dispose();
        conn.Close();
    }
}