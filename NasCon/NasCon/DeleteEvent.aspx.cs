using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class DeleteEvent : System.Web.UI.Page
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

        string Event_ID = TextBox1.Text;

        string query = "Select Event_Name,Event_Date, No_of_participants,price,venue,timing,categoryid from Eventss where Event_ID = " + Event_ID + "";

        cm = new SqlCommand(query, conn);

        if (Convert.ToString(cm.ExecuteScalar()) == "")
        {
            msg = "Event does not exist";
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

        string Event_ID = TextBox1.Text;

        string query4 = "delete from Eventss where Event_ID = " + Event_ID + "";
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

        Response.Redirect("DeleteEvent.aspx");
        cm4.Dispose();
        conn.Close();
    }
}