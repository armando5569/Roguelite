using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class ItemFactory
    {
        private Random _rand;

        public ItemFactory()
        {
            _rand = new Random();
        }

        public Armor SpawnHelmet()
        {
            switch (_rand.Next(1, 4))
            {
                case 1:
                    Armor BronzeHelmet = new Armor("Bronze Helmet", _rand.Next(1, 4), Properties.Resources.uP841M9, false, 1f, InventorySlotId.HELMET, _rand.Next(3, 6));
                    return BronzeHelmet;
                case 2:
                    Armor IronHelmet = new Armor("Iron Helmet", _rand.Next(3, 7), Properties.Resources.Iron_helm, false, 2f, InventorySlotId.HELMET, _rand.Next(5, 10));
                    return IronHelmet;
                case 3:
                    Armor SilverHelmet = new Armor("Silver Helmet", _rand.Next(5, 10), Properties.Resources.Silver_Helm, false, 3f, InventorySlotId.HELMET, _rand.Next(7, 14));
                    return SilverHelmet;
                default:
                    Armor GoldHelmet = new Armor("Gold Helmet", _rand.Next(1, 2), Properties.Resources.Gold_Helm, false, 5f, InventorySlotId.HELMET, _rand.Next(50, 100));
                    return GoldHelmet;
            }
        }

        public Armor SpawnVest()
        {
            switch (_rand.Next(1, 4))
            {
                case 1:
                    Armor BronzeVest = new Armor("Bronze Vest", _rand.Next(1, 4), Properties.Resources.Bronze_vest, false, 1f, InventorySlotId.VEST, _rand.Next(3, 6));
                    return BronzeVest;
                case 2:
                    Armor IronVest = new Armor("Iron Vest", _rand.Next(3, 7), Properties.Resources.Iron_Vest, false, 2f, InventorySlotId.VEST, _rand.Next(5, 10));
                    return IronVest;
                case 3:
                    Armor SilverVest = new Armor("Silver Vest", _rand.Next(5, 10), Properties.Resources.Silver_Vest, false, 3f, InventorySlotId.VEST, _rand.Next(7, 14));
                    return SilverVest;
                default:
                    Armor GoldVest = new Armor("Gold Vest", _rand.Next(1, 2), Properties.Resources.Gold_vest, false, 5f, InventorySlotId.VEST, _rand.Next(50, 100));
                    return GoldVest;
            }
        }

        public Weapon SpawnWeapon()
        {
            switch (_rand.Next(1, 4))
            {
                case 1:
                    Weapon BronzeSword = new Weapon("Bronze Sword", _rand.Next(1, 4), Properties.Resources.Bronze_Sword, false, 1f, InventorySlotId.WEAPON, _rand.Next(3, 6));
                    return BronzeSword;
                case 2:
                    Weapon IronSword = new Weapon("Iron Sword", _rand.Next(3, 7), Properties.Resources.Iron_sword, false, 2f, InventorySlotId.WEAPON, _rand.Next(5, 10));
                    return IronSword;
                case 3:
                    Weapon SilverSword = new Weapon("Silver Sword", _rand.Next(5, 10), Properties.Resources.Silver_sword, false, 3f, InventorySlotId.WEAPON, _rand.Next(7, 14));
                    return SilverSword;
                default:
                    Weapon GoldSword = new Weapon("Gold Sword", _rand.Next(1, 2), Properties.Resources.Gold_sword, false, 5f, InventorySlotId.WEAPON, _rand.Next(50, 100));
                    return GoldSword;
            }
        }

        public Potion SpawnPotion()
        {
            Potion HealPotion = new Potion("Healing Potion", _rand.Next(5, 30), Properties.Resources.potion, false, 1f, InventorySlotId.POTION,5);
            return HealPotion;
        }

        public Item SpawnJunk()
        {
            switch (_rand.Next(1, 4))
            {
                case 1:
                    Armor GoldHelmet = new Armor("Gold Helmet", _rand.Next(1, 2), Properties.Resources.Gold_Helm, false, 5f, InventorySlotId.HELMET, _rand.Next(50, 100));
                    return GoldHelmet;
                case 2:
                    Armor GoldVest = new Armor("Gold Vest", _rand.Next(1, 2), Properties.Resources.Gold_vest, false, 5f, InventorySlotId.VEST, _rand.Next(50, 100));
                    return GoldVest;
                case 3:
                    Weapon GoldSword = new Weapon("Gold Sword", _rand.Next(1, 2), Properties.Resources.Gold_sword, false, 5f, InventorySlotId.WEAPON, _rand.Next(50, 100));
                    return GoldSword;
                default:
                    Potion HealPotion = new Potion("Healing Potion", _rand.Next(5, 10), Properties.Resources.potion, false, 1f, InventorySlotId.POTION, _rand.Next(7, 14));
                    return HealPotion;
            }
        }
    }
}
