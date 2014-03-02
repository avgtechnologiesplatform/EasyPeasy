<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="EasyPeasyWebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Calc.</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    A: =<asp:TextBox ID="txtA" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    B: = <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Op: <asp:DropDownList ID="ddlOp" runat="server">
                        <asp:ListItem Text="+" Value="0"></asp:ListItem>
                        <asp:ListItem Text="-" Value="1"></asp:ListItem>
                        <asp:ListItem Text="*" Value="2"></asp:ListItem>
                        <asp:ListItem Text="/" Value="3"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
        <asp:Button ID="btnSubmit" runat="server" UseSubmitBehavior="true" Text="Submit" />
        
        <asp:Literal ID="litResult" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
