namespace FF8_TXT_Checker
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
         this.lblGetMainDir = new System.Windows.Forms.Label();
         this.txtWorkspace = new System.Windows.Forms.TextBox();
         this.btnBrowse = new System.Windows.Forms.Button();
         this.folderBrowserDialogWorkspace = new System.Windows.Forms.FolderBrowserDialog();
         this.progressBar = new System.Windows.Forms.ProgressBar();
         this.lblStatus = new System.Windows.Forms.Label();
         this.btnBrowseSync = new System.Windows.Forms.Button();
         this.lstMapping = new System.Windows.Forms.ListBox();
         this.txtFile1 = new System.Windows.Forms.TextBox();
         this.txtFile2 = new System.Windows.Forms.TextBox();
         this.txtFile3 = new System.Windows.Forms.TextBox();
         this.txtFile4 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // lblGetMainDir
         // 
         this.lblGetMainDir.AutoSize = true;
         this.lblGetMainDir.Location = new System.Drawing.Point(13, 13);
         this.lblGetMainDir.Name = "lblGetMainDir";
         this.lblGetMainDir.Size = new System.Drawing.Size(116, 13);
         this.lblGetMainDir.TabIndex = 0;
         this.lblGetMainDir.Text = "Select the Workspace:";
         // 
         // txtWorkspace
         // 
         this.txtWorkspace.Location = new System.Drawing.Point(136, 13);
         this.txtWorkspace.Name = "txtWorkspace";
         this.txtWorkspace.ReadOnly = true;
         this.txtWorkspace.Size = new System.Drawing.Size(350, 20);
         this.txtWorkspace.TabIndex = 1;
         // 
         // btnBrowse
         // 
         this.btnBrowse.Location = new System.Drawing.Point(411, 43);
         this.btnBrowse.Name = "btnBrowse";
         this.btnBrowse.Size = new System.Drawing.Size(156, 24);
         this.btnBrowse.TabIndex = 2;
         this.btnBrowse.Text = "Browse And Check Async...";
         this.btnBrowse.UseVisualStyleBackColor = true;
         this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
         // 
         // progressBar
         // 
         this.progressBar.Location = new System.Drawing.Point(16, 68);
         this.progressBar.Name = "progressBar";
         this.progressBar.Size = new System.Drawing.Size(551, 23);
         this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         this.progressBar.TabIndex = 3;
         // 
         // lblStatus
         // 
         this.lblStatus.AutoSize = true;
         this.lblStatus.Location = new System.Drawing.Point(16, 49);
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size(0, 13);
         this.lblStatus.TabIndex = 4;
         // 
         // btnBrowseSync
         // 
         this.btnBrowseSync.Location = new System.Drawing.Point(492, 12);
         this.btnBrowseSync.Name = "btnBrowseSync";
         this.btnBrowseSync.Size = new System.Drawing.Size(75, 23);
         this.btnBrowseSync.TabIndex = 5;
         this.btnBrowseSync.Text = "Browse...";
         this.btnBrowseSync.UseVisualStyleBackColor = true;
         this.btnBrowseSync.Click += new System.EventHandler(this.btnBrowseSync_Click);
         // 
         // lstMapping
         // 
         this.lstMapping.FormattingEnabled = true;
         this.lstMapping.Location = new System.Drawing.Point(12, 113);
         this.lstMapping.Name = "lstMapping";
         this.lstMapping.Size = new System.Drawing.Size(193, 394);
         this.lstMapping.TabIndex = 6;
         this.lstMapping.SelectedIndexChanged += new System.EventHandler(this.lstMapping_SelectedIndexChanged);
         // 
         // txtFile1
         // 
         this.txtFile1.Location = new System.Drawing.Point(211, 113);
         this.txtFile1.Multiline = true;
         this.txtFile1.Name = "txtFile1";
         this.txtFile1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile1.Size = new System.Drawing.Size(255, 394);
         this.txtFile1.TabIndex = 7;
         // 
         // txtFile2
         // 
         this.txtFile2.Location = new System.Drawing.Point(472, 113);
         this.txtFile2.Multiline = true;
         this.txtFile2.Name = "txtFile2";
         this.txtFile2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile2.Size = new System.Drawing.Size(252, 394);
         this.txtFile2.TabIndex = 8;
         // 
         // txtFile3
         // 
         this.txtFile3.Location = new System.Drawing.Point(730, 113);
         this.txtFile3.Multiline = true;
         this.txtFile3.Name = "txtFile3";
         this.txtFile3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile3.Size = new System.Drawing.Size(265, 394);
         this.txtFile3.TabIndex = 9;
         // 
         // txtFile4
         // 
         this.txtFile4.Location = new System.Drawing.Point(1001, 113);
         this.txtFile4.Multiline = true;
         this.txtFile4.Name = "txtFile4";
         this.txtFile4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile4.Size = new System.Drawing.Size(265, 394);
         this.txtFile4.TabIndex = 10;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1284, 516);
         this.Controls.Add(this.txtFile4);
         this.Controls.Add(this.txtFile3);
         this.Controls.Add(this.txtFile2);
         this.Controls.Add(this.txtFile1);
         this.Controls.Add(this.lstMapping);
         this.Controls.Add(this.btnBrowseSync);
         this.Controls.Add(this.lblStatus);
         this.Controls.Add(this.progressBar);
         this.Controls.Add(this.btnBrowse);
         this.Controls.Add(this.txtWorkspace);
         this.Controls.Add(this.lblGetMainDir);
         this.Name = "Form1";
         this.Text = "FF8_TXT_Checker";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblGetMainDir;
      private System.Windows.Forms.TextBox txtWorkspace;
      private System.Windows.Forms.Button btnBrowse;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogWorkspace;
      private System.Windows.Forms.ProgressBar progressBar;
      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.Button btnBrowseSync;
      private System.Windows.Forms.ListBox lstMapping;
      private System.Windows.Forms.TextBox txtFile1;
      private System.Windows.Forms.TextBox txtFile2;
      private System.Windows.Forms.TextBox txtFile3;
      private System.Windows.Forms.TextBox txtFile4;
   }
}

