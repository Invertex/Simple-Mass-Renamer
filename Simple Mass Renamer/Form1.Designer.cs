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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.replaceInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dropPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.renameToBorderColor.SuspendLayout();
            this.renameToBGColor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.dropInfo.TabIndex = 0;
            this.dropInfo.Text = "Drag Files and/or Directories Here";
            this.dropInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.dropInfo, "Drag all files and folders you wish to rename onto here.");
            // 
            // replaceWithInput
            // 
            this.replaceWithInput.AccessibleDescription = "Text to replace with.";
            this.replaceWithInput.AccessibleName = "Replacement Text";
            this.replaceWithInput.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.replaceWithInput.BackColor = System.Drawing.Color.DimGray;
            this.replaceWithInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replaceWithInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.replaceWithInput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.replaceWithInput.Location = new System.Drawing.Point(6, 3);
            this.replaceWithInput.MaxLength = 60;
            this.replaceWithInput.Name = "replaceWithInput";
            this.replaceWithInput.Size = new System.Drawing.Size(182, 18);
            this.replaceWithInput.TabIndex = 3;
            this.toolTip1.SetToolTip(this.replaceWithInput, "Text to replace with.");
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
            this.renameButton.Location = new System.Drawing.Point(172, 166);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(190, 45);
            this.renameButton.TabIndex = 4;
            this.renameButton.Text = "RENAME";
            this.renameButton.UseVisualStyleBackColor = false;
            this.renameButton.Click += new System.EventHandler(this.startRename);
            // 
            // doSubDirs
            // 
            this.doSubDirs.AccessibleDescription = "Look for files and or folders in all subdirectories of input folders.";
            this.doSubDirs.AccessibleName = "Include sub directories.";
            this.doSubDirs.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.doSubDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doSubDirs.AutoSize = true;
            this.doSubDirs.BackColor = System.Drawing.Color.Transparent;
            this.doSubDirs.Checked = true;
            this.doSubDirs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doSubDirs.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.doSubDirs.Location = new System.Drawing.Point(412, 170);
            this.doSubDirs.Name = "doSubDirs";
            this.doSubDirs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doSubDirs.Size = new System.Drawing.Size(98, 17);
            this.doSubDirs.TabIndex = 5;
            this.doSubDirs.Text = "Sub Directories";
            this.toolTip1.SetToolTip(this.doSubDirs, "Look for files and or folders in all subdirectories of input folders.");
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
            this.renameFolders.Checked = true;
            this.renameFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.renameFolders.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.renameFolders.Location = new System.Drawing.Point(407, 193);
            this.renameFolders.Name = "renameFolders";
            this.renameFolders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.renameFolders.Size = new System.Drawing.Size(103, 17);
            this.renameFolders.TabIndex = 6;
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
            this.label2.Location = new System.Drawing.Point(210, 141);
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
            this.panel1.Location = new System.Drawing.Point(1, 219);
            this.panel1.MinimumSize = new System.Drawing.Size(22, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 94);
            this.panel1.TabIndex = 10;
            // 
            // outputLog
            // 
            this.outputLog.BackColor = System.Drawing.Color.DimGray;
            this.outputLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.outputLog.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.outputLog.Location = new System.Drawing.Point(3, 0);
            this.outputLog.Multiline = true;
            this.outputLog.Name = "outputLog";
            this.outputLog.ReadOnly = true;
            this.outputLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputLog.Size = new System.Drawing.Size(517, 94);
            this.outputLog.TabIndex = 1;
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
            this.renameToBorderColor.Controls.Add(this.replaceWithInput);
            this.renameToBorderColor.Controls.Add(this.renameToBGColor);
            this.renameToBorderColor.Location = new System.Drawing.Point(318, 135);
            this.renameToBorderColor.Name = "renameToBorderColor";
            this.renameToBorderColor.Size = new System.Drawing.Size(192, 26);
            this.renameToBorderColor.TabIndex = 12;
            // 
            // renameToBGColor
            // 
            this.renameToBGColor.BackColor = System.Drawing.Color.DimGray;
            this.renameToBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renameToBGColor.Controls.Add(this.textBox2);
            this.renameToBGColor.Location = new System.Drawing.Point(1, 1);
            this.renameToBGColor.Name = "renameToBGColor";
            this.renameToBGColor.Size = new System.Drawing.Size(188, 22);
            this.renameToBGColor.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.Location = new System.Drawing.Point(1, 3);
            this.textBox2.MaxLength = 60;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 18);
            this.textBox2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.replaceInput);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 26);
            this.panel2.TabIndex = 14;
            // 
            // replaceInput
            // 
            this.replaceInput.AccessibleDescription = "Text in each file or folder name to replace.";
            this.replaceInput.AccessibleName = "Replace Text";
            this.replaceInput.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.replaceInput.BackColor = System.Drawing.Color.DimGray;
            this.replaceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.replaceInput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.replaceInput.Location = new System.Drawing.Point(6, 3);
            this.replaceInput.MaxLength = 60;
            this.replaceInput.Name = "replaceInput";
            this.replaceInput.Size = new System.Drawing.Size(182, 18);
            this.replaceInput.TabIndex = 3;
            this.toolTip1.SetToolTip(this.replaceInput, "Text in each file or folder name to replace.");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 22);
            this.panel3.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.DimGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox3.Location = new System.Drawing.Point(1, 3);
            this.textBox3.MaxLength = 60;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 18);
            this.textBox3.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // SimplerRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(521, 313);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.renameFolders);
            this.Controls.Add(this.doSubDirs);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.dropPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.renameToBorderColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(537, 1080);
            this.MinimumSize = new System.Drawing.Size(537, 352);
            this.Name = "SimplerRenamer";
            this.Text = "Simple Mass Renamer";
            this.dropPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.renameToBorderColor.ResumeLayout(false);
            this.renameToBorderColor.PerformLayout();
            this.renameToBGColor.ResumeLayout(false);
            this.renameToBGColor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel renameToBGColor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox replaceInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

