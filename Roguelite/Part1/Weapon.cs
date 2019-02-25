using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Weapon:Item
    {
        protected int _atk;

        public Weapon(string name, int atk, Image img, bool natural, float weight, InventorySlotId slot, int goldValue) : base(name, img, natural, weight, slot, goldValue)
        {
            _atk = atk;
        }

        public override string ToString()
        {
            return _name + " (+" + _atk + ")";
        }

        public int ATK { get { return _atk; } }
    }
}
