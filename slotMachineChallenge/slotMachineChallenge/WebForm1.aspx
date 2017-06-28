<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="slotMachineChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" BorderStyle="None" Height="150px" OnDataBinding="LeverButton_Click" Width="150px" />
&nbsp;<asp:Image ID="Image2" runat="server" BorderStyle="None" Height="150px" OnDataBinding="LeverButton_Click" Width="150px" />
&nbsp;<asp:Image ID="Image3" runat="server" BorderStyle="None" Height="150px" OnDataBinding="LeverButton_Click" Width="150px" />
        <br />
        <br />
        Your Bet:&nbsp; <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="LeverButton" runat="server" OnClick="LeverButton_Click" Text="Pull The Lever!!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry&nbsp; - x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        BAR on any reel - Bust and lose bet!!!</div>
    </form>
</body>
</html>
