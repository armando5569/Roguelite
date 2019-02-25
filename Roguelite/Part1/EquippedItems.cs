using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class EquippedItems:IEnumerable<Item>
    {
        private Dictionary<InventorySlotId, Item> _items;

        public EquippedItems()
        {
            _items = new Dictionary<InventorySlotId, Item>();
            _items[InventorySlotId.HELMET] = null;
            _items[InventorySlotId.VEST] = null;
            _items[InventorySlotId.WEAPON] = null;
            _items[InventorySlotId.POTION] = null;
        }

        public Item Equip(InventorySlotId slot, Item item)
        {
            //_items.Add(slot, item);
            var oldItem = _items[slot];           
           _items[slot] = item;
            return oldItem;
        }
        public Item Unequip(InventorySlotId slot)
        {
            var oldItem = _items[slot];
            _items[slot] = null ;
            return oldItem;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return _items.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Item this[InventorySlotId slot]
        {
            get { return _items[slot]; }
            set { _items[slot] = value;  }
        }


    }
}
