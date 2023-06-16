using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AdminReports : System.Web.UI.Page
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

        DropDownList2.Visible = false;
        DropDownList2.Enabled = false;
        DropDownList2.SelectedIndex = 0;

        DropDownList3.Visible = false;
        DropDownList3.Enabled = false;
        DropDownList3.SelectedIndex = 0;

        DropDownList4.Visible = false;
        DropDownList4.Enabled = false;
        DropDownList4.SelectedIndex = 0;

        Button2.Visible = false;
        Button2.Enabled = false;

        Button3.Visible = false;
        Button3.Enabled = false;

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
                Query2();
                break;
            case 3:
                Query3();
                break;
            case 4:
                Query4();
                break;
            case 5:
                Query5();
                break;
            case 6:
                Query6();
                break;
            case 7:
                Query7();
                break;
            case 8:
                Query8();
                break;
            case 9:
                Query9();
                break;
            case 10:
                Query10();
                break;
            case 11:
                Query11();
                break;
            case 12:
                Query12();
                break;
        }
    }

    void Query1()
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string query = "select PID,Cnic,P_Name,Email,Contact,institute_name,food_registration,Team_Name from participant full outer join participating_team on participant.event_id = participating_team.event_id";

        cm = new SqlCommand(query,conn);

        SqlDataReader reader = cm.ExecuteReader();

        msg = "";
        goodmsg = "";
        result = "";
        result2 = "";

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
    }

    void Query2()
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string query = "select sum(Amount) from sponsors";

        cm = new SqlCommand(query, conn);

        string answer = cm.ExecuteScalar().ToString();

        msg = "";
        goodmsg = "";
        result = "";
        result2 = "";

        result = "Total : " + answer;        
    }

    void Query3()
    {
        msg = "";
        goodmsg = "";
        result2 = "";
        result = "Select Category: ";

        DropDownList2.Visible = true;
        DropDownList2.Enabled = true;

        Button2.Visible = true;
        Button2.Enabled = true;
    }

    void Query4()
    {
        msg = "";
        goodmsg = "";
        result2 = "";
        result = "Select Category: ";

        DropDownList2.Visible = true;
        DropDownList2.Enabled = true;

        Button3.Visible = true;
        Button3.Enabled = true;
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

    void Query6()
    {
        msg = "";
        goodmsg = "";
        result = "";
        result2 = "";

        string query = "select * from sponsors";

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();
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

        string query = "select PID,P_Name,food_registration from participant order by food_registration";

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

    void Query12()
    {
        string query = "SELECT event_time, action_id, statement, database_name, server_principal_name FROM fn_get_audit_file( 'D:\\Audits_778C2556-C1FA-401C-83EE-E363E98A5F60_0_132989204931500000.sqlaudit' , DEFAULT , DEFAULT)";

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        reader.Close();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int index = DropDownList2.SelectedIndex;

        if (index == 0)
        {
            msg2 = "Please Select a category";
            return;
        }

        string cat = Convert.ToString(index);

        string query;

        if (cat == "6")
        {
            query = "select * from eventss";
        }
        else {
            query = "select * from eventss where CategoryID = " + cat;
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

    protected void Button3_Click(object sender, EventArgs e)
    {
        int index = DropDownList2.SelectedIndex;

        if (index == 0)
        {
            msg2 = "Please Select a category";
            return;
        }

        string cat = Convert.ToString(index);

        string query;

        if (cat == "6")
        {
            query = "select * from Faculty_Mentors";
        }
        else
        {
            query = "select * from Faculty_Mentors where Faculty_Mentors.Mentor_ID in (select Eventss.Mentors_ID from Eventss where Eventss.CategoryID = " + cat + ") or Faculty_Mentors.Mentor_ID in (select category.Mentor_ID from category where Cat_ID = " + cat + ")";
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
                query = "select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role,Eventss.Event_NAME from executive_student inner join Eventss on executive_student.ROLL_NO = Eventss.HOE_ID";
                break;
            case "2":
                query = "select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role from executive_student where executive_student.ROLL_NO in (select Eventss.HOE_ID from Eventss inner join category on Eventss.CategoryID = category.Cat_ID) or executive_student.ROLL_NO in (select category.Secretary_ID from category)";
                break;
            case "3":
                query = "select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role from executive_student order by executive_student.S_Role";
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
            query = "select * from participant where P_Name = '" + search + "'";
        }
        else 
        {
            query = "select * from participant where PID = " + search;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        cm = new SqlCommand(query, conn);

        if (cm.ExecuteScalar().ToString() == "")
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

    protected void Button7_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;

        string query = "select count(participant.event_id) from participant inner join Eventss on Eventss.Event_ID = participant.event_id where Eventss.Event_NAME = '" + name + "'";

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm = new SqlCommand(query,conn);

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