using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FacultyPortal : System.Web.UI.Page
{
    public string ID = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Request.QueryString["ID"];
    }
}