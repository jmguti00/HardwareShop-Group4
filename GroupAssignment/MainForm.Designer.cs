namespace GroupAssignment
{
    partial class frmMain
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchLast = new System.Windows.Forms.Button();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.btnExistingCust = new System.Windows.Forms.Button();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.dataGridView1);
            this.grpCustomer.Controls.Add(this.textBox1);
            this.grpCustomer.Controls.Add(this.btnSearch);
            this.grpCustomer.Controls.Add(this.btnSearchLast);
            this.grpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(84, 180);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCustomer.Size = new System.Drawing.Size(1069, 609);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Select customer:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1052, 480);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(287, 82);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearchLast
            // 
            this.btnSearchLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLast.Location = new System.Drawing.Point(8, 31);
            this.btnSearchLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchLast.Name = "btnSearchLast";
            this.btnSearchLast.Size = new System.Drawing.Size(199, 34);
            this.btnSearchLast.TabIndex = 0;
            this.btnSearchLast.Text = "Search by Last Name";
            this.btnSearchLast.UseVisualStyleBackColor = true;
            // 
            // btnNewCust
            // 
            this.btnNewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCust.Location = new System.Drawing.Point(268, 140);
            this.btnNewCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(168, 32);
            this.btnNewCust.TabIndex = 3;
            this.btnNewCust.Text = "New Customer";
            this.btnNewCust.UseVisualStyleBackColor = true;
            // 
            // btnExistingCust
            // 
            this.btnExistingCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingCust.Location = new System.Drawing.Point(92, 140);
            this.btnExistingCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExistingCust.Name = "btnExistingCust";
            this.btnExistingCust.Size = new System.Drawing.Size(168, 32);
            this.btnExistingCust.TabIndex = 4;
            this.btnExistingCust.Text = "Existing Customer";
            this.btnExistingCust.UseVisualStyleBackColor = true;
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOrder.Location = new System.Drawing.Point(84, 796);
            this.btnStartOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(1069, 70);
            this.btnStartOrder.TabIndex = 4;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Handy\'s Hardware Shop";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(950, 113);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(167, 46);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 898);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartOrder);
            this.Controls.Add(this.btnNewCust);
            this.Controls.Add(this.btnExistingCust);
            this.Controls.Add(this.grpCustomer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Handy\'s Hardware Shop";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchLast;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Button btnExistingCust;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
    }
}

