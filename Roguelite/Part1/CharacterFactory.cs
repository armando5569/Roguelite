using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class CharacterFactory
    {
        private Random _rand;
        private ItemFactory _itemFactory;

        public CharacterFactory()
        {
            _rand = new Random();
            _itemFactory = new ItemFactory();
        }

        public Character SpawnPlayer()
        {
            Character Player;
            Player= new Character("Player",_rand.Next(10,30), _rand.Next(1, 20), _rand.Next(1, 20));
             Player.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SpawnHelmet());
            Player.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.SpawnWeapon());
            Player.Equipped.Equip(InventorySlotId.VEST, _itemFactory.SpawnVest());
            Player.Equipped.Equip(InventorySlotId.POTION, _itemFactory.SpawnPotion());
            Player.Bag.Add(_itemFactory.SpawnPotion());
            Player.Bag.Add(_itemFactory.SpawnJunk());
            return Player;
        }

        public Character SpawnEnemy()
        {
            switch(_rand.Next(0,3))
            {
                case 0:
                    Character Goblin = new Character("Goblin", _rand.Next(5, 15), _rand.Next(1, 5), _rand.Next(2, 5));
                    Goblin.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SpawnHelmet());
                    Goblin.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.SpawnWeapon());
                    Goblin.Equipped.Equip(InventorySlotId.VEST, _itemFactory.SpawnVest());
                    Goblin.Equipped.Equip(InventorySlotId.POTION, _itemFactory.SpawnPotion());
                    return Goblin;
                case 1:
                    Character Skeleton = new Character("Skeleton", _rand.Next(10, 20), _rand.Next(5, 10), _rand.Next(6, 10));
                    Skeleton.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SpawnHelmet());
                    Skeleton.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.SpawnWeapon());
                    Skeleton.Equipped.Equip(InventorySlotId.VEST, _itemFactory.SpawnVest());
                    Skeleton.Equipped.Equip(InventorySlotId.POTION, _itemFactory.SpawnPotion());
                    return Skeleton;
                case 2:
                    Character Orc = new Character("Orc", _rand.Next(20, 30), _rand.Next(10, 20), _rand.Next(10, 20));
                    Orc.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SpawnHelmet());
                    Orc.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.SpawnWeapon());
                    Orc.Equipped.Equip(InventorySlotId.VEST, _itemFactory.SpawnVest());
                    Orc.Equipped.Equip(InventorySlotId.POTION, _itemFactory.SpawnPotion());
                    return Orc;
                default:
                    Character Death = new Character("Death", _rand.Next(50, 100), _rand.Next(50, 100), _rand.Next(50, 100));
                    Death.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SpawnHelmet());
                    Death.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.SpawnWeapon());
                    Death.Equipped.Equip(InventorySlotId.VEST, _itemFactory.SpawnVest());
                    Death.Equipped.Equip(InventorySlotId.POTION, _itemFactory.SpawnPotion());
                    return Death;
            }
        }
    }
}
