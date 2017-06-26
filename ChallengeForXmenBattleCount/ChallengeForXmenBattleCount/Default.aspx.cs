using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";
            int highestNum = 0;
            int lowestNum = 0; 

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[highestNum])
                {
                    highestNum = i;                   
                }
                if (numbers[i] < numbers[lowestNum])
                {
                    lowestNum = i; 
                }
                result = string.Format("Least Battles belong to: {0}(Value: {1})", names[lowestNum], numbers[lowestNum]); 
                result += string.Format("</br>Most Battles belong to: {0}(Value: {1})", names[highestNum], numbers[highestNum]);
            }

 


            resultLabel.Text = result;
        }
    }
}