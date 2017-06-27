<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="postalCalcChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Postal Calculator<br />
        <br />
        Width:&nbsp;
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        <br />
        Height:&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        <br />
        Length:&nbsp;
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="handleChange" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="handleChange" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" GroupName="shippingMethod" OnCheckedChanged="handleChange" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
