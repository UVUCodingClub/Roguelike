using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike
{
    class Potion
    {
        private int healingPoints;
        
        public int getHeals()
        {
            return healingPoints;
        }

        public Potion()
        {
            healingPoints = 10;
        }
    }
}
