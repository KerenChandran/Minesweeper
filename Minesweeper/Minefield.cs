using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Minesweeper
{
    class Minefield
    {
        //data fields
        private int mValue; //Keeps track of number value (how many mines box is touching)
        private bool mIsCovered; //Keeps track if the mine is covered
        private bool mIsMine; //Keeps track if it is a mine
        private int mBoxStatus; //Keeps track of Status (0 = empty, 1 = flag, 2 = ?)


        //**************************************************************************************

        //Constructor        

        //**************************************************************************************

        public Minefield()
        {
            //Sets cell to be covered, empty and contain no mine
            mIsCovered = true;
            mIsMine = false;
            mBoxStatus = 0;
        }


        //**************************************************************************************

        //Methods

        //**************************************************************************************

        //Draws each individual mine based on x, y and image
        public void Draw(Graphics g, int x, int y, Bitmap image)
        {
            g.DrawImage(image, x, y);
        }


        //**************************************************************************************

        //Properties

        //**************************************************************************************

        public bool CoveredStatus //Gets and Sets covered status
        {
            get
            {
                return mIsCovered;
            }
            set
            {
                mIsCovered = value;
            }
        }

        public bool IsMine //Gets and Sets Mine Status
        {
            get
            {
                return mIsMine;
            }
            set
            {
                mIsMine = value;
            }
        }

        public int BoxStatus //Gets and Sets Box Status
        {
            get
            {
                return mBoxStatus;
            }
            set
            {
                mBoxStatus = value;
            }
        }

        public int GetValue //Gets and Sets value
        {
            get
            {
                return mValue;
            }
            set
            {
                mValue = value;
            }
        }

    }
}
