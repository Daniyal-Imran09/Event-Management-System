using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Admin2 : System.Web.UI.Page
{
    public string click;
    public string redirectInsert;
    public string redirectModify;
    public string redirectDelete;
    protected void Page_Load(object sender, EventArgs e)
    {
        click = Request.QueryString["click"];

        if (click == "Student")
        {
            redirectInsert = "Inserting.aspx";
            redirectModify = "ModifyStudent.aspx";
            redirectDelete = "DeleteStudent.aspx";
        }

        if (click == "Faculty")
        {
            redirectInsert = "Inserting2.aspx";
            redirectModify = "ModifyFaculty.aspx";
            redirectDelete = "DeleteFaculty.aspx";
        }

        if (click == "Event")
        {
            redirectInsert = "Inserting3.aspx";
            redirectModify = "ModifyEvent.aspx";
            redirectDelete = "DeleteEvent.aspx";
        }

        if (click == "Admin")
        {
            redirectInsert = "Inserting4.aspx";
            redirectModify = "ModifyAdmin.aspx";
            redirectDelete = "DeleteAdmin.aspx";
        }

        if (click == "Sponsor")
        {
            redirectInsert = "Sponsers.aspx";
            redirectModify = "ModifySponsor.aspx";
            redirectDelete = "DeleteSponsor.aspx";
        }
    }
}