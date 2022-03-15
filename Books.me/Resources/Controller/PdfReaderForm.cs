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
using System.Runtime.InteropServices;



namespace Books.me.Resources.Controller
{
    public partial class PdfReaderForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse

        );


        public PdfReaderForm()
        {
            InitializeComponent();
            //
        }

        private void PdfReaderForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\HelpDoc.pdf";//PDF DOc name
            System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.ItPDF);//the resource automatically creates
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
