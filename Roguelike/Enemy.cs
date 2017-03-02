using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    class Enemy
    {
        private int health;
        private int attack;

        public Enemy()
        {
            health = 10; //basic numbers, can be changed later
            attack = 1; //same as above
        }

        public int getEnemyHealth()
        {
            return health;
        }

        public int Attack()
        {
            //making this as simple as possible right now... will add more lately obvi
            int attackValue = 0;
            Random attackval = new Random();
            attackValue = attackval.Next((int)(attack - (attack * .2)), (attack + 1)); //the lower bounds is strength - 20% of its value, the upper bounds is just the full value of strength. 
                                                                                             //upper bounds adds 1 because it is exclusive for the random object
            return attackValue;
        }
    }
}
