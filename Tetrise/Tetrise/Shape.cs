using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


using System.Windows.Forms;


namespace Tetrise
{
    abstract class Shape
    {
        public Color color;
        public int pos_x;
        public int pos_y;
        public int width;
        public int height;
        public Block[,] matrix;


        public Shape(int w, int h)
        {
            this.height = h;
            this.width = w;
            this.matrix = makeMatrix(w, h);
        }

        public Block[,] makeMatrix(int w,int h)
        {
            Block[,] obj = new Block[h, w];
            return obj;
        
        }

        private void moveErase(FieldPlay field)// erase field before moving
        {
            int row, col;
            for (row = 0; row < this.height; row++)
                for (col = 0; col < this.width; col++)
                    if (this.matrix[row,col].exist)
                        field.MassArray[this.pos_y + row, this.pos_x + col].exist = false;
                       
        }

        private bool shiftAble(FieldPlay field) //check if shape were shiftable
        { 

            int i, j;
            moveErase(field);
            if ((pos_x + this.height >= 12)||(pos_y + this.width >= 21))
                return false;

            for (i = 0; i < this.height; i++)
                for (j = 0; j < this.width; j++)
                {
                    if ((matrix[i,j].exist)&&(field.MassArray[pos_y+j,pos_x+height-i].exist))
                        return false;
                }
            return true;
        }

        private bool moveAble(FieldPlay field, int dir) // check if shape could move as its direction
        {
            int i, j;

            if (dir == 1) // move left
            {
                if (this.pos_x <= 0) // at field left eage
                {
                    pos_x = 0;
                    return false;
                }
                else
                {
                    for (i = 0; i < height; i++)
                        for (j = 0; j < width; j++)
                        {   
                            if (matrix[i, j].exist)
                            {
                                if (j == 0) // at shape left eage
                                {
                                    if (field.MassArray[pos_y + i, pos_x + j - 1].exist)
                                        return false;
                                }
                                else
                                {
                                    if (!matrix[i,j-1].exist)
                                        if (field.MassArray[pos_y + i, pos_x + j - 1].exist)
                                            return false;
                                
                                }
                            }

                        }
                }
            
            }

            if (dir == 2) //move right
            {

                if (this.pos_x + width >= 12)//at field right eage
                {
                    pos_x=12-width;
                    return false;
                }
                else
                {
                    for (i = 0; i < height; i++)
                        for (j = 0; j < width; j++)
                        {
                            if (matrix[i, j].exist)
                            {
                                if (j == width-1)// at shape right eage
                                {
                                    if (field.MassArray[pos_y + i, pos_x + j + 1].exist)
                                        return false;
                                }
                                else
                                {
                                    if (!matrix[i, j + 1].exist)
                                        if (field.MassArray[pos_y + i, pos_x + j + 1].exist)
                                            return false;

                                }
                            }
                        }
                }
            }
            

            if (dir == 3) //move down
            {
                if (this.pos_y+this.height >= 21) return false;
                else
                { 
                    for (i = 0;i<this.height;i++)
                        for (j = 0; j < this.width; j++)
                        {
                            //while shape has blank block
                            if (matrix[i, j].exist)
                            {
                                if (i == height - 1)
                                {
                                    if (field.MassArray[pos_y + i + 1, pos_x + j].exist)
                                        return false;
                                }
                                else
                                {
                                    if (!matrix[i + 1, j].exist)
                                        if (field.MassArray[pos_y + i+1, pos_x + j].exist)
                                            return false;
                                }
                            }

                               
                        
                            //check if the bottom position has
                            if ((matrix[height-1,j].exist)&&(pos_y+height+1<=21))
                            {
                                if (field.MassArray[pos_y+height,pos_x+j].exist)
                                    return false;
                            }
                            
                        }
                }
            }
            return true;
        }

        public void moveLeft(FieldPlay field)
        {
            if (moveAble(field,1))
            {
                moveErase(field);
                pos_x--;
            }
        }

        public void moveRight(FieldPlay field)
        {
            if (moveAble(field, 2))
            {
                moveErase(field);
                pos_x++;
            }
        }

        public bool moveDown(FieldPlay field)
        {
            if (moveAble(field, 3))
            {
                moveErase(field);
                pos_y++;
                return true;
            }
            else return false;
        }

        public void shift(FieldPlay field)
        {
            if (shiftAble(field))
            {

                //create new shifted shape
                int tmp_h = this.width;
                int tmp_w = this.height;
     
                Block[,] tmpShape = makeMatrix(tmp_w,tmp_h);
                int i,j;
                for (i = 0; i < this.height; i++)
                    for (j = 0; j < this.width; j++)
                        tmpShape[j,tmp_w-i-1] = matrix[i,j];

                // swap height and width
                this.width = tmp_w;
                this.height = tmp_h;
                matrix = tmpShape;
            }
        }
    }
}
