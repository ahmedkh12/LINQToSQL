<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="LINQToSQL.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="259px" HorizontalAlign="Left" Width="812px">
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="std_id" runat="server" TextMode="Number" Width="54px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Student" />
                <br />
                <br />
                Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="std_name" runat="server" BorderColor="#669900"></asp:TextBox>
                <br />
                <br />
                Gander&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="std_gander" runat="server" BorderColor="#669900"></asp:TextBox>
                <br />
                <br />
                Total Marks
                <asp:TextBox ID="std_totalmarks" runat="server" BorderColor="#669900"></asp:TextBox>
                <br />
                <br />
                Class ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="text_class" runat="server" BorderColor="#669900"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btn_insert" runat="server" OnClick="btn_insert_Click" style="height: 26px" Text="Insert" />
                &nbsp;<asp:Button ID="btn_update" runat="server" Height="26px" OnClick="btn_update_Click" Text="Update" />
                &nbsp;<asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="Delete" />
                <br />
            </asp:Panel>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Panel ID="Panel2" runat="server" Height="429px">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem>male</asp:ListItem>
                <asp:ListItem>female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
