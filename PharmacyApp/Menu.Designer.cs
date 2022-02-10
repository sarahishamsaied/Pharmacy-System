
namespace PharmacyApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.sellProduct = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy System";
            // 
            // sellProduct
            // 
            this.sellProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.sellProduct.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sellProduct.Location = new System.Drawing.Point(59, 188);
            this.sellProduct.Name = "sellProduct";
            this.sellProduct.Size = new System.Drawing.Size(182, 53);
            this.sellProduct.TabIndex = 3;
            this.sellProduct.Text = "Products";
            this.sellProduct.UseVisualStyleBackColor = false;
            this.sellProduct.Click += new System.EventHandler(this.productsButtonHandler);
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customerButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerButton.Location = new System.Drawing.Point(59, 269);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(182, 53);
            this.customerButton.TabIndex = 4;
            this.customerButton.Text = "Customers";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customersButtonHandler);
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard.Location = new System.Drawing.Point(661, 32);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(174, 47);
            this.dashboard.TabIndex = 5;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = false;
            this.dashboard.Click += new System.EventHandler(this.dashboardButtonHandler);
            // 
            // staffButton
            // 
            this.staffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.staffButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staffButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.staffButton.Location = new System.Drawing.Point(59, 346);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(182, 53);
            this.staffButton.TabIndex = 6;
            this.staffButton.Text = "Staff ";
            this.staffButton.UseVisualStyleBackColor = false;
            this.staffButton.Click += new System.EventHandler(this.staffButtonHandler);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(492, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(868, 542);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.sellProduct);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sellProduct;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}