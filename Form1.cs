namespace WordUnprotector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (IniFile.IniFileExists()) //Settings.ini存在時は設定値を読み込む
            {
                var iniFile = new IniFile();
                var isAlertEnabled = bool.Parse(iniFile.Read("IsAlertEnabled"));
                if (isAlertEnabled)
                {
                    enableShowAlertRadioButton.Checked = true;
                }
                else
                {
                    disableShowAlertRadioButton.Checked = true;
                }
            }
        }

        // 「ファイル」メニュー
        private void unprotectSpecifiedFilesMenuItem_Click(object sender, EventArgs e) => UnprotectSpecifiedFiles();
        private void unprotectSpecifiedFoldersMenuItem_Click(object sender, EventArgs e) => UnprotectSpecifiedFolders();
        private void exitMenuItem_Click(object sender, EventArgs e) => this.Close();

        // 「ツール」メニュー
        private void openApplicationDirectoryMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", Application.StartupPath);
        }

        // 「ヘルプ」メニュー
        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://pajoca.com/word-unprotector/");
        }

        private void githubMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/Pajoca/word-unprotector");
        }

        private void aboutBoxMenuItem_Click(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        // ドラッグ＆ドロップエリア
        private void dragAndDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void dragAndDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] draggedAndDroppedPaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> filePaths = draggedAndDroppedPaths.ToList();
            RunWordUnprotectLogic(filePaths);
        }


        /// <summary>
        /// フォーム終了前にラジオボタンに設定されている設定値を読み込み、iniファイルに書き込む
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var iniFile = new IniFile();
            var isAlertEnabled = enableShowAlertRadioButton.Checked;
            iniFile.Write("IsAlertEnabled", isAlertEnabled.ToString());
        }


        // 以下、各イベントで共通の処理をメソッドにして共通化

        /// <summary>
        /// 機能「指定したファイルを保護解除」に対応したメソッド
        /// </summary>
        private void UnprotectSpecifiedFiles()
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filePaths = openFileDialog1.FileNames.ToList();
                RunWordUnprotectLogic(filePaths);
            }
        }

        /// <summary>
        /// 機能「フォルダ内を一括保護解除」に対応したメソッド
        /// </summary>
        private void UnprotectSpecifiedFolders()
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filePaths = new List<string>() { folderBrowserDialog1.SelectedPath };
                RunWordUnprotectLogic(filePaths);
            }
        }

        /// <summary>
        /// 与えられたファイルパスをWordUnprotectLogicインスタンスに渡し、保護解除と警告メッセージ表示を実行する
        /// (フォーム内の各コントロールで共通する処理を共通メソッド化)
        /// </summary>
        /// <param name="filePaths">ファイルパス</param>
        private void RunWordUnprotectLogic(List<string> filePaths)
        {
            var wordUnprotectLogic = new WordUnprotectLogic(filePaths){ IsAlertEnabled = enableShowAlertRadioButton.Checked };
            wordUnprotectLogic.Unprotect();
            wordUnprotectLogic.ShowUnprotectionAlert();
        }

        /// <summary>
        /// 指定したURLを既定のブラウザで開く
        /// </summary>
        /// <param name="url">URL</param>
        private void OpenUrl(string url)
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = url,
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }
    }
}