
namespace PharmacyApp
{
    partial class ProductsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsMenu));
            this.productsMenuTitile = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.sellProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.viewAllProductsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsMenuTitile
            // 
            this.productsMenuTitile.AutoSize = true;
            this.productsMenuTitile.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsMenuTitile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsMenuTitile.Location = new System.Drawing.Point(72, 38);
            this.productsMenuTitile.Name = "productsMenuTitile";
            this.productsMenuTitile.Size = new System.Drawing.Size(233, 41);
            this.productsMenuTitile.TabIndex = 0;
            this.productsMenuTitile.Text = "Products Menu";
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProductButton.Location = new System.Drawing.Point(93, 115);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(182, 53);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButtonHandler);
            // 
            // sellProductButton
            // 
            this.sellProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.sellProductButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sellProductButton.Location = new System.Drawing.Point(304, 115);
            this.sellProductButton.Name = "sellProductButton";
            this.sellProductButton.Size = new System.Drawing.Size(182, 53);
            this.sellProductButton.TabIndex = 5;
            this.sellProductButton.Text = "Sell Product";
            this.sellProductButton.UseVisualStyleBackColor = false;
            this.sellProductButton.Click += new System.EventHandler(this.sellProductButtonHandler);
            // 
            // removeProductButton
            // 
            this.removeProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.removeProductButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeProductButton.Location = new System.Drawing.Point(93, 222);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(182, 53);
            this.removeProductButton.TabIndex = 6;
            this.removeProductButton.Text = "Remove Product";
            this.removeProductButton.UseVisualStyleBackColor = false;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButtonHandler);
            // 
            // viewAllProductsButton
            // 
            this.viewAllProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.viewAllProductsButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewAllProductsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewAllProductsButton.Location = new System.Drawing.Point(304, 222);
            this.viewAllProductsButton.Name = "viewAllProductsButton";
            this.viewAllProductsButton.Size = new System.Drawing.Size(182, 53);
            this.viewAllProductsButton.TabIndex = 7;
            this.viewAllProductsButton.Text = "View All Products";
            this.viewAllProductsButton.UseVisualStyleBackColor = false;
            this.viewAllProductsButton.Click += new System.EventHandler(this.viewAllProductsButtonHandler);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.backButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(589, 38);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(182, 53);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.goBackButtonHandler);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-306, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 491);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ProductsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productsMenuTitile);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewAllProductsButton);
            this.Controls.Add(this.sellProductButton);
            this.Name = "ProductsMenu";
            this.Text = "ProductsMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productsMenuTitile;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button sellProductButton;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button viewAllProductsButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}