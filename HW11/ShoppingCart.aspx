<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 528px; width: 1145px">
    <form id="form1" runat="server">
    <div style="height: 528px; width: 1140px">
    
        <asp:Label ID="lbId" runat="server" Text="Id:"></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" Text="Search" />
        <br />
        <asp:Label ID="lbInfo" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbFirstName" runat="server" Text="First Name:"></asp:Label>
      
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
      
        <br />
        <br />
        <asp:Label ID="lbLastName" runat="server" Text="Last Name:"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbUserName" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbPassword" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbPhone" runat="server" Text="Phone:"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbCreatedDate" runat="server" Text="CreatedDate:"></asp:Label>
        <asp:TextBox ID="txtCreatedDate" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
    
    </div>
    </form>
</body>
</html>
