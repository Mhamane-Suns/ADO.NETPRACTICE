<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClearCacheForm.aspx.cs" Inherits="ClearCacheForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CLEARDATA" />
        <asp:button runat="server" text="LOADDATA" OnClick="Unnamed1_Click" ID="Button2" />

        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" /> 
        </asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SpGetData.aspx">HyperLink</asp:HyperLink>
 
  
    </form>
</body>
</html>
