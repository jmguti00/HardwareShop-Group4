namespace Hardware_Shop
{
    partial class EmployeePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.grpbxAddUpdateEmployee = new System.Windows.Forms.GroupBox();
            this.btnEnterDelete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.grpboxEmployee = new System.Windows.Forms.GroupBox();
            this.lblDeleteInformation = new System.Windows.Forms.Label();
            this.lblUpdateInfo = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.grpbxAddUpdateEmployee.SuspendLayout();
            this.grpboxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(8, 271);
            this.btnAddNewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(185, 38);
            this.btnAddNewEmployee.TabIndex = 0;
            this.btnAddNewEmployee.Text = "Add New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // employeeTable
            // 
            this.employeeTable.BackgroundColor = System.Drawing.SystemColors.Info;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeeTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.employeeTable.Location = new System.Drawing.Point(6, 24);
            this.employeeTable.Margin = new System.Windows.Forms.Padding(2);
            this.employeeTable.Name = "employeeTable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.employeeTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeTable.RowTemplate.Height = 24;
            this.employeeTable.Size = new System.Drawing.Size(1096, 233);
            this.employeeTable.TabIndex = 3;
            // 
            // grpbxAddUpdateEmployee
            // 
            this.grpbxAddUpdateEmployee.Controls.Add(this.btnEnterDelete);
            this.grpbxAddUpdateEmployee.Controls.Add(this.btnDelete);
            this.grpbxAddUpdateEmployee.Controls.Add(this.btnEnter);
            this.grpbxAddUpdateEmployee.Controls.Add(this.btnAdd);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewZip);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label10);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewState);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label9);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewCity);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label8);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewAddress2);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label7);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewAddress1);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label6);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewPhone);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label5);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewFirstName);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label4);
            this.grpbxAddUpdateEmployee.Controls.Add(this.btnUpdate);
            this.grpbxAddUpdateEmployee.Controls.Add(this.txtNewLastName);
            this.grpbxAddUpdateEmployee.Controls.Add(this.label3);
            this.grpbxAddUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddUpdateEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbxAddUpdateEmployee.Location = new System.Drawing.Point(9, 321);
            this.grpbxAddUpdateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxAddUpdateEmployee.Name = "grpbxAddUpdateEmployee";
            this.grpbxAddUpdateEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxAddUpdateEmployee.Size = new System.Drawing.Size(1096, 175);
            this.grpbxAddUpdateEmployee.TabIndex = 7;
            this.grpbxAddUpdateEmployee.TabStop = false;
            this.grpbxAddUpdateEmployee.Text = "Add and Update Employee";
            // 
            // btnEnterDelete
            // 
            this.btnEnterDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnterDelete.Location = new System.Drawing.Point(16, 132);
            this.btnEnterDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterDelete.Name = "btnEnterDelete";
            this.btnEnterDelete.Size = new System.Drawing.Size(168, 38);
            this.btnEnterDelete.TabIndex = 20;
            this.btnEnterDelete.Text = "Enter";
            this.btnEnterDelete.UseVisualStyleBackColor = true;
            this.btnEnterDelete.Click += new System.EventHandler(this.btnEnterDelete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(229, 132);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 38);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(16, 132);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(168, 38);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 132);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewZip
            // 
            this.txtNewZip.Location = new System.Drawing.Point(486, 101);
            this.txtNewZip.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewZip.Name = "txtNewZip";
            this.txtNewZip.Size = new System.Drawing.Size(180, 26);
            this.txtNewZip.TabIndex = 7;
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
            this.txtNewState.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewState.Name = "txtNewState";
            this.txtNewState.Size = new System.Drawing.Size(36, 26);
            this.txtNewState.TabIndex = 6;
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
            this.txtNewCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewCity.Name = "txtNewCity";
            this.txtNewCity.Size = new System.Drawing.Size(180, 26);
            this.txtNewCity.TabIndex = 5;
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
            this.txtNewAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewAddress2.Name = "txtNewAddress2";
            this.txtNewAddress2.Size = new System.Drawing.Size(180, 26);
            this.txtNewAddress2.TabIndex = 4;
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
            this.txtNewAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewAddress1.Name = "txtNewAddress1";
            this.txtNewAddress1.Size = new System.Drawing.Size(180, 26);
            this.txtNewAddress1.TabIndex = 3;
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
            this.txtNewPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(180, 26);
            this.txtNewPhone.TabIndex = 2;
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
            this.txtNewFirstName.Location = new System.Drawing.Point(133, 24);
            this.txtNewFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewFirstName.Name = "txtNewFirstName";
            this.txtNewFirstName.Size = new System.Drawing.Size(180, 26);
            this.txtNewFirstName.TabIndex = 0;
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(229, 132);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 38);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewLastName
            // 
            this.txtNewLastName.Location = new System.Drawing.Point(486, 24);
            this.txtNewLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewLastName.Name = "txtNewLastName";
            this.txtNewLastName.Size = new System.Drawing.Size(180, 26);
            this.txtNewLastName.TabIndex = 1;
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
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(286, 271);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(185, 38);
            this.btnUpdateEmployee.TabIndex = 1;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // grpboxEmployee
            // 
            this.grpboxEmployee.BackColor = System.Drawing.Color.Indigo;
            this.grpboxEmployee.Controls.Add(this.lblDeleteInformation);
            this.grpboxEmployee.Controls.Add(this.lblUpdateInfo);
            this.grpboxEmployee.Controls.Add(this.btnMainMenu);
            this.grpboxEmployee.Controls.Add(this.btnRemoveEmployee);
            this.grpboxEmployee.Controls.Add(this.btnUpdateEmployee);
            this.grpboxEmployee.Controls.Add(this.grpbxAddUpdateEmployee);
            this.grpboxEmployee.Controls.Add(this.employeeTable);
            this.grpboxEmployee.Controls.Add(this.btnAddNewEmployee);
            this.grpboxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpboxEmployee.Location = new System.Drawing.Point(9, 10);
            this.grpboxEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.grpboxEmployee.Name = "grpboxEmployee";
            this.grpboxEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.grpboxEmployee.Size = new System.Drawing.Size(1109, 572);
            this.grpboxEmployee.TabIndex = 3;
            this.grpboxEmployee.TabStop = false;
            this.grpboxEmployee.Text = "Employee Info";
            // 
            // lblDeleteInformation
            // 
            this.lblDeleteInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeleteInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeleteInformation.Location = new System.Drawing.Point(8, 498);
            this.lblDeleteInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteInformation.Name = "lblDeleteInformation";
            this.lblDeleteInformation.Size = new System.Drawing.Size(1097, 46);
            this.lblDeleteInformation.TabIndex = 21;
            this.lblDeleteInformation.Text = "Highlight the employee row you wish to delete from Employee Table View, click ent" +
    "er, then click Delete.";
            // 
            // lblUpdateInfo
            // 
            this.lblUpdateInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUpdateInfo.Location = new System.Drawing.Point(5, 498);
            this.lblUpdateInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateInfo.Name = "lblUpdateInfo";
            this.lblUpdateInfo.Size = new System.Drawing.Size(1097, 46);
            this.lblUpdateInfo.TabIndex = 20;
            this.lblUpdateInfo.Text = "Highlight the employee row you wish to update from Employee Table View, click ent" +
    "er, then update the desired fileds, then click the update button to update the i" +
    "nformation.";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMainMenu.Location = new System.Drawing.Point(916, 271);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(185, 38);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(590, 271);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(185, 38);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1128, 596);
            this.Controls.Add(this.grpboxEmployee);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.grpbxAddUpdateEmployee.ResumeLayout(false);
            this.grpbxAddUpdateEmployee.PerformLayout();
            this.grpboxEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.GroupBox grpbxAddUpdateEmployee;
        private System.Windows.Forms.Button btnAdd;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.GroupBox grpboxEmployee;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Label lblUpdateInfo;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDeleteInformation;
        private System.Windows.Forms.Button btnEnterDelete;
    }
}