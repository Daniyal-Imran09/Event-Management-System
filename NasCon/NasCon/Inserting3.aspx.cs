using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Inserting3 : System.Web.UI.Page
{
    public string click;
    public string msg = "";
    public string goodmsg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        click = Request.QueryString["From"];
    }

    protected void Button1_Click(object sender, EventArgs e)
     {
         SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
         conn.Open();
         SqlCommand cm;

         string Event_ID = TextBox1.Text;
         DateTime Date = Calendar1.SelectedDate;
         string Event_Name = TextBox3.Text;
         string No_of_Participants = TextBox4.Text;
         string Price = TextBox5.Text;
         string Venue = TextBox6.Text;
         string Timing = TextBox7.Text;
         string HOE_ID = TextBox8.Text;
         string Mentors_ID = TextBox9.Text;
         string CategoryID = TextBox10.Text;
         
         

         string query = "Insert into Eventss values('" + Event_ID + "','" + Date + "','" + Event_Name + "'," + No_of_Participants + "," + Price + ",'" + Venue + "','" + Timing + "','" + HOE_ID + "'," + Mentors_ID + "," + CategoryID + ")";
         cm = new SqlCommand(query, conn);

         try
         {
             goodmsg = "Added Record";
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
                System.Diagnostics.Debug.WriteLine(ex.Message);
                goodmsg = "";
                msg = "Error occured while inserting";
            }
         }

         cm.Dispose();
         conn.Close();
     }
}