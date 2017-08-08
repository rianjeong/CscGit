using papaBobs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using papaBobs.DTO.Enums;
using papaBobs.domain;


namespace PapaBobs.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void orderButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a name.";
                validationLabel.Visible = true;
                return; 
            }
            if(addressTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter an address.";
                validationLabel.Visible = true;
                return; 
            
            }

            if(zipTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a Zip Code.";
                validationLabel.Visible = true;
                return;
            }

            if (phoneTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Please enter a phone number";
                validationLabel.Visible = true;
                return;
            }
            try
            {
                var order = buildOrder();
                papaBobs.Domain.OrderManager.CreateOrder(order);
                Response.Redirect("success.aspx");
            }
            catch (Exception ex)
            {

                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
                return;
            }
            
        }

        private PaymentType determinePaymentType()
        {
            PaymentType paymentType;
            if (cashRadioButton.Checked)
            {
                paymentType = PaymentType.cash; 
            }
            else 
            {
                paymentType = PaymentType.credit; 
            }
           
            return paymentType;    
        }

        private CrustType determineCrust()
        {
            CrustType crust; 
            if(!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
            {
                throw new Exception("could not determine pizza crust.");
            }
            return crust; 
        }

        private SizeType determineSize()
        {
            SizeType size;
            if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
            {
                throw new Exception("could not determine pizza crust!");
            }
            return size;
        }

        protected void recalculateTotalCost(object sender,EventArgs e)
        {
            if (sizeDropDownList.SelectedValue == string.Empty) return;
            if (crustDropDownList.SelectedValue == string.Empty) return;
            var order = buildOrder();
            

            try
            {
                totalLabel.Text = PizzaPriceManager.CalculateCost(order).ToString("C");
            }
            catch 
            {

                //swallow the error;
            }
        }

        private OrderDTO buildOrder()
        {
            var order = new OrderDTO();
            order.Size = determineSize();
            order.Crust = determineCrust();
            order.Sausage = sausageCheckBox.Checked;
            order.Pepperoni = pepperoniCheckBox.Checked;
            order.Onions = onionsCheckBox.Checked;
            order.GreenPepper = greenPeppersCheckBox.Checked;
            order.Name = nameTextBox.Text;
            order.Address = addressTextBox.Text;
            order.Zip = zipTextBox.Text;
            order.Phone = phoneTextBox.Text;
            order.PaymentType = determinePaymentType();
            return order; 
        }
    }
}