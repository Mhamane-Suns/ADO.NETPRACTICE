<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>  
            <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">  
                <Columns>  
                    <asp:BoundField DataField="EmpNo" HeaderText="EmpId" />  
                    <asp:BoundField DataField="EmpName" HeaderText="EmpName" />  
                    <asp:BoundField DataField="Job" HeaderText="Job" />  
                    <asp:BoundField DataField="Sal" HeaderText="EmpSalary" />  
                    <asp:BoundField DataField="Dept" HeaderText="Department" />  
                    <asp:TemplateField>  
                        <ItemTemplate>  
                            <asp:Button ID="btnEdit" runat="server" Width="60" Text="Edit" CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />  
                        </ItemTemplate>  
                    </asp:TemplateField>  
                     <asp:TemplateField>  
                        <ItemTemplate>  
                            <asp:Button ID="btnDelete" runat="server" Width="60" Text="Delete" CommandName="DeleteButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />  
                        </ItemTemplate>  
                    </asp:TemplateField>  
                </Columns>  
            </asp:GridView>  
        </div>  
    </div>
    </form>
</body>
</html>
