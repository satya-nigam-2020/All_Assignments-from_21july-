<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConnectedObjects.aspx.cs" Inherits="WebDataAccessDemo.ConnectedObjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="224px" Width="309px">
            </asp:GridView>
            <br />
            <br />
            EmpId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtEmp" runat="server" Width="178px"></asp:TextBox>
            <br />
&nbsp;&nbsp;
            <br />
            EmpName<asp:TextBox ID="TxtEmpNane" runat="server" style="margin-left: 58px" Width="188px"></asp:TextBox>
            <br />
            <br />
            EmpSalary<asp:TextBox ID="TxtSal" runat="server" Height="20px" OnTextChanged="TxtSal_TextChanged" style="margin-left: 68px" Width="177px"></asp:TextBox>
            <br />
            <asp:Button ID="BtnPara" runat="server" Height="36px" style="margin-left: 563px" Text="InsertUsingParameters" Width="158px" OnClick="BtnPara_Click" />
            <asp:Button ID="BtnIsp" runat="server" style="margin-left: 34px; margin-top: 0px" Text="InsertusingSp" Width="134px" OnClick="BtnIsp_Click" />
            <br />
            <asp:Button ID="txtUpdate" runat="server" OnClick="txtUpdate_Click" style="margin-left: 341px" Text="Update" Width="134px" />
            <br />
            <asp:Button ID="TxtButton" runat="server" OnClick="Button1_Click" style="margin-left: 97px" Text="InsrtValue" Width="137px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="DelBtnWithSp" runat="server" OnClick="DelBtnWithSp_Click" style="margin-left: 129px" Text="DelWithSp" Width="120px" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" style="margin-left: 131px" Text="Search Me" Width="121px" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
