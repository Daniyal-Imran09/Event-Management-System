using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ModifySponsor : System.Web.UI.Page
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

        string catID = "";
        string name = TextBox2.Text;
        string RCNIC = TextBox1.Text;
        string cat = DropDownList2.SelectedValue.ToString();
        string package = DropDownList1.SelectedValue.ToString();

        

        if (name == "")
        {
            string q1 = "Select Company_Name from sponsors where Representative_CNIC = '" + RCNIC + "'";
            cm = new SqlCommand(q1, conn);
            name = cm.ExecuteScalar().ToString();
        }

        if (cat == "Select")
        {
            string q1 = "Select cat_ID from sponsors where Representative_CNIC = '" + RCNIC + "'";
            cm = new SqlCommand(q1, conn);
            catID = cm.ExecuteScalar().ToString();
        }
        else
        {
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
        }

        if (package == "Select")
        {
            string q1 = "Select package from sponsors where Representative_CNIC = '" + RCNIC + "'";
            cm = new SqlCommand(q1, conn);
            package = cm.ExecuteScalar().ToString();
        }

        string query = "update Sponsors set Company_Name = '" + name + "', Cat_ID = '" + catID + "', Package = '" + package + "' where Representative_CNIC = '" + RCNIC + "'";

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