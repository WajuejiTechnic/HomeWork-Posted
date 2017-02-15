<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 601px; width: 1119px;">
    <form id="form1" runat="server">
    <div style="height: 596px; width: 1134px;">
    
        <asp:Label ID="Label1" runat="server" Text="Id: "></asp:Label>
        <asp:TextBox ID="txtId" runat="server" Height="22px"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
        <br />
        <asp:Label ID="lblInfo" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Wrap="False"></asp:TextBox>
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
        <asp:Label ID="lbIsActive" runat="server" Text="IsActive:"></asp:Label>
&nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="0">No</asp:ListItem>
            <asp:ListItem Value="1">Yes</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Label ID="lbCreatedDate" runat="server" Text="CreatedDate:"></asp:Label>
        <asp:TextBox ID="txtCreatedDate" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblEmail" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
    
    </div>
    </form>
</body>
</html>
