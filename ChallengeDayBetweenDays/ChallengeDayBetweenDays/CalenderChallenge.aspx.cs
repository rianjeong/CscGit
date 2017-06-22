using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDayBetweenDays
{
    public partial class CalenderChallenge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime firstDate = firstCalendar.SelectedDate; 
            DateTime secondDate = secondCalendar.SelectedDate;

            if (secondDate > firstDate)
            {
                TimeSpan diffDays = secondDate - firstDate;
                resultLabel.Text = diffDays.TotalDays.ToString(); 
            }
            else
            {
                TimeSpan diffDays = firstDate - secondDate;
                resultLabel.Text = diffDays.TotalDays.ToString();
            }
           

            
        }
    }
}