using System;

namespace SimpleMassRenamer
{
    partial class SimplerRenamer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplerRenamer));
            System.Windows.Forms.Label replaceWithLabel;
            System.Windows.Forms.Panel renameToBorderColor;
            System.Windows.Forms.Panel renameToBGColor;
            System.Windows.Forms.Panel replaceInputBGBorder;
            System.Windows.Forms.Panel replaceInputbgPanel;
            this.conflictOptions = new System.Windows.Forms.ComboBox();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.dropInfo = new System.Windows.Forms.Label();
            this.replaceWithInput = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.doSubDirs = new System.Windows.Forms.CheckBox();
            this.renameFolders = new System.Windows.Forms.CheckBox();
            this.outputContainer = new System.Windows.Forms.Panel();
            this.outputLog = new System.Windows.Forms.TextBox();
            this.creator_link = new System.Windows.Forms.Label();
            this.replaceInput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.onFileConflict_label = new System.Windows.Forms.Label();
            this.useRegex = new System.Windows.Forms.CheckBox();
            this.inputsContainer = new System.Windows.Forms.Panel();
            replaceWithLabel = new System.Windows.Forms.Label();
            renameToBorderColor = new System.Windows.Forms.Panel();
            renameToBGColor = new System.Windows.Forms.Panel();
            replaceInputBGBorder = new System.Windows.Forms.Panel();
            replaceInputbgPanel = new System.Windows.Forms.Panel();
            this.dropPanel.SuspendLayout();
            this.outputContainer.SuspendLayout();
            renameToBorderColor.SuspendLayout();
            renameToBGColor.SuspendLayout();
            replaceInputBGBorder.SuspendLayout();
            replaceInputbgPanel.SuspendLayout();
            this.inputsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // conflictOptions
            // 
            this.conflictOptions.FormattingEnabled = true;
            this.conflictOptions.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.conflictOptions.Items.AddRange(new object[] {
            SimpleMassRenamer.SimplerRenamer.ConflictSetting.Overwrite,
            SimpleMassRenamer.SimplerRenamer.ConflictSetting.DontRename,
            SimpleMassRenamer.SimplerRenamer.ConflictSetting.DeleteSelf});
            this.conflictOptions.Location = new System.Drawing.Point(18, 242);
            this.conflictOptions.MaxDropDownItems = 3;
            this.conflictOptions.Name = "conflictOptions";
            this.conflictOptions.Size = new System.Drawing.Size(121, 21);
            this.conflictOptions.TabIndex = 3;
            this.toolTip1.SetToolTip(this.conflictOptions, "What should the renamer do when a file is being renamed to something that already" +
        " exists?");
            this.conflictOptions.SelectedIndexChanged += new System.EventHandler(this.ChangeConflictSetting);
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropPanel.BackColor = System.Drawing.Color.DimGray;
            this.dropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropPanel.Controls.Add(this.dropInfo);
            this.dropPanel.Location = new System.Drawing.Point(12, 15);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(561, 98);
            this.dropPanel.TabIndex = 8;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.processDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // dropInfo
            // 
            this.dropInfo.AccessibleDescription = "Drag all files and folders you wish to rename onto here.";
            this.dropInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dropInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropInfo.BackColor = System.Drawing.Color.Transparent;
            this.dropInfo.CausesValidation = false;
            this.dropInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.dropInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.dropInfo.Location = new System.Drawing.Point(3, 0);
            this.dropInfo.MinimumSize = new System.Drawing.Size(70, 70);
            this.dropInfo.Name = "dropInfo";
            this.dropInfo.Size = new System.Drawing.Size(553, 97);
            this.dropInfo.TabIndex = 0;
            this.dropInfo.Text = "Drag Files and/or Folders Here";
            this.dropInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.dropInfo, resources.GetString("dropInfo.ToolTip"));
            // 
            // replaceWithInput
            // 
            this.replaceWithInput.AccessibleDescription = "Text to replace with.";
            this.replaceWithInput.AccessibleName = "Replacement Text";
            this.replaceWithInput.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.replaceWithInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceWithInput.BackColor = System.Drawing.Color.DimGray;
            this.replaceWithInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replaceWithInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.replaceWithInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.replaceWithInput.Location = new System.Drawing.Point(3, 1);
            this.replaceWithInput.MaxLength = 1000;
            this.replaceWithInput.Name = "replaceWithInput";
            this.replaceWithInput.Size = new System.Drawing.Size(532, 20);
            this.replaceWithInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.replaceWithInput, "Text to replace with.");
            this.replaceWithInput.WordWrap = false;
            this.replaceWithInput.TextChanged += new System.EventHandler(this.replaceWithInput_TextChanged);
            // 
            // renameButton
            // 
            this.renameButton.AccessibleDescription = "Initiate the renaming of all input files and or folders.";
            this.renameButton.AccessibleName = "Rename";
            this.renameButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.renameButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.renameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameButton.BackColor = System.Drawing.Color.DimGray;
            this.renameButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.renameButton.FlatAppearance.BorderSize = 2;
            this.renameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.renameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.renameButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.renameButton.Location = new System.Drawing.Point(230, 224);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(129, 41);
            this.renameButton.TabIndex = 6;
            this.renameButton.Text = "RENAME";
            this.renameButton.UseVisualStyleBackColor = false;
            this.renameButton.Click += new System.EventHandler(this.startRename);
            // 
            // doSubDirs
            // 
            this.doSubDirs.AccessibleDescription = "Look for files and or folders in all sub-folders of input folders.";
            this.doSubDirs.AccessibleName = "Include sub folders.";
            this.doSubDirs.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.doSubDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doSubDirs.AutoSize = true;
            this.doSubDirs.BackColor = System.Drawing.Color.Transparent;
            this.doSubDirs.Checked = true;
            this.doSubDirs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doSubDirs.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.doSubDirs.Location = new System.Drawing.Point(454, 226);
            this.doSubDirs.Name = "doSubDirs";
            this.doSubDirs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doSubDirs.Size = new System.Drawing.Size(119, 17);
            this.doSubDirs.TabIndex = 4;
            this.doSubDirs.Text = "Search Sub Folders";
            this.toolTip1.SetToolTip(this.doSubDirs, "Look for files and or folders in all sub-folders of input folders.");
            this.doSubDirs.UseVisualStyleBackColor = false;
            // 
            // renameFolders
            // 
            this.renameFolders.AccessibleDescription = "Rename folder names as well.";
            this.renameFolders.AccessibleName = "Rename folder names.";
            this.renameFolders.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.renameFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renameFolders.AutoSize = true;
            this.renameFolders.BackColor = System.Drawing.Color.Transparent;
            this.renameFolders.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.renameFolders.Location = new System.Drawing.Point(470, 249);
            this.renameFolders.Name = "renameFolders";
            this.renameFolders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.renameFolders.Size = new System.Drawing.Size(103, 17);
            this.renameFolders.TabIndex = 5;
            this.renameFolders.Text = "Rename Folders";
            this.toolTip1.SetToolTip(this.renameFolders, "Rename folder names as well.");
            this.renameFolders.UseVisualStyleBackColor = false;
            // 
            // replaceWithLabel
            // 
            replaceWithLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            replaceWithLabel.BackColor = System.Drawing.Color.Transparent;
            replaceWithLabel.Enabled = false;
            replaceWithLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            replaceWithLabel.ForeColor = System.Drawing.Color.Gray;
            replaceWithLabel.Location = new System.Drawing.Point(230, 43);
            replaceWithLabel.Name = "replaceWithLabel";
            replaceWithLabel.Size = new System.Drawing.Size(111, 14);
            replaceWithLabel.TabIndex = 0;
            replaceWithLabel.Text = "REPLACE WITH :";
            // 
            // outputContainer
            // 
            this.outputContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputContainer.BackColor = System.Drawing.Color.DimGray;
            this.outputContainer.Controls.Add(this.outputLog);
            this.outputContainer.Location = new System.Drawing.Point(1, 270);
            this.outputContainer.MinimumSize = new System.Drawing.Size(22, 94);
            this.outputContainer.Name = "outputContainer";
            this.outputContainer.Size = new System.Drawing.Size(583, 96);
            this.outputContainer.TabIndex = 7;
            // 
            // outputLog
            // 
            this.outputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLog.BackColor = System.Drawing.Color.DimGray;
            this.outputLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLog.CausesValidation = false;
            this.outputLog.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.outputLog.Location = new System.Drawing.Point(7, 1);
            this.outputLog.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.outputLog.MaxLength = 99999999;
            this.outputLog.Multiline = true;
            this.outputLog.Name = "outputLog";
            this.outputLog.ReadOnly = true;
            this.outputLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputLog.Size = new System.Drawing.Size(576, 90);
            this.outputLog.TabIndex = 7;
            this.outputLog.Text = resources.GetString("outputLog.Text");
            // 
            // creator_link
            // 
            this.creator_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creator_link.AutoSize = true;
            this.creator_link.BackColor = System.Drawing.Color.Transparent;
            this.creator_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creator_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator_link.ForeColor = System.Drawing.Color.Silver;
            this.creator_link.Location = new System.Drawing.Point(474, 1);
            this.creator_link.Name = "creator_link";
            this.creator_link.Size = new System.Drawing.Size(102, 13);
            this.creator_link.TabIndex = 7;
            this.creator_link.Text = "github.com/Invertex";
            this.creator_link.Click += new System.EventHandler(this.openGitPage);
            // 
            // renameToBorderColor
            // 
            renameToBorderColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            renameToBorderColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            renameToBorderColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            renameToBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            renameToBorderColor.CausesValidation = false;
            renameToBorderColor.Controls.Add(renameToBGColor);
            renameToBorderColor.Location = new System.Drawing.Point(7, 60);
            renameToBorderColor.MinimumSize = new System.Drawing.Size(2, 33);
            renameToBorderColor.Name = "renameToBorderColor";
            renameToBorderColor.Size = new System.Drawing.Size(544, 33);
            renameToBorderColor.TabIndex = 2;
            // 
            // renameToBGColor
            // 
            renameToBGColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            renameToBGColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            renameToBGColor.BackColor = System.Drawing.Color.DimGray;
            renameToBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            renameToBGColor.CausesValidation = false;
            renameToBGColor.Controls.Add(this.replaceWithInput);
            renameToBGColor.Location = new System.Drawing.Point(3, 3);
            renameToBGColor.MinimumSize = new System.Drawing.Size(0, 25);
            renameToBGColor.Name = "renameToBGColor";
            renameToBGColor.Size = new System.Drawing.Size(536, 25);
            renameToBGColor.TabIndex = 2;
            // 
            // replaceInputBGBorder
            // 
            replaceInputBGBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            replaceInputBGBorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            replaceInputBGBorder.BackColor = System.Drawing.Color.DeepSkyBlue;
            replaceInputBGBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            replaceInputBGBorder.CausesValidation = false;
            replaceInputBGBorder.Controls.Add(replaceInputbgPanel);
            replaceInputBGBorder.Location = new System.Drawing.Point(7, 6);
            replaceInputBGBorder.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            replaceInputBGBorder.MinimumSize = new System.Drawing.Size(0, 33);
            replaceInputBGBorder.Name = "replaceInputBGBorder";
            replaceInputBGBorder.Size = new System.Drawing.Size(544, 33);
            replaceInputBGBorder.TabIndex = 0;
            // 
            // replaceInput
            // 
            this.replaceInput.AccessibleDescription = "Text in each file or folder name to replace.";
            this.replaceInput.AccessibleName = "Replace Text";
            this.replaceInput.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.replaceInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceInput.BackColor = System.Drawing.Color.DimGray;
            this.replaceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.replaceInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.replaceInput.Location = new System.Drawing.Point(3, 1);
            this.replaceInput.MaxLength = 1000;
            this.replaceInput.Name = "replaceInput";
            this.replaceInput.Size = new System.Drawing.Size(532, 20);
            this.replaceInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.replaceInput, "Text in each file or folder name to replace.");
            this.replaceInput.WordWrap = false;
            // 
            // replaceInputbgPanel
            // 
            replaceInputbgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            replaceInputbgPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            replaceInputbgPanel.BackColor = System.Drawing.Color.DimGray;
            replaceInputbgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            replaceInputbgPanel.CausesValidation = false;
            replaceInputbgPanel.Controls.Add(this.replaceInput);
            replaceInputbgPanel.Location = new System.Drawing.Point(3, 3);
            replaceInputbgPanel.MinimumSize = new System.Drawing.Size(400, 25);
            replaceInputbgPanel.Name = "replaceInputbgPanel";
            replaceInputbgPanel.Size = new System.Drawing.Size(536, 25);
            replaceInputbgPanel.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // onFileConflict_label
            // 
            this.onFileConflict_label.AutoSize = true;
            this.onFileConflict_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onFileConflict_label.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.onFileConflict_label.Location = new System.Drawing.Point(16, 223);
            this.onFileConflict_label.Name = "onFileConflict_label";
            this.onFileConflict_label.Size = new System.Drawing.Size(124, 15);
            this.onFileConflict_label.TabIndex = 0;
            this.onFileConflict_label.Text = "On Filename Conflict:";
            // 
            // useRegex
            // 
            this.useRegex.AccessibleDescription = "Uses the above input as a Regex string for more complex matching behavior";
            this.useRegex.AccessibleName = "Use Regex";
            this.useRegex.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.useRegex.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.useRegex.Location = new System.Drawing.Point(8, 42);
            this.useRegex.Name = "useRegex";
            this.useRegex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.useRegex.Size = new System.Drawing.Size(56, 17);
            this.useRegex.TabIndex = 1;
            this.useRegex.Text = "Regex";
            this.toolTip1.SetToolTip(this.useRegex, "Uses the above input as a Regex string for more complex matching behavior");
            this.useRegex.UseCompatibleTextRendering = true;
            this.useRegex.UseVisualStyleBackColor = false;
            // 
            // inputsContainer
            // 
            this.inputsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputsContainer.BackColor = System.Drawing.Color.Transparent;
            this.inputsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputsContainer.CausesValidation = false;
            this.inputsContainer.Controls.Add(replaceInputBGBorder);
            this.inputsContainer.Controls.Add(renameToBorderColor);
            this.inputsContainer.Controls.Add(replaceWithLabel);
            this.inputsContainer.Controls.Add(this.useRegex);
            this.inputsContainer.Location = new System.Drawing.Point(12, 119);
            this.inputsContainer.MinimumSize = new System.Drawing.Size(500, 0);
            this.inputsContainer.Name = "inputsContainer";
            this.inputsContainer.Size = new System.Drawing.Size(560, 101);
            this.inputsContainer.TabIndex = 1;
            // 
            // SimplerRenamer
            // 
            this.AcceptButton = this.renameButton;
            this.AccessibleDescription = "Simple Mass Renamer";
            this.AccessibleName = "Simple Mass Renamer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.onFileConflict_label);
            this.Controls.Add(this.conflictOptions);
            this.Controls.Add(this.creator_link);
            this.Controls.Add(this.outputContainer);
            this.Controls.Add(this.renameFolders);
            this.Controls.Add(this.doSubDirs);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.dropPanel);
            this.Controls.Add(this.inputsContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(30000, 30000);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "SimplerRenamer";
            this.Text = "Simple Mass Renamer";
            this.Load += new System.EventHandler(this.SimplerRenamer_Load);
            this.ResizeEnd += new System.EventHandler(this.windowResized);
            this.dropPanel.ResumeLayout(false);
            this.outputContainer.ResumeLayout(false);
            this.outputContainer.PerformLayout();
            renameToBorderColor.ResumeLayout(false);
            renameToBGColor.ResumeLayout(false);
            renameToBGColor.PerformLayout();
            replaceInputBGBorder.ResumeLayout(false);
            replaceInputbgPanel.ResumeLayout(false);
            replaceInputbgPanel.PerformLayout();
            this.inputsContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel dropPanel;
        private System.Windows.Forms.Label dropInfo;
        private System.Windows.Forms.TextBox replaceWithInput;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.CheckBox doSubDirs;
        private System.Windows.Forms.CheckBox renameFolders;
        private System.Windows.Forms.Panel outputContainer;
        private System.Windows.Forms.TextBox outputLog;
        private System.Windows.Forms.Label creator_link;
        private System.Windows.Forms.TextBox replaceInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label onFileConflict_label;
        private System.Windows.Forms.CheckBox useRegex;
        private System.Windows.Forms.ComboBox conflictOptions;
        private System.Windows.Forms.Panel inputsContainer;
    }
}

