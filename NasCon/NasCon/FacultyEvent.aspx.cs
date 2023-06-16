using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class FacultyEvent : System.Web.UI.Page
{
    public string goodmsg = "";
    public string msg = "";

    public string ID = "";
    public string cat = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Request.QueryString["ID"];

        string query = "select Cat_ID from category where Mentor_ID = " + ID;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query,conn);

        if (cm.ExecuteScalar() == null)
        {
            query = "select categoryid from eventss where mentors_id = " + ID;

            cm = new SqlCommand(query,conn);

            cat = cm.ExecuteScalar().ToString();
        }
        else
        {
            cat = cm.ExecuteScalar().ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string EVENT_ID = TextBox1.Text;
        DateTime Date = Calendar1.SelectedDate;
        
        string Venue = TextBox6.Text;
        string Timings = TextBox7.Text;

        string checkq = "select categoryid from eventss where event_id = " + EVENT_ID;

        cm = new SqlCommand(checkq,conn);

        if (cm.ExecuteScalar().ToString() != cat)
        {
            msg = "Event not available";
            return;
        }

        if (Date == DateTime.MinValue)
        {
            string q1 = "Select Event_Date from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Date = (DateTime)cm.ExecuteScalar();
        }

        if (Venue == "")
        {
            string q1 = "Select Venue from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Venue = cm.ExecuteScalar().ToString();
        }

        if (Timings == "")
        {
            string q1 = "Select Timing from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Timings = cm.ExecuteScalar().ToString();
        }

        string query = "update Eventss set Event_Date = '" + Date + "', Venue = '" + Venue + "', Timing = '" + Timings + "' where Event_ID = '" + EVENT_ID + "'";

        cm = new SqlCommand(query, conn);

        try
        {
            goodmsg = "Updated Record";
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
                msg = "Error occured while updating";
            }
        }

        cm.Dispose();
        conn.Close();
    }
}