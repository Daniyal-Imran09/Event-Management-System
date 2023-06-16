using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class StudentNormalReports : System.Web.UI.Page
{
    public string msg = "";
    public string msg2 = "";
    public string goodmsg = "";
    public string result = "";
    public string result2 = "";
    public string result3 = "";
    protected void Page_Load(object sender, EventArgs e)
    {

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

        Button6.Visible = false;
        Button6.Enabled = false;

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
                Query9();
                break;
            case 2:
                Query11();
                break;
        }
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

    void Query11()
    {
        TextBox1.Visible = true;
        TextBox1.Enabled = true;

        Button8.Visible = true;
        Button8.Enabled = true;

        result2 = "Enter Name of Event";
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        DateTime Date = Calendar1.SelectedDate;

        if (Date == DateTime.MinValue)
        {
            msg2 = "Please select a Date";
            return;
        }

        string query = "select * from eventss where Event_Date = '" + Date + "'";

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

    protected void Button8_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string query = "select Eventss.*,Faculty_Mentors.F_Name as 'Mentor Name',executive_student.First_Name + executive_student.Last_Name as 'Event Head Name' from (Eventss full outer join Faculty_Mentors on Eventss.Mentors_ID = Faculty_Mentors.Mentor_ID) inner join executive_student on executive_student.ROLL_NO = Eventss.HOE_ID where Eventss.Event_NAME = '" + name + "'";

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm = new SqlCommand(query, conn);

        if (cm.ExecuteScalar().ToString() == "")
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