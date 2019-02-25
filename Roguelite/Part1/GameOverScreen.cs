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
    public partial class GameOverScreen : UserControl
    {
        private Form1 _form;
        public GameOverScreen()
        {
            InitializeComponent();
        }
        public Form1 Form
        {
            get { return _form; }
            set { _form = value; }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            _form.SwitchScreen(ScreenId.MAIN_MENU);
        }
    }
}
