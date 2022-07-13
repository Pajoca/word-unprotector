namespace WordUnprotector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unprotectSpecifiedFilesButton_Click(object sender, EventArgs e) => UnprotectSpecifiedFiles();
        private void unprotectSpecifiedFoldersButton_Click(object sender, EventArgs e) => UnprotectSpecifiedFolders();
        
        private void unprotectSpecifiedFilesMenuItem_Click(object sender, EventArgs e) => UnprotectSpecifiedFiles();
        private void unprotectSpecifiedFoldersMenuItem_Click(object sender, EventArgs e) => UnprotectSpecifiedFolders();

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



        // 以下、各イベントで共通の処理をメソッドにして共通化

        /// <summary>
        /// 機能「指定したファイルを保護解除」に対応したメソッド
        /// </summary>
        private void UnprotectSpecifiedFiles()
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filePaths = new List<string>() { openFileDialog1.FileName };
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
            var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
            wordUnprotectLogic.Unprotect();
            wordUnprotectLogic.ShowUnprotectionAlert();
        }


    }
}