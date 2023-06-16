<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminReports.aspx.cs" Inherits="AdminReports" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <title>Admin Reports</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align:center">
     <div class="navbar" style="box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);">
        <a class="active" href="Home.aspx"><b>Home</b></a>
        <div class="dropdown">
            <button class="dropbtn"><b>Login</b></button>
            <div class="dropdown-content">
                <a href="StudentLogin.aspx">Executive Student</a>
                <a href="MentorLogin.aspx">Faculty Mentor </a>
            </div>
        </div>
        <a href="Home.aspx#Events"><b>Events</b></a>
        <a href="Home.aspx#Contact"><b>Contact</b></a>
        <a href="Home.aspx#About"><b>About</b></a>
        <img src="HeadImage.jpeg" alt="logo" style="height:50px; width:50px; float: right; padding-right:30px"/>
    </div>

    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>

    <div style="text-align:center">
        <img src="Logo.png" alt ="logo"/>
        <br />
        <p style="font-size:x-large; font-family:Garamond; color:#262626">
            <b>WHERE TALENT MEETS OPPORTUNITY</b>
        </p>
    </div>
    <br />
    <br />

    <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>Admin Reports</b></h1>

    

    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:DropDownList ID="DropDownList1"  runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>List all Registered Participants and their information</asp:ListItem>
                <asp:ListItem>Total amount collected by sponsors for each category</asp:ListItem>
                <asp:ListItem>List of events and their information</asp:ListItem>
                <asp:ListItem>List of all the Faculty Mentors</asp:ListItem>
                <asp:ListItem>List of all Student Executives</asp:ListItem>
                <asp:ListItem>List of sponsors and their information</asp:ListItem>
                <asp:ListItem>Search specific participant by Name or Unique ID</asp:ListItem>
                <asp:ListItem>List of those participants who have registered for food deal</asp:ListItem>
                <asp:ListItem>List of events on a particiular date</asp:ListItem>
                <asp:ListItem>Total Registrations in a particular event</asp:ListItem>
                <asp:ListItem>Details of an event</asp:ListItem>
                <asp:ListItem>Audit Log</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <p style="font-size:x-small; color:red"><%=msg %></p>
        <p style="font-size:x-small; color:green"><%=goodmsg %></p>
        <asp:Button ID="Button1" CssClass="BtnClass" runat="server" Text="Search" OnClick="Button1_Click" />

        <br />
        <br />

        <b><%=result %></b>
        <asp:DropDownList ID="DropDownList2" runat="server" Visible = "false" Enabled ="false">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Electrical Engineering</asp:ListItem>
            <asp:ListItem>Computer Science</asp:ListItem>
            <asp:ListItem>Business</asp:ListItem>
            <asp:ListItem>Socail</asp:ListItem>
            <asp:ListItem>Sports</asp:ListItem>
            <asp:ListItem>All</asp:ListItem>
        </asp:DropDownList>
        <br />
       <p style="font-size:x-small; color:red"> <%=msg2 %></p>
        <asp:Button ID="Button2" CssClass="BtnClass" runat="server" Text="Search" Visible ="false" Enabled ="false" OnClick="Button2_Click"/>
        <asp:Button ID="Button3" CssClass="BtnClass" runat="server" Text="Search" Visible ="false" Enabled="false" OnClick="Button3_Click" />
        <b><%=result2 %></b>
        <asp:DropDownList ID="DropDownList3" runat="server" Visible="false" Enabled="false">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>By Event</asp:ListItem>
            <asp:ListItem>By Category</asp:ListItem>
            <asp:ListItem>By Management Department</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button4" CssClass="BtnClass" runat="server" Text="Search" Visible ="false" Enabled="false" OnClick="Button4_Click"/>

        <asp:DropDownList ID="DropDownList4" runat="server" Visible="false" Enabled="false">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Search Name</asp:ListItem>
            <asp:ListItem>Search ID</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" Visible ="false" Enabled="false" required ="true"></asp:TextBox>
        <asp:Button ID="Button5" CssClass="BtnClass" runat="server" Text="Search" Visible="false" Enabled="false" OnClick="Button5_Click"/>
        <asp:Button ID="Button7" CssClass="BtnClass" runat="server" Text="Search" Visible="false" Enabled="false" OnClick="Button7_Click"/>
        <asp:Button ID="Button8" CssClass="BtnClass" runat="server" Text="Search" Visible="false" Enabled="false" OnClick="Button8_Click" />
        <br /><br />
        <%=result3 %>
        <div style="margin-left:40%">
        <asp:Calendar ID="Calendar1" runat="server" Visible ="false" Enabled="false"></asp:Calendar>
        </div>
        <br />
        <asp:Button ID="Button6" CssClass="BtnClass" runat="server" Text="Search" Visible="false" Enabled="false" OnClick="Button6_Click"/>

        <br /><br />

        <asp:GridView ID="GridView1" runat="server" Width="100%"></asp:GridView>
        
    </form>

    <br /><br /><br /><br />
</body>
</html>
