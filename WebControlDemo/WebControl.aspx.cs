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

        }
        protected void Convert_ServerClick(object sender, EventArgs e)
        {
            decimal USAmount;
            bool resultofcon = Decimal.TryParse(US.Value, out USAmount);
            if (resultofcon)
            {
                decimal euroAmount = USAmount * 0.85M;
                Result.InnerText = USAmount + " U.S. dollars = ";
                Result.InnerText += euroAmount + " Euros.";
            }
            else
            {
                Result.InnerText = "The number you typed in was not in the " +"correct format. Use only numbers.";
            }
        }

    }
}