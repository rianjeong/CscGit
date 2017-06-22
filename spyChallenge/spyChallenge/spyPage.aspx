<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spyPage.aspx.cs" Inherits="spyChallenge.spyPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 199px;
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /></p>
        <h1>Spy New Assignment Form</h1>
        Super Secret Spy Spuedonym:&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
        Super Secret Spy Mission Name:&nbsp;
        <asp:TextBox ID="assignTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment: <asp:Calendar ID="oldAssignCalendar" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
        </asp:Calendar>
        <br />
        Start Date of New Assignment: <asp:Calendar ID="newAssignCalendar" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" VisibleDate="2017-07-01">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
            <TodayDayStyle BackColor="#CCCC99" />
        </asp:Calendar>
        <br />
        Projected End Date of New Assignment:
        <asp:Calendar ID="endNewCalendar" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" VisibleDate="2017-07-01">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Button ID="assignButton" runat="server" Height="39px" OnClick="assignButton_Click" Text="Assign Spy" />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="bonusLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
