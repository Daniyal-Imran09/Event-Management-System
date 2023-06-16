<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteSponsor.aspx.cs" Inherits="DeleteSponsor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Delete - Admin </title>
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

    <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>Delete Sponsor</b></h1>

    <br /><br />


    <form id="form1" runat="server">
        Enter Sponsor Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        

        
        <asp:Button ID="Button3" CssClass="BtnClass" runat="server" Text="Search" OnClick="Button3_Click"/>
        <div style="margin-left: 10%; margin-right:10%; text-align:center">
            <asp:GridView ID="GridView1" runat="server" Width="100%"></asp:GridView>
        </div>
        <p style="font-size:x-small; color:red"><%=msg %></p>
        <p style="font-size:x-small; color:green"><%=goodmsg %></p>
        <br />

        
        <asp:Button ID="Button4" runat="server" CssClass="BtnClass" Text="Delete" Visible="false" OnClick="Button4_Click"/>

    </form>
</body>
</html>
