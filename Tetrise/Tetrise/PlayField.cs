using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Tetrise
{
    class PlayField
    {
        public Block[,] MassArray;
        static private int Width = 12;
        static private int Height = 21;
        
        public PlayField()
        {
            int row, col;
            MassArray = new Block[21,12];
            for (row = 0; row < Height; row++)
                for (col = 0; col < Width; col++)
                    MassArray[row, col] = new Block();
        }

        public void addShape(Block[] shape)
        { 
        
        }

        public void showBlocks(Graphics g)
        {
            int row, col;
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen=new Pen(Color.Black,1);
            for (row = 0;row<Height;row++)
                for (col =0;col<Width;col++)
                {
                    if (MassArray[row,col].exist == true)
                    {
                        brush.Color = MassArray[row, col].color;
                        g.FillRectangle(brush,col * 20, row * 20, 20, 20);
                        g.DrawRectangle(pen, col * 20, row * 20, 20, 20);
                    }
                }
            brush.Dispose();
        }
    }
}
