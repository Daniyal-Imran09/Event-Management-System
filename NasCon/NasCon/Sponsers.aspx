<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sponsers.aspx.cs" Inherits="Sponsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NasCon - Home</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
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

    <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>Register Sponser</b></h1>

    <br /><br />

    <form id="form1" runat="server">
        <div style="text-align:center">
            <table style="width:100%">
        <tr>
            <td>
                Company Name
                <asp:TextBox ID="TextBox1" runat="server" required="required"></asp:TextBox>
            </td>
            <td>
                Representative Name
                <asp:TextBox ID="TextBox2" runat="server" required="required"></asp:TextBox>
            </td>
            <td>
                Representative CNIC
                <asp:TextBox ID="TextBox3" runat="server" required="required"></asp:TextBox>
            </td>
            <td>
                Category
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Electrical Engineering</asp:ListItem>
                    <asp:ListItem>Computer Science</asp:ListItem>
                    <asp:ListItem>Business</asp:ListItem>
                    <asp:ListItem>Social</asp:ListItem>
                    <asp:ListItem>Sports</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                Package
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Bronze (25,000 PKR)</asp:ListItem>
                    <asp:ListItem>Silver (60,000 PKR)</asp:ListItem>
                    <asp:ListItem>Gold (1,00,000 PKR)</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>
        <br /><br />
        <p style="font-size:x-small; color:red"><%=msg %></p>
            <p style="font-size:x-small; color:green"><%=goodmsg %></p>
        <asp:Button class="BtnClass" ID="Button1"  runat="server" Text="Register" OnClick="Button1_Click"/>

        </div>
    </form>
</body>
</html>
