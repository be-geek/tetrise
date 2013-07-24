using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Tetrise
{
    class Shape_2:Shape
    {
        public Shape_2()
            : base(3, 2)
        {
            this.color = Color.Green;
            matrix[0, 0].exist = true;
            matrix[0, 1].exist = true;
            matrix[1, 1].exist = true;
            matrix[1, 2].exist = true;
        
        }
    }
}

