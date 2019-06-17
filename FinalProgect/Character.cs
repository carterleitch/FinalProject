﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProgect
{
    class Character
    {
        public int x, y, width, height, speed;
        public int coinX, coinY;
        public string direction;
        public Color color;

        public Character(int _x, int _y, int _width, int _height, int _speed, Color _colour)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            color = _colour;
        }

        public Character(int _x, int _y, int _width, int _height, int _speed, string _direction, Color _color)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            speed = _speed;
            direction = _direction;
            color = _color;
        }

        public void Move(string direction)
        {
            if (direction == "up") { y -= speed; }
            else if (direction == "down") { y += speed; }

            if (direction == "left") { x -= speed; }
            else if (direction == "right") { x += speed; }

        }

        public bool Collision(Character c)
        {
            Rectangle thisRec = new Rectangle(x, y, width, height);
            Rectangle cRec = new Rectangle(c.x, c.y, c.width, c.height);

            if (thisRec.IntersectsWith(cRec))
            {
                return true;
            }
            return false;
        }

        public bool Collision(PlayArea g)
        {
            Rectangle thisRec = new Rectangle(x, y, width, height);
            Rectangle gRec = new Rectangle(g.x, g.y, g.width, g.height);

            if (thisRec.IntersectsWith(gRec))
            {
                return true;
            }
            return false;
        }
    }
}
