using System;
using System.Collections.Generic;
using System.Text;

namespace Tetrise
{
    class FieldPlay:Field
    {

        public FieldPlay()
            : base(21, 12)
        {

        }

        public int check() // check and clean the full line 
        {
            int botPos,i;

            int lines = 0 ; // use of adding score

            bool cleanFlag = true;

            for (botPos = 20; botPos > 0; botPos--)
            {
                cleanFlag = true;
                for (i = 0; i < 12; i++)
                {
                    if (!this.MassArray[botPos, i].exist)
                    {
                        cleanFlag = false;
                        break;
                    }
                }

                if (cleanFlag)
                {
                    clearLine(botPos);
                    botPos++;
                    lines++;
                }
                
            }
            return lines;
        }

        public void clearLine(int beg) // clean a line which is full,and move all blocks to next line
        { 
            int i,j;
            //clean 
            for (i = 0; i < 12; i++)
            {
                this.MassArray[beg, i].exist = false;
            }

            //move
            for (i = beg; i > 0; i--)
            {
                for (j = 0; j < 12; j++)
                { 
                    this.MassArray[i,j]=this.MassArray[i-1,j];
                }
            }
        }
    }
}
