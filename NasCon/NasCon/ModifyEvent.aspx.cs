using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ModifyEvent : System.Web.UI.Page
{
    public string goodmsg = "";
    public string msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string EVENT_ID = TextBox1.Text;
        DateTime Date = Calendar1.SelectedDate;

        string Event_Name = TextBox3.Text;
        string No_of_Participants = TextBox4.Text;
        string Price = TextBox5.Text;
        string Venue = TextBox6.Text;
        string Timings = TextBox7.Text;
        string Head_Of_Event_ID = TextBox8.Text;
        string Mentors_id = TextBox9.Text;
        string Category_id = TextBox10.Text;


        if (Date == DateTime.MinValue)
        {
            string q1 = "Select Event_Date from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Date = (DateTime)cm.ExecuteScalar();
        }

        if (Event_Name == "")
        {
            string q1 = "Select Event_Name from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Event_Name = cm.ExecuteScalar().ToString();
        }

        if (No_of_Participants == "")
        {
            string q1 = "Select No_of_Participants from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            No_of_Participants = cm.ExecuteScalar().ToString();
        }
        if (Price == "")
        {
            string q1 = "Select Price from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Price = cm.ExecuteScalar().ToString();
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

        if (Head_Of_Event_ID == "")
        {
            string q1 = "Select HOE_ID from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Head_Of_Event_ID = cm.ExecuteScalar().ToString();
        }


        if (Mentors_id == "")
        {
            string q1 = "Select Mentors_id from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Mentors_id = cm.ExecuteScalar().ToString();
        }


        if (Category_id == "")
        {
            string q1 = "Select CategoryID from Eventss where EVENT_ID = '" + EVENT_ID + "'";
            cm = new SqlCommand(q1, conn);
            Category_id = cm.ExecuteScalar().ToString();
        }

        string query = "update Eventss set Event_Name = '" + Event_Name + "', No_of_Participants = '" + No_of_Participants + "', Event_Date = '" + Date + "', Price =  '" + Price + "' , Venue = '" + Venue + "', Timing = '" + Timings + "', HOE_ID = '" + Head_Of_Event_ID + "', Mentors_id =  '" + Mentors_id + "' , CategoryID =  '" + Category_id + "'  where Event_ID = '" + EVENT_ID + "'";

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