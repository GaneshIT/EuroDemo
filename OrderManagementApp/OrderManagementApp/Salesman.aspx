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
                    <td>Salesman name</td>
                    <td>
                        <asp:TextBox ID="txtSalesmanname" runat="server" Font-Bold="True" Font-Italic="True"></asp:TextBox>
                        <asp:Label ID="lblSalesmanid" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Salesman city</td>
                    <td>
                        <asp:TextBox ID="txtSalesmancity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Salesman commission</td>
                    <td>
                        <asp:TextBox ID="txtSalesmancommision" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="Update" />
                        <asp:Button ID="btnorderentry" runat="server" OnClick="btnorderentry_Click" Text="Order Entry" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />                      
                    </td>
                </tr>
                <tr>
                    <td></td><td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
            <div>
                <asp:GridView ID="gvSalesmanDetails" runat="server" AutoGenerateColumns="false" OnRowCommand="gvSalesmanDetails_RowCommand" OnRowDeleting="gvSalesmanDetails_RowDeleting" OnRowEditing="gvSalesmanDetails_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="salesman_id" HeaderText="Salesman Id" />
                        <asp:BoundField DataField="name" HeaderText="Salesman Name" />
                        <asp:BoundField DataField="city" HeaderText="City" />
                        <asp:BoundField DataField="commission" HeaderText="Commission" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("salesman_id") %>'>Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("salesman_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <br />
            </div>
            
        </div>
    </form>
</body>
</html>


<%--
    webpage.html
    webpage.aspx

    conversation logic
--%>








