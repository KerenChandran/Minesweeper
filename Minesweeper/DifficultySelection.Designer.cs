namespace Minesweeper
{
    partial class frmDifficultySelection
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.radBegin = new System.Windows.Forms.RadioButton();
            this.radIntermediate = new System.Windows.Forms.RadioButton();
            this.radExpert = new System.Windows.Forms.RadioButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(105, 123);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // radBegin
            // 
            this.radBegin.AutoSize = true;
            this.radBegin.Location = new System.Drawing.Point(105, 44);
            this.radBegin.Name = "radBegin";
            this.radBegin.Size = new System.Drawing.Size(67, 17);
            this.radBegin.TabIndex = 1;
            this.radBegin.TabStop = true;
            this.radBegin.Text = "Beginner";
            this.radBegin.UseVisualStyleBackColor = true;
            // 
            // radIntermediate
            // 
            this.radIntermediate.AutoSize = true;
            this.radIntermediate.Location = new System.Drawing.Point(105, 67);
            this.radIntermediate.Name = "radIntermediate";
            this.radIntermediate.Size = new System.Drawing.Size(83, 17);
            this.radIntermediate.TabIndex = 2;
            this.radIntermediate.TabStop = true;
            this.radIntermediate.Text = "Intermediate";
            this.radIntermediate.UseVisualStyleBackColor = true;
            // 
            // radExpert
            // 
            this.radExpert.AutoSize = true;
            this.radExpert.Location = new System.Drawing.Point(105, 90);
            this.radExpert.Name = "radExpert";
            this.radExpert.Size = new System.Drawing.Size(55, 17);
            this.radExpert.TabIndex = 3;
            this.radExpert.TabStop = true;
            this.radExpert.Text = "Expert";
            this.radExpert.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(179, 166);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(31, 166);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmDifficultySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 219);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.radExpert);
            this.Controls.Add(this.radIntermediate);
            this.Controls.Add(this.radBegin);
            this.Controls.Add(this.btnSelect);
            this.Name = "frmDifficultySelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DifficultySelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RadioButton radBegin;
        private System.Windows.Forms.RadioButton radIntermediate;
        private System.Windows.Forms.RadioButton radExpert;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
    }
}