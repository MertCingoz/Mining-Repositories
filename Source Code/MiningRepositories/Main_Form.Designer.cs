namespace Odev3
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
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
            this.btnCommitter.Location = new System.Drawing.Point(9, 133);
            this.btnCommitter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCommitter.Name = "btnCommitter";
            this.btnCommitter.Size = new System.Drawing.Size(112, 24);
            this.btnCommitter.TabIndex = 0;
            this.btnCommitter.Text = "Get Committer";
            this.btnCommitter.UseVisualStyleBackColor = true;
            this.btnCommitter.Click += new System.EventHandler(this.bntCommitter_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(9, 171);
            this.btnMatrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(112, 24);
            this.btnMatrix.TabIndex = 1;
            this.btnMatrix.Text = "Create Matrix";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnVisualize
            // 
            this.btnVisualize.Location = new System.Drawing.Point(9, 208);
            this.btnVisualize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(112, 24);
            this.btnVisualize.TabIndex = 2;
            this.btnVisualize.Text = "Visualize";
            this.btnVisualize.UseVisualStyleBackColor = true;
            this.btnVisualize.Click += new System.EventHandler(this.btnVisualize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(157, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Information: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(162, 214);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(9, 96);
            this.btnGit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(112, 24);
            this.btnGit.TabIndex = 5;
            this.btnGit.Text = "Get Data";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(80, 13);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(350, 20);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "https://chromium.googlesource.com/chromium/src/tools/android";
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Location = new System.Drawing.Point(9, 15);
            this.lblRepo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(52, 13);
            this.lblRepo.TabIndex = 9;
            this.lblRepo.Text = "Repo Url:";
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Location = new System.Drawing.Point(9, 42);
            this.lblAfter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(58, 13);
            this.lblAfter.TabIndex = 10;
            this.lblAfter.Text = "After Date:";
            // 
            // datePickerAfter
            // 
            this.datePickerAfter.Location = new System.Drawing.Point(80, 40);
            this.datePickerAfter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickerAfter.Name = "datePickerAfter";
            this.datePickerAfter.Size = new System.Drawing.Size(201, 20);
            this.datePickerAfter.TabIndex = 11;
            this.datePickerAfter.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // datePickerBefore
            // 
            this.datePickerBefore.Location = new System.Drawing.Point(80, 67);
            this.datePickerBefore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickerBefore.Name = "datePickerBefore";
            this.datePickerBefore.Size = new System.Drawing.Size(201, 20);
            this.datePickerBefore.TabIndex = 12;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Location = new System.Drawing.Point(9, 69);
            this.lblBefore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(64, 13);
            this.lblBefore.TabIndex = 13;
            this.lblBefore.Text = "Before Date";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 265);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main_Form";
            this.Text = "MiningRepositories";
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

