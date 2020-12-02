namespace Hardware_Shop
{
    partial class ProductInvenotry
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(45, 54);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1143, 794);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnMainPage
            // 
            this.btnMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPage.Location = new System.Drawing.Point(697, 12);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(181, 36);
            this.btnMainPage.TabIndex = 1;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // ProductInvenotry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 860);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ProductInvenotry";
            this.Text = "Product Inventory";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnMainPage;
    }
}