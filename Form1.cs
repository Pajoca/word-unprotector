namespace WordUnprotector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filePaths = new List<string>() { openFileDialog1.FileName };

                var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
                wordUnprotectLogic.Unprotect();
                wordUnprotectLogic.ShowUnprotectionAlert();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {

                var filePaths = new List<string>() { folderBrowserDialog1.SelectedPath };

                var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
                wordUnprotectLogic.Unprotect();
                wordUnprotectLogic.ShowUnprotectionAlert();
            }
        }

        private void dragAndDropPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void dragAndDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] draggedAndDroppedPaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> filePaths = draggedAndDroppedPaths.ToList();
            var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
            wordUnprotectLogic.Unprotect();
            wordUnprotectLogic.ShowUnprotectionAlert();
        }
    }
}