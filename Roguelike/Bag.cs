using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Roguelike
{
    class Bag
    {
        private Object[] bag = new Object[10];
        private int count = 0;

        public void addItem(Object item)
        {
            bag[count] = item;
            count++;
        }

        public int itemCount()
        {
            return count;
        }

        public void useItem()
        {
            count--;
        }

        //public bool isItem(int index)
        //{
        //    if (bag[index] == )
        //}
    }
}
