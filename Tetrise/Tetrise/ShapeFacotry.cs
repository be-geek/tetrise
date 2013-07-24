using System;
using System.Collections.Generic;
using System.Text;

namespace Tetrise
{
    // "Simple Facotry Pattern" ------ Shape Facotry
    class ShapeFacotry 
    {
        static public Shape createShape(int type)
        {
            Shape shape = null;
            switch (type)
            {
                case 0: shape = new Shape_0(); break;
                case 1: shape = new Shape_1(); break;
                case 2: shape = new Shape_2(); break;
                case 3: shape = new Shape_3(); break;
                case 4: shape = new Shape_4(); break;
                case 5: shape = new Shape_5(); break;
                case 6: shape = new Shape_6(); break;
            }
            return shape;
        }
    }
}
