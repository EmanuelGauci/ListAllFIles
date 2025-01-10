namespace AllFilesLister{
    partial class Form1{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GenerateFile = new Button();
            InDirTextBox = new TextBox();
            InDirLabel = new Label();
            OutDirLabel = new Label();
            OutDirTextBox = new TextBox();
            BrowseInDir = new Button();
            BrowseOutDir = new Button();
            OutFileName = new TextBox();
            FileNameLabel = new Label();
            SuspendLayout();
            // 
            // GenerateFile
            // 
            GenerateFile.BackColor = Color.Black;
            GenerateFile.FlatStyle = FlatStyle.Flat;
            GenerateFile.ForeColor = SystemColors.AppWorkspace;
            GenerateFile.Location = new Point(15, 193);
            GenerateFile.Name = "GenerateFile";
            GenerateFile.Size = new Size(103, 23);
            GenerateFile.TabIndex = 0;
            GenerateFile.Text = "Generate file";
            GenerateFile.UseVisualStyleBackColor = false;
            GenerateFile.Click += GenerateFile_Click;
            // 
            // InDirTextBox
            // 
            InDirTextBox.BackColor = SystemColors.ActiveCaptionText;
            InDirTextBox.BorderStyle = BorderStyle.FixedSingle;
            InDirTextBox.ForeColor = SystemColors.ButtonHighlight;
            InDirTextBox.Location = new Point(15, 27);
            InDirTextBox.Name = "InDirTextBox";
            InDirTextBox.Size = new Size(301, 23);
            InDirTextBox.TabIndex = 1;
            InDirTextBox.TextChanged += textBox1_TextChanged;
            // 
            // InDirLabel
            // 
            InDirLabel.AutoSize = true;
            InDirLabel.ForeColor = SystemColors.HighlightText;
            InDirLabel.Location = new Point(12, 9);
            InDirLabel.Name = "InDirLabel";
            InDirLabel.Size = new Size(86, 15);
            InDirLabel.TabIndex = 2;
            InDirLabel.Text = "Input Directory";
            // 
            // OutDirLabel
            // 
            OutDirLabel.AutoSize = true;
            OutDirLabel.ForeColor = SystemColors.HighlightText;
            OutDirLabel.Location = new Point(12, 79);
            OutDirLabel.Name = "OutDirLabel";
            OutDirLabel.Size = new Size(96, 15);
            OutDirLabel.TabIndex = 3;
            OutDirLabel.Text = "Output Directory\r\n";
            OutDirLabel.Click += OutDirLabel_Click_1;
            // 
            // OutDirTextBox
            // 
            OutDirTextBox.BackColor = SystemColors.MenuText;
            OutDirTextBox.BorderStyle = BorderStyle.FixedSingle;
            OutDirTextBox.ForeColor = SystemColors.ButtonHighlight;
            OutDirTextBox.Location = new Point(15, 100);
            OutDirTextBox.Name = "OutDirTextBox";
            OutDirTextBox.Size = new Size(301, 23);
            OutDirTextBox.TabIndex = 4;
            OutDirTextBox.TextChanged += textBox2_TextChanged;
            // 
            // BrowseInDir
            // 
            BrowseInDir.FlatStyle = FlatStyle.Flat;
            BrowseInDir.ForeColor = SystemColors.AppWorkspace;
            BrowseInDir.Location = new Point(322, 26);
            BrowseInDir.Name = "BrowseInDir";
            BrowseInDir.Size = new Size(30, 23);
            BrowseInDir.TabIndex = 5;
            BrowseInDir.Text = "...";
            BrowseInDir.UseVisualStyleBackColor = true;
            BrowseInDir.Click += BrowseInDir_Click;
            // 
            // BrowseOutDir
            // 
            BrowseOutDir.FlatStyle = FlatStyle.Flat;
            BrowseOutDir.ForeColor = SystemColors.AppWorkspace;
            BrowseOutDir.Location = new Point(322, 100);
            BrowseOutDir.Name = "BrowseOutDir";
            BrowseOutDir.Size = new Size(30, 23);
            BrowseOutDir.TabIndex = 6;
            BrowseOutDir.Text = "...";
            BrowseOutDir.UseVisualStyleBackColor = true;
            BrowseOutDir.Click += BrowseOutDir_Click;
            // 
            // OutFileName
            // 
            OutFileName.BackColor = SystemColors.MenuText;
            OutFileName.BorderStyle = BorderStyle.FixedSingle;
            OutFileName.ForeColor = SystemColors.ButtonHighlight;
            OutFileName.Location = new Point(15, 152);
            OutFileName.Name = "OutFileName";
            OutFileName.Size = new Size(337, 23);
            OutFileName.TabIndex = 7;
            OutFileName.TextChanged += textBox1_TextChanged_1;
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.ForeColor = SystemColors.HighlightText;
            FileNameLabel.Location = new Point(12, 134);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(111, 15);
            FileNameLabel.TabIndex = 8;
            FileNameLabel.Text = "GeneratedFileName";
            FileNameLabel.Click += FileNameLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(359, 225);
            Controls.Add(FileNameLabel);
            Controls.Add(OutFileName);
            Controls.Add(BrowseOutDir);
            Controls.Add(BrowseInDir);
            Controls.Add(OutDirTextBox);
            Controls.Add(OutDirLabel);
            Controls.Add(InDirLabel);
            Controls.Add(InDirTextBox);
            Controls.Add(GenerateFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FileStructureLister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateFile;
        private TextBox InDirTextBox;
        private Label InDirLabel;
        private Label OutDirLabel;
        private TextBox OutDirTextBox;
        private Button BrowseInDir;
        private Button BrowseOutDir;
        private TextBox OutFileName;
        private Label FileNameLabel;
    }
}
