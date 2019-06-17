using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProgect
{
    class PlayArea
    {
        public int x, y, width, height;
        public string type;
        public Color colour;

        public PlayArea(int _x, int _y, int _width, int _height, string _type, Color _colour)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            type = _type;
            colour = _colour;
        }
    }
}
