namespace Coaching_Classes
{
    partial class Frantpage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.courseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseDetailsToolStripMenuItem,
            this.teacherDetailsToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.feesDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // courseDetailsToolStripMenuItem
            // 
            this.courseDetailsToolStripMenuItem.Name = "courseDetailsToolStripMenuItem";
            this.courseDetailsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.courseDetailsToolStripMenuItem.Text = "Course Details";
            this.courseDetailsToolStripMenuItem.Click += new System.EventHandler(this.courseDetailsToolStripMenuItem_Click);
            // 
            // teacherDetailsToolStripMenuItem
            // 
            this.teacherDetailsToolStripMenuItem.Name = "teacherDetailsToolStripMenuItem";
            this.teacherDetailsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.teacherDetailsToolStripMenuItem.Text = "Teacher Details";
            this.teacherDetailsToolStripMenuItem.Click += new System.EventHandler(this.teacherDetailsToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // feesDetailsToolStripMenuItem
            // 
            this.feesDetailsToolStripMenuItem.Name = "feesDetailsToolStripMenuItem";
            this.feesDetailsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.feesDetailsToolStripMenuItem.Text = "Fees Details";
            this.feesDetailsToolStripMenuItem.Click += new System.EventHandler(this.feesDetailsToolStripMenuItem_Click);
            // 
            // Frantpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coaching_Classes.Properties.Resources.demo;
            this.ClientSize = new System.Drawing.Size(375, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frantpage";
            this.Text = "Frantpage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem courseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesDetailsToolStripMenuItem;
    }
}