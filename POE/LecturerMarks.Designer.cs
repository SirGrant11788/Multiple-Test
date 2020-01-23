namespace POE
{
    partial class LecturerMarks
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
            this.lblLecturerMarks = new System.Windows.Forms.Label();
            this.btnLectureMarksHome = new System.Windows.Forms.Button();
            this.btnLecturerMarksExit = new System.Windows.Forms.Button();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLecturerMarks
            // 
            this.lblLecturerMarks.AutoSize = true;
            this.lblLecturerMarks.Location = new System.Drawing.Point(215, 6);
            this.lblLecturerMarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLecturerMarks.Name = "lblLecturerMarks";
            this.lblLecturerMarks.Size = new System.Drawing.Size(78, 13);
            this.lblLecturerMarks.TabIndex = 0;
            this.lblLecturerMarks.Text = "Lecturer Marks";
            this.lblLecturerMarks.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLectureMarksHome
            // 
            this.btnLectureMarksHome.Location = new System.Drawing.Point(8, 248);
            this.btnLectureMarksHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLectureMarksHome.Name = "btnLectureMarksHome";
            this.btnLectureMarksHome.Size = new System.Drawing.Size(133, 45);
            this.btnLectureMarksHome.TabIndex = 2;
            this.btnLectureMarksHome.Text = "Home";
            this.btnLectureMarksHome.UseVisualStyleBackColor = true;
            this.btnLectureMarksHome.Click += new System.EventHandler(this.btnLectureMarksHome_Click);
            // 
            // btnLecturerMarksExit
            // 
            this.btnLecturerMarksExit.Location = new System.Drawing.Point(396, 248);
            this.btnLecturerMarksExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLecturerMarksExit.Name = "btnLecturerMarksExit";
            this.btnLecturerMarksExit.Size = new System.Drawing.Size(133, 45);
            this.btnLecturerMarksExit.TabIndex = 3;
            this.btnLecturerMarksExit.Text = "Exit";
            this.btnLecturerMarksExit.UseVisualStyleBackColor = true;
            this.btnLecturerMarksExit.Click += new System.EventHandler(this.btnLecturerMarksExit_Click);
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.Location = new System.Drawing.Point(8, 21);
            this.lbxDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(523, 225);
            this.lbxDisplay.TabIndex = 4;
            this.lbxDisplay.SelectedIndexChanged += new System.EventHandler(this.lbxDisplay_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(194, 248);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 45);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // LecturerMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbxDisplay);
            this.Controls.Add(this.btnLecturerMarksExit);
            this.Controls.Add(this.btnLectureMarksHome);
            this.Controls.Add(this.lblLecturerMarks);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LecturerMarks";
            this.Text = "LecturerMarks";
            this.Load += new System.EventHandler(this.LecturerMarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLecturerMarks;
        private System.Windows.Forms.Button btnLectureMarksHome;
        private System.Windows.Forms.Button btnLecturerMarksExit;
        private System.Windows.Forms.ListBox lbxDisplay;
        private System.Windows.Forms.Button btnLoad;
    }
}