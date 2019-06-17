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
    public partial class PauseScreen : UserControl
    {
        private static PauseScreen pauseForm;
        private static DialogResult buttonResult = new DialogResult();


        public PauseScreen()
        {
            InitializeComponent();
        }

        public static DialogResult Show()
        {
            pauseForm = new PauseScreen();

            //pauseForm.ShowDialog();

            return buttonResult;
        }

        private static void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "Continue":
                    buttonResult = DialogResult.Cancel;
                    break;
                case "Exit Game":
                    buttonResult = DialogResult.Abort;
                    break;
            }

            //pauseForm.Close();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            buttonResult = DialogResult.Abort;
            //pauseForm.Close();
        }

        private void resumeGame_Click(object sender, EventArgs e)
        {
            buttonResult = DialogResult.Cancel;
            //pauseForm.Close();
        }
    }
}
