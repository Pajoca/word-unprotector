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
            List<string> filePaths = System.Environment.GetCommandLineArgs().ToList(); // コマンドライン引数の取得
            filePaths.RemoveAt(0); // ※最初(0番目)のコマンドライン引数は実行ファイル自身のファイルパスなので除外

            if (filePaths.Count == 0) // コマンドライン引数が無い(=ファイルがドラッグ&ドロップされていない)場合はフォームを立ち上げ
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else // コマンドライン引数があればフォームを起動せず、直接それをWordUnprotectLogicに渡す
            {
                var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
                wordUnprotectLogic.Unprotect();
                wordUnprotectLogic.ShowUnprotectionAlert();
            }
        }
    }
}