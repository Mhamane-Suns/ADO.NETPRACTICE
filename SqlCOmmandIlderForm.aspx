<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlCOmmandIlderForm.aspx.cs" Inherits="SqlCOmmandIlderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="align-content:center; text-align:center;">
        <table border="2">
            <tr>
                <td>
                    id
                </td>
                <td>
                    <asp:TextBox ID="TextId" runat="server" OnTextChanged="TextId_TextChanged" AutoPostBack="true"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Name</td>
                <td> <asp:TextBox ID="TextName" runat="server"  ></asp:TextBox></td>
            </tr>
            <tr>
                <td>Gender</td>
                <td><asp:DropDownList ID="ddlGender" runat="server">
                       <asp:ListItem Text="SelectGender" Value="-1"></asp:ListItem>
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female" ></asp:ListItem> 
                       </asp:DropDownList></td>
                </tr>
            <tr><td class="auto-style1">Marks</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextMarks" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr><td colspan="2"> <asp:Button ID="BUpdate" runat="server" Text="UPDATE" OnClick="BUpdate_Click" /></td></tr>
           
            <tr><td colspan="2"> <asp:Label ID="LMessage" runat="server" Text=""></asp:Label></td></tr>
  
        </table>
    <br />
        <table><tr><td>Insert</td><td>
            <asp:Label ID="LblInsert" runat="server" Text=""></asp:Label>
            </td></tr>

            <tr><td>Update</td><td>
            <asp:Label ID="LblUpdate" runat="server" Text=""></asp:Label>
            </td></tr>
            <tr><td>Delete</td><td>
            <asp:Label ID="LblDelete" runat="server" Text=""></asp:Label>
            </td></tr>
        </table>
    </div>
    </form>
</body>
</html>
