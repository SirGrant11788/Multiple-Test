namespace POE
{
    partial class MultipleChoiceTest
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
            this.lblMCT = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.btnViewMarks = new System.Windows.Forms.Button();
            this.btnBeginTest = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMCT
            // 
            this.lblMCT.AutoSize = true;
            this.lblMCT.Location = new System.Drawing.Point(300, 9);
            this.lblMCT.Name = "lblMCT";
            this.lblMCT.Size = new System.Drawing.Size(151, 20);
            this.lblMCT.TabIndex = 0;
            this.lblMCT.Text = "Multiple Choice Test";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(99, 162);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(606, 26);
            this.txtbName.TabIndex = 1;
            this.txtbName.Text = "Name";
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // btnViewMarks
            // 
            this.btnViewMarks.Location = new System.Drawing.Point(12, 360);
            this.btnViewMarks.Name = "btnViewMarks";
            this.btnViewMarks.Size = new System.Drawing.Size(156, 78);
            this.btnViewMarks.TabIndex = 3;
            this.btnViewMarks.Text = "View Mark";
            this.btnViewMarks.UseVisualStyleBackColor = true;
            this.btnViewMarks.Click += new System.EventHandler(this.btnViewMarks_Click);
            // 
            // btnBeginTest
            // 
            this.btnBeginTest.Location = new System.Drawing.Point(304, 361);
            this.btnBeginTest.Name = "btnBeginTest";
            this.btnBeginTest.Size = new System.Drawing.Size(156, 78);
            this.btnBeginTest.TabIndex = 4;
            this.btnBeginTest.Text = "Begin Test";
            this.btnBeginTest.UseVisualStyleBackColor = true;
            this.btnBeginTest.Click += new System.EventHandler(this.btnBeginTest_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreate.Location = new System.Drawing.Point(632, 361);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(156, 78);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create Test";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // MultipleChoiceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnBeginTest);
            this.Controls.Add(this.btnViewMarks);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblMCT);
            this.Name = "MultipleChoiceTest";
            this.Text = "Multiple Choice Test";
            this.Load += new System.EventHandler(this.MultipleChoiceTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMCT;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Button btnViewMarks;
        private System.Windows.Forms.Button btnBeginTest;
        private System.Windows.Forms.Button btnCreate;
    }
}

