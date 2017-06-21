<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pizzaDefault.aspx.cs" Inherits="papaBobs.pizzaDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bob's Pizza</title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            text-align: center;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="papabob.png" />
            <span class="auto-style1">Papa Bob&#39;s Pizza and Software</span></h1>
    <div>
    
    </div>
        <asp:RadioButton ID="babyRadioButton" runat="server" Checked="True" GroupName="size" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaRadioButton" runat="server" GroupName="size"  Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="PapaRadioButton" runat="server" GroupName="size" Text="Papa Bob Size(16&quot;)-$16" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:RadioButton ID="regCrustRadioButton" runat="server" Checked="True" GroupName="crust" Text="Regular Crust" />
        <br />
        <asp:RadioButton ID="deepDishRadioButton" runat="server" GroupName="crust" Text="Deep Dish(+$2)" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:CheckBox ID="peppCheckBox" runat="server" Text="Pepperoni(+$1.50)" />
        &nbsp;<br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions(+$0.75)" />
        &nbsp;&nbsp;&nbsp;<br />
        <asp:CheckBox ID="gPeppCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:CheckBox ID="rPeppCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <br />
        <br />
        <h2 class="auto-style2">Papa Bob&#39;s <span class="auto-style3">Special Deal</span></h2>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.
        </p>
        <p>
            <asp:Label ID="discoutLabel" runat="server" BackColor="#66FF99"></asp:Label>
        </p>
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <br />
        Total:&nbsp; <asp:Label ID="totalLabel" runat="server" Text="$0.00"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only...We need a better website!
    </form>
</body>
</html>
