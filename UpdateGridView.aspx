<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateGridView.aspx.cs" Inherits="UpdateGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>    
   <table>    
       <tr>    
           <td>EmpId</td>    
           <td>    
               <asp:TextBox ID="txtEmpId" runat="server" ReadOnly="true" />    
           </td>    
       </tr>    
       <tr>    
           <td>EmpName</td>    
           <td>    
               <asp:TextBox ID="txtEmpName" runat="server" />    
           </td>    
       </tr>    
       <tr>    
           <td>Job</td>    
           <td>    
               <asp:TextBox ID="txtJob" runat="server" />    
           </td>    
       </tr>    
       <tr>    
           <td>EmpSalary</td>    
           <td>    
               <asp:TextBox ID="txtEmpSalary" runat="server" />    
           </td>    
       </tr>    
       <tr>    
           <td>Department</td>    
           <td>    
               <asp:TextBox ID="txtDept" runat="server" />    
           </td>    
       </tr>    
       <tr>    
           <td >    
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />    
           </td>    
           <td >    
               <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />    
           </td>    
           <td>    
               <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />    
           </td>  
       </tr>    
   </table>    
</div>
    </div>
    </form>
</body>
</html>
