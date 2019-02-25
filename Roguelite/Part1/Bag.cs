using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Bag:IEnumerable<Item>
    {
        private List<Item> _items;
        private float _totalWeight;
        private float _maxWeight;
        private int _maxItems;

        public Bag(float maxWeight, int maxItems)
        {
            _items = new List<Item>();
            _maxItems = maxItems;
            _totalWeight = 0;
            _maxWeight = maxWeight;
        }

        public void Add(Item item)
        {
            // FIXME: ADD BAGFULLEXCEPTION
            float itemWeight = item.Weight;
            _items.Add(item);
            _totalWeight += itemWeight;
        }
        public Item RemoveAt(int index)
        {
            if (index >= 0) 
            {
                Item removeItem = _items[index];
                _items.RemoveAt(index);
                _totalWeight -= removeItem.Weight;
                return removeItem;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public Item RemoveById(Guid id)
        {
            int index = _items.FindIndex(x => x.ID == id);
            if (index < 0)
            {
                return null;
            }
            else
            {
                var oldItem = _items[index];
                _items.RemoveAt(index);
                return oldItem;
            }
            //Item itemToRemove = null;
            //foreach (var item in _items)
            //{
            //    if (item.ID == id)
            //    {
            //        itemToRemove = item;
            //        break;
            //    }
            //}
            //if (itemToRemove != null)
            //{
            //    return itemToRemove;
            //}
            //else { return null; }
        }
        public IEnumerator<Item> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public int Count { get { return _items.Count; } }

        public float TotalWeight { get { return _totalWeight; } }
        public float MaxWeight { get { return _maxWeight; } }
        public int MaxItems { get { return _maxItems; } }
        public Item this[int index] { get { return _items[index]; } }
    }
}
