<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StockApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Company Listing"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="ListingCompany" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Check Stock" />
            <br />
            <br />
            <asp:Label ID="NameLabel" runat="server"></asp:Label>
            <br />
            <p>Current price: <asp:Label ID="CurrentPrice" runat="server"></asp:Label></p>
            <p>High price of the day: <asp:Label ID="HighPrice" runat="server"></asp:Label></p>
            <p>Low price of the day: <asp:Label ID="LowPrice" runat="server"></asp:Label></p>
            <br />
            
            
        </div>
    </form>
</body>
</html>
