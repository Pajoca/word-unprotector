// IniFileに値を読み書きするためのクラス。以下のサイトで Danny Beckett さんによりパブリックドメインで公開されていたコードを改変
// https://stackoverflow.com/questions/217902/reading-writing-an-ini-file

using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace WordUnprotector
{
    internal class IniFile
    {
        /// <summary>
        /// 作成・読込するiniファイルのデフォルト名。
        /// </summary>
        public static string IniFileDefaultName { get; set; } = "Settings.ini";
        // "settings.ini" の代わりに ApplicationName + ".ini" などをデフォルト名として設定するのも良い。(任意)

        private readonly string IniFilePath;
        private readonly string ApplicationName = Assembly.GetExecutingAssembly().GetName().Name!;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string section, string? key, string? value, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string section, string key, string defaultString, StringBuilder returnedString, int size, string filePath);


        /// <summary>
        /// 読み込み・編集対象のiniファイルを設定するコンストラクタ。
        /// 引数で指定されたファイル名のiniファイルを対象として設定する。
        /// (同じファイル名でiniが既に存在する場合はそれを、無ければその名前を持つ新しいiniを操作対象とする。)
        /// 引数は相対パス。例えば単に「"Settings.ini"」を渡した場合はアプリケーションの実行ファイル(.exe)と同じディレクトリの Settings.ini が操作対象となる。
        /// </summary>
        /// <param name="iniFileName">iniファイル名(相対パス・省略可)</param>
        public IniFile(string? iniFileName = null)
        {
            IniFilePath = new FileInfo(iniFileName ?? IniFileDefaultName).FullName;
        }


        /// <summary>
        /// 指定したキーに対応する値を返す。オプションでセクション名の指定も可能。
        /// </summary>
        /// <param name="key">キー名</param>
        /// <param name="section">セクション名(省略可能)</param>
        /// <returns>キーに対応する値(:文字列)</returns>
        public string Read(string key, string? section = null)
        {
            var returnedString = new StringBuilder(1024);
            GetPrivateProfileString(section ?? ApplicationName, key, "", returnedString, 1024, IniFilePath);
            return returnedString.ToString();
        }

        /// <summary>
        /// キーと値のペアを書き込む。
        /// セクション名を省略した場合、アプリケーション名をセクション名に設定しその下に書き込む。
        /// </summary>
        /// <param name="key">キー名</param>
        /// <param name="value">値</param>
        /// <param name="section">セクション名(省略可能)</param>
        public void Write(string? key, string? value, string? section = null)
        {
            WritePrivateProfileString(section ?? ApplicationName, key, value, IniFilePath);
        }

        /// <summary>
        /// 指定したキーのエントリを削除する。オプションでセクション名の指定も可能。
        /// </summary>
        /// <param name="key">キー名</param>
        /// <param name="section">セクション名(省略可能)</param>
        public void DeleteKey(string key, string? section = null)
        {
            Write(key, null, section ?? ApplicationName);
        }

        /// <summary>
        /// 指定したセクションを削除する。
        /// </summary>
        /// <param name="section">セクション名(省略可能)</param>
        public void DeleteSection(string? section = null)
        {
            Write(null, null, section ?? ApplicationName);
        }

        /// <summary>
        /// 指定したキーが存在するかどうか返す。オプションでセクション名の指定も可能。
        /// </summary>
        /// <param name="key">キー名</param>
        /// <param name="section">セクション名(省略可能)</param>
        /// <returns></returns>
        public bool KeyExists(string key, string? section = null)
        {
            return Read(key, section).Length > 0;
        }


        /// <summary>
        /// 指定したファイル名のiniファイルがアプリケーションと同じディレクトリに存在するかどうか返す。
        /// 引数はアプリケーション本体(.exe)のパスを基準とした相対パス。(ファイル名単独を指定した場合はexeと同ディレクトリ。)
        /// 引数を省略した場合は、IniFileDefaultNameプロパティで設定されたファイル名のiniファイルが存在するか返す。
        /// </summary>
        /// <param name="iniFileName">iniファイル名(拡張子含む・相対パス)</param>
        /// <returns>指定したiniファイルが存在すればtrue</returns>
        public static bool IniFileExists(string? iniFileName = null)
        {
            return File.Exists(iniFileName ?? IniFileDefaultName);
        }
    }
}
