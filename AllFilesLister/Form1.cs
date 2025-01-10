namespace AllFilesLister{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //get input
        private void BrowseInDir_Click(object sender, EventArgs e) {//populate the input directory text field with data from a file brwoser dialogue
            FolderBrowserDialog infolder = new FolderBrowserDialog();//open file browser dialogue
            DialogResult indialogresult = infolder.ShowDialog();
            if (indialogresult == DialogResult.OK) {
                InDirTextBox.Text = infolder.SelectedPath;//set the path of the selected item to the input directory text box
            }
        }

        private void BrowseOutDir_Click(object sender, EventArgs e) {//populate the output directory text field with data from a file browser dialogue
            FolderBrowserDialog outfolder = new FolderBrowserDialog();//open file browser dialogue
            DialogResult outdialogresult = outfolder.ShowDialog();
            if (outdialogresult == DialogResult.OK) {
                OutDirTextBox.Text = outfolder.SelectedPath;//set the path of teh selected item to the output directory text box
            }
        }

        //main logic
        private void GenerateFile_Click(object sender, EventArgs e) {
            string inputDir = InDirTextBox.Text;//get text data for the input directory
            string outputDir = OutDirTextBox.Text;//get text data for the output directory
            string customFileName = OutFileName.Text;//get text data fro the optional file name


            if (Directory.Exists(inputDir) && Directory.Exists(outputDir)) {
                String filename;
                if (string.IsNullOrWhiteSpace(customFileName)) {
                    filename = "file structure output.txt";
                } else {
                    filename = customFileName + ".txt";
                }
                string outputPath = Path.Combine(outputDir, filename);
                using (StreamWriter writer = new StreamWriter(outputPath)) {
                    WriteDirectoryStructure(writer, inputDir, "");
                }
                MessageBox.Show("File structure has been generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Please ensure both input and output directories are valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteDirectoryStructure(StreamWriter writer, string dirPath, string indent) {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            writer.WriteLine(indent + "[Folder] " + dirInfo.Name);

            foreach (FileInfo file in dirInfo.GetFiles()) {
                writer.WriteLine(indent + "    [File] " + file.Name);
            }

            foreach (DirectoryInfo subDir in dirInfo.GetDirectories()) {
                WriteDirectoryStructure(writer, subDir.FullName, indent + "    ");
            }
        }

        //unused elements
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void InDirLabel_Click(object sender, EventArgs e) { }
        private void OutDirLabel_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void OutDirLabel_Click_1(object sender, EventArgs e) { }
        private void FileNameLabel_Click(object sender, EventArgs e) { }
    }
}
