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
        private int hp; //base healthpoints
        private int xp;
        private int money;

        public int getStrength()
        {
            return strength;
        }

        public void setStrength(int s)
        {
            strength = s;
        }

        public int getHP()
        {
            return hp;
        }

        public void setHP(int HP)
        {
            hp = HP;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }

        public int getXP()
        {
            return xp;
        }

        public void setXP(int XP)
        {
            xp = XP;
        }

        public void giveXP()
        {
            xp++;
        }

        public int getMoney()
        {
            return money;
        }

        public void setMoney(int gold)
        {
            money = gold;
        }

        public void giveMoney(int gold)
        {
            money += gold;
        }

        public Player(string n)
        {
            name = n;
            strength = 2; //base number to start with can change later
            hp = 10;
            xp = 0;
            money = 0;
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
