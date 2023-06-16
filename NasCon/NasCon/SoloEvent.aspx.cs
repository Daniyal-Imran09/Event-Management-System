using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class SoloEvent : System.Web.UI.Page
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
        SqlCommand cm;


        string Participant_Email = TextBox2.Text;
        string Participant_Cnic = TextBox3.Text;
        string Participant_Contact = TextBox4.Text;
        string Institue_Name = TextBox5.Text;
        string Food = DropDownList1.SelectedValue.ToString();
        string Participant_Name = TextBox9.Text;

        string getID = "select PID from participant order by PID desc";
        SqlCommand cm1 = new SqlCommand(getID,conn);
        string topID = cm1.ExecuteScalar().ToString();
        cm1.Dispose();

        topID = (Convert.ToInt64(topID) + 1).ToString();

        string query = "Insert into participant values(" + topID + "," + Participant_Cnic + ",'" + Participant_Name + "','" + Participant_Email + "','" + Participant_Contact + "','" + Institue_Name + "','" + Food + "',NULL," + ID + ")";
        cm = new SqlCommand(query, conn);

        try
        {
            msg = "";
            cm.ExecuteNonQuery();
            Ticket = "SoloTicket.aspx?ID=" + topID + "&N=" + Participant_Name + "&C=" + Participant_Cnic + "&Event=" + eventname;
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

        cm.Dispose();
        conn.Close();
    }
}