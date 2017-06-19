using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challengeSimpleCalculator
{
    public partial class Calculator1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string firstValue = firstValuebox.Text;
            string secondValue =secondValueBox.Text;

            int result = int.Parse(firstValue) + int.Parse(secondValue);
            totalValue.Text = result.ToString(); 
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            string firstValue = firstValuebox.Text;
            string secondValue = secondValueBox.Text;

            int result = int.Parse(firstValue) - int.Parse(secondValue);
            totalValue.Text = result.ToString();
        }

        protected void multiplcationButton_Click(object sender, EventArgs e)
        {
            string firstValue = firstValuebox.Text;
            string secondValue = secondValueBox.Text;

            int result = int.Parse(firstValue) * int.Parse(secondValue);
            totalValue.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            string firstValue = firstValuebox.Text;
            string secondValue = secondValueBox.Text;

            double result = double.Parse(firstValue) / double.Parse(secondValue);
            totalValue.Text = result.ToString();
        }
    }
}