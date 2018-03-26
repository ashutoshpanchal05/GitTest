<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration page.aspx.cs" Inherits="Proj1.Registeration_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        

        
        .classA {
            width:30%;
            float:left;
            height: 224px;
        }
        .classB {
            width:30%;
            float:left;
        }

          .classC {
            width:100%;
            float:none;
        }
        #GridView1 {
            flex-item-align:center;
            }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="classA">
        <asp:Label ID="Label1"  height="20px" runat="server" Text="ID"></asp:Label><br />
        <asp:Label ID="Label2" height="20px" runat="server" Text="First Name"></asp:Label><br />
        <asp:Label ID="Label3" height="20px" runat="server" Text="Last Name"></asp:Label><br />
        <asp:Label ID="Label4" height="20px" runat="server" Text="Email-ID"></asp:Label><br />
        <asp:Label ID="Label5" height="20px" runat="server" Text="Password"></asp:Label><br />
        <asp:Label ID="Label8" height="20px" runat="server" Text="Address"></asp:Label><br />
        <asp:Label ID="Label6" height="20px" runat="server" Text="State"></asp:Label><br />
        <asp:Label ID="Label7" height="20px" runat="server" Text="city"></asp:Label><br />
    </div>

        <div class="classB">
            <asp:TextBox ID="id" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="fname" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="lname" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="pass" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="addr" runat="server"></asp:TextBox><br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">Maharashtra</asp:ListItem>
                <asp:ListItem Value="2">Guj</asp:ListItem>
            </asp:DropDownList><br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="1">Pune</asp:ListItem>
                <asp:ListItem Value="2">Mumbai</asp:ListItem>
            </asp:DropDownList><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
            <asp:Button ID="Button2" runat="server" Text="Clear" /><br />


        </div>

        <div class="classC">
            <asp:GridView ID="GridView1" runat="server" Width="914px"></asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
