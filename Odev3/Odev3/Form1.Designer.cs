namespace Odev3
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
            this.btnCommitter = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnGit = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblRepo = new System.Windows.Forms.Label();
            this.lblAfter = new System.Windows.Forms.Label();
            this.datePickerAfter = new System.Windows.Forms.DateTimePicker();
            this.datePickerBefore = new System.Windows.Forms.DateTimePicker();
            this.lblBefore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommitter
            // 
            this.btnCommitter.Location = new System.Drawing.Point(12, 164);
            this.btnCommitter.Name = "btnCommitter";
            this.btnCommitter.Size = new System.Drawing.Size(150, 30);
            this.btnCommitter.TabIndex = 0;
            this.btnCommitter.Text = "Get Committer";
            this.btnCommitter.UseVisualStyleBackColor = true;
            this.btnCommitter.Click += new System.EventHandler(this.bntCommitter_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(12, 210);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(150, 30);
            this.btnMatrix.TabIndex = 1;
            this.btnMatrix.Text = "Create Matrix";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnVisualize
            // 
            this.btnVisualize.Location = new System.Drawing.Point(12, 256);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(150, 30);
            this.btnVisualize.TabIndex = 2;
            this.btnVisualize.Text = "Visualize";
            this.btnVisualize.UseVisualStyleBackColor = true;
            this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(209, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Information: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(216, 263);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(12, 118);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(150, 30);
            this.btnGit.TabIndex = 5;
            this.btnGit.Text = "Get Data";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(106, 16);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(465, 22);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "https://chromium.googlesource.com/chromium/src/tools/android";
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(12, 19);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(68, 17);
            this.lblRepo.TabIndex = 9;
            this.lblRepo.Text = "Repo Url:";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Location = new System.Drawing.Point(12, 52);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(76, 17);
            this.lblAfter.TabIndex = 10;
            this.lblAfter.Text = "After Date:";
            // 
            // datePickerAfter
            // 
            this.datePickerAfter.Location = new System.Drawing.Point(106, 49);
            this.datePickerAfter.Name = "datePickerAfter";
            this.datePickerAfter.Size = new System.Drawing.Size(267, 22);
            this.datePickerAfter.TabIndex = 11;
            this.datePickerAfter.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // datePickerBefore
            // 
            this.datePickerBefore.Location = new System.Drawing.Point(106, 82);
            this.datePickerBefore.Name = "datePickerBefore";
            this.datePickerBefore.Size = new System.Drawing.Size(267, 22);
            this.datePickerBefore.TabIndex = 12;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(12, 85);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(84, 17);
            this.lblBefore.TabIndex = 13;
            this.lblBefore.Text = "Before Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 326);
            this.Controls.Add(this.lblBefore);
            this.Controls.Add(this.datePickerBefore);
            this.Controls.Add(this.datePickerAfter);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.lblRepo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisualize);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnCommitter);
            this.Name = "Form1";
            this.Text = "Project 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommitter;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnVisualize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblRepo;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.DateTimePicker datePickerAfter;
        private System.Windows.Forms.DateTimePicker datePickerBefore;
        private System.Windows.Forms.Label lblBefore;
    }
}

