using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class DeleteAdmin : System.Web.UI.Page
{
    public string msg = "";
    public string goodmsg = "";
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string Admin_ID = TextBox1.Text;

        string query = "Select A_Name, Email from Admins where ID = '" + Admin_ID + "'";

        cm = new SqlCommand(query, conn);

        if (Convert.ToString(cm.ExecuteScalar()) == "")
        {
            msg = "Admin does not exist";
            return;
        }

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        Button4.Visible = true;

        reader.Close();
        cm.Dispose();
        conn.Close();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm4;

        string Admin_ID = TextBox1.Text;

        string query4 = "delete from Admins where ID = '" + Admin_ID + "'";
        cm4 = new SqlCommand(query4, conn);

        try
        {
            cm4.ExecuteNonQuery();
            goodmsg = "Successfully deleted";
            msg = "";
        }
        catch (SqlException ex)
        {
            goodmsg = "";
            msg = "Error";
        }

        Response.Redirect("DeleteAdmin.aspx");
        cm4.Dispose();
        conn.Close();
    }
}