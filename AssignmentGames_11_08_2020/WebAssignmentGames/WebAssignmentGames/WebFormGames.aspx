<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormGames.aspx.cs" Inherits="WebAssignmentGames.WebFormGames" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="A" OnCheckedChanged="RadioButton1_CheckedChanged" Text="CricketPlayers" />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="A" OnCheckedChanged="RadioButton2_CheckedChanged" Text="TenisPlayers" />
        <asp:Panel ID="Panel1" runat="server" Height="181px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HtmDhoni.html">Dhoni</asp:HyperLink>
            &nbsp;<br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/HtmlKohali.html">Kohali</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/HtmlBumrah.html">Bumarah</asp:HyperLink>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="222px">
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/HtmlMirza.html">Mirza</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/HtmlNadal.html">Nadal</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/HtmlMartina.html">Martina</asp:HyperLink>
        </asp:Panel>
    </form>
</body>
</html>
