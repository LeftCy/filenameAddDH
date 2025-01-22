namespace filenameAddDH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var folderPath = textBoxFolderPath.Text.Trim();
            var fileNames = textBoxFileNames.Text.Split(',').Select(f => f.Trim());

            foreach (var fileName in fileNames)
            {
                var files = Directory.GetFiles(folderPath, fileName, SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    var directory = Path.GetDirectoryName(file);
                    var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
                    var extension = Path.GetExtension(file);

                    var newFileD = Path.Combine(directory, $"{fileNameWithoutExtension}_d{extension}");
                    var newFileH = Path.Combine(directory, $"{fileNameWithoutExtension}_h{extension}");

                    File.Copy(file, newFileD);
                    File.Copy(file, newFileH);
                }
            }

            MessageBox.Show("ï°êªÇ™äÆóπÇµÇ‹ÇµÇΩ");
        }

        private void textBoxFileNames_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFolderPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
