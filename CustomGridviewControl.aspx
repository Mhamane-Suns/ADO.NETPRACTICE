<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomGridviewControl.aspx.cs" Inherits="CustomGridviewControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         
    <div style="font-family: Arial">
        <asp:Button ID="BGetData" runat="server" Text="GetData" OnClick="BGetData_Click" />
   
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ID" onrowediting="GridView1_RowEditing" 
        onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowdeleting="GridView1_RowDeleting" 
        onrowupdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" 
                SortExpression="Gender" />
            <asp:BoundField DataField="Marks" HeaderText="Marks" 
                SortExpression="TotalMarks" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="BUpdateDatabase" runat="server" Text="UpdateDatabase" OnClick="BUpdateDatabase_Click" />
    <asp:Label ID="LMessage" runat="server" Text="Label"></asp:Label>
        
    </div>
    </form>
</body>
</html>
