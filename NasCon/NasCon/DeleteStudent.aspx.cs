using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class DeleteStudent : System.Web.UI.Page
{
    public string msg = "";
    public string goodmsg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string RollNo = TextBox1.Text;

        string query = "Select First_Name, Last_Name, S_Role, Email from executive_student where ROLL_NO = '" + RollNo + "'";

        cm = new SqlCommand(query, conn);

        if (Convert.ToString(cm.ExecuteScalar()) == "")
        {
            msg = "Student does not exist";
            return;
        }

        SqlDataReader reader = cm.ExecuteReader();

        

        GridView1.DataSource = reader;
        GridView1.DataBind();

        Button2.Visible = true;

        reader.Close();
        cm.Dispose();
        conn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm1,cm2,cm3,cm4;

        string RollNo = TextBox1.Text;

        msg = RollNo;

        string query1 = "Select S_Role from executive_student where ROLL_NO = '" + RollNo + "'";

        cm1 = new SqlCommand(query1, conn);

        if (cm1.ExecuteScalar().ToString() == "Head" || cm1.ExecuteScalar().ToString() == "Secretary")
        {
            
            string query2 = "update Eventss set HOE_ID = NULL where HOE_ID = '" + RollNo + "'";
            cm2 = new SqlCommand(query2,conn);
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

            string query3 = "update category set Secretary_ID = NULL where Secretary_ID = '" + RollNo + "'";
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
        }

        string query4 = "delete from executive_student where ROLL_NO = '" + RollNo + "'";
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

        Response.Redirect("DeleteStudent.aspx");
        cm4.Dispose();
        conn.Close();
    }

    
}