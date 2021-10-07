<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="OrderManagementApp.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Customer name</td>
                    <td>
                        <asp:TextBox ID="txtCustomername" runat="server" Font-Bold="True" Font-Italic="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Customer city</td>
                    <td>
                        <asp:TextBox ID="txtCustomercity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Grade</td>
                    <td>
                        <asp:TextBox ID="txtGrade" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td>Salesman Id</td><td>
                    <asp:DropDownList ID="ddlSalesmanid" runat="server">
                    </asp:DropDownList></td></tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"  />                      
                    </td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
