using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class TeamEvent :  System.Web.UI.Page
{
    public string msg = "";
    public string ID = "";
    public string eventname = "";
    public string Ticket = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        eventname = Request.QueryString["Name"];
        ID = Request.QueryString["ID"];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cmT;
        SqlCommand cmP1;
        SqlCommand cmP2;
        SqlCommand cmP3;

        string InstituteName = TextBox1.Text;
        string TeamName = TextBox4.Text;
        string A_Name = TextBox5.Text;
        string A_Contact = TextBox6.Text;
        string Food = DropDownList1.SelectedValue.ToString();
        string getTeam = "select Team_ID from participating_team order by Team_ID desc";
        SqlCommand cm1 = new SqlCommand(getTeam, conn);
        string teamID = cm1.ExecuteScalar().ToString();
        cm1.Dispose();

        teamID = (Convert.ToInt64(teamID) + 1).ToString();

        string teamquery = "insert into participating_team values (" + teamID + ",'" + TeamName + "','" + A_Name + "','" + A_Contact + "'," + ID + ")";

        cmT = new SqlCommand(teamquery, conn);

        string Participant1_Email, Participant2_Email, Participant3_Email;
        string Participant1_Cnic, Participant2_Cnic, Participant3_Cnic;
        string Participant1_Contact, Participant2_Contact,Participant3_Contact;
        string Participant1_Name, Participant2_Name, Participant3_Name;

        Participant1_Email = TextBox10.Text;
        Participant1_Cnic = TextBox11.Text;
        Participant1_Name = TextBox9.Text;
        Participant1_Contact = TextBox2.Text;

        string getID = "select PID from participant order by PID desc";
        cm1 = new SqlCommand(getID, conn);
        string topID1 = cm1.ExecuteScalar().ToString();
        cm1.Dispose();

        topID1 = (Convert.ToInt64(topID1) + 1).ToString();

        string queryP1 = "Insert into participant values(" + topID1 + "," + Participant1_Cnic + ",'" + Participant1_Name + "','" + Participant1_Email + "','" + Participant1_Contact + "','" + InstituteName + "','" + Food + "'," + teamID + "," + ID + ")";
        cmP1 = new SqlCommand(queryP1, conn);

        Participant2_Email = TextBox13.Text;
        Participant2_Cnic = TextBox14.Text;
        Participant2_Name = TextBox12.Text;
        Participant2_Contact = TextBox3.Text;

        string topID2 = (Convert.ToInt64(topID1) + 1).ToString();

        string queryP2 = "Insert into participant values(" + topID2 + "," + Participant2_Cnic + ",'" + Participant2_Name + "','" + Participant2_Email + "','" + Participant2_Contact + "','" + InstituteName + "','" + Food + "'," + teamID + "," + ID + ")";
        cmP2 = new SqlCommand(queryP2, conn);

        Participant3_Email = TextBox16.Text;
        Participant3_Cnic = TextBox17.Text;
        Participant3_Name = TextBox15.Text;
        Participant3_Contact = TextBox7.Text;

        string topID3 = (Convert.ToInt64(topID2) + 1).ToString();

        string queryP3 = "Insert into participant values(" + topID3 + "," + Participant3_Cnic + ",'" + Participant3_Name + "','" + Participant3_Email + "','" + Participant3_Contact + "','" + InstituteName + "','" + Food + "'," + teamID + "," + ID + ")";
        cmP3 = new SqlCommand(queryP3, conn);

        try
        {
            msg = "";
            cmT.ExecuteNonQuery();
            cmP1.ExecuteNonQuery();
            cmP2.ExecuteNonQuery();
            cmP3.ExecuteNonQuery();
            Ticket = "TeamTicket.aspx?ID=" + teamID + "&N1=" + Participant1_Name + "&N2=" + Participant2_Name + "&N3=" + Participant3_Name + "&C1=" + Participant1_Cnic + "&C2=" + Participant2_Cnic + "&C3=" + Participant3_Cnic + "&Event="+eventname + "&TN=" + TeamName;
            Response.Redirect(Ticket);
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                msg = "Roll Number already exists in record";
            }
            else
            {
                msg = "Some error occured";
            }
        }

        cmP1.Dispose();
        cmP2.Dispose();
        cmP3.Dispose();
        conn.Close();
    }
}