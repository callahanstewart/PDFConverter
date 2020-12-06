namespace PDF_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MergePDFButton = new System.Windows.Forms.Button();
            this.SelectPDF = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.MergePDF = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WebURLtoPDF = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SearchQueryTextBox = new System.Windows.Forms.TextBox();
            this.SearchInPDFButton = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListView();
            this.Clear = new System.Windows.Forms.Button();
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.ChosenFolderLocation = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.Label();
            this.MergePDF.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MergePDFButton
            // 
            this.MergePDFButton.Location = new System.Drawing.Point(672, 6);
            this.MergePDFButton.Name = "MergePDFButton";
            this.MergePDFButton.Size = new System.Drawing.Size(150, 36);
            this.MergePDFButton.TabIndex = 0;
            this.MergePDFButton.Text = "Merge PDF";
            this.MergePDFButton.UseVisualStyleBackColor = true;
            this.MergePDFButton.Click += new System.EventHandler(this.MergePDFButton_Click);
            // 
            // SelectPDF
            // 
            this.SelectPDF.Location = new System.Drawing.Point(5, 83);
            this.SelectPDF.Name = "SelectPDF";
            this.SelectPDF.Size = new System.Drawing.Size(150, 36);
            this.SelectPDF.TabIndex = 2;
            this.SelectPDF.Text = "Select PDF(s)";
            this.SelectPDF.UseVisualStyleBackColor = true;
            this.SelectPDF.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // MergePDF
            // 
            this.MergePDF.AccessibleName = "Merge PDF";
            this.MergePDF.Controls.Add(this.tabPage1);
            this.MergePDF.Controls.Add(this.tabPage2);
            this.MergePDF.Controls.Add(this.tabPage3);
            this.MergePDF.Location = new System.Drawing.Point(1, 2);
            this.MergePDF.Name = "MergePDF";
            this.MergePDF.SelectedIndex = 0;
            this.MergePDF.Size = new System.Drawing.Size(836, 75);
            this.MergePDF.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.FileNameLabel);
            this.tabPage1.Controls.Add(this.FileName);
            this.tabPage1.Controls.Add(this.ChosenFolderLocation);
            this.tabPage1.Controls.Add(this.ChooseFolder);
            this.tabPage1.Controls.Add(this.MergePDFButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 49);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MERGE";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.WebURLtoPDF);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 68);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "WEB TO PDF";
            // 
            // WebURLtoPDF
            // 
            this.WebURLtoPDF.Location = new System.Drawing.Point(672, 11);
            this.WebURLtoPDF.Name = "WebURLtoPDF";
            this.WebURLtoPDF.Size = new System.Drawing.Size(150, 36);
            this.WebURLtoPDF.TabIndex = 1;
            this.WebURLtoPDF.Text = "WebURLtoPDF";
            this.WebURLtoPDF.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SearchInPDFButton);
            this.tabPage3.Controls.Add(this.SearchQueryTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(828, 49);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SEARCH";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // SearchQueryTextBox
            // 
            this.SearchQueryTextBox.Location = new System.Drawing.Point(421, 19);
            this.SearchQueryTextBox.Name = "SearchQueryTextBox";
            this.SearchQueryTextBox.Size = new System.Drawing.Size(218, 20);
            this.SearchQueryTextBox.TabIndex = 0;
            this.SearchQueryTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchInPDFButton
            // 
            this.SearchInPDFButton.Location = new System.Drawing.Point(645, 17);
            this.SearchInPDFButton.Name = "SearchInPDFButton";
            this.SearchInPDFButton.Size = new System.Drawing.Size(129, 23);
            this.SearchInPDFButton.TabIndex = 1;
            this.SearchInPDFButton.Text = "Search in PDF";
            this.SearchInPDFButton.UseVisualStyleBackColor = true;
            this.SearchInPDFButton.Click += new System.EventHandler(this.SearchInPDFButton_Click);
            // 
            // FileList
            // 
            this.FileList.HideSelection = false;
            this.FileList.Location = new System.Drawing.Point(5, 125);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(832, 265);
            this.FileList.TabIndex = 5;
            this.FileList.UseCompatibleStateImageBehavior = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(162, 84);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(122, 35);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(21, 16);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(139, 23);
            this.ChooseFolder.TabIndex = 1;
            this.ChooseFolder.Text = "Choose Save Location";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.ChooseFolder_Click);
            // 
            // ChosenFolderLocation
            // 
            this.ChosenFolderLocation.Location = new System.Drawing.Point(172, 18);
            this.ChosenFolderLocation.Name = "ChosenFolderLocation";
            this.ChosenFolderLocation.ReadOnly = true;
            this.ChosenFolderLocation.Size = new System.Drawing.Size(181, 20);
            this.ChosenFolderLocation.TabIndex = 2;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(456, 18);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(112, 20);
            this.FileName.TabIndex = 3;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(396, 21);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FileNameLabel.TabIndex = 4;
            this.FileNameLabel.Text = "File Name";
            // 
            // Progress
            // 
            this.Progress.AutoSize = true;
            this.Progress.Location = new System.Drawing.Point(674, 84);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(0, 13);
            this.Progress.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 402);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SelectPDF);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.MergePDF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MergePDF.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MergePDFButton;
        private System.Windows.Forms.Button SelectPDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TabControl MergePDF;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button WebURLtoPDF;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SearchInPDFButton;
        private System.Windows.Forms.TextBox SearchQueryTextBox;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.TextBox ChosenFolderLocation;
        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.Label Progress;
    }
}

