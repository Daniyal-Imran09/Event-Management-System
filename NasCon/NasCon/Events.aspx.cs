using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Events : System.Web.UI.Page
{
    public string category= "";
    public string msg = "Nothing";
    public string redirect = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string click = Request.QueryString["click"];
        string cat = "0";

        switch (click)
        {
            case "EE":
                category = "Electrical Engineering";
                cat = "1";
                break;
            case "CS":
                category = "Computer Science";
                cat = "2";
                break;
            case "Business":
                category = "Business";
                cat = "3";
                break;
            case "Social":
                category = "Social";
                cat = "4";
                break;
            case "Sports":
                category = "Sports";
                cat = "5";
                break;
        }

        string query = "Select Event_Date, Event_NAME, No_of_Participants, Timing from Eventss where CategoryID = " + cat;

        cm = new SqlCommand(query,conn);

        SqlDataReader reader = cm.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();

        cm.Dispose();
        conn.Close();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = GridView1.SelectedIndex;

        string eventname = GridView1.SelectedRow.Cells[2].Text;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string query = "Select Event_ID from Eventss where Event_NAME = '" + eventname+"'";

        cm = new SqlCommand(query, conn);

        string ID = cm.ExecuteScalar().ToString();

        if (GridView1.SelectedRow.Cells[3].Text == "1")
        {
            Response.Redirect("SoloEvent.aspx?Name=" + eventname + "&ID=" + ID);
        }
        else 
        {
            Response.Redirect("TeamEvent.aspx?Name=" + eventname + "&ID=" + ID);
        }
    }
}