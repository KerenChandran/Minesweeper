  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Minesweeper
{
    class Minefields
    {
        //fields
        private Minefield[,] grid; //Creates an array of minefield cells
        private Random r = new Random(); //Generates random locations
        private int mGameState = 0; //Keeps track of Game State that the user is in

        //constructor

        public Minefields(int rows, int columns)
        {
            //Initializes the cells
            grid = new Minefield[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {                    
                    grid[i, j] = new Minefield();

                }
            }
            //Creates Mines
            for (int k = 0; k < Math.Pow(grid.GetLength(0),2)/10; k++)
            {
                //Continuously creates mines at random locations until a certain amount are created
                int i, j;
                do
                {
                    i = r.Next(0, grid.GetLength(0));
                    j = r.Next(0, grid.GetLength(1));
                } while (grid[i, j].IsMine == true);
                grid[i, j].IsMine = true; //Changes the status of the square to have a mine
                //Changes the values (makes other squares know that they are touching a mine)
                if (i == 0) //First Row
                {
                    if (j == 0) //Left Corner
                    {
                        grid[i + 1, j].GetValue += 1;
                        grid[i + 1, j + 1].GetValue += 1;
                        grid[i, j + 1].GetValue += 1;
                    }
                    else if (j == grid.GetLength(0)-1) //Right Corner
                    {
                        grid[i + 1, j].GetValue += 1;
                        grid[i + 1, j - 1].GetValue += 1;
                        grid[i, j - 1].GetValue += 1;
                    }
                    else if (j >0 && j < grid.GetLength(0)-1) //Anywhere in that row
                    {
                        grid[i, j-1].GetValue += 1;
                        grid[i + 1, j - 1].GetValue += 1;
                        grid[i+1, j].GetValue += 1;
                        grid[i + 1, j + 1].GetValue += 1;
                        grid[i, j + 1].GetValue += 1;
                    }
                }
                if (i == grid.GetLength(0)-1) //Last row
                {
                    if (j == 0) //Left Corner
                    {
                        grid[i - 1, j].GetValue += 1;
                        grid[i - 1, j + 1].GetValue += 1;
                        grid[i, j + 1].GetValue += 1;
                    }
                    else if (j == grid.GetLength(0) - 1) //Right Corner
                    {
                        grid[i - 1, j].GetValue += 1;
                        grid[i - 1, j - 1].GetValue += 1;
                        grid[i, j - 1].GetValue += 1;
                    }
                    else if (j > 0 && j < grid.GetLength(0) - 1) //Anywhere in that row
                    {
                        grid[i, j - 1].GetValue += 1;
                        grid[i - 1, j - 1].GetValue += 1;
                        grid[i - 1, j].GetValue += 1;
                        grid[i - 1, j + 1].GetValue += 1;
                        grid[i, j + 1].GetValue += 1;
                    }
                }
                if (i > 0 && i < grid.GetLength(0) - 1) //Anywhere in between
                {
                    if (j == 0) //Left Column 
                    {
                        grid[i - 1, j].GetValue += 1;
                        grid[i - 1, j + 1].GetValue += 1;
                        grid[i, j + 1].GetValue += 1;
                        grid[i + 1, j + 1].GetValue += 1;
                        grid[i + 1, j].GetValue += 1;
                    }
                    else if (j == grid.GetLength(0) - 1) //Right Column
                    {
                        grid[i - 1, j].GetValue += 1;
                        grid[i - 1, j - 1].GetValue += 1;
                        grid[i, j - 1].GetValue += 1;
                        grid[i + 1, j - 1].GetValue += 1;
                        grid[i + 1, j].GetValue += 1;
                    }
                    else if (j > 0 && j < grid.GetLength(0) - 1) //In the Middle
                    {
                        grid[i, j - 1].GetValue += 1;
                        grid[i - 1, j - 1].GetValue += 1;
                        grid[i - 1, j].GetValue += 1;
                        grid[i - 1, j + 1].GetValue += 1;
                        grid[i, j + 1].GetValue += 1;
                        grid[i + 1, j + 1].GetValue += 1;
                        grid[i + 1, j].GetValue += 1;
                        grid[i + 1, j - 1].GetValue += 1;
                    }
                }
            }
        }

        //methods

        //Drawing Method
        public void Draw(Graphics g, int x, int y) 
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].CoveredStatus == true) //Runs if blocks are covered
                    {
                        grid[i, j].Draw(g, x + 16 * i, y + 16 * j, Images.sqt0); //Displays normal block
                        if (grid[i,j].BoxStatus == 2) //Displays question mark
                            grid[i, j].Draw(g, x + 16 * i, y + 16 * j, Images.sqquestion);                     
                    }
                    else //Runs if block is uncovered
                    {
                        if (grid[i, j].IsMine == false) //Checks if there is no mine
                        {
                            if (grid[i, j].GetValue != 0) //Displays a number value
                                grid[i, j].Draw(g, x + 16 * i, y + 16 * j, (Bitmap)Images.ResourceManager.GetObject("sq" + grid[i, j].GetValue.ToString()));
                            else if (grid[i, j].GetValue == 0 && grid[i, j].BoxStatus != 1) //Displays an empty uncovered square
                                grid[i, j].Draw(g, x + 16 * i, y + 16 * j, Images.sq0);
                            if (grid[i, j].BoxStatus == 1) //Displays a flagged box
                                grid[i, j].Draw(g, x + 16 * i, y + 16 * j, Images.sqflag);
                        }
                        else if (grid[i, j].IsMine == true) //Checks if a mine is present
                        {
                            if (mGameState == 0 || mGameState == 2) //Checks if user is still playing game
                            {
                                if (grid[i, j].BoxStatus == 1) //Checks if the mine is flagged && displays flagged image
                                    grid[i, j].Draw(g, x + 16 * i, y + 16 * j, Images.sqflag);
                            }
                            else if (mGameState == 1)//Runs if user loses game
                            {
                                grid[i, j].Draw(g, x + 16 * i, y + 16 * j, Images.minered); //Displays red mine
                                if (grid[i, j].BoxStatus == 1) //Displays a dead mine if it was flagged
                                    grid[i, j].Draw(g, x + 16 * i, y + 16 * j, Images.bombmisflagged);
                            }
                        }
                    }
                }
            }
        }
        
        //Uncovers surrounding squares
        public void FieldUncover(int row, int column)
        {
            if (grid[row, column].BoxStatus != 1) //Runs only if the box ain't flagged
                if (grid[row, column].IsMine == false && grid[row, column].CoveredStatus == true) //Checks if the box is not a mine and not covered
                {
                    grid[row, column].CoveredStatus = false; //Sets its covered status to false
                    if (grid[row, column].GetValue == 0) //Recursively uncovers all the blank squares
                    {
                        if (row > 0) //Left
                            FieldUncover(row - 1, column);
                        if (column > 0) //Up
                            FieldUncover(row, column - 1);
                        if (row < grid.GetLength(0) - 1) //Right
                            FieldUncover(row + 1, column);
                        if (column < grid.GetLength(1) - 1) //Down
                            FieldUncover(row, column + 1);
                        if (row > 0 && column > 0) //Up Left
                            FieldUncover(row - 1, column - 1);
                        if (row > 0 && column < grid.GetLength(1) - 1) //Up Right
                            FieldUncover(row - 1, column + 1);
                        if (row < grid.GetLength(0) - 1 && column > 0) //Down Left
                            FieldUncover(row + 1, column - 1);
                        if (row < grid.GetLength(0) - 1 && column < grid.GetLength(1) - 1) //Down Right
                            FieldUncover(row + 1, column + 1);
                    }
                }
                else if (grid[row, column].IsMine == true) //Runs if the cell they clicked is a mine
                {
                    mGameState = 1; //Changes GameState to lose
                    grid[row, column].CoveredStatus = false; //Uncovers mine
                    for (int i = 0; i < grid.GetLength(0); i++) //Uncovers all the other mines
                    {
                        for (int j = 0; j < grid.GetLength(1); j++)
                        {
                            if (grid[i, j].IsMine == true)
                                grid[i, j].CoveredStatus = false;
                        }
                    }
                }
        }

        public void BoxStatus(int row, int column, int status) //Changes BoxStatus (Empty = 0, Flagged = 1, Question Mark = 2)
        {
            grid[row, column].BoxStatus = status; //Sets the box status
            if (status == 1) //Checks if it is a flag and uncovers the box so users can't click the box
                grid[row, column].CoveredStatus = false;
            else //Keeps the box blocked
                grid[row, column].CoveredStatus = true;
        }

        public bool CoveredStatus(int row, int column) //Gets covered status of the selected cell
        {
            return grid[row, column].CoveredStatus;
        }

        public int GetBoxStatus(int row, int column) //Gets Current Box Status
        {
            return grid[row, column].BoxStatus;
        }
        public int GameState //Gets and sets current Game State (playing, lose, win)
        {
            get
            {
                return mGameState;
            }
            set
            {
                mGameState = value;
            }
        }
        public void Scan() //Scans the field to see if all the flags are placed in the right spots
        {
            int counter = 0; //Keeps track of the amount of correct flagged locations
            for (int i = 0; i < grid.GetLength(0); i++) //Loops through field
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].BoxStatus == 1 && grid[i, j].IsMine == true) //Increases Counter every time a flag was placed correctly
                        counter += 1;
                    else if (grid[i, j].CoveredStatus == true && grid[i, j].IsMine == false) //Decreases counter if flag was placed incorrectly
                        counter -= 1;
                }
            }
            if (counter == Math.Pow(grid.GetLength(0), 2) / 10) //Changes Game State to win if flags are placed correctly
                mGameState = 2;
        }
    }
}
