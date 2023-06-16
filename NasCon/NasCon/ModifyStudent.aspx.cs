using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ModifyStudent : System.Web.UI.Page
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

        string RollNo = TextBox1.Text;
        string FirstName = TextBox2.Text;
        string LastName = TextBox3.Text;
        string Role = TextBox4.Text;
        string Email = TextBox5.Text;
        string Password = TextBox6.Text;

        if (FirstName == "")
        {
            string q1 = "Select First_Name from executive_student where ROLL_NO = '" + RollNo + "'";
            cm = new SqlCommand(q1,conn);
            FirstName = cm.ExecuteScalar().ToString();
        }

        if (LastName == "")
        {
            string q1 = "Select Last_Name from executive_student where ROLL_NO = '" + RollNo + "'";
            cm = new SqlCommand(q1, conn);
            LastName = cm.ExecuteScalar().ToString();
        }

        if (Role == "")
        {
            string q1 = "Select S_Role from executive_student where ROLL_NO = '" + RollNo + "'";
            cm = new SqlCommand(q1, conn);
            Role = cm.ExecuteScalar().ToString();
        }

        if (Email == "")
        {
            string q1 = "Select Email from executive_student where ROLL_NO = '" + RollNo + "'";
            cm = new SqlCommand(q1, conn);
            Email = cm.ExecuteScalar().ToString();
        }

        if (Password == "")
        {
            string q1 = "Select S_Password from executive_student where ROLL_NO = '" + RollNo + "'";
            cm = new SqlCommand(q1, conn);
            Password = cm.ExecuteScalar().ToString();
        }

        string query = "update executive_student set First_Name = '" + FirstName + "', Last_Name = '" + LastName + "', S_Role =  '" + Role + "' , Email = '" + Email + "', S_Password = '" + Password + "' where ROLL_NO = '" + RollNo + "'";

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