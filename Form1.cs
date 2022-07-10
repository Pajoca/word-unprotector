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
                textBox1.Text = openFileDialog1.FileName;
                var filePaths = new List<string>() { openFileDialog1.FileName };

                var wordUnprotectLogic = new WordUnprotectLogic(filePaths);
                wordUnprotectLogic.Unprotect();
                wordUnprotectLogic.ShowUnprotectionAlert();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}