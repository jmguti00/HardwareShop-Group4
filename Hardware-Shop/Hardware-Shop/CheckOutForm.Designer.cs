namespace Hardware_Shop
{
    partial class CheckOutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lstOrderSummary = new System.Windows.Forms.ListBox();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.rdoCheck = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.grpCardInfo = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnAddMoreItems = new System.Windows.Forms.Button();
            this.grpOrderSummary.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpCardInfo.SuspendLayout();
            this.grpOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Out";
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.Controls.Add(this.lstOrderSummary);
            this.grpOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpOrderSummary.Location = new System.Drawing.Point(12, 51);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(226, 598);
            this.grpOrderSummary.TabIndex = 1;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Check out list";
            // 
            // lstOrderSummary
            // 
            this.lstOrderSummary.BackColor = System.Drawing.SystemColors.Info;
            this.lstOrderSummary.FormattingEnabled = true;
            this.lstOrderSummary.HorizontalScrollbar = true;
            this.lstOrderSummary.ItemHeight = 20;
            this.lstOrderSummary.Location = new System.Drawing.Point(7, 25);
            this.lstOrderSummary.Name = "lstOrderSummary";
            this.lstOrderSummary.Size = new System.Drawing.Size(213, 544);
            this.lstOrderSummary.TabIndex = 0;
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblPhoneNumber);
            this.grpCustomerInfo.Controls.Add(this.lblState);
            this.grpCustomerInfo.Controls.Add(this.lblZip);
            this.grpCustomerInfo.Controls.Add(this.lblAddress1);
            this.grpCustomerInfo.Controls.Add(this.lblCity);
            this.grpCustomerInfo.Controls.Add(this.lblAddress);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerName);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpCustomerInfo.Location = new System.Drawing.Point(254, 51);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(539, 185);
            this.grpCustomerInfo.TabIndex = 2;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhoneNumber.Location = new System.Drawing.Point(341, 120);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(169, 30);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(204, 120);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 30);
            this.lblState.TabIndex = 6;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZip
            // 
            this.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZip.Location = new System.Drawing.Point(254, 120);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(81, 30);
            this.lblZip.TabIndex = 5;
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress1
            // 
            this.lblAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress1.Location = new System.Drawing.Point(341, 77);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(169, 30);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCity.Location = new System.Drawing.Point(29, 120);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(169, 30);
            this.lblCity.TabIndex = 3;
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Location = new System.Drawing.Point(29, 77);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(306, 30);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerName.Location = new System.Drawing.Point(29, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(481, 30);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.rdoCheck);
            this.grpPayment.Controls.Add(this.rdoCash);
            this.grpPayment.Controls.Add(this.rdoCreditCard);
            this.grpPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPayment.Location = new System.Drawing.Point(254, 260);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(539, 78);
            this.grpPayment.TabIndex = 4;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Type";
            // 
            // rdoCheck
            // 
            this.rdoCheck.AutoSize = true;
            this.rdoCheck.Location = new System.Drawing.Point(401, 38);
            this.rdoCheck.Name = "rdoCheck";
            this.rdoCheck.Size = new System.Drawing.Size(72, 24);
            this.rdoCheck.TabIndex = 2;
            this.rdoCheck.Text = "Check";
            this.rdoCheck.UseVisualStyleBackColor = true;
            this.rdoCheck.CheckedChanged += new System.EventHandler(this.rdoCheck_CheckedChanged);
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(255, 38);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(64, 24);
            this.rdoCash.TabIndex = 1;
            this.rdoCash.Text = "Cash";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(66, 38);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(107, 24);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.rdoCreditCard_CheckedChanged);
            // 
            // grpCardInfo
            // 
            this.grpCardInfo.Controls.Add(this.textBox5);
            this.grpCardInfo.Controls.Add(this.textBox4);
            this.grpCardInfo.Controls.Add(this.textBox3);
            this.grpCardInfo.Controls.Add(this.textBox2);
            this.grpCardInfo.Controls.Add(this.textBox1);
            this.grpCardInfo.Controls.Add(this.label11);
            this.grpCardInfo.Controls.Add(this.label7);
            this.grpCardInfo.Controls.Add(this.label6);
            this.grpCardInfo.Controls.Add(this.label5);
            this.grpCardInfo.Controls.Add(this.label4);
            this.grpCardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCardInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpCardInfo.Location = new System.Drawing.Point(254, 356);
            this.grpCardInfo.Name = "grpCardInfo";
            this.grpCardInfo.Size = new System.Drawing.Size(324, 185);
            this.grpCardInfo.TabIndex = 3;
            this.grpCardInfo.TabStop = false;
            this.grpCardInfo.Text = "Credit Card Info";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 135);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 26);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(259, 100);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 26);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 98);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 26);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 64);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 26);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 26);
            this.textBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(174, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Exp Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "CRV Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Exp Month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "CC Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name on card:";
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.Controls.Add(this.lblBalance);
            this.grpOrderTotal.Controls.Add(this.lblTax);
            this.grpOrderTotal.Controls.Add(this.lblDeliveryFee);
            this.grpOrderTotal.Controls.Add(this.lblTotal);
            this.grpOrderTotal.Controls.Add(this.label12);
            this.grpOrderTotal.Controls.Add(this.label10);
            this.grpOrderTotal.Controls.Add(this.label9);
            this.grpOrderTotal.Controls.Add(this.label8);
            this.grpOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpOrderTotal.Location = new System.Drawing.Point(584, 356);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Size = new System.Drawing.Size(209, 185);
            this.grpOrderTotal.TabIndex = 4;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order Total";
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBalance.Location = new System.Drawing.Point(95, 138);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(108, 27);
            this.lblBalance.TabIndex = 7;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTax.Location = new System.Drawing.Point(95, 100);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(108, 27);
            this.lblTax.TabIndex = 6;
            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDeliveryFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeliveryFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliveryFee.Location = new System.Drawing.Point(95, 62);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(108, 27);
            this.lblDeliveryFee.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(95, 24);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(108, 27);
            this.lblTotal.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "Balance:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Delivery fee:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheckOut.Location = new System.Drawing.Point(531, 547);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(262, 31);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCanel.Location = new System.Drawing.Point(257, 547);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(268, 31);
            this.btnCanel.TabIndex = 1;
            this.btnCanel.Text = "Cancel Order";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnAddMoreItems
            // 
            this.btnAddMoreItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoreItems.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMoreItems.Location = new System.Drawing.Point(257, 597);
            this.btnAddMoreItems.Name = "btnAddMoreItems";
            this.btnAddMoreItems.Size = new System.Drawing.Size(268, 31);
            this.btnAddMoreItems.TabIndex = 5;
            this.btnAddMoreItems.Text = "Add More Items";
            this.btnAddMoreItems.UseVisualStyleBackColor = true;
            this.btnAddMoreItems.Click += new System.EventHandler(this.btnAddMoreItems_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(824, 662);
            this.Controls.Add(this.btnAddMoreItems);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.grpCardInfo);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.grpOrderSummary);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.grpOrderSummary.ResumeLayout(false);
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpCardInfo.ResumeLayout(false);
            this.grpCardInfo.PerformLayout();
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.GroupBox grpCardInfo;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.RadioButton rdoCheck;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ListBox lstOrderSummary;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddMoreItems;
    }
}