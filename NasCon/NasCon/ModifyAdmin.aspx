<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModifyAdmin.aspx.cs" Inherits="ModifyAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Admin</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align:center">
     <div class="navbar" style="box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);">
        <a class="active" href="Home.aspx"><b>Home</b></a>
        <div class="dropdown">
            <button class="dropbtn"><b>Login</b></button>
            <div class="dropdown-content">
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

    <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>Modify Admin</b></h1>

    <form id="form1" runat="server">
        Admin ID to Modify
        <asp:TextBox ID="TextBox1" runat="server" required="required"></asp:TextBox>
        <br />
        <br />

        <table style="width:100%">
        <tr>
            <td>
                Name
                <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
            </td>
            <td>
                Email
                <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
            </td>
            <td>
                Password
                <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
            </td>
        </tr>
    </table>
        <br />
         <p style="font-size:x-small; color:green"><%=goodmsg %></p>
        <p style="font-size:x-small; color:red"><%=msg %></p>
        <asp:Button ID="Button1" CssClass="BtnClass" runat="server" Text="Update" OnClick="Button1_Click"/>
    </form>
</body>
</html>
