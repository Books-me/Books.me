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
        Stopwatch stopwatch = new Stopwatch();
        private static int durationRead;
        public static int DurationRead
        {
            get { return durationRead; }
            set { durationRead = value; }
        }

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
        }
        private void PdfReaderForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            DisplayBookPDF(Globals.BookClicked);

            stopwatch.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackToLibrary_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            DurationRead = (int)stopwatch.ElapsedMilliseconds / 60000;
            ClosePDFViewerForm();
            Dispose();
        }
        public void ClosePDFViewerForm()
        {
            this.Hide();
            LibraryForm libraryForm = new LibraryForm();
            libraryForm.Closed += (s, args) => this.Close();
            libraryForm.Show();
        }
        public void DisplayBookPDF(int position)
        {
            string openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\HelpDoc.pdf";
            switch (LibraryForm.AddedBooksName[position])
            {
                case "The Subtle Art of Not Giving a Fuck":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.TheSubtleArtofNotGivingaFuckPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "The Alchemist":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.TheAlchemistPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "Shadow and Bone":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.ShadowAndBonePDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "IT":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.ItPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "The Nature of Space and Time":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.TheNatureOfSpaceAndTimePDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "Elon Musk":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.ElonMuskPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "The Lightning Thief":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.TheLightningThiefPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "Under the Yoke: Pod Igoto":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.PodIgotoPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "Murder on the Orient Express":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.MurderOnTheOrientExpressPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "Arsene Lupin, Gentleman-Thief":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.ArseneLupinTest);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "Hamlet":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.HamletPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
                case "The Prince and the Pauper":
                    System.IO.File.WriteAllBytes(openPDFFile, global::Books.me.Properties.Resources.ThePrinceAndThePauperPDF);//the resource automatically creates
                    axAcroPDF1.LoadFile(openPDFFile);
                    break;
            }
        }
    }
}
