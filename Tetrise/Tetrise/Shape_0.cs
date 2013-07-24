using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Tetrise
{
    class Shape_0:Shape
    {

        public Shape_0()
            : base(1, 4)
        {
            this.color = Color.Red;
            for (int i = 0; i < 4; i++)
                matrix[i,0].exist = true;
        }

    }
}
