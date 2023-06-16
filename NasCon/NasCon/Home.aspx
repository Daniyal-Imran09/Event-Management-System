<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NasCon - Home</title>
    <link rel="icon" type="image/x-icon" href="HeadImage.jpeg"/>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="background-image:url('back.png');background-repeat:no-repeat;background-size:cover">

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
    <section id="Events">
    <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>Events</b></h1>

    <div style="background-color:rgba(256,256,256,0.6)">
        <table style="width:100%;padding:20px; text-align:center">
            <tr>
                <td>
                    <div class="image-button">
                        <a href="Events.aspx?click=EE" style=" font-size:xx-large; width:100%">
                            <img src ="EE.jpg"; alt="EE image" style="height:350px; width:450px"/>
                            <br />
                            <div style=" position: absolute; bottom: 8px; left: 16px ;color:lightseagreen; background-color:rgba(256,256,256,0.9); width:inherit; box-shadow:  0px 8px 16px 0px rgba(0,0,0,0.2);text-shadow: 1px 1px 2px #000000;">Electrical Engineering</div>
                        </a>
                    </div>
                </td>
                <td>
                    <div class="image-button">
                        <a href="Events.aspx?click=CS" style=" font-size:xx-large;width:100%">
                            <img src ="CS.jfif" style="height:350px; width:450px"/>
                            <br />
                            <div style=" position: absolute; bottom: 8px; left: 16px ;color:red; background-color:rgba(256,256,256,0.9); width:inherit; box-shadow:  0px 8px 16px 0px rgba(0,0,0,0.2);text-shadow: 1px 1px 2px #000000;">Computer Science</div>
                        </a>
                    </div>
                </td>
                <td>
                    <div class="image-button">
                        <a href="Events.aspx?click=Business" style=" font-size:xx-large; width:100%">
                            <img src ="Business.jfif" style="height:350px; width:450px" />
                            <br />
                            <div style=" position: absolute; bottom: 8px; left: 16px ;color:deepskyblue; background-color:rgba(256,256,256,0.9); width:inherit; box-shadow:  0px 8px 16px 0px rgba(0,0,0,0.2);text-shadow: 1px 1px 2px #000000;">Business</div>
                        </a>
                    </div>
                </td>
            </tr>
        </table>

        <table style="width:100%;padding:20px; text-align:center">
            <tr>
                <td>
                    <div class="image-button">
                        <a href="Events.aspx?click=Social" style=" font-size:xx-large; width:100%">
                            <img src ="social.jpg" style="height:350px; width:450px" />
                            <br />
                            <div style=" position: absolute; bottom: 8px; left: 16px ;color:firebrick; background-color:rgba(256,256,256,0.9); width:inherit; box-shadow:  0px 8px 16px 0px rgba(0,0,0,0.2);text-shadow: 1px 1px 2px #000000;">Social</div>
                        </a>
                    </div>
                </td>
                 <td>
                    <div class="image-button">
                        <a href="Events.aspx?click=Sports" style=" font-size:xx-large; width:100%">
                            <img src ="Sports.png" style="height:350px; width:450px" />
                            <br />
                            <div style=" position: absolute; bottom: 8px; left: 16px ;color:Highlight; background-color:rgba(256,256,256,0.9); width:inherit; box-shadow:  0px 8px 16px 0px rgba(0,0,0,0.2);text-shadow: 1px 1px 2px #000000;">Sports</div>
                        </a>
                    </div>
                </td>
            </tr>
        </table>
        
    </div>
    </section>
    <section id="About">
        <br />
        <h1 style="text-align:center; font-family:'Century Gothic'; color:rgb(185, 78, 176);text-shadow: 1px 1px 1px #000000; font-size:50px"><b>About</b></h1>

        <table style="width: 100%; background-color: rgba(256,256,256,0.6); font-size: larger; padding-top: 20px">
            <tr>
                <td style="padding-left: 75px; width: 50%; word-wrap: normal">National Solutions Convention is the flagship event of FAST-NU’s annual social calendar. It is a student-run mega event that has provided the best technological and industrial set of opportunities over the years. NaSCon welcomes an average of 7000 participants annually, representing institutions from all over Pakistan.
            <br />
                    <br />
                    A LEGACY OVER 2 DECADES
            <br />
                    For the past two decades, NaSCon has enriched the awareness amongst students and professionals alike, providing a forum for the exchange of ideas, an environment for the showcase of exceptional professional skill and a platform for innovation.
            <br />
                    <br />
                    OUR MISSION
            <br />
                    NaSCon is primarily dedicated to bringing together and combining the mental prowess of students from all over the country, and putting it to good use. Apart from students, people from different organizations are also invited to attend the event and contribute to providing solutions for a sustainable future of Pakistan.
                </td>
                <td>
                    <img src="FAST Image.jfif" alt="FAST IMAGE" style="height: 300px; width: 600px" />
                </td>
            </tr>
        </table>

    </section>
    
    <br />
            <br />

    <section id="Contact">
        <div style="border-top: solid 2px black; background-color: grey; color: white; width: 100%; padding-top: 25px">
            <div style="margin-left: 75px">
                <p style="font-size:large"> <b>NasCon</b> (C)</p>
                <img src="globeicon.png" alt="globe icon" style="height: 20px; width: 20px" />
                <a href="https://nu.edu.pk" style="text-decoration:none; color:white">https://nu.edu.pk</a>
                <br />
                <img src="callicon.png" alt="call icon" style="height: 40px; width: 40px" />
                <p style="display:inline">
                +92 333 123456,
                +92 333 654321,
                +92 321 987654
                </p>
            </div>
            <br />
            <br />
            <br />
            <br />
        </div>
    </section>

    

    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
