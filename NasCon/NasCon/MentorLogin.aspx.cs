using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MentorLogin : System.Web.UI.Page
{
    public string msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8NA38GU\\SQLEXPRESS;Initial Catalog=NasCon;Integrated Security=True");
        conn.Open();
        SqlCommand cm;

        string un = TextBox1.Text;
        string pass = TextBox2.Text;
        string query = "Select Mentor_ID from faculty_mentors where Email= '" + un + "' and F_Password= '" + pass + "'";
        cm = new SqlCommand(query, conn);
        string count = Convert.ToString(cm.ExecuteScalar());
        if (count == "")
        {
            msg = "Incorrect Username or Password";
        }
        else
        {
            Response.Redirect("FacultyPortal.aspx?ID="+count);
        }
        cm.Dispose();
        conn.Close();
    }
}