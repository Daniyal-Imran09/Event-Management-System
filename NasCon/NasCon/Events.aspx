<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Events.aspx.cs" Inherits="Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Events</title>
    <link  rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
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
        <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b><%=category %></b></h1>    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Width="100%" SelectedIndex="0" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
        </div>
    </form>
</body>
</html>
