//using PdfSharp.Pdf;
//using PdfSharp.Pdf.Advanced;
using SelectPdf;
//using EO.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Converter
{
    public partial class Form1 : Form
    {
        bool lv1_mdown = false;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        bool lv2_mdown = false;

        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog1();
            InitializeOpenFileDialog2();
        }
        private void InitializeOpenFileDialog1()
        {
            // Set the file dialog to filter for pdf
            this.openFileDialog1.Filter = "*(.pdf) | *.pdf";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "PDF File Browser";
        }
        private void InitializeOpenFileDialog2()
        {
            // Set the file dialog to filter for pdf
            //this.openFileDialog1.Filter = "*(.pdf) | *.pdf";

            // Allow the user to select multiple images.
            //this.openFileDialog1.Multiselect = true;
            this.openFileDialog2.Title = "New PDF Save Location and Name";
        }
        private void button3_Click(object sender, EventArgs e) //Select PDF
        {
            
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    //Load filename into listview
                    try
                    {
                        FileList.Items.Add(new ListViewItem(file.ToString()));
                        
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileList.View = View.Details;
            FileList.Columns.Add("File");
            FileList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void MergePDFButton_Click(object sender, EventArgs e)
        {
            try
            {
                Progress.Text = $"Progress: 0/{FileList.Items.Count} pdfs merged";
                PdfDocument document = new PdfDocument();
                for (int i = 0; i < FileList.Items.Count; i++)
                {
                    var filePath = FileList.Items[i].Text;
                    PdfDocument pdfDocument = new PdfDocument(filePath);
                    for (int j = 0; j < pdfDocument.Pages.Count; j++)
                    {
                        document.Pages.Add(pdfDocument.Pages[j]);
                        //document.AddPage();
                    }
                    Progress.Text = $"Progress: {i + 1}/{FileList.Items.Count} pdfs merged";
                };
                //DialogResult dr = this.openFileDialog2.ShowDialog();
                document.Save($@"{ChosenFolderLocation.Text}\\{FileName.Text}.pdf");
                //Process.Start(filename);
                MessageBox.Show("Sucessfully Merged");
            }
            catch(Exception)
            {
                MessageBox.Show("Failed To Merge");
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FileList
            FileList.Alignment = ListViewAlignment.Left;
            FileList.DragDrop += FileList_DragDrop;
        }

        private void FileList_DragDrop(object sender, DragEventArgs e)
        {
            string textBox1 = e.Data.GetData(DataFormats.Text).ToString();
            string[] items = textBox1.Split(',');
            FileList.Items.Add(new ListViewItem(items, 0));
            lv1_mdown = false;
            lv2_mdown = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void SearchInPDFButton_Click(object sender, EventArgs e)
        {
            //This will look through all the pdfs in the list and search for a keyword
            // then spit out a list of the pdfs and pages they were found
            List<string> filesIncludingSearch = new List<string>();
            try
            {
                for (int i = 0; i < FileList.Items.Count; i++)
                {
                    var filePath = FileList.Items[i].Text;
                    PdfDocument pdfDocument = new PdfDocument(filePath);
                    for (int j = 0; j < pdfDocument.Pages.Count; j++)
                    {
                        PdfPage pdfPage = pdfDocument.Pages[j];
                        //string content;
                        string pdfText = pdfPage.ToString();
                        var pdfToText = new PdfToText();
                        pdfToText.Load(filePath);
                        var content = pdfToText.GetText();
                        if (content.Contains(SearchQueryTextBox.ToString()))
                        {
                            filesIncludingSearch.Add($"Found in {filePath} on page {j}");
                        }
                    }
                };

                MessageBox.Show($"Sucessfully searched. Found on {String.Join(",\n", filesIncludingSearch)}");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed To Search");
            }



            //for (int i = 0; i < FileList.Items.Count; i++)
            //{
            //    string fileName = FileList.Items[i].Text;
            //    PdfDocument pdfDocument = new PdfDocument(fileName);
            //    for (int j = 0; j < pdfDocument.Pages.Count; j++)
            //    {
            //        PdfPage pdfPage = pdfDocument.Pages[j];
            //        //string content;
            //        string pdfText = pdfPage.ToString();
                    
            //        var content = new PdfToText().Search(SearchQueryTextBox.Text, false, false);
            //        if (content.ToString().Contains(SearchQueryTextBox.ToString()))
            //        {
            //            filesIncludingSearch.Add($"Found in {fileName} on page {j}");
            //        }
            //    }
            //}
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FileList.Items.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath;  //selected folder path
                ChosenFolderLocation.Text = folder;
            }

        }
    }
}
