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



        // �ȉ��A�e�C�x���g�ŋ��ʂ̏��������\�b�h�ɂ��ċ��ʉ�

        /// <summary>
        /// �@�\�u�w�肵���t�@�C����ی�����v�ɑΉ��������\�b�h
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
        /// �@�\�u�t�H���_�����ꊇ�ی�����v�ɑΉ��������\�b�h
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
        /// �^����ꂽ�t�@�C���p�X��WordUnprotectLogic�C���X�^���X�ɓn���A�ی�����ƌx�����b�Z�[�W�\�������s����
        /// (�t�H�[�����̊e�R���g���[���ŋ��ʂ��鏈�������ʃ��\�b�h��)
        /// </summary>
        /// <param name="filePaths">�t�@�C���p�X</param>
        private void RunWordUnprotectLogic(List<string> filePaths)
        {
            var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
            wordUnprotectLogic.Unprotect();
            wordUnprotectLogic.ShowUnprotectionAlert();
        }


    }
}