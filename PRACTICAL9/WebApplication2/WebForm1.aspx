<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txt2"
            runat="server"></asp:TextBox><asp:Button ID="btn1" runat="server" Text="+" 
            onclick="btn1_Click" />
        <asp:Button
                ID="btn2" runat="server" Text="-" onclick="btn2_Click" />
        <asp:Button runat="server"
                    Text="*" onclick="Unnamed1_Click" style="width: 19px" />
        <asp:Button ID="btn4" runat="server" Text="/" onclick="btn4_Click" 
            style="width: 18px" />
        <asp:Label
                        ID="lblresult" runat="server" Text="Label"></asp:Label></div>
    </form>
    </body>
</html>
