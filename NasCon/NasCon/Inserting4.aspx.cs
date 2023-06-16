using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Inserting4 : System.Web.UI.Page
{
    public string click;
    public string msg = "";
    public string goodmsg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        click = Request.QueryString["From"];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string AdminID = TextBox1.Text;
        string Name = TextBox2.Text;
        string Email = TextBox3.Text;
        string Password = TextBox4.Text;

        string query = "Insert into Admins values('" + AdminID + "','" + Name + "','" + Email + "','" + Password + "')";
        cm = new SqlCommand(query, conn);

        try
        {
            goodmsg = "Added Record";
            msg = "";
            cm.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                msg = "Admin Number already exists in record";
                goodmsg = "";
            }
            else
            {
                goodmsg = "";
                msg = "Error occured while inserting";
            }
        }

        cm.Dispose();
        conn.Close();
    }
}