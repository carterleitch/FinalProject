using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgect
{
    public partial class HowToScreen : UserControl
    {
        public HowToScreen()
        {
            InitializeComponent();
        }

        private void howtoExit_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }

        private void howtoPlay_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "GameScreen");
        }

        //ADD NAME CREATION HERE
    }
}
