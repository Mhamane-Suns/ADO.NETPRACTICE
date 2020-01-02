<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowData.aspx.cs" Inherits="ShowData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="RGISTERATION FORM"></asp:Label>
        <br />
        <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Mobile"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Photo"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sava" />
        <asp:Button ID="Button2" runat="server" Text="Cancle" />
        <asp:Button ID="Button3" runat="server" Text="Update" />
        <br />
        <br />
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1163px" OnRowEditing="GridView1_RowEditing"  OnRowCommand="GridView1_RowCommand"  OnRowDeleting="GridView1_RowDeleting1"  OnRowUpdating="GridView1_RowUpdating">
        <AlternatingRowStyle BackColor="White" />
        <Columns>

            <asp:TemplateField HeaderText="Id" >
                <HeaderTemplate>
                    <asp:LinkButton ID ="lnId" runat="server" Text="Id"  CommandName="sort" CommandArgument="Id"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="lId" runat="server" Text='<%#Bind("Id") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tId" runat="server" Text='<%#Bind("Id") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tnId" runat="server" Text='<%#Bind("Id") %>'></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
        

            <asp:TemplateField HeaderText="NAME" >
                <HeaderTemplate>
                    <asp:LinkButton ID ="lnname" runat="server" Text="Name"  CommandName="sort" CommandArgument="Name"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="lname" runat="server" Text='<%#Bind("Name") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tname" runat="server" Text='<%#Bind("Name") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tnname" runat="server" Text='<%#Bind("Name") %>'></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
        
            
            <asp:TemplateField HeaderText="Contact" >
                <HeaderTemplate>
                    <asp:LinkButton ID ="lnContact" runat="server" Text="Contact"  CommandName="sort" CommandArgument="Contact"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="lContact" runat="server" Text='<%#Bind("Contact") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="tContact" runat="server" Text='<%#Bind("Contact") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tnContact" runat="server" Text='<%#Bind("Contact") %>'></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
        
            <asp:TemplateField HeaderText="impath" >
                <HeaderTemplate>
                    <asp:LinkButton ID ="lnimpath" runat="server" Text="Contact"  CommandName="sort" CommandArgument="impath"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="limpath" runat="server" Text='<%#Bind("impath") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="timpath" runat="server" Text='<%#Bind("impath") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="tnimpath" runat="server" Text='<%#Bind("impath") %>'></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
                <asp:TemplateField HeaderText="Edit/Delete">
             <ItemTemplate>
                 <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" ></asp:LinkButton>
              <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete" ></asp:LinkButton>
             </ItemTemplate>
                <EditItemTemplate> <asp:LinkButton ID="lnkUpadte" runat="server" Text="Upadte" CommandName="Update" ></asp:LinkButton>
                     <asp:LinkButton ID="lnkCancle" runat="server" Text="Cancle" CommandName="Cancel" ></asp:LinkButton>
                </EditItemTemplate>
               <FooterTemplate>
                <asp:LinkButton ID="lnkSave" runat="server" Text="Save" CommandName="Insert" ></asp:LinkButton>
               </FooterTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>

        <br />
    </div>
    </form>
</body>
</html>
