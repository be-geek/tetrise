using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Tetrise
{
    class Shape_6:Shape
    {
        public Shape_6()
            : base(3, 2)
        {
            color = Color.Yellow;
            matrix[0, 1].exist = true;
            matrix[1, 0].exist = true;
            matrix[1, 1].exist = true;
            matrix[1, 2].exist = true;
        
        }
    }
}
