/************************************************************
 * Keren & Aman
 * Minesweeper
 * June 2013
 * The famous Minesweeper game made popular by Microsoft. 
 * Additional details included in the specifications
 * **********************************************************
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();            
            time.Tick += new EventHandler(TimeTicked);
        }

        int MineFieldSize; //Size of the field
        Minefields field; //Initilize the field class
        int FlagsAvailable = 0; //Sets and keeps track of how many flags are available
        bool firstClick = false; //Determines if the user has started the game

        void TimeTicked(object sender, EventArgs e)
        {
            //keeps track of how much time has been elapsed
            int timeElapsed = int.Parse(lblTimer.Text) + 1;
            lblTimer.Text = timeElapsed.ToString(); //Update timer label with the current elapsed time
        }


        private void btnSmile_Click(object sender, EventArgs e)
        {
            this.Invalidate();            
            field = new Minefields(MineFieldSize, MineFieldSize);

            //draw the gui interface depending on the difficulty setting.
            if (MineFieldSize == 10)
            {
                Width = 218;
                Height = 269;
                btnSmile.Left = 88;
                lblTimer.Left = 150;
                FlagsAvailable = 10;
            }
            else if (MineFieldSize == 20)
            {
                Width = 374;
                Height = 436;
                btnSmile.Left = 168;
                lblTimer.Left = 300;
                FlagsAvailable = 40;
            }
            else if (MineFieldSize == 30)
            {
                Width = 544;
                Height = 596;
                btnSmile.Left = 245;
                lblTimer.Left = 468;
                FlagsAvailable = 90;
            }
            Graphics g = this.CreateGraphics();
            btnSmile.Image = Images.btnsmile;
            firstClick = false;
            lblTimer.Text = "0";
            lblFlagsUsed.Text = FlagsAvailable.ToString();
            field.GameState = 0; //Gamestate keeps track of the state of the game. 0 means the game has started.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Draw grid.
            if (field != null)
            {
                field.Draw(e.Graphics, 20, 60);
                //Scans the field when the user runs out of flags
                //See's if flag locations are correct.
                if (FlagsAvailable == 0)
                {
                    field.Scan();
                    //If the user has won, stop the time, and change the button image to reflect the win.
                    if (field.GameState == 2)
                    {
                        time.Stop();
                        btnSmile.Image = Images.btncool;
                    }
                }
            }
        }

        //Start the game.
        private void mnuPlayStart_Click(object sender, EventArgs e)
        {
            btnSmile_Click(sender, e);
        }

        //Set the field size to 10x10 and start the game.
        private void MnuDifficultyEasy_Click(object sender, EventArgs e)
        {
            MineFieldSize = 10;
            btnSmile_Click(sender, e);
        }

        //Set the field size to 20x20 and start the game.
        private void MnuDifficultyIntermediate_Click(object sender, EventArgs e)
        {
            MineFieldSize = 20;
            btnSmile_Click(sender, e);
        }

        //Set the field size to 30x30 and start the game.
        private void MnuDifficultyHard_Click(object sender, EventArgs e)
        {
            MineFieldSize = 30;
            btnSmile_Click(sender, e);
        }

        //When a user clicks a cell this method will determine if they 
        //clicked the cell with the left or right mouse button.
 
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {            
            int MouseX = e.X, MouseY = e.Y;//Get x & Y cordinates of mouse

            //Makes sure the user clicked within the grid
            if (MineFieldSize == 10 && MouseX > 20 && MouseX < 180 && MouseY > 60 && MouseY < 220 || MineFieldSize == 20 && MouseX > 20 && MouseX < 340 && MouseY > 60 && MouseY < 380 || MineFieldSize == 30 && MouseX > 20 && MouseX < 500 && MouseY > 60 && MouseY < 540)
            {
                //Starts the timer if not already started.
                if (firstClick == false)
                {
                    firstClick = true;
                    time.Start();
                }                

                //Gets X & Y cord of cell.
                MouseX = (MouseX - 20) / 16;
                MouseY = (MouseY - 60) / 16;

                //Runs if the cell is covered and not flagged OR uncovered and flagged
                if (field.CoveredStatus(MouseX, MouseY) == true && field.GetBoxStatus(MouseX, MouseY) != 1 || field.CoveredStatus(MouseX, MouseY) == false && field.GetBoxStatus(MouseX, MouseY) == 1)
                {
                    //If the user has not finished the game...
                    if (field.GameState != 2)
                    {
                        //If the left mouse button was clicked and the box isn't flagged
                        if (e.Button == MouseButtons.Left && field.GetBoxStatus(MouseX, MouseY) != 1)
                        {
                            if (field.GameState == 0)//And if the game is started
                            {
                                field.FieldUncover(MouseX, MouseY);//Uncover cells
                                if (field.GameState == 1)//If the game is lost, stop time and change image on the smiley button to relect the loss.
                                {
                                    time.Stop();
                                    btnSmile.Image = Images.btndead;
                                }
                                //Updates form
                                this.Invalidate();
                            }
                        }
                        //If the user clicked the right button.
                        else if (e.Button == MouseButtons.Right)
                        {
                            //And if is started
                            if (field.GameState == 0)
                            {
                                //And if the box is empty and there's more flags
                                if (field.GetBoxStatus(MouseX, MouseY) == 0 && FlagsAvailable > 0)
                                {
                                    //If the box is covered
                                    if (field.CoveredStatus(MouseX, MouseY) == true)
                                    {
                                        //Flag the box, decrease flag counter, update label
                                        field.BoxStatus(MouseX, MouseY, 1);
                                        FlagsAvailable -= 1;
                                        lblFlagsUsed.Text = FlagsAvailable.ToString();
                                    }
                                }
                                    //If the box is flagged
                                else if (field.GetBoxStatus(MouseX, MouseY) == 1)
                                {
                                    //Place a question mark on the box, increase flag counter, update label
                                    field.BoxStatus(MouseX, MouseY, 2);
                                    FlagsAvailable += 1;
                                    lblFlagsUsed.Text = FlagsAvailable.ToString();
                                }
                                else//If the box is question marked, change it to empty.
                                {
                                    field.BoxStatus(MouseX, MouseY, 0);
                                }
                                //Update gui
                                this.Invalidate();
                            }
                        }
                    }
                }
            }
        }

        //On load, display the difficulty selection gui.
        private void Form1_Load(object sender, EventArgs e)
        {
            frmDifficultySelection diff = new frmDifficultySelection();            
            diff.ShowDialog();
            if (diff.SizeReturn == 0)
                this.Close();
            else
            {
                MineFieldSize = diff.SizeReturn;
                btnSmile_Click(sender, e);
            }
        }

        //On mouse down. change the smiley button to scared image
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int MouseX = e.X, MouseY = e.Y;
            if (field.GameState == 0)
                if (MineFieldSize == 10 && MouseX > 20 && MouseX < 180 && MouseY > 60 && MouseY < 220 || MineFieldSize == 20 && MouseX > 20 && MouseX < 340 && MouseY > 60 && MouseY < 380 || MineFieldSize == 30 && MouseX > 20 && MouseX < 500 && MouseY > 60 && MouseY < 540)
                    btnSmile.Image = Images.btnscare;
        }

        //Change button back to smile when the mouse is up.
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (field.GameState == 0)
                btnSmile.Image = Images.btnsmile;
        }

        //Exit the game
        private void mnuPlayExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Handle closing.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            time.Stop();
            //Asks User if they wish to quit
            if (MessageBox.Show("Are you sure you want to Quit?", "Minesweeper", MessageBoxButtons.YesNo) == DialogResult.No) //Asks user if they want to quit
            {
                if(field.GameState == 0)
                    time.Start();
                e.Cancel = true; //Runs if they wish not to quit
            }
        }

        private void mnuAboutHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();            
        }

        private void mnuAboutAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
    }
}
