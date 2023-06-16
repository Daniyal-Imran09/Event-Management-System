using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamTicket : System.Web.UI.Page
{
    public string ID, N1, N2, N3, C1, C2, C3, Event, TN;
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Request.QueryString["ID"];
        N1 = Request.QueryString["N1"];
        N2 = Request.QueryString["N2"];
        N3 = Request.QueryString["N3"];
        C1 = Request.QueryString["C1"];
        C2 = Request.QueryString["C2"];
        C3 = Request.QueryString["C3"];
        Event = Request.QueryString["Event"];
        TN = Request.QueryString["TN"];
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}