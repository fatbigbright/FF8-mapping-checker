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
         this.txtFileJP1 = new System.Windows.Forms.TextBox();
         this.txtFileJP2 = new System.Windows.Forms.TextBox();
         this.txtFileJP3 = new System.Windows.Forms.TextBox();
         this.txtFileJP4 = new System.Windows.Forms.TextBox();
         this.lblFileNameJP1 = new System.Windows.Forms.Label();
         this.lblFileNameJP2 = new System.Windows.Forms.Label();
         this.lblFileNameJP3 = new System.Windows.Forms.Label();
         this.lblFileNameJP4 = new System.Windows.Forms.Label();
         this.lblFileName1 = new System.Windows.Forms.Label();
         this.lblFileName2 = new System.Windows.Forms.Label();
         this.lblFileName3 = new System.Windows.Forms.Label();
         this.lblFileName4 = new System.Windows.Forms.Label();
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
         this.lstMapping.Size = new System.Drawing.Size(193, 836);
         this.lstMapping.TabIndex = 6;
         this.lstMapping.SelectedIndexChanged += new System.EventHandler(this.lstMapping_SelectedIndexChanged);
         // 
         // txtFile1
         // 
         this.txtFile1.Location = new System.Drawing.Point(211, 547);
         this.txtFile1.Multiline = true;
         this.txtFile1.Name = "txtFile1";
         this.txtFile1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile1.Size = new System.Drawing.Size(255, 394);
         this.txtFile1.TabIndex = 7;
         // 
         // txtFile2
         // 
         this.txtFile2.Location = new System.Drawing.Point(472, 547);
         this.txtFile2.Multiline = true;
         this.txtFile2.Name = "txtFile2";
         this.txtFile2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile2.Size = new System.Drawing.Size(252, 394);
         this.txtFile2.TabIndex = 8;
         // 
         // txtFile3
         // 
         this.txtFile3.Location = new System.Drawing.Point(730, 547);
         this.txtFile3.Multiline = true;
         this.txtFile3.Name = "txtFile3";
         this.txtFile3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile3.Size = new System.Drawing.Size(265, 394);
         this.txtFile3.TabIndex = 9;
         // 
         // txtFile4
         // 
         this.txtFile4.Location = new System.Drawing.Point(999, 547);
         this.txtFile4.Multiline = true;
         this.txtFile4.Name = "txtFile4";
         this.txtFile4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFile4.Size = new System.Drawing.Size(265, 394);
         this.txtFile4.TabIndex = 10;
         // 
         // txtFileJP1
         // 
         this.txtFileJP1.Location = new System.Drawing.Point(211, 113);
         this.txtFileJP1.Multiline = true;
         this.txtFileJP1.Name = "txtFileJP1";
         this.txtFileJP1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFileJP1.Size = new System.Drawing.Size(255, 394);
         this.txtFileJP1.TabIndex = 11;
         // 
         // txtFileJP2
         // 
         this.txtFileJP2.Location = new System.Drawing.Point(472, 113);
         this.txtFileJP2.Multiline = true;
         this.txtFileJP2.Name = "txtFileJP2";
         this.txtFileJP2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFileJP2.Size = new System.Drawing.Size(252, 394);
         this.txtFileJP2.TabIndex = 12;
         // 
         // txtFileJP3
         // 
         this.txtFileJP3.Location = new System.Drawing.Point(730, 113);
         this.txtFileJP3.Multiline = true;
         this.txtFileJP3.Name = "txtFileJP3";
         this.txtFileJP3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFileJP3.Size = new System.Drawing.Size(265, 394);
         this.txtFileJP3.TabIndex = 13;
         // 
         // txtFileJP4
         // 
         this.txtFileJP4.Location = new System.Drawing.Point(1001, 113);
         this.txtFileJP4.Multiline = true;
         this.txtFileJP4.Name = "txtFileJP4";
         this.txtFileJP4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtFileJP4.Size = new System.Drawing.Size(265, 394);
         this.txtFileJP4.TabIndex = 14;
         // 
         // lblFileNameJP1
         // 
         this.lblFileNameJP1.AutoSize = true;
         this.lblFileNameJP1.Location = new System.Drawing.Point(211, 98);
         this.lblFileNameJP1.Name = "lblFileNameJP1";
         this.lblFileNameJP1.Size = new System.Drawing.Size(0, 13);
         this.lblFileNameJP1.TabIndex = 15;
         // 
         // lblFileNameJP2
         // 
         this.lblFileNameJP2.AutoSize = true;
         this.lblFileNameJP2.Location = new System.Drawing.Point(472, 98);
         this.lblFileNameJP2.Name = "lblFileNameJP2";
         this.lblFileNameJP2.Size = new System.Drawing.Size(0, 13);
         this.lblFileNameJP2.TabIndex = 16;
         // 
         // lblFileNameJP3
         // 
         this.lblFileNameJP3.AutoSize = true;
         this.lblFileNameJP3.Location = new System.Drawing.Point(727, 97);
         this.lblFileNameJP3.Name = "lblFileNameJP3";
         this.lblFileNameJP3.Size = new System.Drawing.Size(0, 13);
         this.lblFileNameJP3.TabIndex = 17;
         // 
         // lblFileNameJP4
         // 
         this.lblFileNameJP4.AutoSize = true;
         this.lblFileNameJP4.Location = new System.Drawing.Point(998, 97);
         this.lblFileNameJP4.Name = "lblFileNameJP4";
         this.lblFileNameJP4.Size = new System.Drawing.Size(0, 13);
         this.lblFileNameJP4.TabIndex = 18;
         // 
         // lblFileName1
         // 
         this.lblFileName1.AutoSize = true;
         this.lblFileName1.Location = new System.Drawing.Point(211, 531);
         this.lblFileName1.Name = "lblFileName1";
         this.lblFileName1.Size = new System.Drawing.Size(0, 13);
         this.lblFileName1.TabIndex = 19;
         // 
         // lblFileName2
         // 
         this.lblFileName2.AutoSize = true;
         this.lblFileName2.Location = new System.Drawing.Point(472, 531);
         this.lblFileName2.Name = "lblFileName2";
         this.lblFileName2.Size = new System.Drawing.Size(0, 13);
         this.lblFileName2.TabIndex = 20;
         // 
         // lblFileName3
         // 
         this.lblFileName3.AutoSize = true;
         this.lblFileName3.Location = new System.Drawing.Point(727, 531);
         this.lblFileName3.Name = "lblFileName3";
         this.lblFileName3.Size = new System.Drawing.Size(0, 13);
         this.lblFileName3.TabIndex = 21;
         // 
         // lblFileName4
         // 
         this.lblFileName4.AutoSize = true;
         this.lblFileName4.Location = new System.Drawing.Point(998, 531);
         this.lblFileName4.Name = "lblFileName4";
         this.lblFileName4.Size = new System.Drawing.Size(0, 13);
         this.lblFileName4.TabIndex = 22;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1276, 953);
         this.Controls.Add(this.lblFileName4);
         this.Controls.Add(this.lblFileName3);
         this.Controls.Add(this.lblFileName2);
         this.Controls.Add(this.lblFileName1);
         this.Controls.Add(this.lblFileNameJP4);
         this.Controls.Add(this.lblFileNameJP3);
         this.Controls.Add(this.lblFileNameJP2);
         this.Controls.Add(this.lblFileNameJP1);
         this.Controls.Add(this.txtFileJP4);
         this.Controls.Add(this.txtFileJP3);
         this.Controls.Add(this.txtFileJP2);
         this.Controls.Add(this.txtFileJP1);
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
      private System.Windows.Forms.TextBox txtFileJP1;
      private System.Windows.Forms.TextBox txtFileJP2;
      private System.Windows.Forms.TextBox txtFileJP3;
      private System.Windows.Forms.TextBox txtFileJP4;
      private System.Windows.Forms.Label lblFileNameJP1;
      private System.Windows.Forms.Label lblFileNameJP2;
      private System.Windows.Forms.Label lblFileNameJP3;
      private System.Windows.Forms.Label lblFileNameJP4;
      private System.Windows.Forms.Label lblFileName1;
      private System.Windows.Forms.Label lblFileName2;
      private System.Windows.Forms.Label lblFileName3;
      private System.Windows.Forms.Label lblFileName4;
   }
}

