using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tetrise
{
    class Shape_1:Shape
    {
        public Shape_1()
            : base(2, 2)
        {
            this.color = Color.Blue;
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2;j++ )
                    matrix[i, j].exist = true;
        }
    }
}
