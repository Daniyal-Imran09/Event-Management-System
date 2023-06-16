<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamEvent.aspx.cs" Inherits="TeamEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Registration - Team </title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align:center; background-image:url('TeamBG.jpeg'); background-repeat:no-repeat; background-size:cover">
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
        <div>
            <h1>Event Registration - <%=eventname %></h1>
        </div>
        
        <div style =" margin-right:800px; text-align:right">
        <p>
            &nbsp;
         <b> <asp:Label ID="Label1" runat="server" Text="Team Name"></asp:Label></b> 
            <asp:TextBox ID="TextBox4" runat="server" required="required"></asp:TextBox></p>
        <p>

            <b><asp:Label ID="Label2" runat="server" Text="Institute Name"></asp:Label></b>
        
            <asp:TextBox ID="TextBox1" runat="server" required="required" ></asp:TextBox>
        </p>
        <p>
            <b> <asp:Label ID="Label5" runat="server" Text="Ambassador Name"></asp:Label></b>
        
    
        <asp:TextBox ID="TextBox5" runat="server" required="required"></asp:TextBox>
     </p>
        <p>      
            <b> <asp:Label ID="Label6" runat="server" Text="Ambassador Contact"></asp:Label></b>
        
    
        <asp:TextBox ID="TextBox6" runat="server" required="required"></asp:TextBox>
       </p>    
        <p>      
    <b> <asp:Label ID="Label9" runat="server" Text="Team Member 1 Name"></asp:Label></b>
        
    
        <asp:TextBox ID="TextBox9" runat="server" required="required"></asp:TextBox>
     </p>       
             <b> <asp:Label ID="Label10" runat="server" Text="Team Member 1 Email"></asp:Label></b>
   
        <asp:TextBox ID="TextBox10" runat="server" required="required"></asp:TextBox>
      <p>      
             <b> <asp:Label ID="Label11" runat="server" Text="Team Member 1 Cnic"></asp:Label></b>
    
        <asp:TextBox ID="TextBox11" runat="server" required="required"></asp:TextBox>
      </p>  
            <p> Team Member 1 Contact <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></p>
             <b> <asp:Label ID="Label12" runat="server" Text="Team Member 2 Name"></asp:Label></b>
    
        <asp:TextBox ID="TextBox12" runat="server" required="required"></asp:TextBox>
      <p>       
             <b> <asp:Label ID="Label13" runat="server" Text="Team Member 2 Email"></asp:Label></b>
   
        <asp:TextBox ID="TextBox13" runat="server" required="required"></asp:TextBox>
     </p>      
             <b> <asp:Label ID="Label14" runat="server" Text="Team Member 2 Cnic"></asp:Label></b>
   
        <asp:TextBox ID="TextBox14" runat="server" required="required"></asp:TextBox>
            <p>Team Member 2 Contact <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></p>
      <p>      
            <b> <asp:Label ID="Label15" runat="server" Text="Team Member 3 Name"></asp:Label></b>
    
        <asp:TextBox ID="TextBox15" runat="server" required="required"></asp:TextBox>
     </p>       
            <b> <asp:Label ID="Label16" runat="server" Text="Team Member 3 Email"></asp:Label></b>
    
        <asp:TextBox ID="TextBox16" runat="server" required="required"></asp:TextBox>
            
     <p>       <b> <asp:Label ID="Label17" runat="server" Text="Team Member 3 Cnic"></asp:Label></b>
    
        <asp:TextBox ID="TextBox17" runat="server" required="required"></asp:TextBox>
            </p>
            <p>Team Member 3 Contact <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></p>
            <p>
                Food Registration:
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>3 burgers, fries and 3 drinks for Rs 1200</asp:ListItem>
                    <asp:ListItem>4 burgers, fries and 4 drinks for Rs 1500</asp:ListItem>
                    <asp:ListItem>1 burger, fries and 1 drink for Rs 500</asp:ListItem>
                </asp:DropDownList>

            </p>
           
   </div>
        <p style="font-size:x-small; color:red"><%=msg %></p>
        <asp:Button ID="Button1" class="BtnClass" runat="server" Text="Register" OnClick="Button1_Click" />
    </form>

     <div style="border-top:solid 2px black; background-color:grey; color:white; width:100%; padding-top:25px">
        <div style="margin-left:75px; text-align:left">
            <img src="globeicon.jpeg" alt="globe icon" style="height:20px; width:20px" />
            https://nu.edu.pk

        </div>
        <br />
            <br />
        <br />
            <br />
    </div>

    </body>
</html>
