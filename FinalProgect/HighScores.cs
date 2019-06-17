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
    public partial class HighScores : UserControl
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void HighscoreExitButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }

        //DISPLAY HIGH SCORES
    }
}
