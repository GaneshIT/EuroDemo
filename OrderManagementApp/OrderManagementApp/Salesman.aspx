<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="OrderManagementApp.Salesman" %>

<!DOCTYPE html>
<%--html5--%>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%--Design--%>
    <form id="form1" runat="server">
        <div>            
            <table>
                <tr>
                    <td>Salesman name</td><td>
                        <asp:TextBox ID="txtSalesmanname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman city</td><td>
                        <asp:TextBox ID="txtSalesmancity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman commission</td><td>
                        <asp:TextBox ID="txtSalesmancommision" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" />
                             </td>
                </tr>
            </table>
            <table>
                <thead>
                    <tr>
                        <th>Salesman Id
                        </th>
                        <th>Salesman name
                        </th>
                        <th>Salesman city
                        </th>
                        <th>Salesman commission
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>abc</td>
                        <td>Blr</td>
                        <td>100</td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>abc</td>
                        <td>Blr</td>
                        <td>100</td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>abc</td>
                        <td>Blr</td>
                        <td>100</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>


<%--
    webpage.html
    webpage.aspx

    conversation logic
--%>








