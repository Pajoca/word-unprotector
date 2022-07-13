namespace WordUnprotector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unprotectSpecifiedFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unprotectSpecifiedFoldersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpParentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragAndDropPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.disableShowAlertRadioButton = new System.Windows.Forms.RadioButton();
            this.enableShowAlertRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.dragAndDropPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.toolMenuItem,
            this.helpParentMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unprotectSpecifiedFilesMenuItem,
            this.unprotectSpecifiedFoldersMenuItem,
            this.toolStripMenuItem1,
            this.exitMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // unprotectSpecifiedFilesMenuItem
            // 
            this.unprotectSpecifiedFilesMenuItem.Name = "unprotectSpecifiedFilesMenuItem";
            this.unprotectSpecifiedFilesMenuItem.Size = new System.Drawing.Size(232, 22);
            this.unprotectSpecifiedFilesMenuItem.Text = "指定したファイルを保護解除(&O)...";
            this.unprotectSpecifiedFilesMenuItem.Click += new System.EventHandler(this.unprotectSpecifiedFilesMenuItem_Click);
            // 
            // unprotectSpecifiedFoldersMenuItem
            // 
            this.unprotectSpecifiedFoldersMenuItem.Name = "unprotectSpecifiedFoldersMenuItem";
            this.unprotectSpecifiedFoldersMenuItem.Size = new System.Drawing.Size(232, 22);
            this.unprotectSpecifiedFoldersMenuItem.Text = "フォルダ内を一括保護解除(&D)...";
            this.unprotectSpecifiedFoldersMenuItem.Click += new System.EventHandler(this.unprotectSpecifiedFoldersMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(232, 22);
            this.exitMenuItem.Text = "終了(&X)";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolMenuItem
            // 
            this.toolMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            this.toolMenuItem.Name = "toolMenuItem";
            this.toolMenuItem.Size = new System.Drawing.Size(60, 20);
            this.toolMenuItem.Text = "ツール(&T)";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(113, 22);
            this.settingsMenuItem.Text = "設定(&P)";
            // 
            // helpParentMenuItem
            // 
            this.helpParentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem,
            this.githubMenuItem,
            this.versionInfoMenuItem});
            this.helpParentMenuItem.Name = "helpParentMenuItem";
            this.helpParentMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpParentMenuItem.Text = "ヘルプ(&H)";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(203, 22);
            this.helpMenuItem.Text = "ヘルプ(&H)";
            // 
            // githubMenuItem
            // 
            this.githubMenuItem.Name = "githubMenuItem";
            this.githubMenuItem.Size = new System.Drawing.Size(203, 22);
            this.githubMenuItem.Text = "GitHub リポジトリページ(&G)";
            // 
            // versionInfoMenuItem
            // 
            this.versionInfoMenuItem.Name = "versionInfoMenuItem";
            this.versionInfoMenuItem.Size = new System.Drawing.Size(203, 22);
            this.versionInfoMenuItem.Text = "バージョン情報(&A)...";
            // 
            // dragAndDropPanel
            // 
            this.dragAndDropPanel.AccessibleDescription = "";
            this.dragAndDropPanel.AllowDrop = true;
            this.dragAndDropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dragAndDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragAndDropPanel.Controls.Add(this.label2);
            this.dragAndDropPanel.Controls.Add(this.label1);
            this.dragAndDropPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dragAndDropPanel.Location = new System.Drawing.Point(13, 35);
            this.dragAndDropPanel.Name = "dragAndDropPanel";
            this.dragAndDropPanel.Size = new System.Drawing.Size(387, 313);
            this.dragAndDropPanel.TabIndex = 4;
            this.dragAndDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragAndDropPanel_DragDrop);
            this.dragAndDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragAndDropPanel_DragEnter);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "複数個のファイル・フォルダのドラッグ＆ドロップに対応\r\nフォルダの場合は、フォルダ直下に含まれるWordファイル全てを保護解除";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "保護解除したいWordファイルを\r\nここにドラッグ＆ドロップ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.disableShowAlertRadioButton);
            this.panel1.Controls.Add(this.enableShowAlertRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 54);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "警告メッセージの表示：";
            // 
            // disableShowAlertRadioButton
            // 
            this.disableShowAlertRadioButton.AutoSize = true;
            this.disableShowAlertRadioButton.Location = new System.Drawing.Point(209, 17);
            this.disableShowAlertRadioButton.Name = "disableShowAlertRadioButton";
            this.disableShowAlertRadioButton.Size = new System.Drawing.Size(61, 19);
            this.disableShowAlertRadioButton.TabIndex = 1;
            this.disableShowAlertRadioButton.TabStop = true;
            this.disableShowAlertRadioButton.Text = "非表示";
            this.disableShowAlertRadioButton.UseVisualStyleBackColor = true;
            // 
            // enableShowAlertRadioButton
            // 
            this.enableShowAlertRadioButton.AutoSize = true;
            this.enableShowAlertRadioButton.Location = new System.Drawing.Point(142, 17);
            this.enableShowAlertRadioButton.Name = "enableShowAlertRadioButton";
            this.enableShowAlertRadioButton.Size = new System.Drawing.Size(49, 19);
            this.enableShowAlertRadioButton.TabIndex = 0;
            this.enableShowAlertRadioButton.TabStop = true;
            this.enableShowAlertRadioButton.Text = "表示";
            this.enableShowAlertRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dragAndDropPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(432, 452);
            this.Name = "Form1";
            this.Text = "WordUnprotector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dragAndDropPanel.ResumeLayout(false);
            this.dragAndDropPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem unprotectSpecifiedFilesMenuItem;
        private ToolStripMenuItem unprotectSpecifiedFoldersMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem toolMenuItem;
        private ToolStripMenuItem helpParentMenuItem;
        private ToolStripMenuItem settingsMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem githubMenuItem;
        private ToolStripMenuItem versionInfoMenuItem;
        private Panel dragAndDropPanel;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private RadioButton disableShowAlertRadioButton;
        private RadioButton enableShowAlertRadioButton;
    }
}