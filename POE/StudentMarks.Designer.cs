namespace POE
{
    partial class StudentMarks
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
            this.lblViewStudentMarks = new System.Windows.Forms.Label();
            this.btnStudentMarksHome = new System.Windows.Forms.Button();
            this.btnStudentMarksExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblViewStudentMarks
            // 
            this.lblViewStudentMarks.AutoSize = true;
            this.lblViewStudentMarks.Location = new System.Drawing.Point(211, 6);
            this.lblViewStudentMarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewStudentMarks.Name = "lblViewStudentMarks";
            this.lblViewStudentMarks.Size = new System.Drawing.Size(76, 13);
            this.lblViewStudentMarks.TabIndex = 0;
            this.lblViewStudentMarks.Text = "Student Marks";
            // 
            // btnStudentMarksHome
            // 
            this.btnStudentMarksHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnStudentMarksHome.Location = new System.Drawing.Point(8, 233);
            this.btnStudentMarksHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentMarksHome.Name = "btnStudentMarksHome";
            this.btnStudentMarksHome.Size = new System.Drawing.Size(111, 52);
            this.btnStudentMarksHome.TabIndex = 2;
            this.btnStudentMarksHome.Text = "Home";
            this.btnStudentMarksHome.UseVisualStyleBackColor = false;
            this.btnStudentMarksHome.Click += new System.EventHandler(this.btnStudentMarksHome_Click);
            // 
            // btnStudentMarksExit
            // 
            this.btnStudentMarksExit.Location = new System.Drawing.Point(417, 233);
            this.btnStudentMarksExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentMarksExit.Name = "btnStudentMarksExit";
            this.btnStudentMarksExit.Size = new System.Drawing.Size(108, 52);
            this.btnStudentMarksExit.TabIndex = 3;
            this.btnStudentMarksExit.Text = "Exit";
            this.btnStudentMarksExit.UseVisualStyleBackColor = true;
            this.btnStudentMarksExit.Click += new System.EventHandler(this.btnStudentMarksExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(193, 233);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 51);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Marks";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.Location = new System.Drawing.Point(9, 23);
            this.lbxDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(518, 199);
            this.lbxDisplay.TabIndex = 5;
            this.lbxDisplay.SelectedIndexChanged += new System.EventHandler(this.lbxDisplay_SelectedIndexChanged);
            // 
            // StudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lbxDisplay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnStudentMarksExit);
            this.Controls.Add(this.btnStudentMarksHome);
            this.Controls.Add(this.lblViewStudentMarks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentMarks";
            this.Text = "Student Marks";
            this.Load += new System.EventHandler(this.StudentMarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewStudentMarks;
        private System.Windows.Forms.Button btnStudentMarksHome;
        private System.Windows.Forms.Button btnStudentMarksExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxDisplay;
    }
}