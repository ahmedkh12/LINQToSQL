<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="LINQToSQL.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" ValidateRequestMode="Enabled"  TextMode="Number" ></asp:TextBox>
   

            &nbsp;<asp:Button ID="Button1" runat="server" Text="Get Student" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert Student" />
            &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="update" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="delete" />
            <br />
            <asp:Label ID="msg" runat="server"></asp:Label>
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" >
        </asp:GridView>
    </form>
</body>
</html>
