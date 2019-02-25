using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Potion:Item
    {
        protected int _healValue;

        public Potion(string name, int healValue, Image img, bool natural, float weight, InventorySlotId slot, int goldValue):base(name, img, natural, weight, slot, goldValue)
        {
            _healValue = healValue;
        }

        public override string ToString()
        {
            return _name + " (+" + _healValue + ")";
        }

        public int HealValue { get { return _healValue; } }
    }
}
