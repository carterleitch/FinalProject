using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProgect
{
    public partial class GameScreen : UserControl
    {
        Boolean leftPressed, rightPressed, upPressed, downPressed;

        SolidBrush drawBrush = new SolidBrush(Color.Black);

        List<PlayArea> gameAreas = new List<PlayArea>();  
        List<PlayArea> outAreas = new List<PlayArea>();   
        List<Character> obstacles = new List<Character>(); 

        int heroX = 20, heroY = 20;
        Character hero;

        public GameScreen()
        {
            InitializeComponent();
            gameTimer.Enabled = true;
            InitializeGameValues();
        }

        public void InitializeGameValues()
        {
            hero = new Character(heroX, heroY, 20, 20, 3, Color.LightBlue);

            #region Walls
            outAreas.Add(new PlayArea(0, 0, 10, 700, "out", Color.Blue));
            outAreas.Add(new PlayArea(0, 0, 1000, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(990, 0, 10, 700, "out", Color.Blue));
            outAreas.Add(new PlayArea(0, 690, 1000, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(10, 90, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(90, 10, 10, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(70, 90, 30, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(90, 70, 10, 30, "out", Color.Blue));
            outAreas.Add(new PlayArea(100, 10, 710, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(100, 80, 70, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(10, 100, 10, 170, "out", Color.Blue));
            outAreas.Add(new PlayArea(80, 100, 20, 170, "out", Color.Blue));
            outAreas.Add(new PlayArea(220, 80, 80, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(300, 80, 190, 80, "out", Color.Blue));
            outAreas.Add(new PlayArea(480, 20, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(580, 20, 10, 80, "out", Color.Blue));
            outAreas.Add(new PlayArea(480, 70, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(490, 150, 360, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(10, 400, 0, 0, "out", Color.Blue));
            outAreas.Add(new PlayArea(10, 260, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(70, 260, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(100, 250, 50, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(190, 250, 110, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(300, 160, 10, 100, "out", Color.Blue));
            outAreas.Add(new PlayArea(140, 270, 10, 40, "out", Color.Blue));
            outAreas.Add(new PlayArea(140, 300, 210, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(350, 200, 10, 110, "out", Color.Blue));
            outAreas.Add(new PlayArea(350, 200, 560, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(580, 140, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(590, 80, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(650, 80, 70, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(720, 80, 90, 80, "out", Color.Blue));
            outAreas.Add(new PlayArea(800, 70, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(800, 20, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(910, 160, 10, 70, "out", Color.Blue));
            outAreas.Add(new PlayArea(890, 150, 40, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(870, 70, 50, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(880, 60, 30, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(880, 90, 30, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(970, 150, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(780, 210, 10, 110, "out", Color.Blue));
            outAreas.Add(new PlayArea(790, 300, 60, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(910, 270, 10, 130, "out", Color.Blue));
            outAreas.Add(new PlayArea(890, 300, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(890, 380, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(780, 370, 10, 100, "out", Color.Blue));
            outAreas.Add(new PlayArea(790, 380, 60, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(360, 460, 560, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(140, 360, 220, 50, "out", Color.Blue));
            outAreas.Add(new PlayArea(70, 400, 70, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(10, 400, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(350, 410, 10, 60, "out", Color.Blue));
            outAreas.Add(new PlayArea(450, 260, 20, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(560, 260, 20, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(670, 260, 20, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(450, 400, 20, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(560, 400, 20, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(670, 400, 20, 20, "out", Color.Blue));
            outAreas.Add(new PlayArea(910, 440, 10, 30, "out", Color.Blue));
            outAreas.Add(new PlayArea(920, 460, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(970, 460, 20, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(90, 410, 10, 200, "out", Color.Blue));
            outAreas.Add(new PlayArea(90, 660, 10, 30, "out", Color.Blue));
            outAreas.Add(new PlayArea(140, 410, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(140, 460, 10, 150, "out", Color.Blue));
            outAreas.Add(new PlayArea(140, 660, 10, 30, "out", Color.Blue));
            outAreas.Add(new PlayArea(150, 560, 200, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(350, 470, 10, 50, "out", Color.Blue));
            outAreas.Add(new PlayArea(350, 560, 10, 130, "out", Color.Blue));
            outAreas.Add(new PlayArea(430, 470, 10, 140, "out", Color.Blue));
            outAreas.Add(new PlayArea(430, 610, 40, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(520, 610, 50, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(560, 470, 10, 140, "out", Color.Blue));
            outAreas.Add(new PlayArea(570, 550, 100, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(710, 550, 10, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(720, 470, 10, 90, "out", Color.Blue));
            outAreas.Add(new PlayArea(620, 600, 10, 100, "out", Color.Blue));
            outAreas.Add(new PlayArea(630, 600, 40, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(710, 600, 60, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(770, 510, 30, 100, "out", Color.Blue));
            outAreas.Add(new PlayArea(790, 610, 10, 90, "out", Color.Blue));
            outAreas.Add(new PlayArea(800, 510, 70, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(910, 510, 80, 10, "out", Color.Blue));
            outAreas.Add(new PlayArea(0, 700, 1000, 500, "out", Color.Black));
            #endregion
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            //{
            //    gameTimer.Enabled = false;
            //    rightPressed = leftPressed = upPressed = downPressed = false;

            //    DialogResult result = PauseScreen.Show();

            //    if (result == DialogResult.Cancel)
            //    {
            //        gameTimer.Enabled = true;
            //    }
            //    else if (result == DialogResult.Abort)
            //    {
            //        Form1.ChangeScreen(this, "MenuScreen");
            //    }
            //}

            switch (e.KeyCode)
            {
                case Keys.A:
                    leftPressed = true;
                    break;
                case Keys.S:
                    downPressed = true;
                    break;
                case Keys.D:
                    rightPressed = true;
                    break;
                case Keys.W:
                    upPressed = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.A:
                    leftPressed = false;
                    break;
                case Keys.S:
                    downPressed = false;
                    break;
                case Keys.D:
                    rightPressed = false;
                    break;
                case Keys.W:
                    upPressed = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int tempX = hero.x;
            int tempY = hero.y;

            if (leftPressed == true)
            {
                hero.x -= hero.speed;
            }
            if (downPressed == true)
            {
                hero.y += hero.speed;
            }
            if (rightPressed == true)
            {
                hero.x += hero.speed;
            }
            if (upPressed == true)
            {
                hero.y -= hero.speed;
            }

            foreach (PlayArea g in outAreas)
            {
                if (hero.Collision(g))
                {
                    hero.x = tempX;
                    hero.y = tempY;
                }
            }

            foreach (Character c in obstacles)
            {
                c.Move(c.direction);

                if (c.direction == "down" && c.y >= 412)
                {
                    c.direction = "up";
                }
                else if (c.direction == "up" && c.y <= 62)
                {
                    c.direction = "down";
                }
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (PlayArea g in outAreas)
            {
                drawBrush.Color = g.colour;
                e.Graphics.FillRectangle(drawBrush, g.x, g.y, g.width, g.height);
            }

            drawBrush.Color = hero.color;
            e.Graphics.FillRectangle(drawBrush, hero.x, hero.y, hero.width, hero.height);
        }
    }
}
