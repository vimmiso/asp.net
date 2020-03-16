<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tweet.aspx.cs" Inherits="twitt2.tweet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 408px; margin-left: 137px; margin-right: 320px;">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            
           

            &nbsp;</p>
        <p style="font-size:large">
            You can make new comments...</p>
        <p style="margin-left: 440px">
            Name<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 15px"></asp:TextBox>
        </p>
        <p style="margin-left: 440px">
            Comment<asp:TextBox ID="TextBox2" runat="server" Height="50px" style="margin-left: 15px" TextMode="MultiLine" Width="162px"></asp:TextBox>
        </p>
        <div style="margin-left: 440px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tweet" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p class="style7">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <hr />
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("name") %>'/>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("time") %>'/>
                    <br />
                    <div  runat="server" style="color:lightslategrey" innerText='<%#Eval("tweet_content") %>'></div>
                    <div>
                        <asp:Label ID="Label3" runat="server"  Text='0'/>
                        <asp:Button ID="Button4" runat="server" Text="Likes" disabled />
                   
                        <asp:Button ID="Button5" runat="server" Text="comment" disabled />
                    </div>
                    
         
                    </ItemTemplate>
            </asp:Repeater>
        </p>
        <p>
            
           

            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
