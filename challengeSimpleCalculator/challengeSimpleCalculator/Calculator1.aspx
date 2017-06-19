<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator1.aspx.cs" Inherits="challengeSimpleCalculator.Calculator1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: Arial, Helvetica, sans-serif">
    
    
        <h1><strong>Simple Calculator</strong></h1>
        <br />
    
    
        First Value:&nbsp;&nbsp;
        <asp:TextBox ID="firstValuebox" runat="server"></asp:TextBox>
        <br />
        <br />
        Second Value:&nbsp;
        <asp:TextBox ID="secondValueBox" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;
        <asp:Button ID="addButton" runat="server" Text="+" OnClick="addButton_Click" Width="22px" />
        &nbsp;
        <asp:Button ID="subtractButton" runat="server" Text="-" OnClick="subtractButton_Click" Width="21px" />
        &nbsp;
        <asp:Button ID="multiplcationButton" runat="server" Text="*" OnClick="multiplcationButton_Click" Width="22px" />
        &nbsp;
        <asp:Button ID="divideButton" runat="server" Text="/" Width="20px" OnClick="divideButton_Click" />
        <br />
        <br />   
        <asp:Label ID="totalValue" runat="server" BackColor="#3399FF"></asp:Label>
    
       
    </form>
</body>
</html>
