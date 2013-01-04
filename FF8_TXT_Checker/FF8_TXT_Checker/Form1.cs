using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FF8_TXT_Checker
{
   public partial class Form1 : Form
   {
      private delegate int CheckWorkSpaceHandler(string workSpacePath, out string resultString);

      private delegate void InvokeUIHandler(string status);

      private delegate void InvokeUIHandlerNoParameter();

      private string globalResultString = string.Empty;

      public Form1()
      {
         InitializeComponent();
      }


      private void btnBrowseSync_Click(object sender, EventArgs e)
      {
         if (DialogResult.OK == folderBrowserDialogWorkspace.ShowDialog())
         {
            string resultString = string.Empty;
            if (CheckingMethod(folderBrowserDialogWorkspace.SelectedPath, out resultString) == 0)
            {
               this.txtWorkspace.Text = folderBrowserDialogWorkspace.SelectedPath;

               ReadUpdateMappingFile(folderBrowserDialogWorkspace.SelectedPath);
            }

            this.lblStatus.Text = resultString;
         }
      }

      private void ReadUpdateMappingFile(string workSpacePath)
      {
         string mappingFilePath = string.Format(@"{0}\updates.txt", workSpacePath);

         using (StreamReader reader = new StreamReader(mappingFilePath))
         {
            List<string> mappingList = new List<string>();
            while (reader.Peek() >= 0)
            {
               mappingList.Add(reader.ReadLine());
            }

            this.lstMapping.DataSource = mappingList;
         }
      }

#region Browse and check work space Async
      
      private void btnBrowse_Click(object sender, EventArgs e)
      {
         if (DialogResult.OK == this.folderBrowserDialogWorkspace.ShowDialog())
         {
            CheckWorkSpaceHandler checkWorkSpaceCaller = new CheckWorkSpaceHandler(this.CheckingMethod);
            IAsyncResult result = checkWorkSpaceCaller
               .BeginInvoke(this.folderBrowserDialogWorkspace.SelectedPath
                           , out globalResultString
                           ,new AsyncCallback(this.CallbackMethod), checkWorkSpaceCaller);
            UnableEverything("Checking workspace....");

         }
      }

      private void UnableEverything(string status)
      {
         this.btnBrowse.Enabled = false;
         this.progressBar.Enabled = true;
         this.lblStatus.Text = status;
      }

      private void EnableEverything(string status)
      {
         this.btnBrowse.Enabled = true;
         this.progressBar.Enabled = false;
         this.lblStatus.Text = status;
      }

      private void ShowWorkSpace()
      {
         this.txtWorkspace.Text = this.folderBrowserDialogWorkspace.SelectedPath;
      }


      private void CallbackMethod(IAsyncResult result)
      {
         CheckWorkSpaceHandler checkWorkSpaceCaller = (CheckWorkSpaceHandler)result.AsyncState;

         int returnValue = checkWorkSpaceCaller.EndInvoke(out globalResultString, result);

         //Cannot directly call EnableEverything(), because the controls were created by the main thread
         this.Invoke(new InvokeUIHandler(EnableEverything), globalResultString);

         if (returnValue == 0)
         {
            this.Invoke(new InvokeUIHandlerNoParameter(ShowWorkSpace));
         }
      }

#endregion

      private int CheckingMethod(string workSpacePath, out string resultString)
      {
         if (CheckPath(workSpacePath, @"all_test_texts\1", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\2", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\3", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\4", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\c1", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\c2", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\c3", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\c4", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\m1", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\m2", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\m3", out resultString) == 0 &&
            CheckPath(workSpacePath, @"all_test_texts\m4", out resultString) == 0 &&
            CheckFile(workSpacePath, @"updates.txt", out resultString) == 0)
         {
            resultString = "Work space loaded successfully!";
            return 0;
         }

         return -1;
      }

      private int CheckPath(string workSpacePath, string folderName, out string resultString)
      {
         if (!Directory.Exists(string.Format(@"{0}\{1}", workSpacePath, folderName)))
         {
            resultString = string.Format(@"Directory {0}\{1} does not exists!", workSpacePath, folderName);
            return -1;
         }
         resultString = string.Empty;
         return 0;
      }

      private int CheckFile(string workSpacePath, string suffix, out string resultString)
      {
         if (!File.Exists(string.Format(@"{0}\{1}", workSpacePath, suffix)))
         {
            resultString = string.Format(@"File {0}\{1} does not exists!", workSpacePath, suffix);
            return -1;
         }
         resultString = string.Empty;

         return 0;
      }

      private void lstMapping_SelectedIndexChanged(object sender, EventArgs e)
      {
         txtFile1.Text = string.Empty;
         txtFile2.Text = string.Empty;
         txtFile3.Text = string.Empty;
         txtFile4.Text = string.Empty;

         ListBox lstMapping = sender as ListBox;

         if (lstMapping == null) return;

         string selectString = lstMapping.SelectedValue as string;

         if (string.IsNullOrEmpty(selectString.Trim())) return;

         string[] fileList = selectString.Split(new char[]{'='});

         if (fileList.Length <= 1)
         {
            lblStatus.Text = "Format error in updates.txt";
            return;
         }

         string file1 = fileList[0];
         ReadFileContent(file1, @"{0}\all_test_texts\m{1}\FL {2}.txt", this.txtFile1);

         string file2 = fileList[1];
         ReadFileContent(file2, @"{0}\all_test_texts\c{1}\FL {2}.txt", this.txtFile2);

         if (fileList.Length > 2)
         {
            string file3 = fileList[2];
            ReadFileContent(file3, @"{0}\all_test_texts\c{1}\FL {2}.txt", this.txtFile3);
         }
         if (fileList.Length > 3)
         {
            string file4 = fileList[3];
            ReadFileContent(file4, @"{0}\all_test_texts\c{1}\FL {2}.txt", this.txtFile4);
         }
      }

      private void ReadFileContent(string file, string filePathExpression, TextBox monitor)
      {
         string[] fileParts = file.Split(new char[] { '/' });
         if (fileParts.Length <= 0 || fileParts[0].Length > 1)
         {
            lblStatus.Text = "Format error in updates.txt";
            return;
         }
         using (StreamReader fileReader = new StreamReader(
            string.Format(filePathExpression, txtWorkspace.Text, fileParts[0], fileParts[1])
            , Encoding.GetEncoding("gb2312")))
         {
            monitor.Text = fileReader.ReadToEnd();
         }
      }
   }
}
