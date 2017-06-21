using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace papaBobs
{
    public partial class pizzaDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            totalLabel.Text = "$0.00";
            discoutLabel.Text = "";
        }


        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            //variables
            double sizeTotal = 0;
            double crustTotal = 0;
            double toppingTotal = 0;

            //size radio buttons
            if (babyRadioButton.Checked)
            {
                sizeTotal = 10.0;
            }
            else if (mamaRadioButton.Checked)
            {
                sizeTotal = 13.0;
            }
            else if (PapaRadioButton.Checked)
            {
                sizeTotal = 16.0;
            }
            double runningTotal = sizeTotal; //running total

            //crust radio button
            if (regCrustRadioButton.Checked)
            {
                crustTotal = 0;
            }
            else if (deepDishRadioButton.Checked)
            {
                crustTotal = 2.0;
            }
            runningTotal = sizeTotal + crustTotal; //running total
            
            //if topping is left empty
            if (toppingTotal == 0)
            {
                runningTotal = crustTotal + sizeTotal;
                totalLabel.Text = runningTotal.ToString();
            }
                //if topping checked
                if (peppCheckBox.Checked)
                {
                    toppingTotal += 1.50;
                }
                if (onionsCheckBox.Checked)
                {
                    toppingTotal += 0.75;
                }
                if (gPeppCheckBox.Checked)
                {
                    toppingTotal += 0.50;
                }
                if (rPeppCheckBox.Checked)
                {
                    toppingTotal += 0.75;
                }
                if (anchoviesCheckBox.Checked)
                {
                    toppingTotal += 2.0;
                }
                //discount if statement
                if ((peppCheckBox.Checked)
                && (gPeppCheckBox.Checked)
                && (anchoviesCheckBox.Checked)
                || (peppCheckBox.Checked)
                && (rPeppCheckBox.Checked)
                && (onionsCheckBox.Checked))
                {
                runningTotal = toppingTotal -= 2;
                discoutLabel.Text = "You Saved $2.00 on your order!!";
                }

                runningTotal = toppingTotal + crustTotal + sizeTotal;
                totalLabel.Text = "$ " + runningTotal.ToString();



            
            




        }
    }
}