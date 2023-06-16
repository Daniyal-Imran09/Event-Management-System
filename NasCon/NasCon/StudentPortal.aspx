<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentPortal.aspx.cs" Inherits="StudentPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Portal</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <div class="navbar" style="box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);">
        <a class="active" href="Home.aspx"><b>Home</b></a>
        <div class="dropdown">
            <button class="dropbtn"><b>Login</b></button>
            <div class="dropdown-content">
                <a href="StudentLogin.aspx">Executive Student</a>
                <a href="AdminLogin.aspx">Admin</a>
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

     <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>Student Portal</b></h1>

    <br />
     
    <table style="width:100%;padding:20px; text-align:center">
        <tr>
                <td>
                    <div class="image-button">
                        <a href="<%=redirect %>"" style=" font-size:xx-large; width:100%">
                            <img src ="Report.png" style="height:350px; width:450px" />
                            <br />
                            <div style=" position: absolute; bottom: 8px; color:orange; background-color:rgba(256,256,256,0.9); width:inherit; box-shadow:  0px 8px 16px 0px rgba(0,0,0,0.2);text-shadow: 1px 1px 2px #000000;">Reports</div>
                        </a>
                    </div>
                </td>
        </tr>
    </table>

    <br />
    <br />

    <form id="form1" runat="server">
        <div>
            
        </div>
    </form>
</body>
</html>



