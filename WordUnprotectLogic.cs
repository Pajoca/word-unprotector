using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using static System.Environment;

namespace WordUnprotector
{
    internal class WordUnprotectLogic
    {
        private static readonly List<string> _WordFileExtension = new() {".docx",".docm",".doc" };  // Wordファイル拡張子
        private static readonly List<string> _NewWordFileExtension = new() { ".docx", ".docm" };    // (保護解除可能な)新しい形式のWordファイル拡張子 
        private static readonly List<string> _OldWordFileExtension = new() { ".doc" };              // (保護解除できない)古い形式のWordファイル拡張子

        // ShowUnprotectionAlert() で表示するアラートメッセージの本文
        private static readonly string _OldWordFileAlertText1 = "拡張子 .doc の Word 97-2003 形式は編集保護解除に対応していません。" + NewLine + "以下のファイルは保護解除されませんでした。";
        private static readonly string _OldWordFileAlertText2 = "拡張子 .doc の Word 97-2003 形式は編集保護解除に対応していないため、一部のファイルは保護解除されませんでした。" + NewLine + "非対応のファイルは以下のこれらです。";
        private static readonly string _FailToUnprotectAlertText = "以下のファイルは編集保護解除済みまたは元々保護されていない、もしくは暗号化済みなど特殊な状態のため保護解除できませんでした。";

        // ShowUnprotectionAlert() で表示するアラートメッセージのボックスタイトル
        private static readonly string _AlertMessageBoxTitle = "注意";


        public WordUnprotectLogic(List<string> filePaths)
        {
            FilePaths = filePaths;
        }

        /// <summary>
        ///  保護解除対象のファイルのフルパスリスト(Wordファイル以外のファイルやフォルダを含んでいても問題ない)
        /// </summary>
        public List<string> FilePaths { get; }

        /// <summary>
        ///  保護解除できたファイルのフルパスリスト
        /// </summary>
        public List<string> UnprotectedFileList { get; set; } = new();

        /// <summary>
        ///  保護解除に失敗したファイルのフルパスリスト(旧形式のファイルで元々保護解除できない場合は除く)
        /// </summary>
        public List<string> FailedFileList { get; set; } = new();

        /// <summary>
        ///  旧形式のファイルのフルパスリスト(旧形式のため保護解除はできない)
        /// </summary>
        public List<string> OldTypeFileList { get; set; } = new();


        /// <summary>
        /// インスタンス生成時に与えたファイルパスに含まれるWordファイルの編集保護を解除する [:大元のメソッド] (元のファイルに変更は加えられず、保護解除されたコピーが同ディレクトリに生成される)
        /// </summary>
        public void Unprotect()
        {
            foreach (var filePath in FilePaths)
            {
                if (File.Exists(filePath))
                {
                    ProcessFileDependingOnFiletype(filePath);
                }
                else if (Directory.Exists(filePath))
                {
                    ProcessFolder(filePath);
                }
                else
                {
                    // 万が一ファイルとしてもフォルダとしても存在しないパスであった場合は、何も処理しない (コマンドプロンプト経由で誤った引数が渡された場合など)
                }
            }
        }


