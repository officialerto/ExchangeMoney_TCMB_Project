<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExchangeMoney_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            height: 497px;
        }
        .auto-style7 {
            height: 75px;
            text-align: center;
        }
        .auto-style8 {
            width: 1474px;
            height: 75px;
            text-align: center;
        }
        .auto-style9 {
            height: 452px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
        .auto-style11 {
            width: 1474px;
            height: 76px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 389px">
    <form id="form1" runat="server">
        <div class="auto-style9">

            <table class="auto-style3">

                <tr>
                    <td class="auto-style8"><asp:Label ID="Label1" runat="server" Text="DÖVİZ ALIŞ" Font-Bold="True" Font-Size="X-Large" ForeColor="#33CC33"></asp:Label></td>
                    <td class="auto-style8"><asp:Label ID="Label7" runat="server" Text="DÖVİZ SATIŞ" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label></td>
                </tr>

                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Lbdalis" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Lbdsatis" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Lbealis" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Lbesatis" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style7" colspan="2">
                        <asp:Button ID="Button1" runat="server" BorderColor="#993300" Font-Bold="True" Font-Size="X-Large" Height="42px" OnClick="Button1_Click" Text="Güncelle" Width="250px" />
                    </td>
                </tr>

                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="PARAM            : "></asp:Label>
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style10" OnTextChanged="TextBox5_TextChanged" Width="208px"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style10" Width="208px"></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style10" Width="208px"></asp:TextBox>
                    </td>
                </tr>

            </table>

        </div>
    </form>
    <p>
        **Kur Değerleri Anlık Olarak TCMB&#39;den Güncellenmektedir!</p>
</body>
</html>
