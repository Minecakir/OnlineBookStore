
namespace OOP2P
{
    partial class UC_MainProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.labelPr1 = new System.Windows.Forms.Label();
            this.labelPr2 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(129, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(190, 29);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(161, 258);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(127, 29);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "----price---- ₺";
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(172, 425);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(102, 38);
            this.buttonPurchase.TabIndex = 2;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProduct.Location = new System.Drawing.Point(129, 65);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(190, 190);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 3;
            this.pictureBoxProduct.TabStop = false;
            // 
            // labelPr1
            // 
            this.labelPr1.Location = new System.Drawing.Point(61, 299);
            this.labelPr1.Name = "labelPr1";
            this.labelPr1.Size = new System.Drawing.Size(325, 51);
            this.labelPr1.TabIndex = 4;
            this.labelPr1.Text = "label1";
            // 
            // labelPr2
            // 
            this.labelPr2.Location = new System.Drawing.Point(61, 360);
            this.labelPr2.Name = "labelPr2";
            this.labelPr2.Size = new System.Drawing.Size(325, 51);
            this.labelPr2.TabIndex = 5;
            this.labelPr2.Text = "label2";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 12);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 17);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Type";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelPr2);
            this.Controls.Add(this.labelPr1);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(459, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label labelPr1;
        private System.Windows.Forms.Label labelPr2;
        private System.Windows.Forms.Label labelType;
    }
}
