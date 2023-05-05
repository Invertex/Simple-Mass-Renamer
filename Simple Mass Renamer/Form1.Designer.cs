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
            this.conflictOptions = new System.Windows.Forms.ComboBox();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.dropInfo = new System.Windows.Forms.Label();
            this.replaceWithInput = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.doSubDirs = new System.Windows.Forms.CheckBox();
            this.renameFolders = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.renameToBorderColor = new System.Windows.Forms.Panel();
            this.renameToBGColor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.replaceInput = new System.Windows.Forms.TextBox();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.useRegex = new System.Windows.Forms.CheckBox();
            this.dropPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.renameToBorderColor.SuspendLayout();
            this.renameToBGColor.SuspendLayout();
            this.bgPanel.SuspendLayout();
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
            this.conflictOptions.Location = new System.Drawing.Point(18, 237);
            this.conflictOptions.MaxDropDownItems = 3;
            this.conflictOptions.Name = "conflictOptions";
            this.conflictOptions.Size = new System.Drawing.Size(121, 21);
            this.conflictOptions.TabIndex = 50;
            this.toolTip1.SetToolTip(this.conflictOptions, "What should the renamer do when a file is being renamed to something that already" +
        " exists?");
            this.conflictOptions.SelectedIndexChanged += new System.EventHandler(this.ChangeConflictSetting);
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.BackColor = System.Drawing.Color.DimGray;
            this.dropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropPanel.Controls.Add(this.dropInfo);
            this.dropPanel.Location = new System.Drawing.Point(12, 12);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(498, 117);
            this.dropPanel.TabIndex = 0;
            this.dropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.processDrop);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropPanel_DragEnter);
            // 
            // dropInfo
            // 
            this.dropInfo.AccessibleDescription = "Drag all files and folders you wish to rename onto here.";
            this.dropInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dropInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropInfo.BackColor = System.Drawing.Color.Transparent;
            this.dropInfo.CausesValidation = false;
            this.dropInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.dropInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.dropInfo.Location = new System.Drawing.Point(2, 8);
            this.dropInfo.Name = "dropInfo";
            this.dropInfo.Size = new System.Drawing.Size(491, 98);
            this.dropInfo.TabIndex = 20;
            this.dropInfo.Text = "Drag Files and/or Folders Here";
            this.dropInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.dropInfo, resources.GetString("dropInfo.ToolTip"));
            // 
            // replaceWithInput
            // 
            this.replaceWithInput.AccessibleDescription = "Text to replace with.";
            this.replaceWithInput.AccessibleName = "Replacement Text";
            this.replaceWithInput.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.replaceWithInput.BackColor = System.Drawing.Color.DimGray;
            this.replaceWithInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replaceWithInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.replaceWithInput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.replaceWithInput.Location = new System.Drawing.Point(3, 1);
            this.replaceWithInput.MaxLength = 200;
            this.replaceWithInput.Name = "replaceWithInput";
            this.replaceWithInput.Size = new System.Drawing.Size(482, 20);
            this.replaceWithInput.TabIndex = 4;
            this.toolTip1.SetToolTip(this.replaceWithInput, "Text to replace with.");
            this.replaceWithInput.WordWrap = false;
            // 
            // renameButton
            // 
            this.renameButton.AccessibleDescription = "Initiate the renaming of all input files and or folders.";
            this.renameButton.AccessibleName = "Rename";
            this.renameButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.renameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renameButton.AutoSize = true;
            this.renameButton.BackColor = System.Drawing.Color.DimGray;
            this.renameButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.renameButton.FlatAppearance.BorderSize = 2;
            this.renameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.renameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.renameButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.renameButton.Location = new System.Drawing.Point(165, 216);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(192, 45);
            this.renameButton.TabIndex = 22;
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
            this.doSubDirs.Location = new System.Drawing.Point(391, 220);
            this.doSubDirs.Name = "doSubDirs";
            this.doSubDirs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doSubDirs.Size = new System.Drawing.Size(119, 17);
            this.doSubDirs.TabIndex = 38;
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
            this.renameFolders.Location = new System.Drawing.Point(407, 243);
            this.renameFolders.Name = "renameFolders";
            this.renameFolders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.renameFolders.Size = new System.Drawing.Size(103, 17);
            this.renameFolders.TabIndex = 39;
            this.renameFolders.Text = "Rename Folders";
            this.toolTip1.SetToolTip(this.renameFolders, "Rename folder names as well.");
            this.renameFolders.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(207, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "> REPLACE WITH :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.outputLog);
            this.panel1.Location = new System.Drawing.Point(1, 270);
            this.panel1.MinimumSize = new System.Drawing.Size(22, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 196);
            this.panel1.TabIndex = 10;
            // 
            // outputLog
            // 
            this.outputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.outputLog.BackColor = System.Drawing.Color.DimGray;
            this.outputLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLog.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.outputLog.Location = new System.Drawing.Point(6, 1);
            this.outputLog.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.outputLog.Multiline = true;
            this.outputLog.Name = "outputLog";
            this.outputLog.ReadOnly = true;
            this.outputLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputLog.Size = new System.Drawing.Size(516, 190);
            this.outputLog.TabIndex = 80;
            this.outputLog.Text = resources.GetString("outputLog.Text");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(457, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "by Invertex";
            this.label3.Click += new System.EventHandler(this.openGitPage);
            // 
            // renameToBorderColor
            // 
            this.renameToBorderColor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.renameToBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renameToBorderColor.Controls.Add(this.renameToBGColor);
            this.renameToBorderColor.Location = new System.Drawing.Point(12, 181);
            this.renameToBorderColor.Name = "renameToBorderColor";
            this.renameToBorderColor.Size = new System.Drawing.Size(498, 30);
            this.renameToBorderColor.TabIndex = 12;
            this.renameToBorderColor.Paint += new System.Windows.Forms.PaintEventHandler(this.renameToBorderColor_Paint);
            // 
            // renameToBGColor
            // 
            this.renameToBGColor.BackColor = System.Drawing.Color.DimGray;
            this.renameToBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renameToBGColor.Controls.Add(this.replaceWithInput);
            this.renameToBGColor.Location = new System.Drawing.Point(3, 2);
            this.renameToBGColor.Name = "renameToBGColor";
            this.renameToBGColor.Size = new System.Drawing.Size(490, 24);
            this.renameToBGColor.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 30);
            this.panel2.TabIndex = 14;
            // 
            // replaceInput
            // 
            this.replaceInput.AccessibleDescription = "Text in each file or folder name to replace.";
            this.replaceInput.AccessibleName = "Replace Text";
            this.replaceInput.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.replaceInput.BackColor = System.Drawing.Color.DimGray;
            this.replaceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.replaceInput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.replaceInput.Location = new System.Drawing.Point(3, 0);
            this.replaceInput.MaximumSize = new System.Drawing.Size(500, 50);
            this.replaceInput.MaxLength = 200;
            this.replaceInput.MinimumSize = new System.Drawing.Size(0, 20);
            this.replaceInput.Name = "replaceInput";
            this.replaceInput.Size = new System.Drawing.Size(482, 20);
            this.replaceInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.replaceInput, "Text in each file or folder name to replace.");
            this.replaceInput.WordWrap = false;
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.DimGray;
            this.bgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bgPanel.Controls.Add(this.replaceInput);
            this.bgPanel.Location = new System.Drawing.Point(16, 136);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(490, 24);
            this.bgPanel.TabIndex = 13;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(15, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "On Filename Conflict:";
            // 
            // useRegex
            // 
            this.useRegex.AutoSize = true;
            this.useRegex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.useRegex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.useRegex.Location = new System.Drawing.Point(442, 163);
            this.useRegex.Name = "useRegex";
            this.useRegex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.useRegex.Size = new System.Drawing.Size(68, 18);
            this.useRegex.TabIndex = 55;
            this.useRegex.Text = "Is Regex";
            this.useRegex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.useRegex.UseCompatibleTextRendering = true;
            this.useRegex.UseVisualStyleBackColor = true;
            // 
            // SimplerRenamer
            // 
            this.AcceptButton = this.renameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(521, 461);
            this.Controls.Add(this.bgPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conflictOptions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.renameFolders);
            this.Controls.Add(this.doSubDirs);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.dropPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.useRegex);
            this.Controls.Add(this.renameToBorderColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(537, 1080);
            this.MinimumSize = new System.Drawing.Size(537, 400);
            this.Name = "SimplerRenamer";
            this.Text = "Simple Mass Renamer";
            this.Load += new System.EventHandler(this.SimplerRenamer_Load);
            this.dropPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.renameToBorderColor.ResumeLayout(false);
            this.renameToBGColor.ResumeLayout(false);
            this.renameToBGColor.PerformLayout();
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox outputLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel renameToBorderColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox replaceInput;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox useRegex;
        private System.Windows.Forms.ComboBox conflictOptions;
        private System.Windows.Forms.Panel renameToBGColor;
    }
}

