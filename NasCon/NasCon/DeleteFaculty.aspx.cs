using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class DeleteFaculty : System.Web.UI.Page
{
    public string msg = "";
    public string goodmsg = "";
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string Mentor_ID = TextBox1.Text;

        string query = "Select F_Name, Email from Faculty_Mentors where Mentor_ID = '" + Mentor_ID + "'";

        cm = new SqlCommand(query, conn);

        if (Convert.ToString(cm.ExecuteScalar()) == "")
        {
            msg = "Faculty Mentor does not exist";
            return;
        }

        SqlDataReader reader = cm.ExecuteReader();



        GridView1.DataSource = reader;
        GridView1.DataBind();

        Button4.Visible = true;

        reader.Close();
        cm.Dispose();
        conn.Close();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand  cm2, cm3, cm4;

        string Mentor_ID = TextBox1.Text;

        msg = Mentor_ID;



        string query2 = "update Eventss set Mentor_ID = NULL where Mentor_ID = '" + Mentor_ID + "'";
        cm2 = new SqlCommand(query2, conn);
        try
        {
            cm2.ExecuteNonQuery();
            goodmsg = "Successfully deleted";
            msg = "";
        }
        catch (SqlException ex)
        {
            goodmsg = "";
            msg = "Error";
        }

        string query3 = "update category set Mentor_ID = NULL where Mentor_ID = '" + Mentor_ID + "'";
        cm3 = new SqlCommand(query3, conn);
        try
        {
            cm3.ExecuteNonQuery();
            goodmsg = "Successfully deleted";
            msg = "";
        }
        catch (SqlException ex)
        {
            goodmsg = "";
            msg = "Error";
        }

        string query4 = "delete from Faculty_Mentors where Mentor_ID = '" + Mentor_ID + "'";
        cm4 = new SqlCommand(query4, conn);

        try
        {
            cm4.ExecuteNonQuery();
            goodmsg = "Successfully deleted";
            msg = "";
        }
        catch (SqlException ex)
        {
            goodmsg = "";
            msg = "Error";
        }

        Response.Redirect("DeleteFaculty.aspx");
        cm4.Dispose();
        conn.Close();
    }
}