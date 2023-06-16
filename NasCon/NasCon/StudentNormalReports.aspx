<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentNormalReports.aspx.cs" Inherits="StudentNormalReports" %>

<!DOCTYPE html>
<html>

<head runat="server">
    <title>Student Reports</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align:center">
     <div class="navbar" style="box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);">
        <a class="active" href="Home.aspx"><b>Home</b></a>
        <div class="dropdown">
            <button class="dropbtn"><b>Login</b></button>
            <div class="dropdown-content">
                <a href="AdminLogin.aspx">Admin</a>
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

    <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>Student Reports</b></h1>

    

    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:DropDownList ID="DropDownList1"  runat="server">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>List of events on a particiular date</asp:ListItem>
                <asp:ListItem>Details of an event</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <p style="font-size:x-small; color:red"><%=msg %></p>
        <p style="font-size:x-small; color:green"><%=goodmsg %></p>
        <asp:Button ID="Button1" CssClass="BtnClass" runat="server" Text="Search" OnClick="Button1_Click" />

        <br />
        <br />

        <b><%=result %></b>
        <br />
       <p style="font-size:x-small; color:red"> <%=msg2 %></p>
       <%=result2 %>
        <asp:TextBox ID="TextBox1" runat="server" Visible ="false" Enabled="false" required ="true"></asp:TextBox>
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
