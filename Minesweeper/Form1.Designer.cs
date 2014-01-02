namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSmile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlayStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDifficultyEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDifficultyIntermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDifficultyHard = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimer = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lblFlagsUsed = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSmile
            // 
            this.btnSmile.Image = global::Minesweeper.Images.btnsmile;
            this.btnSmile.Location = new System.Drawing.Point(88, 30);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(27, 23);
            this.btnSmile.TabIndex = 0;
            this.btnSmile.UseVisualStyleBackColor = true;
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(195, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlayStart,
            this.mnuPlayExit});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.playToolStripMenuItem.Text = "File";
            // 
            // mnuPlayStart
            // 
            this.mnuPlayStart.Name = "mnuPlayStart";
            this.mnuPlayStart.Size = new System.Drawing.Size(163, 22);
            this.mnuPlayStart.Text = "Start New Game";
            this.mnuPlayStart.Click += new System.EventHandler(this.mnuPlayStart_Click);
            // 
            // mnuPlayExit
            // 
            this.mnuPlayExit.Name = "mnuPlayExit";
            this.mnuPlayExit.Size = new System.Drawing.Size(163, 22);
            this.mnuPlayExit.Text = "Exit";
            this.mnuPlayExit.Click += new System.EventHandler(this.mnuPlayExit_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDifficultyEasy,
            this.MnuDifficultyIntermediate,
            this.MnuDifficultyHard});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.optionsToolStripMenuItem.Text = "Difficulty Setting";
            // 
            // MnuDifficultyEasy
            // 
            this.MnuDifficultyEasy.Name = "MnuDifficultyEasy";
            this.MnuDifficultyEasy.Size = new System.Drawing.Size(147, 22);
            this.MnuDifficultyEasy.Text = "Beginner";
            this.MnuDifficultyEasy.Click += new System.EventHandler(this.MnuDifficultyEasy_Click);
            // 
            // MnuDifficultyIntermediate
            // 
            this.MnuDifficultyIntermediate.Name = "MnuDifficultyIntermediate";
            this.MnuDifficultyIntermediate.Size = new System.Drawing.Size(147, 22);
            this.MnuDifficultyIntermediate.Text = "Intermediate";
            this.MnuDifficultyIntermediate.Click += new System.EventHandler(this.MnuDifficultyIntermediate_Click);
            // 
            // MnuDifficultyHard
            // 
            this.MnuDifficultyHard.Name = "MnuDifficultyHard";
            this.MnuDifficultyHard.Size = new System.Drawing.Size(147, 22);
            this.MnuDifficultyHard.Text = "Expert";
            this.MnuDifficultyHard.Click += new System.EventHandler(this.MnuDifficultyHard_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutHelp,
            this.mnuAboutAbout});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "Extras";
            // 
            // mnuAboutHelp
            // 
            this.mnuAboutHelp.Name = "mnuAboutHelp";
            this.mnuAboutHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAboutHelp.Size = new System.Drawing.Size(139, 22);
            this.mnuAboutHelp.Text = "Help";
            this.mnuAboutHelp.Click += new System.EventHandler(this.mnuAboutHelp_Click);
            // 
            // mnuAboutAbout
            // 
            this.mnuAboutAbout.Name = "mnuAboutAbout";
            this.mnuAboutAbout.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuAboutAbout.Size = new System.Drawing.Size(139, 22);
            this.mnuAboutAbout.Text = "About";
            this.mnuAboutAbout.Click += new System.EventHandler(this.mnuAboutAbout_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(150, 35);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(13, 13);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "0";
            // 
            // time
            // 
            this.time.Interval = 900;
            // 
            // lblFlagsUsed
            // 
            this.lblFlagsUsed.AutoSize = true;
            this.lblFlagsUsed.Location = new System.Drawing.Point(35, 35);
            this.lblFlagsUsed.Name = "lblFlagsUsed";
            this.lblFlagsUsed.Size = new System.Drawing.Size(0, 13);
            this.lblFlagsUsed.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(195, 273);
            this.Controls.Add(this.lblFlagsUsed);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnSmile);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minesweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayStart;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuDifficultyEasy;
        private System.Windows.Forms.ToolStripMenuItem MnuDifficultyIntermediate;
        private System.Windows.Forms.ToolStripMenuItem MnuDifficultyHard;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutHelp;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lblFlagsUsed;
        private System.Windows.Forms.ToolStripMenuItem mnuPlayExit;
    }
}

