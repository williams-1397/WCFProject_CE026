using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Amount_TextBox1.Text == null)
            {
                Result_Label1.Text = "No Amount Found";
            }
            else
            {
                double amount = Convert.ToDouble(Amount_TextBox1.Text);
                string currency1 = Currency_DropDownList2.SelectedValue.ToString();
                string currency2 = Currency_DropDownList1.SelectedValue.ToString(); 
                CurrencyConversionService.CurrencyConversionServiceClient sc =
                    new CurrencyConversionService.CurrencyConversionServiceClient();

                if (Currency_DropDownList1.SelectedIndex == 0)
                {
                    double result = sc.ConvertINRTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem ;
                }
                if (Currency_DropDownList1.SelectedIndex == 1)
                {
                    double result = sc.ConvertUSDTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 2)
                {
                    double result = sc.ConvertCADTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 3)
                {
                    double result = sc.ConvertGBPTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 4)
                {
                    double result = sc.ConvertYENTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 5)
                {
                    double result = sc.ConvertEUROTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 6)
                {
                    double result = sc.ConvertPKRTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 7)
                {
                    double result = sc.ConvertYUANTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 8)
                {
                    double result = sc.ConvertNZDTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 9)
                {
                    double result = sc.ConvertAEDTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == 10)
                {
                    double result = sc.ConvertRUBTo(amount, currency1);
                    Result_Label1.Text = "The Amount " + amount + Currency_DropDownList1.SelectedItem + " is equals to " + result.ToString() + Currency_DropDownList2.SelectedItem;
                }
                if (Currency_DropDownList1.SelectedIndex == Currency_DropDownList2.SelectedIndex)
                {
                    Result_Label1.Text = "Invalid Selection.";
                }
            }
            
        }
    }
}