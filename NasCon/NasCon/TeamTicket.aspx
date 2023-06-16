<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamTicket.aspx.cs" Inherits="TeamTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Registration - Team </title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align:center;">
    <div class="navbar" style="box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);">
        <a class="active" href="Home.aspx"><b>Home</b></a>
        <div class="dropdown">
            <button class="dropbtn"><b>Login</b></button>
            <div class="dropdown-content">
                <a href="AdminLogin.aspx">Admin</a>
                <a href="StudentLogin.aspx">Executive Student</a>
                <a href="MentorLogin.aspx">Faculty Mentor</a>
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

    <div style="margin-left:10%;text-align:left">
        <p style="font-size:xx-large">Ticket for <b><%=Event %></b></p>
        <br />
        <br />
        <p style="font-size:larger">Team Name: <b><%= TN%></b></p>
        <br />
        <p style="font-size:x-large"><b>Member 1</b></p>
        <p style="font-size:larger">Name: <b><%= N1%></b></p>
        <p style="font-size:larger">CNIC: <b><%= C1%></b></p>
        <br />
        <p style="font-size:x-large"><b>Member 2</b></p>
        <p style="font-size:larger">Name: <b><%= N2%></b></p>
        <p style="font-size:larger">CNIC: <b><%= C2%></b></p>
        <br />
        <p style="font-size:x-large"><b>Member 3</b></p>
        <p style="font-size:larger">Name: <b><%= N3%></b></p>
        <p style="font-size:larger">CNIC: <b><%= C3%></b></p>
        <br />
        <p style="font-size:larger">Ticket Number: <b><%= ID%></b></p>
    </div>



    <form id="form1" runat="server">
        <div>
                <asp:Button ID="Button1" class="BtnClass" runat="server" Text="Home" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
