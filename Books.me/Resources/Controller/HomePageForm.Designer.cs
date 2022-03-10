namespace Books.me.Resources.Controller
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rightSlide = new System.Windows.Forms.PictureBox();
            this.leftSlide = new System.Windows.Forms.PictureBox();
            this.rightBook = new System.Windows.Forms.PictureBox();
            this.middleBook = new System.Windows.Forms.PictureBox();
            this.leftBook = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(562, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(215, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(767, 47);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "WELCOME, USER";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________________________________________________________________________" +
    "_______________________________________________";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.kryptonButton1.Location = new System.Drawing.Point(445, 554);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(313, 66);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.TabIndex = 10;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // rightSlide
            // 
            this.rightSlide.Image = global::Books.me.Properties.Resources.RightArrow;
            this.rightSlide.Location = new System.Drawing.Point(1075, 310);
            this.rightSlide.Name = "rightSlide";
            this.rightSlide.Size = new System.Drawing.Size(50, 50);
            this.rightSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightSlide.TabIndex = 9;
            this.rightSlide.TabStop = false;
            this.rightSlide.Click += new System.EventHandler(this.rightSlide_Click);
            // 
            // leftSlide
            // 
            this.leftSlide.Image = global::Books.me.Properties.Resources.LeftArrow;
            this.leftSlide.Location = new System.Drawing.Point(75, 310);
            this.leftSlide.Name = "leftSlide";
            this.leftSlide.Size = new System.Drawing.Size(50, 50);
            this.leftSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftSlide.TabIndex = 8;
            this.leftSlide.TabStop = false;
            this.leftSlide.Click += new System.EventHandler(this.leftSlide_Click);
            // 
            // rightBook
            // 
            this.rightBook.Image = global::Books.me.Properties.Resources.ShadowAndBone_bk3;
            this.rightBook.Location = new System.Drawing.Point(782, 182);
            this.rightBook.Name = "rightBook";
            this.rightBook.Size = new System.Drawing.Size(200, 300);
            this.rightBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightBook.TabIndex = 7;
            this.rightBook.TabStop = false;
            this.rightBook.Click += new System.EventHandler(this.rightBook_Click);
            // 
            // middleBook
            // 
            this.middleBook.Image = global::Books.me.Properties.Resources.TheAlchemist_bk2;
            this.middleBook.Location = new System.Drawing.Point(500, 182);
            this.middleBook.Name = "middleBook";
            this.middleBook.Size = new System.Drawing.Size(200, 300);
            this.middleBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.middleBook.TabIndex = 6;
            this.middleBook.TabStop = false;
            this.middleBook.Click += new System.EventHandler(this.middleBook_Click);
            // 
            // leftBook
            // 
            this.leftBook.Image = global::Books.me.Properties.Resources.TheSubtleArtOfNotGivingAFuck_bk1;
            this.leftBook.Location = new System.Drawing.Point(215, 182);
            this.leftBook.Name = "leftBook";
            this.leftBook.Size = new System.Drawing.Size(200, 300);
            this.leftBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftBook.TabIndex = 5;
            this.leftBook.TabStop = false;
            this.leftBook.Click += new System.EventHandler(this.leftBook_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Books.me.Properties.Resources.CloseWhite;
            this.btnClose.Location = new System.Drawing.Point(1168, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HomePageForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.rightSlide);
            this.Controls.Add(this.leftSlide);
            this.Controls.Add(this.rightBook);
            this.Controls.Add(this.middleBook);
            this.Controls.Add(this.leftBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rightSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox leftBook;
        private System.Windows.Forms.PictureBox middleBook;
        private System.Windows.Forms.PictureBox rightBook;
        private System.Windows.Forms.PictureBox leftSlide;
        private System.Windows.Forms.PictureBox rightSlide;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}