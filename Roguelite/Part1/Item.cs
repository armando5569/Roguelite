using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public abstract class Item
    {
        protected Guid _id;
        protected string _name;
        protected Image _image;
        protected bool _natural;
        protected float _weight;
        protected InventorySlotId _slot;
        protected int _goldValue;

        public Item(string name, Image img, bool natural, float weight, InventorySlotId slot, int goldValue)
        {
            _name = name;
            _image = img;
            _id = Guid.NewGuid();
            _natural = natural;
            _weight = weight;
            _slot = slot;
            _goldValue = goldValue;
        }

        public override string ToString()
        {
            return _name;
        }
        public override bool Equals(object obj)
        {
            Item other = obj as Item;
            if (other == null) { return false; }
            return this.ID == other.ID;
        }
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public Guid ID { get { return _id; } }
        public string Name { get { return _name; } }
        public Image Image { get { return _image; } }
        public bool IsNatural { get { return _natural; } }
        public float Weight { get { return _weight;} }
        public InventorySlotId Slot { get { return _slot; } }
        public int GoldValue { get { return _goldValue; } }
    }
}
