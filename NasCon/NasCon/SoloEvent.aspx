<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SoloEvent.aspx.cs" Inherits="SoloEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>Registration - Solo</title>
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

    <form id="form1" runat="server">
         <!--nascon logo-->  

    <!--Welcome text -->
     <div style="text-align:center">
         <h1>Event Registration - <%=eventname %></h1>
     </div>

        <table style="width:100%;padding:75px; text-align:right">
            <tr>
                <td>
                    <h5>
                        Participant Name
                    <asp:TextBox ID="TextBox9" runat="server" required="required"></asp:TextBox>

                    </h5>
                </td>
                <td>
                    <h5>
                        Participant Email
                    <asp:TextBox ID="TextBox2" runat="server" required="required"></asp:TextBox>
                        </h5>
                </td>
                <td rowspan="5" ;style="width:50%; text-align:right">
                    <img src="Sports.png" style="padding-left:100px"/>
                </td>
            </tr>
            <tr>
                <td>
                     <h5>
                         Participant Cnic
                     <asp:TextBox ID="TextBox3" runat="server" required="required"></asp:TextBox>
                         </h5>
                </td>
                <td>
                    <h5>
                        Participant Contact no:
                    <asp:TextBox ID="TextBox4" runat="server" required="required"></asp:TextBox>
                        </h5>
                </td>
            </tr>
            <tr>
                <td>
                    <h5>
                        Institue Name
                     <asp:TextBox ID="TextBox5" runat="server" required="required"></asp:TextBox>
                        </h5>
                </td>
                <td>
                     <h5>
                         Food Registration:
                         <asp:DropDownList ID="DropDownList1" runat="server">
                             <asp:ListItem>Select</asp:ListItem>
                             <asp:ListItem>3 burgers, fries and 3 drinks for Rs 1200</asp:ListItem>
                             <asp:ListItem>4 burgers, fries and 4 drinks for Rs 1500</asp:ListItem>
                             <asp:ListItem>1 burger, fries and 1 drink for Rs 500</asp:ListItem>
                         </asp:DropDownList>
                         </h5>
                    
                </td>
            </tr>
            <tr>
                <td>

                </td>
                <td style="padding-left:10px">
                    <p style="font-size:x-small; color:red"><%=msg %></p>
                    <asp:Button class="BtnClass" ID="Button1"  runat="server" Text="Register" OnClick="Button1_Click"/>
                </td>

            </tr>
        </table>
        

        <br />
        <br />

        

        
         <br /><br /><br />
         
      <div style="border-top:solid 2px black; background-color:grey; color:white; width:100%; padding-top:25px">
        <div style="margin-left:75px">
            <img src="globeicon.jpeg" alt="globe icon" style="height:20px; width:20px" />
            https://nu.edu.pk

        </div>
        <br />
            <br />
        <br />
            <br />
    </div>
       
    </form>
</body>
</html>
