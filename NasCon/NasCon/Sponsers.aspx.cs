using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Sponsers : System.Web.UI.Page
{
    public string msg = "";
    public string goodmsg = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string Rname = TextBox2.Text;
        string RCNIC = TextBox3.Text;
        string cat = DropDownList2.SelectedValue.ToString();
        string package = DropDownList1.SelectedValue.ToString();
        string amnt = "";

        if (package == "Bronze (25,000 PKR)")
        {
            amnt = "25000";
        }

        if (package == "Silver (60,000 PKR)")
        {
            amnt = "60000";
        }

        if (package == "Gold (1,00,000 PKR)")
        {
            amnt = "100000";
        }

        if (cat == "Select")
        {
            msg = "Please Enter all Fields";
            return;
        }

        if (package == "Select")
        {
            msg = "Please Enter all Fields";
            return;
        }

        string catID = "";

        switch (cat)
        {
            case "Electrical Engineering":
                catID = "1";
                break;
            case "Computer Science":
                catID = "2";
                break;
            case "Business":
                catID = "3";
                break;
            case "Social":
                catID = "4";
                break;
            case "Sports":
                catID = "5";
                break;
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string query = "Insert into Sponsors values('" + RCNIC + "','" + Rname + "','" + name + "'," + catID + ",'" + package + "'," + amnt + ")";
        cm = new SqlCommand(query, conn);

        try
        {
            msg = "";
            cm.ExecuteNonQuery();
            goodmsg = "Successfully registered sponsor";
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                msg = "Sponsor already exists in record";
            }
            else
            {
                msg = "Error occured while inserting";
            }
        }

        cm.Dispose();
        conn.Close();
    }
}