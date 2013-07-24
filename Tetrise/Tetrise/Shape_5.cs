using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tetrise
{
    class Shape_5:Shape
    {
        public Shape_5()
            : base(2, 3)
        {
            this.color = Color.Cyan;
            matrix[0, 0].exist = true;
            matrix[0, 1].exist = true;
            matrix[1, 1].exist = true;
            matrix[2, 1].exist = true;
        
        }
    }
}