        /// <summary>
        /// Unprotect()実行後、保護解除できなかったファイルや解除非対応なファイルが存在した場合にそれらを表示する警告メッセージを表示する
        /// </summary>
        public void ShowUnprotectionAlert()
        {
            if (OldTypeFileList.Count > 0)
            {
                var displayText = (UnprotectedFileList.Count == 0) ? _OldWordFileAlertText1 : _OldWordFileAlertText2;
                var displayFileList = string.Join(NewLine, OldTypeFileList);
                MessageBox.Show(displayText + displayFileList, _AlertMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (FailedFileList.Count > 0)
            {
                var displayText = _FailToUnprotectAlertText;
                var displayFileList = string.Join(NewLine, FailedFileList);
                MessageBox.Show(displayText + displayFileList, _AlertMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        /// <summary>
        /// 与えられたファイルの拡張子に応じて処理を振り分けて実行する
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        private void ProcessFileDependingOnFiletype(string filePath)
        {
            if (_NewWordFileExtension.Contains(Path.GetExtension(filePath)))         // (保護解除可能な)新しい形式のWordファイルの場合
            {
                RemoveProtectionFromWordfile(filePath);
            }
            else if (_OldWordFileExtension.Contains(Path.GetExtension(filePath)))    // (保護解除できない)古い形式のWordファイルの場合
            {
                OldTypeFileList.Add(filePath);
            }
            else
            {
                // Wordファイル以外では何もしない
            }
        }

        /// <summary>
        /// 与えられたフォルダ内のWordファイルのみに対してファイル処理を呼び出す
        /// </summary>
        /// <param name="folderPath">フォルダパス</param>
        private void ProcessFolder(string folderPath)
        {
            var files = Directory.GetFiles(folderPath).ToList(); // フォルダ内の全ファイルのパスを取得 (サブフォルダ内のファイルは取得しない)
            var wordFiles = files.Where(file => _WordFileExtension.Contains(Path.GetExtension(file)));
            foreach (var file in wordFiles)
            {
                ProcessFileDependingOnFiletype(file);
            }
        }

        /// <summary>
        /// 与えられたWordファイルのコピーを作成し、ファイル内部を編集して保護部分を除去
        /// </summary>
        /// <param name="filePath">保護解除可能な形式のWordファイルのパス</param>
        private void RemoveProtectionFromWordfile(string filePath)
        {
            var wordFile = CopyFile(filePath);

            using (WordprocessingDocument document = WordprocessingDocument.Open(wordFile, true))
            {
                // Word文書の編集保護を指定するXML要素 <w:documentProtection> を取得。
                // (.docxファイル内の settings.xml の <w:settings> 要素内の <w:documentProtection> 要素を指定している)
                var documentProtectionElements = document.MainDocumentPart?.DocumentSettingsPart?.Settings.Elements<DocumentProtection>();

                // 要素 <w:documentProtection> が無い場合(そもそも保護されてない場合など)は、作成したコピーを削除し 保護解除失敗リストに追加。メソッドを抜ける。
                if (documentProtectionElements is null)
                {
                    File.Delete(wordFile);
                    FailedFileList.Add(filePath);
                    return;
                }
                else
                {
                    foreach (var element in documentProtectionElements)
                    {
                        element.Remove();
                    }
                    document.Save(); // AutoSaveはデフォルトでTrueだから不要かも。
                    UnprotectedFileList.Add(filePath);
                }
            }
        }

        /// <summary>
        /// 与えられたファイルのコピーをコピー元のファイルと同ディレクトリに作成する。
        /// コピーファイルの名前は元のファイル名末尾に"_Unprotected"を付与したもの。
        /// ファイル名の衝突が起きた場合は"_Unprotected(1)"のように連番を付与する。
        /// </summary>
        /// <param name="filePath">コピーしたいファイルのフルパス</param>
        /// <returns>コピーで生成した新ファイルのフルパス</returns>
        private string CopyFile(string filePath)
        {
            // 元のファイル名末尾に"_Unprotected"を付与したものを新パスとする
            string newFilePath = Path.Combine(Path.GetDirectoryName(filePath), 
                                           Path.GetFileNameWithoutExtension(filePath)+"_Unprotected",
                                           Path.GetExtension(filePath));
            
            if (!File.Exists(newFilePath)) //新パスが既存のファイルと被らなければコピーを作成
            {
                File.Copy(filePath, newFilePath);
                return newFilePath;
            }

            // 新パスが既存のファイルと被った場合、番号を末尾に付与し被らなくなるまで増加させる
            long i = 1;
            do
            {
                newFilePath = Path.Combine(Path.GetDirectoryName(filePath),
                                           Path.GetFileNameWithoutExtension(filePath) + $"({i})",
                                           Path.GetExtension(filePath));
                i++;
            } while (File.Exists(newFilePath));

            File.Copy(filePath, newFilePath);
            return newFilePath;
        }
    }
}