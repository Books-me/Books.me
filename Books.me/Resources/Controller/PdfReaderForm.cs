using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string FileName = @".\Books.me\Resources\ArseneLupinTest.pdf";
            axAcroPDF1.LoadFile(FileName);
            axAcroPDF1.src = FileName;
        }
    }
}
