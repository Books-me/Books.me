namespace Books.me.Resources.Controller
{
    partial class SingleBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleBookForm));
            this.lblBookName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAuthor = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDescriptionSegment = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAddToLibrary = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblTimeRead = new System.Windows.Forms.Label();
            this.timeToReadIcon = new System.Windows.Forms.PictureBox();
            this.pageCountIcon = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.rating = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.singleBookImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeToReadIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCountIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.Location = new System.Drawing.Point(505, 75);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(423, 45);
            this.lblBookName.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblBookName.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.lblBookName.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Values.Text = "Arsène Lupin, Gentleman-Thief";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(505, 120);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(165, 33);
            this.lblAuthor.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.lblAuthor.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.lblAuthor.StateNormal.LongText.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblAuthor.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.lblAuthor.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Values.Text = "Maurice Leblanc";
            // 
            // lblDescriptionSegment
            // 
            this.lblDescriptionSegment.Location = new System.Drawing.Point(505, 230);
            this.lblDescriptionSegment.Name = "lblDescriptionSegment";
            this.lblDescriptionSegment.Size = new System.Drawing.Size(139, 37);
            this.lblDescriptionSegment.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionSegment.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblDescriptionSegment.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.lblDescriptionSegment.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionSegment.TabIndex = 6;
            this.lblDescriptionSegment.Values.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(507, 280);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(625, 230);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.DimGray;
            this.lblGenre.Location = new System.Drawing.Point(507, 510);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(625, 29);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre:";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.DimGray;
            this.lblType.Location = new System.Drawing.Point(507, 545);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(625, 29);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "This Book is:";
            // 
            // btnAddToLibrary
            // 
            this.btnAddToLibrary.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btnAddToLibrary.Location = new System.Drawing.Point(938, 588);
            this.btnAddToLibrary.Name = "btnAddToLibrary";
            this.btnAddToLibrary.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddToLibrary.Size = new System.Drawing.Size(250, 50);
            this.btnAddToLibrary.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnAddToLibrary.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnAddToLibrary.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddToLibrary.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddToLibrary.StateCommon.Border.Rounding = 20;
            this.btnAddToLibrary.StateCommon.Border.Width = 2;
            this.btnAddToLibrary.StateCommon.Content.LongText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToLibrary.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAddToLibrary.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAddToLibrary.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToLibrary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToLibrary.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddToLibrary.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddToLibrary.StatePressed.Border.Color1 = System.Drawing.Color.Aqua;
            this.btnAddToLibrary.StatePressed.Border.Color2 = System.Drawing.Color.Aqua;
            this.btnAddToLibrary.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddToLibrary.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddToLibrary.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.btnAddToLibrary.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAddToLibrary.TabIndex = 13;
            this.btnAddToLibrary.Values.Text = "Add to Library";
            this.btnAddToLibrary.Click += new System.EventHandler(this.btnAddToLibrary_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPageCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPageCount.Location = new System.Drawing.Point(867, 165);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(93, 25);
            this.lblPageCount.TabIndex = 16;
            // 
            // lblTimeRead
            // 
            this.lblTimeRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeRead.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeRead.Location = new System.Drawing.Point(1032, 165);
            this.lblTimeRead.Name = "lblTimeRead";
            this.lblTimeRead.Size = new System.Drawing.Size(81, 25);
            this.lblTimeRead.TabIndex = 17;
            // 
            // timeToReadIcon
            // 
            this.timeToReadIcon.Image = global::Books.me.Properties.Resources.Clock;
            this.timeToReadIcon.Location = new System.Drawing.Point(996, 165);
            this.timeToReadIcon.Name = "timeToReadIcon";
            this.timeToReadIcon.Size = new System.Drawing.Size(25, 25);
            this.timeToReadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.timeToReadIcon.TabIndex = 15;
            this.timeToReadIcon.TabStop = false;
            // 
            // pageCountIcon
            // 
            this.pageCountIcon.Image = global::Books.me.Properties.Resources.Pages;
            this.pageCountIcon.Location = new System.Drawing.Point(836, 165);
            this.pageCountIcon.Name = "pageCountIcon";
            this.pageCountIcon.Size = new System.Drawing.Size(25, 25);
            this.pageCountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pageCountIcon.TabIndex = 14;
            this.pageCountIcon.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Image = global::Books.me.Properties.Resources.LeftArrow;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 11;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Books.me.Properties.Resources.CloseWhite;
            this.btnClose.Location = new System.Drawing.Point(1173, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rating
            // 
            this.rating.Image = ((System.Drawing.Image)(resources.GetObject("rating.Image")));
            this.rating.Location = new System.Drawing.Point(512, 165);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(120, 25);
            this.rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rating.TabIndex = 5;
            this.rating.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Books.me.Properties.Resources.Divider;
            this.pictureBox1.Location = new System.Drawing.Point(500, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // singleBookImage
            // 
            this.singleBookImage.Image = global::Books.me.Properties.Resources.TheAdventuresOfArseneLupinGentleman_Thief_bk10;
            this.singleBookImage.Location = new System.Drawing.Point(75, 75);
            this.singleBookImage.Name = "singleBookImage";
            this.singleBookImage.Size = new System.Drawing.Size(350, 500);
            this.singleBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.singleBookImage.TabIndex = 0;
            this.singleBookImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 56);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SingleBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.lblTimeRead);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.timeToReadIcon);
            this.Controls.Add(this.pageCountIcon);
            this.Controls.Add(this.btnAddToLibrary);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDescriptionSegment);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.singleBookImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryForm";
            this.Load += new System.EventHandler(this.SingleBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeToReadIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageCountIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleBookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox singleBookImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblBookName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAuthor;
        private System.Windows.Forms.PictureBox rating;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDescriptionSegment;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox pageCountIcon;
        private System.Windows.Forms.PictureBox timeToReadIcon;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblTimeRead;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddToLibrary;
        private System.Windows.Forms.Button button1;
    }
}