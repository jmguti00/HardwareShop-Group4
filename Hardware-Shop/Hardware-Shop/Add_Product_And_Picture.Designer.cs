namespace Hardware_Shop
{
    partial class Add_Product_And_Picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product_And_Picture));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picbxProductPicture = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.gpbxProductInfo = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.grpbxAddPicture = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpbxAddNewProduct = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewBrowse = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddPictureMenu = new System.Windows.Forms.Button();
            this.btnAddProductMenu = new System.Windows.Forms.Button();
            this.grpbxUpdateInformation = new System.Windows.Forms.GroupBox();
            this.btnUpdateEnter = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbxProductPicture)).BeginInit();
            this.gpbxProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.grpbxAddPicture.SuspendLayout();
            this.grpbxAddNewProduct.SuspendLayout();
            this.grpbxUpdateInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert or Upload or Save Image Into SQL Server DataBase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name:";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(230, 367);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(126, 30);
            this.txtProductId.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(230, 419);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(237, 30);
            this.txtProductName.TabIndex = 4;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.Location = new System.Drawing.Point(932, 73);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(170, 35);
            this.btnAddPicture.TabIndex = 6;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(472, 636);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(211, 35);
            this.btnUpdateProduct.TabIndex = 7;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(460, 73);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(170, 35);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picbxProductPicture
            // 
            this.picbxProductPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxProductPicture.Location = new System.Drawing.Point(497, 364);
            this.picbxProductPicture.Name = "picbxProductPicture";
            this.picbxProductPicture.Size = new System.Drawing.Size(605, 230);
            this.picbxProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxProductPicture.TabIndex = 5;
            this.picbxProductPicture.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(954, 636);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(166, 35);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // gpbxProductInfo
            // 
            this.gpbxProductInfo.Controls.Add(this.txtPrice);
            this.gpbxProductInfo.Controls.Add(this.txtQuantity);
            this.gpbxProductInfo.Controls.Add(this.txtDescription);
            this.gpbxProductInfo.Controls.Add(this.label6);
            this.gpbxProductInfo.Controls.Add(this.picbxProductPicture);
            this.gpbxProductInfo.Controls.Add(this.label5);
            this.gpbxProductInfo.Controls.Add(this.label4);
            this.gpbxProductInfo.Controls.Add(this.productTable);
            this.gpbxProductInfo.Controls.Add(this.txtProductName);
            this.gpbxProductInfo.Controls.Add(this.label1);
            this.gpbxProductInfo.Controls.Add(this.txtProductId);
            this.gpbxProductInfo.Controls.Add(this.label2);
            this.gpbxProductInfo.Controls.Add(this.label3);
            this.gpbxProductInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxProductInfo.Location = new System.Drawing.Point(12, 12);
            this.gpbxProductInfo.Name = "gpbxProductInfo";
            this.gpbxProductInfo.Size = new System.Drawing.Size(1108, 607);
            this.gpbxProductInfo.TabIndex = 10;
            this.gpbxProductInfo.TabStop = false;
            this.gpbxProductInfo.Text = "Product Information";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(230, 564);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(126, 30);
            this.txtPrice.TabIndex = 15;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(230, 513);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(126, 30);
            this.txtQuantity.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(230, 467);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(237, 30);
            this.txtDescription.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Description:";
            // 
            // productTable
            // 
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Location = new System.Drawing.Point(6, 53);
            this.productTable.Name = "productTable";
            this.productTable.RowTemplate.Height = 24;
            this.productTable.Size = new System.Drawing.Size(1096, 305);
            this.productTable.TabIndex = 0;
            // 
            // grpbxAddPicture
            // 
            this.grpbxAddPicture.Controls.Add(this.btnAddPicture);
            this.grpbxAddPicture.Controls.Add(this.label8);
            this.grpbxAddPicture.Controls.Add(this.btnEnter);
            this.grpbxAddPicture.Controls.Add(this.btnBrowse);
            this.grpbxAddPicture.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddPicture.Location = new System.Drawing.Point(12, 682);
            this.grpbxAddPicture.Name = "grpbxAddPicture";
            this.grpbxAddPicture.Size = new System.Drawing.Size(1108, 122);
            this.grpbxAddPicture.TabIndex = 11;
            this.grpbxAddPicture.TabStop = false;
            this.grpbxAddPicture.Text = "Add Picture";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(991, 44);
            this.label8.TabIndex = 1;
            this.label8.Text = "Highlight the product row you wish to enter a picture to from Product Table View," +
    " press the enter button, then browse for the picture, and click add picture.";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(10, 73);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(170, 35);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Press Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(734, 636);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(166, 35);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpbxAddNewProduct
            // 
            this.grpbxAddNewProduct.Controls.Add(this.btnSave);
            this.grpbxAddNewProduct.Controls.Add(this.btnNewBrowse);
            this.grpbxAddNewProduct.Controls.Add(this.label13);
            this.grpbxAddNewProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddNewProduct.Location = new System.Drawing.Point(12, 682);
            this.grpbxAddNewProduct.Name = "grpbxAddNewProduct";
            this.grpbxAddNewProduct.Size = new System.Drawing.Size(1108, 122);
            this.grpbxAddNewProduct.TabIndex = 13;
            this.grpbxAddNewProduct.TabStop = false;
            this.grpbxAddNewProduct.Text = "Add a new Product";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(461, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewBrowse
            // 
            this.btnNewBrowse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBrowse.Location = new System.Drawing.Point(6, 73);
            this.btnNewBrowse.Name = "btnNewBrowse";
            this.btnNewBrowse.Size = new System.Drawing.Size(170, 35);
            this.btnNewBrowse.TabIndex = 8;
            this.btnNewBrowse.Text = "Browse";
            this.btnNewBrowse.UseVisualStyleBackColor = true;
            this.btnNewBrowse.Click += new System.EventHandler(this.btnNewBrowse_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1072, 41);
            this.label13.TabIndex = 1;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // btnAddPictureMenu
            // 
            this.btnAddPictureMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPictureMenu.Location = new System.Drawing.Point(12, 636);
            this.btnAddPictureMenu.Name = "btnAddPictureMenu";
            this.btnAddPictureMenu.Size = new System.Drawing.Size(166, 35);
            this.btnAddPictureMenu.TabIndex = 14;
            this.btnAddPictureMenu.Text = "Add  Picture";
            this.btnAddPictureMenu.UseVisualStyleBackColor = true;
            this.btnAddPictureMenu.Click += new System.EventHandler(this.btnAddPictureMenu_Click);
            // 
            // btnAddProductMenu
            // 
            this.btnAddProductMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductMenu.Location = new System.Drawing.Point(233, 636);
            this.btnAddProductMenu.Name = "btnAddProductMenu";
            this.btnAddProductMenu.Size = new System.Drawing.Size(172, 35);
            this.btnAddProductMenu.TabIndex = 15;
            this.btnAddProductMenu.Text = "Add  Products";
            this.btnAddProductMenu.UseVisualStyleBackColor = true;
            this.btnAddProductMenu.Click += new System.EventHandler(this.btnAddProductMenu_Click);
            // 
            // grpbxUpdateInformation
            // 
            this.grpbxUpdateInformation.Controls.Add(this.btnUpdateEnter);
            this.grpbxUpdateInformation.Controls.Add(this.btnUpdateInfo);
            this.grpbxUpdateInformation.Controls.Add(this.label7);
            this.grpbxUpdateInformation.Controls.Add(this.btnUpdateBrowse);
            this.grpbxUpdateInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxUpdateInformation.Location = new System.Drawing.Point(12, 682);
            this.grpbxUpdateInformation.Name = "grpbxUpdateInformation";
            this.grpbxUpdateInformation.Size = new System.Drawing.Size(1108, 122);
            this.grpbxUpdateInformation.TabIndex = 16;
            this.grpbxUpdateInformation.TabStop = false;
            this.grpbxUpdateInformation.Text = "Update Product Information";
            // 
            // btnUpdateEnter
            // 
            this.btnUpdateEnter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEnter.Location = new System.Drawing.Point(10, 73);
            this.btnUpdateEnter.Name = "btnUpdateEnter";
            this.btnUpdateEnter.Size = new System.Drawing.Size(170, 35);
            this.btnUpdateEnter.TabIndex = 9;
            this.btnUpdateEnter.Text = "Enter";
            this.btnUpdateEnter.UseVisualStyleBackColor = true;
            this.btnUpdateEnter.Click += new System.EventHandler(this.btnUpdateEnter_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(515, 73);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(170, 35);
            this.btnUpdateInfo.TabIndex = 6;
            this.btnUpdateInfo.Text = "Update Product";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(991, 44);
            this.label7.TabIndex = 1;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // btnUpdateBrowse
            // 
            this.btnUpdateBrowse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBrowse.Location = new System.Drawing.Point(249, 73);
            this.btnUpdateBrowse.Name = "btnUpdateBrowse";
            this.btnUpdateBrowse.Size = new System.Drawing.Size(170, 35);
            this.btnUpdateBrowse.TabIndex = 8;
            this.btnUpdateBrowse.Text = "Browse";
            this.btnUpdateBrowse.UseVisualStyleBackColor = true;
            this.btnUpdateBrowse.Click += new System.EventHandler(this.btnUpdateBrowse_Click);
            // 
            // Add_Product_And_Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 821);
            this.Controls.Add(this.grpbxUpdateInformation);
            this.Controls.Add(this.grpbxAddNewProduct);
            this.Controls.Add(this.btnAddProductMenu);
            this.Controls.Add(this.btnAddPictureMenu);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpbxAddPicture);
            this.Controls.Add(this.gpbxProductInfo);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnMainMenu);
            this.Name = "Add_Product_And_Picture";
            this.Text = "Add_Product_And_Picture";
            ((System.ComponentModel.ISupportInitialize)(this.picbxProductPicture)).EndInit();
            this.gpbxProductInfo.ResumeLayout(false);
            this.gpbxProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.grpbxAddPicture.ResumeLayout(false);
            this.grpbxAddNewProduct.ResumeLayout(false);
            this.grpbxUpdateInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.PictureBox picbxProductPicture;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.GroupBox gpbxProductInfo;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpbxAddPicture;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpbxAddNewProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewBrowse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddPictureMenu;
        private System.Windows.Forms.Button btnAddProductMenu;
        private System.Windows.Forms.GroupBox grpbxUpdateInformation;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateBrowse;
        private System.Windows.Forms.Button btnUpdateEnter;
    }
}