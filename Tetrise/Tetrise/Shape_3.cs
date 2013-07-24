using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tetrise
{
    class Shape_3:Shape
    {
        public Shape_3()
            : base(3, 2)
        {
            this.color = Color.LightBlue;
            matrix[0, 1].exist = true;
            matrix[0, 2].exist = true;
            matrix[1, 0].exist = true;
            matrix[1, 1].exist = true;
        
        }
    }
}
