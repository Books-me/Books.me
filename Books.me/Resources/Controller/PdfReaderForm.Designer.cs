﻿namespace Books.me.Resources.Controller
{
    partial class PdfReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfReaderForm));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnBackToLibrary = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(15, 60);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(620, 790);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Books.me.Properties.Resources.CloseWhite;
            this.btnClose.Location = new System.Drawing.Point(618, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackToLibrary
            // 
            this.btnBackToLibrary.Image = global::Books.me.Properties.Resources.LeftArrowFixed;
            this.btnBackToLibrary.Location = new System.Drawing.Point(12, 8);
            this.btnBackToLibrary.Name = "btnBackToLibrary";
            this.btnBackToLibrary.Size = new System.Drawing.Size(25, 24);
            this.btnBackToLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBackToLibrary.TabIndex = 5;
            this.btnBackToLibrary.TabStop = false;
            this.btnBackToLibrary.Click += new System.EventHandler(this.btnBackToLibrary_Click);
            // 
            // PdfReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(650, 850);
            this.Controls.Add(this.btnBackToLibrary);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.axAcroPDF1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PdfReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PdfReaderForm";
            this.Load += new System.EventHandler(this.PdfReaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToLibrary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnBackToLibrary;
    }
}