using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Books.me.Resources.Controller;



namespace Books.me.Resources.Controller
{
    public partial class PdfReaderForm : Form
    {
        public PdfReaderForm()
        {
            InitializeComponent();
        }

        private void PdfReaderForm_Load(object sender, EventArgs e)
        {
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\HelpDoc.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.ArseneLupinTest);//the resource automatically creates
            axAcroPDF1.LoadFile(openPDFFile);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackToLibrary_Click(object sender, EventArgs e)
        {
            ClosePDFViewerForm();
        }
        public void ClosePDFViewerForm()
        {
            this.Hide();
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.Closed += (s, args) => this.Close();
            libraryForm.Show();
        }

    }
}
