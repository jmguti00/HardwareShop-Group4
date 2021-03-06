﻿namespace Hardware_Shop
{
    partial class CustomerPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxCustomer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.grpbxAddNewCustomer = new System.Windows.Forms.GroupBox();
            this.txtNewZip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewAddress2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewAddress1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.grpboxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.grpbxAddNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(175, 72);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 26);
            this.txtLastName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Last Name:";
            // 
            // grpboxCustomer
            // 
            this.grpboxCustomer.Controls.Add(this.label2);
            this.grpboxCustomer.Controls.Add(this.customerTable);
            this.grpboxCustomer.Controls.Add(this.txtLastName);
            this.grpboxCustomer.Controls.Add(this.label1);
            this.grpboxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpboxCustomer.Location = new System.Drawing.Point(20, 267);
            this.grpboxCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxCustomer.Name = "grpboxCustomer";
            this.grpboxCustomer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpboxCustomer.Size = new System.Drawing.Size(1102, 339);
            this.grpboxCustomer.TabIndex = 2;
            this.grpboxCustomer.TabStop = false;
            this.grpboxCustomer.Text = "Customer Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search customers by last name.";
            // 
            // customerTable
            // 
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.customerTable.Location = new System.Drawing.Point(22, 101);
            this.customerTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerTable.Name = "customerTable";
            this.customerTable.RowTemplate.Height = 24;
            this.customerTable.Size = new System.Drawing.Size(1058, 233);
            this.customerTable.TabIndex = 3;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(16, 132);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(190, 38);
            this.btnAddNewCustomer.TabIndex = 3;
            this.btnAddNewCustomer.Text = "Add New Customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartOrder.Location = new System.Drawing.Point(43, 619);
            this.btnStartOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(168, 44);
            this.btnStartOrder.TabIndex = 5;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.btnStartOrder_Click);
            // 
            // grpbxAddNewCustomer
            // 
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewZip);
            this.grpbxAddNewCustomer.Controls.Add(this.label10);
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewState);
            this.grpbxAddNewCustomer.Controls.Add(this.label9);
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewCity);
            this.grpbxAddNewCustomer.Controls.Add(this.label8);
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewAddress2);
            this.grpbxAddNewCustomer.Controls.Add(this.label7);
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewAddress1);
            this.grpbxAddNewCustomer.Controls.Add(this.label6);
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewPhone);
            this.grpbxAddNewCustomer.Controls.Add(this.label5);
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewFirstName);
            this.grpbxAddNewCustomer.Controls.Add(this.label4);
            this.grpbxAddNewCustomer.Controls.Add(this.txtNewLastName);
            this.grpbxAddNewCustomer.Controls.Add(this.label3);
            this.grpbxAddNewCustomer.Controls.Add(this.btnAddNewCustomer);
            this.grpbxAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddNewCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.grpbxAddNewCustomer.Location = new System.Drawing.Point(26, 17);
            this.grpbxAddNewCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxAddNewCustomer.Name = "grpbxAddNewCustomer";
            this.grpbxAddNewCustomer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxAddNewCustomer.Size = new System.Drawing.Size(1096, 175);
            this.grpbxAddNewCustomer.TabIndex = 6;
            this.grpbxAddNewCustomer.TabStop = false;
            this.grpbxAddNewCustomer.Text = "Add New Customer";
            // 
            // txtNewZip
            // 
            this.txtNewZip.Location = new System.Drawing.Point(486, 101);
            this.txtNewZip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewZip.Name = "txtNewZip";
            this.txtNewZip.Size = new System.Drawing.Size(180, 26);
            this.txtNewZip.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Zip: ";
            // 
            // txtNewState
            // 
            this.txtNewState.Location = new System.Drawing.Point(133, 102);
            this.txtNewState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewState.Name = "txtNewState";
            this.txtNewState.Size = new System.Drawing.Size(36, 26);
            this.txtNewState.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "State: ";
            // 
            // txtNewCity
            // 
            this.txtNewCity.Location = new System.Drawing.Point(870, 63);
            this.txtNewCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewCity.Name = "txtNewCity";
            this.txtNewCity.Size = new System.Drawing.Size(180, 26);
            this.txtNewCity.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(818, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "City: ";
            // 
            // txtNewAddress2
            // 
            this.txtNewAddress2.Location = new System.Drawing.Point(486, 63);
            this.txtNewAddress2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewAddress2.Name = "txtNewAddress2";
            this.txtNewAddress2.Size = new System.Drawing.Size(180, 26);
            this.txtNewAddress2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address2: ";
            // 
            // txtNewAddress1
            // 
            this.txtNewAddress1.Location = new System.Drawing.Point(133, 63);
            this.txtNewAddress1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewAddress1.Name = "txtNewAddress1";
            this.txtNewAddress1.Size = new System.Drawing.Size(180, 26);
            this.txtNewAddress1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address1: ";
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(870, 24);
            this.txtNewPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(180, 26);
            this.txtNewPhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number: ";
            // 
            // txtNewFirstName
            // 
            this.txtNewFirstName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNewFirstName.Location = new System.Drawing.Point(133, 24);
            this.txtNewFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(180, 26);
            this.txtNewFirstName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name: ";
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(486, 24);
            this.txtNewLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(180, 26);
            this.txtNewLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name: ";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisplay.Location = new System.Drawing.Point(43, 209);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(189, 44);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display Customers";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMainMenu.Location = new System.Drawing.Point(954, 621);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(168, 44);
            this.btnMainMenu.TabIndex = 8;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1146, 674);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.grpbxAddNewCustomer);
            this.Controls.Add(this.btnStartOrder);
            this.Controls.Add(this.grpboxCustomer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerPage";
            this.Text = "CustomerPage";
            this.grpboxCustomer.ResumeLayout(false);
            this.grpboxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.grpbxAddNewCustomer.ResumeLayout(false);
            this.grpbxAddNewCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxCustomer;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.GroupBox grpbxAddNewCustomer;
        private System.Windows.Forms.TextBox txtNewZip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewAddress2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewAddress1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnMainMenu;
    }
}