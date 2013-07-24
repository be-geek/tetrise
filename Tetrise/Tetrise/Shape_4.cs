using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tetrise
{
    class Shape_4:Shape
    {
        public Shape_4()
            : base(2, 3)
        {
            this.color = Color.BlueViolet;
            matrix[0, 0].exist = true;
            matrix[0, 1].exist = true;
            matrix[1, 0].exist = true;
            matrix[2, 0].exist = true;
        
        }
    }
}
