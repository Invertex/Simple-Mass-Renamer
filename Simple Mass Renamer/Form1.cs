using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace SimpleMassRenamer
{
    public partial class SimplerRenamer : Form
    {
        public readonly string gitPage = "https://github.com/Invertex/Simple-Mass-Renamer";
        public string[] fileList;
        public string cantRenameText = "Drag Files and/or Folders Here";
        public int renamedFiles = 0;
        public int renamedFolders = 0;

        public SimplerRenamer()
        {
            InitializeComponent();
            conflictOptions.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public enum ConflictSetting
        {
            Overwrite = 0, DontRename = 1, DeleteSelf = 2
        };
        public ConflictSetting conflictSetting = ConflictSetting.DeleteSelf;

        private void processDrop(object sender, DragEventArgs e)
        {
            dropInfo.Text = "Calculating input file count...";
            fileList = (string[])e.Data.GetData(DataFormats.FileDrop, true);

            int fileCount = 0;
            int folderCount = 0;

            foreach (string file in fileList)
            {
                if(!File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                {
                    fileCount += 1;
                }
                else
                {
                    if (renameFolders.Checked)
                    {
                        folderCount += 1;
                        if (doSubDirs.Checked)
                        {
                            folderCount += Directory.GetDirectories(file, "*", SearchOption.AllDirectories).Length;
                        }
                        else
                        {
                            folderCount += Directory.GetDirectories(file, "*", SearchOption.TopDirectoryOnly).Length;
                        }
                    }
                    if (doSubDirs.Checked)
                    {
                        fileCount += Directory.GetFiles(file, "*", SearchOption.AllDirectories).Length;
                    }
                    else
                    {
                        fileCount += Directory.GetFiles(file, "*", SearchOption.TopDirectoryOnly).Length;
                    }
                }
            }

            if (fileCount > 0 || folderCount > 0)
            {
                string dropText = fileCount + " Files to Process";

                if (folderCount > 0 && renameFolders.Checked)
                {
                    dropText = folderCount + " Folders && " + dropText;
                }

                dropInfo.Text = dropText;
            }
            else
            {
                dropInfo.Text = cantRenameText;
            }
        }

        private void startRename(object sender, EventArgs e)
        {
            string replaceText = replaceInput.Text;
            string replaceWithText = replaceWithInput.Text;
            dropPanel.Enabled = false;
            if (fileList != null)
            {
                if (replaceText != "" && replaceText != null)
                {
                    outputLog.Text = "";
                    foreach (string file in fileList)
                    {
                        if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                        {
                            renameFilesInDirectory(file, replaceText, replaceWithText);
                        }
                        else
                        {
                            renameFile(file, replaceText, replaceWithText);
                        }
                    }

                    outputLog.AppendLine("");
                    outputLog.AppendLine("Renaming Finished!");
                    outputLog.AppendLine(renamedFiles + " Files and " + renamedFolders + " Folders renamed.");

                    fileList = null;
                    renamedFiles = 0;
                    renamedFolders = 0;
                    dropInfo.Text = cantRenameText;
                }
                else
                {
                    outputLog.AppendLine("No text to replace has been input. Cannot rename.");
                }
            }
            else
            {
                outputLog.AppendLine("No files or folders have been dragged onto app. Nothing to rename.");
            }
            dropPanel.Enabled = true;
        }

        private void renameFilesInDirectory(string dir, string replace, string replaceWith)
        {
            string[] files = Directory.GetFiles(dir);

            for (int i = 0; i < files.Length; i++)
            {
                renameFile(files[i], replace, replaceWith);
            }

            DirectoryInfo folder = new DirectoryInfo(dir);

            if (doSubDirs.Checked)
            {
                foreach (DirectoryInfo subFolder in folder.GetDirectories())
                {
                    renameFilesInDirectory(subFolder.FullName, replace, replaceWith);

                }
            }
            if (renameFolders.Checked)
            {
                renameDirectory(dir, replace, replaceWith);
            }
        }

        private void renameFile(string file, string replace, string replaceWith)
        {
            string fileName = Path.GetFileName(file);
            string oldName = fileName;
            string filePath = Path.GetDirectoryName(file);
            fileName = fileName.Replace(replace, replaceWith);
            
            if (fileName != oldName)
            {
                fileName = Path.Combine(filePath, fileName);

                if(File.Exists(fileName))
                {
                    if(conflictSetting == ConflictSetting.DeleteSelf)
                    {
                        File.Delete(file);
                        return;
                    }
                    else if(conflictSetting == ConflictSetting.DontRename)
                    {
                        return;
                    }
                    else
                    {
                        File.Delete(fileName);
                    }
                }
                
                File.Move(file, fileName);
                outputLog.AppendText(Environment.NewLine);
                outputLog.AppendLine("File: ");
                outputLog.AppendLine(file + " >> " + fileName);
                renamedFiles += 1;
            }
        }

        private void renameDirectory(string dir, string replace, string replaceWith)
        {
            string folderName = Path.GetFileName(dir);
            string oldName = folderName;
            string folderPath = Path.GetDirectoryName(dir);
            folderName = folderName.Replace(replace, replaceWith);

            if (folderName != oldName)
            {
                folderName = Path.Combine(folderPath, folderName);

                if (!File.Exists(folderName))
                {
                    Directory.Move(dir, folderName);
                    outputLog.AppendText(Environment.NewLine);
                    outputLog.AppendLine("Folder: ");
                    outputLog.AppendLine(dir + " >> " + folderName);
                    renamedFolders += 1;
                }
                else
                {
                    outputLog.AppendText(Environment.NewLine);
                    outputLog.AppendLine("'" + folderName + "' already exists. Cannot rename '" + dir + "' to it.");
                }
            }
        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void openGitPage(object sender, EventArgs e)
        {
            Process.Start(gitPage);
        }

        private void ChangeConflictSetting(object sender, EventArgs e)
        {
            //Enum.TryParse<ConflictSetting>(conflictOptions.SelectedValue.ToString(), out conflictSetting);
            conflictSetting = (ConflictSetting)conflictOptions.SelectedValue;
            Console.WriteLine(conflictSetting.ToString());
        }
    }
}
