using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SoloTicket : System.Web.UI.Page
{
    public string N, C, Event, ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Request.QueryString["ID"];
        N = Request.QueryString["N"];
        C = Request.QueryString["C"];
        Event = Request.QueryString["Event"];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}