using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class InventoryScreen : UserControl
    {
        private Form1 _form;
        private Character _player;
        private Character _enemy;
        private Item selected ;

        public InventoryScreen()
        {
            InitializeComponent();
            selected = listBag.SelectedItem as Item;
        }

        public Form1 Form
        {
            get { return _form; }
            set { _form = value; }
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            _enemy = new CharacterFactory().SpawnEnemy();
            _form.GameManager.Enemy = _enemy;
            _form.SwitchScreen(ScreenId.COMBAT);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

      

        private void btnEquip_Click(object sender, EventArgs e)
        {
            selected = listBag.SelectedItem as Item;
            var oldItem = _player.Equipped[selected.Slot];
            //_form.GameManager.Player.Equipped.Equip(item.Slot, item);
            if (oldItem != null)
            {
                _player.Bag.Add(oldItem);
            }
            _player.Equipped.Equip(selected.Slot, selected);
            _player.Bag.RemoveById(selected.ID);
            UpdateScreen();
        }

        private void btnLoot_Click(object sender, EventArgs e)
        {
            selected = listBox1.SelectedItem as Item;
            _player.Bag.Add(selected);
            _enemy.Bag.RemoveById(selected.ID);
            UpdateScreen();
        }
        private void UpdateScreen()
        {
            lblHelmet.Text = _player.Helmet.ToString();
            lblVest.Text = _player.Vest.ToString();
            lblWeapon.Text = _player.Weapon.ToString();
            picHelmet.Image = _player.Helmet.Image;
            PicVest.Image = _player.Vest.Image;
            picWeapon.Image = _player.Weapon.Image;
            if (_player.Potion == null)
            {
                picPotion.Image = null;
                lblPotion.Text = null;
            }
            else
            {
                picPotion.Image = _player.Potion.Image;
                lblPotion.Text = _player.Potion.ToString();
            }
            listBag.Items.Clear();
            for (int i = 0; i < _player.Bag.Count; ++i)
            {
                object[] playerItems = new object[]
                {
                        _player.Bag[i]
                };
                listBag.Items.AddRange(playerItems);
            }

            listBox1.Items.Clear();
            for (int i = 0; i < _enemy.Bag.Count; ++i)
            {
                object[] enemyItems = new object[]
                {
                        _enemy.Bag[i]
                };
                listBox1.Items.AddRange(enemyItems);
            }
            DisableBtns();
        }

        private void InventoryScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && _form != null)
            {
                _player = _form.GameManager.Player;
                _enemy = _form.GameManager.Enemy;

                //listBag.Items.Clear();
                //for(int i =0;i<_player.Bag.Count;++i)
                //{
                //    object[] playerItems = new object[]
                //    {
                //        _player.Bag[i]
                //    };
                //    listBag.Items.AddRange(playerItems);
                //}

                //listBox1.Items.Clear();
                //for (int i = 0; i < _enemy.Bag.Count; ++i)
                //{
                //    object[] enemyItems = new object[]
                //    {
                //        _enemy.Bag[i]
                //    };
                //    listBox1.Items.AddRange(enemyItems);
                //}

                //object[] playerItems = new object[]
                //{
                //   _player.Bag[_player.Bag.Count]
                //};
                //listBag.Items.AddRange(playerItems);

                //object[] enemyItems = new object[]
                //{
                //    _enemy.Bag[_enemy.Bag.Count]
                //};
                //listBox1.Items.AddRange(enemyItems);


                UpdateScreen();
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            selected = listBag.SelectedItem as Item;
            _player.Bag.RemoveById(selected.ID);
            UpdateScreen();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            selected = listBag.SelectedItem as Item;
            _player.Bag.RemoveById(selected.ID);
            UpdateScreen();
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            
            if (selected.Slot == InventorySlotId.POTION) 
            {
                var potion = selected as Potion;
                _player.Heal(potion.HealValue);
                _player.Bag.RemoveById(selected.ID);
                UpdateScreen();
            }
        }

        private void DisableBtns()
        {
            btnDrop.Enabled = false;
            btnEquip.Enabled = false;
            btnUse.Enabled = false;
            btnSell.Enabled = false;
            btnLoot.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as Item;
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem == item)
                    btnLoot.Enabled = true;
                else
                    btnLoot.Enabled = false;
            }
        }
        private void listBag_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBag.SelectedItem as Item;
            if(listBag.SelectedItem != null)
            { 
                if (listBag.SelectedItem == item)
                {
                    btnDrop.Enabled = true;
                    btnEquip.Enabled = true;
                    btnSell.Enabled = true;
                    if (item.Slot == InventorySlotId.POTION)
                        btnUse.Enabled = true;
                    else
                        btnUse.Enabled = false;
                }
                else
                {
                    btnDrop.Enabled = false;
                    btnEquip.Enabled = false;
                    btnSell.Enabled = false;
                }
            }
        }
    }
}
