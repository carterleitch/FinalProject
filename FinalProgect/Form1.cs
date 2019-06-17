using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProgect
{
    public partial class Form1 : Form
    {
        bool fullScreen = true;

        public Form1()
        {
            InitializeComponent();

            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

            #region open in full screen or not
            if (fullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;

                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                ms.Location = new Point((screenWidth - ms.Width) / 2, (screenHeight - ms.Height) / 2);
            }
            else
            {
                ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            }
            #endregion

        }

        public static void ChangeScreen(UserControl current, string next)
        {
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            switch (next)
            {
                case "MainScreen":
                    ns = new MainScreen();
                    break;
                case "HowToScreen":
                    ns = new HowToScreen();
                    break;
                case "HighScores":
                    ns = new HighScores();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
            }
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);
            ns.Focus();
        }
    }
}
