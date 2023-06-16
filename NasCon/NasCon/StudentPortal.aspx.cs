using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentPortal : System.Web.UI.Page
{
    public string role = "";
    public string redirect = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        role = Request.QueryString["Role"];
        if (role == "President")
        {
            redirect = "StudentPresidentReports.aspx";
        }
        else
        {
            redirect = "StudentNormalReports.aspx";
        }
    }
}