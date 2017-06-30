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
            Character Hero = new Character();
            Hero.Name = "Edward the Crazy";
            Hero.Health = 100;
            Hero.damageMaximum = 30;
            //Hero.AttackBonus = false;

            Character Monster = new Character();
            Monster.Name = "Bill the Bulbous";
            Monster.Health = 100;
            Monster.damageMaximum = 25;
            //Monster.AttackBonus = false;

            int damage = Hero.Attack();
            Monster.Defend(damage);

            damage = Monster.Attack();
            Hero.Defend(damage);

            showStats(Hero);
            showStats(Monster); 
        }
        private void showStats(Character character)
        {
            resultLabel.Text += String.Format("<p> Name: {0} Health: {1} damage maximum: {2} Attack Bonus: {3}</p>", character.Name, character.Health, character.damageMaximum, character.AttackBonus); 
            
        }

    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int damageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        Random random = new Random();
        public int Attack()
        {
            
            int attack = random.Next(this.damageMaximum);
            int damageTaken = Health - attack;
            return damageTaken;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
              
        }


    }

    


}