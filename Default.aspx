<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        .formclass {
        padding:20px;
        margin: 0px auto;
        background:#fff;
        width:200px;
        }
        h2{
            text-align:center;
        }
        .input
        {
            padding:2px;
            }
        body{
            background:#ccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="formclass">
        <h2>Đăng nhập</h2>
        <asp:TextBox ID="txtUser" CssClass="input" placeholder="User Name" runat="server" Width="163px"></asp:TextBox><br /> <br />
        
        <asp:TextBox ID="txtPass" CssClass="input" placeholder="Password" TextMode="Password" 
            runat="server" Width="160px"></asp:TextBox> <br /> <br />
        <asp:Button ID="btDangnhap" runat="server" Text="Đăng nhập" Height="38px" Width="129px" OnClick="btDangnhap_Click" />
    </div>
    </form>
</body>
</html>
