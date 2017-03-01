using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    class Player
    {
        private string name; //just the name, self explanatory
        private int strength; //base strength attribute before buffs and other mods

        public int getStrength()
        {
            return strength;
        }

        public Player(string n)
        {
            name = n;
            strength = 10; //base number to start with can change later
        }

        public int attack()
        {
            //making this as simple as possible right now... will add more lately obvi
            int attackValue = 0;
            Random attackval = new Random();
            attackValue = attackval.Next((int)(strength - (strength * .2)), (strength + 1)); //the lower bounds is strength - 20% of its value, the upper bounds is just the full value of strength. 
                                                                                             //upper bounds adds 1 because it is exclusive for the random object
            return attackValue;
        }
    }
}
