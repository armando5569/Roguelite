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
    public partial class StartScreen : UserControl
    {
        private Form1 _form;
        public StartScreen()
        {
            InitializeComponent();
        }
        public Form1 Form
        {
            get { return _form; }
            set { _form = value; }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _form.GameManager.Enemy = new CharacterFactory().SpawnEnemy();
            _form.GameManager.Player = new CharacterFactory().SpawnPlayer();
            _form.SwitchScreen(ScreenId.COMBAT);
        }

        private void StartScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && _form != null)
            {
                lblWelcome.Text = "Welcome To The Game";
            }
        }
    }
}
