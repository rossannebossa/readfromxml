<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SongForm.aspx.cs" Inherits="BrokenSocialScene.SongForm" %>

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
                    <td>Song</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Album</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Track</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th>
                        <asp:Button ID="Button1" Text="Submit" OnClick="Button1_Click" runat="server" />
                    </th>
                </tr>
            </table>

            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    Song<%#DataBinder.Eval(Container.DataItem,"song") %>
                    Album<%#DataBinder.Eval(Container.DataItem,"album") %>
                    Track<%#DataBinder.Eval(Container.DataItem,"track") %>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
