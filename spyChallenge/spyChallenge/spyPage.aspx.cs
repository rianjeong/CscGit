using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace spyChallenge
{
    public partial class spyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                oldAssignCalendar.SelectedDate = DateTime.Now.Date;
                newAssignCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
                
            }
            bonusLabel.Text = "";
            resultLabel.Text = "";


        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            TimeSpan assignmentLength = endNewCalendar
                 .SelectedDate
                 .Subtract(newAssignCalendar.SelectedDate);
            double assignmentBudget = assignmentLength
                .TotalDays * 500; 

            if (assignmentLength.TotalDays > 21)
            {
                assignmentBudget += 1000;
                bonusLabel.Text = "and an extra $1000 since it's going to be a long one...";
            }


            resultLabel.Text = String.Format("Special Agent {0} to assignment {1} is authorized. Budget total:{2:C}"
            , nameTextBox.Text
            , assignTextBox.Text
            ,assignmentBudget.ToString());

            TimeSpan betweenAssignments = newAssignCalendar
                .SelectedDate
                .Subtract(oldAssignCalendar.SelectedDate);
                
            if (betweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment.";

                DateTime newAssignment = oldAssignCalendar.SelectedDate.AddDays(14);

                newAssignCalendar.SelectedDate = newAssignment;
                newAssignCalendar.VisibleDate = newAssignment; 
            }

             




        }




    }
}