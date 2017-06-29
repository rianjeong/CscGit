using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stringChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            
            string name = "Bob Tabor";
            string reverseName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseName += name[i];
            }
            resultLabel.Text = reverseName;
            
            // In my case, the result would be:
            // robaT boB



            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            StringBuilder sb = new StringBuilder();
            string[] reverseNames = names.Split(',');
            for (int i = reverseNames.Length - 1; i >=0;  i--)
            {
                sb.Append(reverseNames[i]);
                sb.Append(","); 
            }
            string results = sb.ToString();
            resultLabel.Text = results;
            


            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke




            // 3. Use the sequence to create ascii art:
            
            string names = "Luke,Leia,Han,Chewbacca";
            StringBuilder sb = new StringBuilder();
            string[] stringTopad = names.Split(',');
            for (int i = 0; i < stringTopad.Length; i++)
            {
                int padding = (14 - stringTopad[i].Length) / 2;
                sb.Append(stringTopad[i].PadLeft(stringTopad[i].Length + padding, '*').PadRight(14, '*'));
                sb.Append("</br>");
                 
            }
            string results = sb.ToString();
            resultLabel.Text = results; 
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***





            // 4. Solve this puzzle:
            
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";


            if (puzzle.Contains("remove-me"))
            {
                int index = puzzle.IndexOf("remove-me");
                resultLabel.Text = puzzle.Replace("Z", "T").Remove(index, index - 1).ToLower().Remove(0, 1).Insert(0, "N"); 
            }
            


                 

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

        }
    }
}