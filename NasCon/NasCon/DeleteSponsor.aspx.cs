using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class DeleteSponsor : System.Web.UI.Page
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

        string sponsor = TextBox1.Text;

        string query = "Select Company_Name, Representatvie_Name, Representative_CNIC, Package, C_Name from Sponsors inner join Category on Sponsors.Cat_ID = category.Cat_ID where Company_Name = '" + sponsor + "'";

        cm = new SqlCommand(query, conn);

        if (Convert.ToString(cm.ExecuteScalar()) == "")
        {
            msg = "Sponsor does not exist";
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
        SqlCommand cm4;

        string sponsor = TextBox1.Text;

        string query4 = "delete from sponsors where Company_Name = '" + sponsor + "'";
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

        Response.Redirect("DeleteSponsorAdmin.aspx");
        cm4.Dispose();
        conn.Close();
    }
}