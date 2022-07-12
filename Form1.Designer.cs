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
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイルを開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォルダを開くDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubリポジトリページGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragAndDropPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.dragAndDropPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openFileButton.Location = new System.Drawing.Point(12, 346);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(178, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "指定したファイルを保護解除";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFolderButton
            // 
            this.openFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFolderButton.Location = new System.Drawing.Point(221, 346);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(178, 23);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "フォルダ内を一括保護解除";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルを開くOToolStripMenuItem,
            this.フォルダを開くDToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // ファイルを開くOToolStripMenuItem
            // 
            this.ファイルを開くOToolStripMenuItem.Name = "ファイルを開くOToolStripMenuItem";
            this.ファイルを開くOToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ファイルを開くOToolStripMenuItem.Text = "指定したファイルを保護解除(&O)...";
            // 
            // フォルダを開くDToolStripMenuItem
            // 
            this.フォルダを開くDToolStripMenuItem.Name = "フォルダを開くDToolStripMenuItem";
            this.フォルダを開くDToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.フォルダを開くDToolStripMenuItem.Text = "フォルダ内を一括保護解除(&D)...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定PToolStripMenuItem});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールTToolStripMenuItem.Text = "ツール(&T)";
            // 
            // 設定PToolStripMenuItem
            // 
            this.設定PToolStripMenuItem.Name = "設定PToolStripMenuItem";
            this.設定PToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.設定PToolStripMenuItem.Text = "設定(&P)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプHToolStripMenuItem1,
            this.gitHubリポジトリページGToolStripMenuItem,
            this.バージョン情報AToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // ヘルプHToolStripMenuItem1
            // 
            this.ヘルプHToolStripMenuItem1.Name = "ヘルプHToolStripMenuItem1";
            this.ヘルプHToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.ヘルプHToolStripMenuItem1.Text = "ヘルプ(&H)";
            // 
            // gitHubリポジトリページGToolStripMenuItem
            // 
            this.gitHubリポジトリページGToolStripMenuItem.Name = "gitHubリポジトリページGToolStripMenuItem";
            this.gitHubリポジトリページGToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.gitHubリポジトリページGToolStripMenuItem.Text = "GitHub リポジトリページ(&G)";
            // 
            // バージョン情報AToolStripMenuItem
            // 
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            this.バージョン情報AToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)...";
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
            this.dragAndDropPanel.Location = new System.Drawing.Point(13, 27);
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
            this.label2.Location = new System.Drawing.Point(23, 258);
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
            this.label1.Location = new System.Drawing.Point(38, 123);
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
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(12, 375);
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(209, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "非表示";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(142, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "表示";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dragAndDropPanel);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(432, 477);
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

        private Button openFileButton;
        private OpenFileDialog openFileDialog1;
        private Button openFolderButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem ファイルを開くOToolStripMenuItem;
        private ToolStripMenuItem フォルダを開くDToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 終了XToolStripMenuItem;
        private ToolStripMenuItem ツールTToolStripMenuItem;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem 設定PToolStripMenuItem;
        private ToolStripMenuItem ヘルプHToolStripMenuItem1;
        private ToolStripMenuItem gitHubリポジトリページGToolStripMenuItem;
        private ToolStripMenuItem バージョン情報AToolStripMenuItem;
        private Panel dragAndDropPanel;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}