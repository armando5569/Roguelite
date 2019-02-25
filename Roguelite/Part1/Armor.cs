using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Armor:Item
    {
        protected int _def;

        public Armor(string name, int def, Image img, bool natural, float weight, InventorySlotId slot, int goldValue) :base(name, img, natural, weight, slot, goldValue)
        {
            _def = def;
        }
        public override string ToString()
        {
            return _name + " (+" + _def + ")";
        }
        
        public int DEF { get { return _def; } }
    }
}
