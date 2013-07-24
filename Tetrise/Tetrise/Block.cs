using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tetrise
{
    class Block
    {
        public Color color;
        public bool exist;
        //public int pos_x;
        //public int pos_y;

        public Block()
        {
            color = Color.Black;
            exist = false;
        }
    }
}
