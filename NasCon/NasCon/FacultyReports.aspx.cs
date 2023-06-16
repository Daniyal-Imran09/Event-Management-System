using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class FacultyReports : System.Web.UI.Page
{
    public string msg = "";
    public string msg2 = "";
    public string goodmsg = "";
    public string result = "";
    public string result2 = "";
    public string result3 = "";
    public string ID = "";
    public string cat = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Request.QueryString["ID"];

        string query = "select Cat_ID from category where Mentor_ID = " + ID;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        if (cm.ExecuteScalar() == null)
        {
            query = "select categoryid from eventss where mentors_id = " + ID;

            cm = new SqlCommand(query, conn);

            cat = cm.ExecuteScalar().ToString();
        }
        else
        {
            cat = cm.ExecuteScalar().ToString();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        msg = "";
        msg2 = "";
        goodmsg = "";
        result = "";
        result2 = "";
        result3 = "";

        GridView1.DataSource = null;
        GridView1.DataBind();

        DropDownList3.Visible = false;
        DropDownList3.Enabled = false;
        DropDownList3.SelectedIndex = 0;

        DropDownList4.Visible = false;
        DropDownList4.Enabled = false;
        DropDownList4.SelectedIndex = 0;

        Button4.Visible = false;
        Button4.Enabled = false;

        Button5.Visible = false;
        Button5.Enabled = false;

        Button6.Visible = false;
        Button6.Enabled = false;

        Button7.Visible = false;
        Button7.Enabled = false;

        Button8.Visible = false;
        Button8.Enabled = false;

        TextBox1.Visible = false;
        TextBox1.Enabled = false;
        TextBox1.Text = "";

        Calendar1.Visible = false;
        Calendar1.Enabled = false;
        Calendar1.SelectedDate = DateTime.MinValue;

        int selection = DropDownList1.SelectedIndex;

        if (selection == 0)
        {
            msg = "Please Select a query";
            return;
        }

        switch (selection)
        {
            case 1:
                Query1();
                break;
            case 2:
                Query3();
                break;
            case 3:
                Query5();
                break;
            case 4:
                Query7();
                break;
            case 5:
                Query8();
                break;
            case 6:
                Query9();
                break;
            case 7:
                Query10();
                break;
            case 8:
                Query11();
                break;
        }
    }

    void Query1()
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string query = "select PID,Cnic,P_Name,Email,Contact,institute_name,food_registration,Team_Name from participant full outer join participating_team on participant.event_id = participating_team.event_id";

        cm = new SqlCommand(query, conn);

        SqlDataReader reader = cm.ExecuteReader();

        msg = "";
        goodmsg = "";
        result = "";
        result2 = "";

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }

    void Query3()
    {

        string query = "select * from eventss where CategoryID = " + cat;



        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }

    void Query5()
    {
        msg = "";
        goodmsg = "";
        result = "";
        result2 = "Select Option: ";

        DropDownList3.Visible = true;
        DropDownList3.Enabled = true;

        Button4.Visible = true;
        Button4.Enabled = true;
    }

    void Query7()
    {
        msg = "";
        goodmsg = "";
        result = "";
        result2 = "";

        DropDownList4.Visible = true;
        DropDownList4.Enabled = true;

        Button5.Visible = true;
        Button5.Enabled = true;

        TextBox1.Visible = true;
        TextBox1.Enabled = true;
    }

    void Query8()
    {
        msg = "";
        goodmsg = "";
        result = "";
        result2 = "";

        string query = "select PID,P_Name,food_registration from participant inner join eventss on eventss.event_id = participant.event_id where eventss.categoryid = " + cat + " order by food_registration";

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }

    void Query9()
    {
        msg = "";
        goodmsg = "";
        result = "";
        result2 = "";

        Calendar1.Visible = true;
        Calendar1.Enabled = true;

        Button6.Visible = true;
        Button6.Enabled = true;
    }

    void Query10()
    {
        TextBox1.Visible = true;
        TextBox1.Enabled = true;

        Button7.Visible = true;
        Button7.Enabled = true;

        result2 = "Enter Name of Event";
    }

    void Query11()
    {
        TextBox1.Visible = true;
        TextBox1.Enabled = true;

        Button8.Visible = true;
        Button8.Enabled = true;

        result2 = "Enter Name of Event";
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string selected = DropDownList3.SelectedIndex.ToString();

        if (selected == "0")
        {
            msg = "Please select an option";
            return;
        }

        string query = "";

        switch (selected)
        {
            case "1":
                query = "select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role,Eventss.Event_NAME from executive_student inner join Eventss on executive_student.ROLL_NO = Eventss.HOE_ID where Eventss.CategoryID = " + cat;
                break;
            case "2":
                query = "select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role,Eventss.Event_NAME from executive_student inner join Eventss on executive_student.ROLL_NO = Eventss.HOE_ID where Eventss.CategoryID = " + cat;
                break;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        string selected = DropDownList4.SelectedIndex.ToString();

        if (selected == "0")
        {
            msg = "Please select an option";
            return;
        }

        string search = TextBox1.Text;

        string query;
        if (selected == "1")
        {
            query = "select * from participant inner join Eventss on participant.event_id = Eventss.Event_ID where participant.P_Name = '" + search + "' and Eventss.categoryID = " + cat;
        }
        else
        {
            query = "select * from participant inner join Eventss on participant.event_id = Eventss.Event_ID where participant.PID = '" + search + "' and Eventss.categoryID = " + cat;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        if (cm.ExecuteScalar() == null)
        {
            if (selected == "1")
            {
                msg = "Please enter a valid Participant name";
            }
            else
            {
                msg = "Please enter a valid ID";
            }

            return;
        }

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        DateTime Date = Calendar1.SelectedDate;

        if (Date == DateTime.MinValue)
        {
            msg2 = "Please select a Date";
            return;
        }

        string query = "select * from eventss where Event_Date = '" + Date + "' and eventss.categoryID = " + cat;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        if (cm.ExecuteScalar().ToString() == "")
        {
            msg2 = "No Event on this date";
            return;
        }

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;

        string query = "select count(participant.event_id) from participant inner join Eventss on Eventss.Event_ID = participant.event_id where Eventss.Event_NAME = '" + name + "'";

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm = new SqlCommand(query, conn);

        if (cm.ExecuteScalar().ToString() == "")
        {
            msg2 = "Event does not have any registrations";
            return;
        }

        result3 = "Registrations: " + cm.ExecuteScalar().ToString();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string query = "select Eventss.*,Faculty_Mentors.F_Name as 'Mentor Name',executive_student.First_Name + executive_student.Last_Name as 'Event Head Name' from (Eventss full outer join Faculty_Mentors on Eventss.Mentors_ID = Faculty_Mentors.Mentor_ID) inner join executive_student on executive_student.ROLL_NO = Eventss.HOE_ID where Eventss.Event_NAME = '" + name + "'";

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm = new SqlCommand(query, conn);

        if (cm.ExecuteScalar() == null)
        {
            msg2 = "Event is not in record";
            return;
        }

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }
}