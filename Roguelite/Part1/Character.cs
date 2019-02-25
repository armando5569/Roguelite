 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Character
    {
        protected string _name;
        protected int _hp;
        protected int _atk;
        protected int _def;
        protected bool _dead;
        //protected Armor _helmet;
        //protected Armor _vest;
        //protected Weapon _weapon;
        protected Bag _bag;
        protected EquippedItems _equipped;

        public Character(string name, int hp, int atk, int def)
        {
            _name = name;
            _hp = hp;
            _atk = atk;
            _def = def;
            _bag = new Bag(40f,20);
            _equipped = new EquippedItems();
        }

        public void ApplyDamage(int damage)
        {
            _hp -= damage;
            if (_hp <= 0)
            {
                _hp = 0;
                _dead = true;
            }
            else
                _dead = false;
        }

        public void Heal(int healing)
        {
            _hp += healing;
        }
        
        public string Name { get { return _name; } }
        public int HP { get { return _hp; } }
        public int TotalATK
        {
            get
            {
                int total = _atk;
                if (Weapon != null)
                {
                    total += Weapon.ATK;
                }
                return total;
            }
        }
        public int TotalDEF
        {
            get
            {
                int total = _def;
                if(Helmet!=null)
                {
                    total+=Helmet.DEF;
                }
                if (Vest != null)
                {
                    total += Vest.DEF;
                }
                return total;
            }
        }
        public bool IsDead { get { return _dead; } }
        public EquippedItems Equipped { get { return _equipped; } }
        public Bag Bag { get { return _bag; } }


        public Armor Helmet
        {
            get { return _equipped[InventorySlotId.HELMET] as Armor; }
            set { _equipped[InventorySlotId.HELMET] = value; }
        }
        public Armor Vest
        {
            get { return _equipped[InventorySlotId.VEST] as Armor; }
            set { _equipped[InventorySlotId.VEST] = value; }
        }
        public Weapon Weapon
        {
            get { return _equipped[InventorySlotId.WEAPON] as Weapon; }
            set { _equipped[InventorySlotId.WEAPON] = value; }
        }
        public Potion Potion
        {
            get { return _equipped[InventorySlotId.POTION] as Potion; }
            set { _equipped[InventorySlotId.POTION] = value; }
        }
    }
}
