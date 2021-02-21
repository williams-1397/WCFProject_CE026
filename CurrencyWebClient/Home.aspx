<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CurrencyWebClient.WebForm1" %>

<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Currency Conversion Service</title>
<style>
body {font-family: Arial, Helvetica, sans-serif;}
* {box-sizing: border-box;
    font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    background-color:#F3F3F3;
}

input[type=text], select, textarea {
  width: 100%;
  padding: 12px;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
  margin-top: 6px;
  margin-bottom: 16px;
  resize: vertical;
}

input[type=submit] {
  background-color: #4CAF50;
  color: white;
  padding: 12px 20px;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  font-size:20px;
}

input[type=submit]:hover {
  background-color: #45a049;
}

.container {
  border-radius: 5px;
  padding: 20px;
  border:solid 1px;
}
h3{
    font-size:30px;
    font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    padding-left:130px;
}
.Result{
    text-align:center;
    font-size:30px;
}
    .auto-style1 {
        margin-left: 52px;
    }
    .auto-style3 {
        margin-left: 55px;
    }
    .auto-style4 {
        margin-left: 56px;
    }
    .auto-style5 {
        width: 739px;
    }
    .auto-style6 {
        height: 72px;
    }
</style>
</head>
<body style="margin-left: 307px; margin-right: 312px; margin-top: 76px; width: 915px;">

<div class="container">
  <form id="form1" runat="server">
      <h3 class="auto-style5">Welcome to Currency Conversion Service</h3>
      <hr/ >
      <label for="Amount">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Your Amount</label>
      <asp:TextBox ID="Amount_TextBox1" runat="server" CssClass="auto-style4" Width="674px" ></asp:TextBox>
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select Your Local Currency:
            <asp:DropDownList ID="Currency_DropDownList1" runat="server" CssClass="auto-style3" Width="700px">
                <asp:ListItem Value="INR">₹ (INR - Indian Rupees)</asp:ListItem>
                <asp:ListItem Value="USD">$( USD - US Dollars)</asp:ListItem>
                <asp:ListItem Value="CAD">C$ (CAD - Canadian Dollars)</asp:ListItem>
                <asp:ListItem Value="GBP">£ (GBP - Great Britain Pound)</asp:ListItem>
                <asp:ListItem Value="YEN">¥ (YEN - Japanese Yen)</asp:ListItem>
                <asp:ListItem Value="EURO">€ (EURO Europian Euro)</asp:ListItem>
                <asp:ListItem Value="PKR">₨ (PKR - Pakistani Rupees)</asp:ListItem>
                <asp:ListItem Value="YUAN">¥ (YUAN - Chinese Yuan)</asp:ListItem>
                <asp:ListItem Value="NZD">$ (NZD - New Zeland Dollars)</asp:ListItem>
                <asp:ListItem Value="AED">د.إ  (AED - Aram Emirites Dirhams)</asp:ListItem>
                <asp:ListItem Value="RUB">₽ (RUB - Russian Rubble)</asp:ListItem>
            </asp:DropDownList>
      <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     Select Currency To be Converted:
            <asp:DropDownList ID="Currency_DropDownList2" runat="server" CssClass="auto-style3" Width="700px">
                <asp:ListItem Value="INR">₹ (INR - Indian Rupees)</asp:ListItem>
                <asp:ListItem Value="USD">$( USD - US Dollars)</asp:ListItem>
                <asp:ListItem Value="CAD">C$ (CAD - Canadian Dollars)</asp:ListItem>
                <asp:ListItem Value="GBP">£ (GBP - Great Britain Pound)</asp:ListItem>
                <asp:ListItem Value="YEN">¥ (YEN - Japanese Yen)</asp:ListItem>
                <asp:ListItem Value="EURO">€ (EURO Europian Euro)</asp:ListItem>
                <asp:ListItem Value="PKR">₨ (PKR - Pakistani Rupees)</asp:ListItem>
                <asp:ListItem Value="YUAN">¥ (YUAN - Chinese Yuan)</asp:ListItem>
                <asp:ListItem Value="NZD">$ (NZD - New Zeland Dollars)</asp:ListItem>
                <asp:ListItem Value="AED">د.إ  (AED - Aram Emirites Dirhams)</asp:ListItem>
                <asp:ListItem Value="RUB">₽ (RUB - Russian Rubble)</asp:ListItem>
            </asp:DropDownList>
    <asp:Button ID="Button1" runat="server"  Text="Convert" OnClick="Button1_Click" Width="705px" CssClass="auto-style1" />
      <br />
      <br />
      <br />
    <center class="auto-style6"><asp:Label ID="Result_Label1" runat="server" class="Result"></asp:Label></center>
  </form>
    <hr />
   <center> NOTE : Exchange Rates might be diffrent in such case make sure rates before any doing transactions. </div></center>
</body>
</html>