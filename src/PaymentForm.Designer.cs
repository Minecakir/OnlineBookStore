
namespace OOP2P
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxBilgiler = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCreditCart = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.groupBoxInvoice = new System.Windows.Forms.GroupBox();
            this.radioButtonSms = new System.Windows.Forms.RadioButton();
            this.radioButtonEmail = new System.Windows.Forms.RadioButton();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.groupBoxCardInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxInvoice.SuspendLayout();
            this.groupBoxCardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.buttonApprove.Font = new System.Drawing.Font("Snap ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApprove.Location = new System.Drawing.Point(316, 564);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(129, 38);
            this.buttonApprove.TabIndex = 0;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Snap ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(472, 564);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(129, 38);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxBilgiler
            // 
            this.textBoxBilgiler.Location = new System.Drawing.Point(57, 51);
            this.textBoxBilgiler.Multiline = true;
            this.textBoxBilgiler.Name = "textBoxBilgiler";
            this.textBoxBilgiler.Size = new System.Drawing.Size(512, 92);
            this.textBoxBilgiler.TabIndex = 2;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(54, 31);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(56, 17);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Adress:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCreditCart);
            this.groupBox1.Controls.Add(this.radioButtonCash);
            this.groupBox1.Location = new System.Drawing.Point(112, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Type";
            // 
            // radioButtonCreditCart
            // 
            this.radioButtonCreditCart.AutoSize = true;
            this.radioButtonCreditCart.Location = new System.Drawing.Point(23, 74);
            this.radioButtonCreditCart.Name = "radioButtonCreditCart";
            this.radioButtonCreditCart.Size = new System.Drawing.Size(96, 21);
            this.radioButtonCreditCart.TabIndex = 1;
            this.radioButtonCreditCart.TabStop = true;
            this.radioButtonCreditCart.Text = "Credit Cart";
            this.radioButtonCreditCart.UseVisualStyleBackColor = true;
            this.radioButtonCreditCart.CheckedChanged += new System.EventHandler(this.radioButtonCreditCart_CheckedChanged);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(23, 38);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(61, 21);
            this.radioButtonCash.TabIndex = 0;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButtonCash_CheckedChanged);
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.radioButtonSms);
            this.groupBoxInvoice.Controls.Add(this.radioButtonEmail);
            this.groupBoxInvoice.Location = new System.Drawing.Point(409, 196);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(160, 121);
            this.groupBoxInvoice.TabIndex = 5;
            this.groupBoxInvoice.TabStop = false;
            this.groupBoxInvoice.Text = "Ivoice Selection";
            // 
            // radioButtonSms
            // 
            this.radioButtonSms.AutoSize = true;
            this.radioButtonSms.Location = new System.Drawing.Point(23, 74);
            this.radioButtonSms.Name = "radioButtonSms";
            this.radioButtonSms.Size = new System.Drawing.Size(78, 21);
            this.radioButtonSms.TabIndex = 1;
            this.radioButtonSms.TabStop = true;
            this.radioButtonSms.Text = "By SMS";
            this.radioButtonSms.UseVisualStyleBackColor = true;
            this.radioButtonSms.CheckedChanged += new System.EventHandler(this.radioButtonSms_CheckedChanged);
            // 
            // radioButtonEmail
            // 
            this.radioButtonEmail.AutoSize = true;
            this.radioButtonEmail.Location = new System.Drawing.Point(23, 38);
            this.radioButtonEmail.Name = "radioButtonEmail";
            this.radioButtonEmail.Size = new System.Drawing.Size(88, 21);
            this.radioButtonEmail.TabIndex = 0;
            this.radioButtonEmail.TabStop = true;
            this.radioButtonEmail.Text = "By E-Mail";
            this.radioButtonEmail.UseVisualStyleBackColor = true;
            this.radioButtonEmail.CheckedChanged += new System.EventHandler(this.radioButtonEmail_CheckedChanged);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(409, 428);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(166, 22);
            this.textBoxPhoneNumber.TabIndex = 6;
            this.textBoxPhoneNumber.Visible = false;
            this.textBoxPhoneNumber.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "PhoneNumber";
            this.label1.Visible = false;
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(23, 56);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(225, 22);
            this.textBoxCardNumber.TabIndex = 9;
            // 
            // groupBoxCardInfo
            // 
            this.groupBoxCardInfo.Controls.Add(this.label4);
            this.groupBoxCardInfo.Controls.Add(this.label3);
            this.groupBoxCardInfo.Controls.Add(this.label2);
            this.groupBoxCardInfo.Controls.Add(this.textBoxCVV);
            this.groupBoxCardInfo.Controls.Add(this.textBoxExpDate);
            this.groupBoxCardInfo.Controls.Add(this.textBoxCardNumber);
            this.groupBoxCardInfo.Location = new System.Drawing.Point(24, 337);
            this.groupBoxCardInfo.Name = "groupBoxCardInfo";
            this.groupBoxCardInfo.Size = new System.Drawing.Size(307, 182);
            this.groupBoxCardInfo.TabIndex = 10;
            this.groupBoxCardInfo.TabStop = false;
            this.groupBoxCardInfo.Text = "Card Information";
            this.groupBoxCardInfo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "CVV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Expration Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Card Number";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(23, 145);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(96, 22);
            this.textBoxCVV.TabIndex = 11;
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.Location = new System.Drawing.Point(23, 101);
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.Size = new System.Drawing.Size(171, 22);
            this.textBoxExpDate.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(187)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(619, 627);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxCardInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.groupBoxInvoice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxBilgiler);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApprove);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxInvoice.ResumeLayout(false);
            this.groupBoxInvoice.PerformLayout();
            this.groupBoxCardInfo.ResumeLayout(false);
            this.groupBoxCardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxBilgiler;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCreditCart;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.GroupBox groupBoxInvoice;
        private System.Windows.Forms.RadioButton radioButtonSms;
        private System.Windows.Forms.RadioButton radioButtonEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.GroupBox groupBoxCardInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxExpDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}