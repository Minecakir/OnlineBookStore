
namespace OOP2P
{
    partial class FormMainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonShoppingCart = new System.Windows.Forms.Button();
            this.labelMainHeader = new System.Windows.Forms.Label();
            this.buttonMain = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonMagazine = new System.Windows.Forms.Button();
            this.buttonMusicCD = new System.Windows.Forms.Button();
            this.groupBoxShoppingCartComp = new System.Windows.Forms.GroupBox();
            this.labelPriceText = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxShoppingCartComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(109)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(301, 251);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1377, 704);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.Yellow;
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOrders.ImageIndex = 3;
            this.buttonOrders.ImageList = this.imageList1;
            this.buttonOrders.Location = new System.Drawing.Point(1704, 452);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(187, 72);
            this.buttonOrders.TabIndex = 4;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "book (1).png");
            this.imageList1.Images.SetKeyName(1, "magazine (1).png");
            this.imageList1.Images.SetKeyName(2, "cd.png");
            this.imageList1.Images.SetKeyName(3, "box.png");
            this.imageList1.Images.SetKeyName(4, "shopping-cart.png");
            // 
            // buttonShoppingCart
            // 
            this.buttonShoppingCart.BackColor = System.Drawing.Color.Yellow;
            this.buttonShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShoppingCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShoppingCart.ImageIndex = 4;
            this.buttonShoppingCart.ImageList = this.imageList1;
            this.buttonShoppingCart.Location = new System.Drawing.Point(1704, 555);
            this.buttonShoppingCart.Name = "buttonShoppingCart";
            this.buttonShoppingCart.Size = new System.Drawing.Size(187, 75);
            this.buttonShoppingCart.TabIndex = 5;
            this.buttonShoppingCart.Text = "Shopping Cart";
            this.buttonShoppingCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShoppingCart.UseVisualStyleBackColor = false;
            this.buttonShoppingCart.UseWaitCursor = true;
            this.buttonShoppingCart.Click += new System.EventHandler(this.buttonShoppingCart_Click);
            // 
            // labelMainHeader
            // 
            this.labelMainHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.labelMainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainHeader.ForeColor = System.Drawing.Color.Teal;
            this.labelMainHeader.Location = new System.Drawing.Point(728, 87);
            this.labelMainHeader.Name = "labelMainHeader";
            this.labelMainHeader.Size = new System.Drawing.Size(676, 67);
            this.labelMainHeader.TabIndex = 6;
            this.labelMainHeader.Text = "Yettim Kitabevi";
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.Color.Teal;
            this.buttonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMain.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMain.Location = new System.Drawing.Point(77, 194);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(169, 69);
            this.buttonMain.TabIndex = 7;
            this.buttonMain.Text = "Main Page";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(1497, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(325, 34);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Hüseyin Can Ergün";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(1828, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 27);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBook.ImageIndex = 0;
            this.buttonBook.ImageList = this.imageList1;
            this.buttonBook.Location = new System.Drawing.Point(64, 323);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(169, 70);
            this.buttonBook.TabIndex = 1;
            this.buttonBook.Text = "Book";
            this.buttonBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonMagazine
            // 
            this.buttonMagazine.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMagazine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMagazine.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMagazine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMagazine.ImageKey = "magazine (1).png";
            this.buttonMagazine.ImageList = this.imageList1;
            this.buttonMagazine.Location = new System.Drawing.Point(64, 399);
            this.buttonMagazine.Name = "buttonMagazine";
            this.buttonMagazine.Size = new System.Drawing.Size(169, 76);
            this.buttonMagazine.TabIndex = 2;
            this.buttonMagazine.Text = "Magazine";
            this.buttonMagazine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMagazine.UseVisualStyleBackColor = false;
            this.buttonMagazine.Click += new System.EventHandler(this.buttonMagazine_Click);
            // 
            // buttonMusicCD
            // 
            this.buttonMusicCD.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMusicCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusicCD.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMusicCD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMusicCD.ImageIndex = 2;
            this.buttonMusicCD.ImageList = this.imageList1;
            this.buttonMusicCD.Location = new System.Drawing.Point(64, 481);
            this.buttonMusicCD.Name = "buttonMusicCD";
            this.buttonMusicCD.Size = new System.Drawing.Size(169, 71);
            this.buttonMusicCD.TabIndex = 3;
            this.buttonMusicCD.Text = "MusicCD";
            this.buttonMusicCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusicCD.UseVisualStyleBackColor = false;
            this.buttonMusicCD.Click += new System.EventHandler(this.buttonMusicCD_Click);
            // 
            // groupBoxShoppingCartComp
            // 
            this.groupBoxShoppingCartComp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxShoppingCartComp.Controls.Add(this.labelPriceText);
            this.groupBoxShoppingCartComp.Controls.Add(this.labelTotalPrice);
            this.groupBoxShoppingCartComp.Controls.Add(this.buttonPurchase);
            this.groupBoxShoppingCartComp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxShoppingCartComp.Location = new System.Drawing.Point(64, 323);
            this.groupBoxShoppingCartComp.Name = "groupBoxShoppingCartComp";
            this.groupBoxShoppingCartComp.Size = new System.Drawing.Size(169, 235);
            this.groupBoxShoppingCartComp.TabIndex = 11;
            this.groupBoxShoppingCartComp.TabStop = false;
            this.groupBoxShoppingCartComp.Visible = false;
            // 
            // labelPriceText
            // 
            this.labelPriceText.AutoSize = true;
            this.labelPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceText.Location = new System.Drawing.Point(6, 42);
            this.labelPriceText.Name = "labelPriceText";
            this.labelPriceText.Size = new System.Drawing.Size(108, 25);
            this.labelPriceText.TabIndex = 0;
            this.labelPriceText.Text = "Total Cost;";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(4, 85);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(165, 25);
            this.labelTotalPrice.TabIndex = 1;
            this.labelTotalPrice.Text = "----price---- ₺";
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.ForeColor = System.Drawing.Color.White;
            this.buttonPurchase.Location = new System.Drawing.Point(11, 134);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(140, 40);
            this.buttonPurchase.TabIndex = 2;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(411, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1087, 243);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1698, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1003);
            this.Controls.Add(this.buttonMagazine);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelMainHeader);
            this.Controls.Add(this.buttonMusicCD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonShoppingCart);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.groupBoxShoppingCartComp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Book Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainPage_Load);
            this.groupBoxShoppingCartComp.ResumeLayout(false);
            this.groupBoxShoppingCartComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonShoppingCart;
        private System.Windows.Forms.Label labelMainHeader;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonMagazine;
        private System.Windows.Forms.Button buttonMusicCD;
        private System.Windows.Forms.GroupBox groupBoxShoppingCartComp;
        private System.Windows.Forms.Label labelPriceText;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

