namespace Books.me.Resources.Controller
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.btnBackLibrary = new System.Windows.Forms.PictureBox();
            this.libraryBook4 = new System.Windows.Forms.PictureBox();
            this.libraryBook3 = new System.Windows.Forms.PictureBox();
            this.libraryBook5 = new System.Windows.Forms.PictureBox();
            this.libraryBook2 = new System.Windows.Forms.PictureBox();
            this.libraryBook1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackLibrary
            // 
            this.btnBackLibrary.Image = global::Books.me.Properties.Resources.LeftArrowFixed;
            this.btnBackLibrary.Location = new System.Drawing.Point(12, 12);
            this.btnBackLibrary.Name = "btnBackLibrary";
            this.btnBackLibrary.Size = new System.Drawing.Size(25, 24);
            this.btnBackLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBackLibrary.TabIndex = 4;
            this.btnBackLibrary.TabStop = false;
            this.btnBackLibrary.Click += new System.EventHandler(this.btnLibraryBack_Click);
            // 
            // libraryBook4
            // 
            this.libraryBook4.Location = new System.Drawing.Point(724, 161);
            this.libraryBook4.Name = "libraryBook4";
            this.libraryBook4.Size = new System.Drawing.Size(200, 300);
            this.libraryBook4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libraryBook4.TabIndex = 3;
            this.libraryBook4.TabStop = false;
            // 
            // libraryBook3
            // 
            this.libraryBook3.Location = new System.Drawing.Point(491, 161);
            this.libraryBook3.Name = "libraryBook3";
            this.libraryBook3.Size = new System.Drawing.Size(200, 300);
            this.libraryBook3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libraryBook3.TabIndex = 2;
            this.libraryBook3.TabStop = false;
            // 
            // libraryBook5
            // 
            this.libraryBook5.Location = new System.Drawing.Point(954, 161);
            this.libraryBook5.Name = "libraryBook5";
            this.libraryBook5.Size = new System.Drawing.Size(200, 300);
            this.libraryBook5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libraryBook5.TabIndex = 2;
            this.libraryBook5.TabStop = false;
            // 
            // libraryBook2
            // 
            this.libraryBook2.Location = new System.Drawing.Point(263, 161);
            this.libraryBook2.Name = "libraryBook2";
            this.libraryBook2.Size = new System.Drawing.Size(200, 300);
            this.libraryBook2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libraryBook2.TabIndex = 1;
            this.libraryBook2.TabStop = false;
            // 
            // libraryBook1
            // 
            this.libraryBook1.Location = new System.Drawing.Point(33, 161);
            this.libraryBook1.Name = "libraryBook1";
            this.libraryBook1.Size = new System.Drawing.Size(200, 300);
            this.libraryBook1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.libraryBook1.TabIndex = 0;
            this.libraryBook1.TabStop = false;
            this.libraryBook1.Click += new System.EventHandler(this.libraryBook1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Books.me.Properties.Resources.CloseWhite;
            this.btnClose.Location = new System.Drawing.Point(1168, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackLibrary);
            this.Controls.Add(this.libraryBook4);
            this.Controls.Add(this.libraryBook3);
            this.Controls.Add(this.libraryBook5);
            this.Controls.Add(this.libraryBook2);
            this.Controls.Add(this.libraryBook1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books.me";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBook1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox libraryBook1;
        private System.Windows.Forms.PictureBox libraryBook2;
        private System.Windows.Forms.PictureBox libraryBook5;
        private System.Windows.Forms.PictureBox libraryBook3;
        private System.Windows.Forms.PictureBox libraryBook4;
        private System.Windows.Forms.PictureBox btnBackLibrary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnClose;
    }
}