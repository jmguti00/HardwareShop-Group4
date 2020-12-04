﻿namespace Hardware_Shop
{
    partial class PlaceOrder
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
            this.btnHomeReno = new System.Windows.Forms.Button();
            this.btnBuildingConstruction = new System.Windows.Forms.Button();
            this.btnLawnGarden = new System.Windows.Forms.Button();
            this.btnToolsAccessories = new System.Windows.Forms.Button();
            this.btnReturnToCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shop by Department";
            // 
            // btnHomeReno
            // 
            this.btnHomeReno.BackgroundImage = global::Hardware_Shop.Properties.Resources.home_renovation;
            this.btnHomeReno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomeReno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeReno.Location = new System.Drawing.Point(150, 373);
            this.btnHomeReno.Name = "btnHomeReno";
            this.btnHomeReno.Size = new System.Drawing.Size(239, 177);
            this.btnHomeReno.TabIndex = 4;
            this.btnHomeReno.Text = "&Home Renovations";
            this.btnHomeReno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomeReno.UseVisualStyleBackColor = true;
            this.btnHomeReno.Click += new System.EventHandler(this.btnHomeReno_Click);
            // 
            // btnBuildingConstruction
            // 
            this.btnBuildingConstruction.BackgroundImage = global::Hardware_Shop.Properties.Resources.Layer_3_pasted_;
            this.btnBuildingConstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuildingConstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildingConstruction.Location = new System.Drawing.Point(483, 373);
            this.btnBuildingConstruction.Name = "btnBuildingConstruction";
            this.btnBuildingConstruction.Size = new System.Drawing.Size(239, 177);
            this.btnBuildingConstruction.TabIndex = 3;
            this.btnBuildingConstruction.Text = "&Building and Construction";
            this.btnBuildingConstruction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuildingConstruction.UseVisualStyleBackColor = true;
            this.btnBuildingConstruction.Click += new System.EventHandler(this.btnBuildingConstruction_Click);
            // 
            // btnLawnGarden
            // 
            this.btnLawnGarden.BackgroundImage = global::Hardware_Shop.Properties.Resources.LawnMower;
            this.btnLawnGarden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLawnGarden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLawnGarden.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLawnGarden.Location = new System.Drawing.Point(483, 143);
            this.btnLawnGarden.Name = "btnLawnGarden";
            this.btnLawnGarden.Size = new System.Drawing.Size(239, 177);
            this.btnLawnGarden.TabIndex = 2;
            this.btnLawnGarden.Text = "L&awn and Garden";
            this.btnLawnGarden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLawnGarden.UseVisualStyleBackColor = true;
            this.btnLawnGarden.Click += new System.EventHandler(this.btnLawnGarden_Click);
            // 
            // btnToolsAccessories
            // 
            this.btnToolsAccessories.BackgroundImage = global::Hardware_Shop.Properties.Resources._32217641660027p;
            this.btnToolsAccessories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToolsAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolsAccessories.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnToolsAccessories.Location = new System.Drawing.Point(150, 143);
            this.btnToolsAccessories.Name = "btnToolsAccessories";
            this.btnToolsAccessories.Size = new System.Drawing.Size(239, 177);
            this.btnToolsAccessories.TabIndex = 0;
            this.btnToolsAccessories.Text = "&Tools and Accessories";
            this.btnToolsAccessories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnToolsAccessories.UseVisualStyleBackColor = true;
            this.btnToolsAccessories.Click += new System.EventHandler(this.btnToolsAccessories_Click);
            // 
            // btnReturnToCust
            // 
            this.btnReturnToCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToCust.Location = new System.Drawing.Point(150, 570);
            this.btnReturnToCust.Name = "btnReturnToCust";
            this.btnReturnToCust.Size = new System.Drawing.Size(147, 33);
            this.btnReturnToCust.TabIndex = 5;
            this.btnReturnToCust.Text = "&Return to Customers";
            this.btnReturnToCust.UseVisualStyleBackColor = true;
            this.btnReturnToCust.Click += new System.EventHandler(this.btnReturnToCust_Click);
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 624);
            this.Controls.Add(this.btnReturnToCust);
            this.Controls.Add(this.btnHomeReno);
            this.Controls.Add(this.btnBuildingConstruction);
            this.Controls.Add(this.btnLawnGarden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToolsAccessories);
            this.Name = "PlaceOrder";
            this.Text = "PlaceOrder";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToolsAccessories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLawnGarden;
        private System.Windows.Forms.Button btnBuildingConstruction;
        private System.Windows.Forms.Button btnHomeReno;
        private System.Windows.Forms.Button btnReturnToCust;
    }
}