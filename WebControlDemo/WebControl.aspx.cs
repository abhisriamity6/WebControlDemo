using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlDemo
{
    public partial class WebControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(this.IsPostBack))
            {
                Currency.Items.Add(new ListItem("Euros", "0.85"));
                Currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
                Currency.Items.Add(new ListItem("Canadian Dollars", "1.2"));
            }
            Graph.Visible = false;
        }
        protected void Convert_ServerClick(object sender, EventArgs e)
        {
            decimal OriginalAmount;
            bool resultofcon = Decimal.TryParse(US.Value, out OriginalAmount);
            if (resultofcon)
            {
                ListItem LS =  Currency.Items[Currency.SelectedIndex];
                decimal ConvertedAmount = OriginalAmount * decimal.Parse(LS.Value);
                Result.InnerText = OriginalAmount + " U.S. dollars = ";
                Result.InnerText += ConvertedAmount + LS.Text;
            }
            else
            {
                Result.InnerText = "The number you typed in was not in the " +"correct format. Use only numbers.";
            }
        }
        protected void ShowGraph_ServerClick(object sender, EventArgs e)
        {
            ListItem LS = Currency.Items[Currency.SelectedIndex];
            Graph.Src = "./images/Dollor2" + LS.Text + ".gif";
            Graph.Visible = true;
        }

    }
}