using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeMonsterHero
{

    public partial class Default : System.Web.UI.Page
    {

        public void Page_Load(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            
            Character Hero = new Character();
            Hero.Name = "Edward the Crazy";
            Hero.Health = 100;
            Hero.damageMaximum = 30;
            Hero.AttackBonus = false;

            Character Monster = new Character();
            Monster.Name = "Bill the Bulbous";
            Monster.Health = 100;
            Monster.damageMaximum = 25;
            Monster.AttackBonus = false;

            if (Hero.AttackBonus)
                Monster.Defend(Hero.Attack(dice));
            if (Monster.AttackBonus)
                Hero.Defend(Hero.Attack(dice));

            while (Hero.Health > 0 && Monster.Health > 0)
            {
                Monster.Defend(Hero.Attack(dice));
                Hero.Defend(Hero.Attack(dice));

                showStats(Hero);
                showStats(Monster);
            }

            displayResults(Hero, Monster); 
            
            
        }

        private void displayResults(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p> Both {0} and {1} died. </p>", opponent1.Name, opponent2.Name);
            else if (opponent1.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>", opponent1.Name, opponent2.Name);
            else
                resultLabel.Text += String.Format("<p>{0} defeats {1}</p>", opponent2.Name, opponent1.Name);
            
        }
        private void showStats(Character character)
        {
            resultLabel.Text += String.Format("<p> Name: {0} Health: {1} damage maximum: {2} Attack Bonus: {3}</p>", character.Name, character.Health, character.damageMaximum, character.AttackBonus); 
            
        }

    }
    class Dice
    {
        public int sides { get; set; }

        Random random = new Random();
        public int Roll()
        {
            return random.Next(this.sides);
            
        }


    }
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int damageMaximum { get; set; }
        public bool AttackBonus { get; set; }

       
        public int Attack(Dice dice)
        {

            dice.sides = this.damageMaximum; 
            
            return dice.Roll();
            
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
              
        }


    }

    


}