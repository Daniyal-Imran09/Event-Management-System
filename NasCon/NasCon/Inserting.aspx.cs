using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Inserting : System.Web.UI.Page
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

        string RollNo = TextBox1.Text;
        string FirstName = TextBox2.Text;
        string LastName = TextBox3.Text;
        string Role = TextBox4.Text;
        string Email = TextBox5.Text;
        string Password = TextBox6.Text;

        string query = "Insert into executive_student values('" + RollNo + "','" + FirstName + "','" + LastName + "','" + Role + "','" + Email + "','" + Password + "')";
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
                msg = "Roll Number already exists in record";
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