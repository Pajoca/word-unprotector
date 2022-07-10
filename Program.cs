namespace WordUnprotector
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> filePaths = System.Environment.GetCommandLineArgs().ToList(); // �R�}���h���C�������̎擾
            filePaths.RemoveAt(0); // ���ŏ�(0�Ԗ�)�̃R�}���h���C�������͎��s�t�@�C�����g�̃t�@�C���p�X�Ȃ̂ŏ��O

            if (filePaths.Count == 0) // �R�}���h���C������������(=�t�@�C�����h���b�O&�h���b�v����Ă��Ȃ�)�ꍇ�̓t�H�[���𗧂��グ
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else // �R�}���h���C������������΃t�H�[�����N�������A���ڂ����WordUnprotectLogic�ɓn��
            {
                var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
                wordUnprotectLogic.Unprotect();
                wordUnprotectLogic.ShowUnprotectionAlert();
            }
        }
    }
}