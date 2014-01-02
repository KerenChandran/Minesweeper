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
    public partial class frmDifficultySelection : Form
    {
        public frmDifficultySelection()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public int mSet;

        public int SizeReturn
        {
            get
            {
                return mSet;
            }
            set
            {
                mSet = value;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (radBegin.Checked)
            {
                SizeReturn = 10;
                Form1 MainForm = new Form1();
                this.Close();
            }
            else if (radIntermediate.Checked)
            {
                SizeReturn = 20;
                Form1 MainForm = new Form1();
                this.Close();
            }
            else if (radExpert.Checked)
            {
                SizeReturn = 30;
                Form1 MainForm = new Form1();
                this.Close();
            }            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
    }
}
