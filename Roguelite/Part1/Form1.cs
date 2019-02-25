using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part1
{
    public partial class Form1 : Form
    {
        private Game _game;

        public Form1()
        {
            InitializeComponent();

            _game = new Game(1, 0,null,null);
            startScreen.Form = this;
            inventoryScreen1.Form = this;
            gameOverScreen1.Form = this;
            combat1.Form = this;
            gameOverScreen1.Visible = false;
            inventoryScreen1.Visible = false;
            combat1.Visible = false;
        }

        public Game GameManager { get { return _game; } }

        public void SwitchScreen(ScreenId screen)
        {
            gameOverScreen1.Visible = false;
            inventoryScreen1.Visible = false;
            combat1.Visible = false;
            startScreen.Visible = false;

            switch (screen)
            {
                case ScreenId.MAIN_MENU:
                    startScreen.Visible = true;
                    break;
                case ScreenId.COMBAT:
                    combat1.Visible = true;
                    break;
                case ScreenId.INVENTORY:
                    inventoryScreen1.Visible = true;
                    break;
                case ScreenId.GAME_OVER:
                    gameOverScreen1.Visible = true;
                    break;
            }
        }
    }
}