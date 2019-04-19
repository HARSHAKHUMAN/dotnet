<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lbla" runat="server" Text="A"></asp:Label>
    <asp:TextBox ID="txta" runat="server" style="width: 128px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txta" Display="Dynamic" 
        ErrorMessage="Please enter required number1" ForeColor="Red">*</asp:RequiredFieldValidator>
    <div>
    
        <asp:Label ID="lblb" runat="server" Text="B"></asp:Label>
        <asp:TextBox ID="txtb" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtb" Display="Dynamic" 
            ErrorMessage="Please enter required number2" ForeColor="Red">*</asp:RequiredFieldValidator>
    
    </div>
    <asp:Button ID="btn1" runat="server" onclick="btn1_Click" Text="+" />
    <asp:Button ID="btn2" runat="server" onclick="btn2_Click" Text="-" />
    <asp:Button ID="btn3" runat="server" onclick="btn3_Click" Text="*" />
    <asp:Button ID="btn4" runat="server" onclick="btn4_Click" Text="/" />
    <p>
        <asp:Label ID="lblresult" runat="server" Text="result"></asp:Label>
    </p>
    </form>
</body>
</html>
