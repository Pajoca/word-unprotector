namespace WordUnprotector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (IniFile.IniFileExists()) //Settings.ini���ݎ��͐ݒ�l��ǂݍ���
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

        // �u�t�@�C���v���j���[
        private void unprotectSpecifiedFilesMenuItem_Click(object sender, EventArgs e) => UnprotectSpecifiedFiles();
        private void unprotectSpecifiedFoldersMenuItem_Click(object sender, EventArgs e) => UnprotectSpecifiedFolders();
        private void exitMenuItem_Click(object sender, EventArgs e) => this.Close();

        // �u�c�[���v���j���[
        private void openApplicationDirectoryMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", Application.StartupPath);
        }

        // �u�w���v�v���j���[
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

        // �h���b�O���h���b�v�G���A
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
        /// �t�H�[���I���O�Ƀ��W�I�{�^���ɐݒ肳��Ă���ݒ�l��ǂݍ��݁Aini�t�@�C���ɏ�������
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var iniFile = new IniFile();
            var isAlertEnabled = enableShowAlertRadioButton.Checked;
            iniFile.Write("IsAlertEnabled", isAlertEnabled.ToString());
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
                var filePaths = openFileDialog1.FileNames.ToList();
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
            var wordUnprotectLogic = new WordUnprotectLogic(filePaths){ IsAlertEnabled = enableShowAlertRadioButton.Checked };
            wordUnprotectLogic.Unprotect();
            wordUnprotectLogic.ShowUnprotectionAlert();
        }

        /// <summary>
        /// �w�肵��URL������̃u���E�U�ŊJ��
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