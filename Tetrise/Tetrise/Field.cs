using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tetrise
{

    abstract class Field
    {
        public Block[,] MassArray;
        private int Width;
        private int Height;
        
        public Field(int row,int col)
        {
            this.Height = row;
            this.Width = col;
            this.MassArray = new Block[Height,Width];
        }


        public void clearField()
        { 
            int i,j;
            for (i = 0; i < Height; i++)
                for (j = 0; j < Width; j++)
                {
                    this.MassArray[i, j].exist = false;
                }
        
        }

        public void showBlocks(Graphics g)
        {
            
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen=new Pen(Color.Black,1);

            int row, col;
            for (row = 0;row<Height;row++)
                for (col =0;col<Width;col++)
                {
                    if (MassArray[row, col].exist == true)
                    {
                        brush.Color = MassArray[row, col].color;
                        g.FillRectangle(brush, col * 20, row * 20, 20, 20);//fill blocks which exist
                        g.DrawRectangle(pen, col * 20, row * 20, 20, 20);  //draw border 
                    }
                    else
                    {
                        brush.Color = Color.Black;
                        g.FillRectangle(brush, col * 20, row * 20, 20, 20);
                    }
                }

            brush.Dispose();
            pen.Dispose();
        }

        public void placeShape(Shape shape)
        {
            int row, col;
            for (row = 0;row<shape.height;row++)
                for (col = 0;col<shape.width;col++)
                    if ((shape.matrix[row, col].exist)&&(!this.MassArray[shape.pos_y + row, shape.pos_x + col].exist))
                    {
                        this.MassArray[shape.pos_y + row, shape.pos_x + col].exist = true;
                        this.MassArray[shape.pos_y + row, shape.pos_x + col].color = shape.color;
                    }
        }
    }
}
