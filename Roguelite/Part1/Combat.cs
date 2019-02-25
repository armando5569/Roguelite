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
    public partial class Combat : UserControl
    {
        private Form1 _form;
        private Random _rand;
        private CharacterFactory _characterFactory;
        //int playerHp = 0;
        //int playerAtk = 0;
        //int playerDef = 0;
        //int enemyHp = 0;
        //int enemyAtk = 0;
        //int enemyDef = 0;
        private Character _player;
        private Character _enemy;
        //Armor Helmet = new ItemFactory().SpawnHelmet();
        //Armor Vest = new ItemFactory().SpawnVest();
        //Weapon Weapon = new ItemFactory().SpawnWeapon();
        public Combat()
        {
            InitializeComponent();

            _rand = new Random();
            _characterFactory = new CharacterFactory();
            

            // ALL CHARACTERS STATS HAVE BEEN TRANSPORTED TO CHARACTER FACTORY 

            //_player = _characterFactory.SpawnPlayer();
            //_enemy = _characterFactory.SpawnEnemy();
            //Player.Helmet = Helmet;
            //Player.Vest = Vest;
            //Player.Weapon = Weapon;
            //playerHp = rand.Next(10, 20);
            //playerAtk = rand.Next(1, 10);
            //playerDef = rand.Next(1, 10);
            //enemyHp = rand.Next(10, 20);
            //enemyAtk = rand.Next(1, 10);
            //enemyDef = rand.Next(1, 10);
            //lblEnemyHp.Text = "HP: " + _enemy.HP;
            //lblEnemyAtk.Text = "ATK: " + _enemy.TotalATK;
            //lblEnemyDef.Text = "DEF: " + _enemy.TotalDEF;
            //lblPlayHp.Text = "HP: " + _player.HP;
            //lblPlayAtk.Text = "ATK: " + _player.TotalATK;
            //lblPlayDef.Text = "DEF: " + _player.TotalDEF;
            //lblEnemy.Text = _enemy.Name;
            //lblStats.Text = Player.Helmet.ToString() + "+" + Player.Vest.ToString() +"+" + Player.Weapon.ToString();


        }
        private void btnAttack_Click(object sender, EventArgs e)
        {
            TakeDamage(false);
        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            TakeDamage(true);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _enemy = _characterFactory.SpawnEnemy();
          
            _form.SwitchScreen(ScreenId.INVENTORY);
        }
        private void ShowPictures()
        {

            picEnemyHelmet.Image = _enemy.Helmet.Image;
            picEnemyVest.Image = _enemy.Vest.Image;
            picEnemyWeapon.Image = _enemy.Weapon.Image;
            picEnemyPotion.Image = _enemy.Potion.Image;
            picPlayerHelmet.Image = _player.Helmet.Image;
            picPlayerVest.Image = _player.Vest.Image;
            picPlayerWeapon.Image = _player.Weapon.Image;

            
            lblEnemyHelmet.Text = _enemy.Helmet.ToString();
            lblEnemyVest.Text = _enemy.Vest.ToString();
            lblEnemyWeapon.Text = _enemy.Weapon.ToString();
            lblEnemyPotion.Text = _enemy.Potion.ToString();
            lblPlayerHelmet.Text = _player.Helmet.ToString();
            lblPlayerVest.Text = _player.Vest.ToString();
            lblPlayerWeapon.Text = _player.Weapon.ToString();
            if (_player.Potion != null)
            {
                picPlayerPotion.Image = _player.Potion.Image;
                lblPlayerPotion.Text = _player.Potion.ToString();
            }
            if (_player.Potion == null)
            {
                picPlayerPotion.Image = null;
                picPlayerPotion.Text = null;
                btnHeal.Enabled = false;
            }
        }


        private void TakeDamage(bool guard)
        {
            int damage = 0;
            if (guard == true)
            {
                //{
                //    enemyHp -= Math.Max(0, (playerAtk - enemyDef)) / 2 + rand.Next(0, 3);
                //    if(IsEnemyDead(enemyHp)==true)
                //    {
                //        return;
                //    }else
                //    playerHp -= Math.Max(0, (enemyAtk - playerDef)) / 2 + rand.Next(0, 3);
                //    IsPlayerDead(playerHp);

                damage = Math.Max(0, (_player.TotalATK - _enemy.TotalDEF)) / 2 + _rand.Next(0, 3);
                _enemy.ApplyDamage(damage);
                if (_enemy.IsDead == true)
                {
                    EnemyIsDead();
                    return;
                }
                else
                    damage = Math.Max(0, (_enemy.TotalATK - _player.TotalDEF)) / 2 + _rand.Next(0, 3);
                _player.ApplyDamage(damage);
                if (_player.IsDead == true)
                    PlayerIsDead();
            }
            
            else
            {
                //enemyHp -= Math.Max(0,(playerAtk - enemyDef)) + rand.Next(0, 4);
                //if (IsEnemyDead(enemyHp) == true)
                //{
                //    return;
                //}
                //else
                //playerHp -= Math.Max(0,(enemyAtk - playerDef)) + rand.Next(0, 4);
                //IsPlayerDead(playerHp);
                damage = Math.Max(0, (_player.TotalATK - _enemy.TotalDEF)) + _rand.Next(0, 4);
                _enemy.ApplyDamage(damage);
                if (_enemy.IsDead == true)
                {
                    EnemyIsDead();
                    return;
                }
                else
                    damage = Math.Max(0, (_enemy.TotalATK - _player.TotalDEF)) + _rand.Next(0, 4);
                _player.ApplyDamage(damage);
                if (_player.IsDead == true)
                    PlayerIsDead();
            }
            ShowStats();
        }


        private void PlayerIsDead()
        {
            btnAttack.Enabled = false;
            btnGuard.Enabled = false;
            btnInventory.Enabled = false;
            btnHeal.Enabled = false;;
            _form.SwitchScreen(ScreenId.GAME_OVER);
        }

        private void EnemyIsDead()
        {
            btnAttack.Enabled = false;
            btnGuard.Enabled = false;
            btnInventory.Enabled = true;
            btnHeal.Enabled = false;

            var helmet = _enemy.Equipped.Unequip(InventorySlotId.HELMET);
            if (helmet != null) {  _enemy.Bag.Add(helmet); }
            _enemy.Bag.Add(_enemy.Equipped.Unequip(InventorySlotId.VEST));
            _enemy.Bag.Add(_enemy.Equipped.Unequip(InventorySlotId.WEAPON));
            _enemy.Bag.Add(_enemy.Equipped.Unequip(InventorySlotId.POTION));
            ShowStats();
        }

        private void ShowStats()
        {
            lblEnemy.Text = _enemy.Name;
            lblEnemyHp.Text = "HP: " + _enemy.HP;
            lblEnemyAtk.Text = "ATK: " + _enemy.TotalATK;
            lblEnemyDef.Text = "DEF: " + _enemy.TotalDEF;
            lblPlayHp.Text = "HP: " + _player.HP;
            lblPlayAtk.Text = "ATK: " + _player.TotalATK;
            lblPlayDef.Text = "DEF: " + _player.TotalDEF;

          
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            _player.Heal(_player.Potion.HealValue);
            _player.Equipped.Unequip(_player.Potion.Slot);
            picPlayerPotion.Image = null;
            lblPlayerPotion.Text = null; 
            btnHeal.Enabled = false;
            ShowStats();
        }
        
        public Form1 Form
        {
            get { return _form; }
            set { _form = value; }
        }

        private void Combat_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && _form != null)
            {
                btnAttack.Enabled = true;
                btnGuard.Enabled = true;
                btnHeal.Enabled = true;
                btnInventory.Enabled = false;
                _enemy = _form.GameManager.Enemy;
                _player = _form.GameManager.Player;
                ShowStats();
                ShowPictures();
            }
        }
    }
}
