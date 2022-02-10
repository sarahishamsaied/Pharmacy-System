
namespace PharmacyApp
{
    partial class AddProduct
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
            this.addProductTitle = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productCode = new System.Windows.Forms.TextBox();
            this.productSupplierLabel = new System.Windows.Forms.Label();
            this.productSupplier = new System.Windows.Forms.TextBox();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ComboBox();
            this.productDiscount = new System.Windows.Forms.TextBox();
            this.productDiscountLabel = new System.Windows.Forms.Label();
            this.expiryDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addProductButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.product_Price = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProductTitle
            // 
            this.addProductTitle.AutoSize = true;
            this.addProductTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addProductTitle.Location = new System.Drawing.Point(27, 20);
            this.addProductTitle.Name = "addProductTitle";
            this.addProductTitle.Size = new System.Drawing.Size(211, 45);
            this.addProductTitle.TabIndex = 0;
            this.addProductTitle.Text = "Add Product";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productNameLabel.Location = new System.Drawing.Point(36, 85);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(121, 23);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Product Name";
            // 
            // productName
            // 
            this.productName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.productName.Location = new System.Drawing.Point(197, 84);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(195, 27);
            this.productName.TabIndex = 7;
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productCodeLabel.Location = new System.Drawing.Point(36, 128);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(115, 23);
            this.productCodeLabel.TabIndex = 8;
            this.productCodeLabel.Text = "Product Code";
            // 
            // productCode
            // 
            this.productCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productCode.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.productCode.Location = new System.Drawing.Point(197, 128);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(195, 27);
            this.productCode.TabIndex = 9;
            // 
            // productSupplierLabel
            // 
            this.productSupplierLabel.AutoSize = true;
            this.productSupplierLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productSupplierLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productSupplierLabel.Location = new System.Drawing.Point(36, 170);
            this.productSupplierLabel.Name = "productSupplierLabel";
            this.productSupplierLabel.Size = new System.Drawing.Size(137, 23);
            this.productSupplierLabel.TabIndex = 10;
            this.productSupplierLabel.Text = "Product Supplier";
            // 
            // productSupplier
            // 
            this.productSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productSupplier.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.productSupplier.Location = new System.Drawing.Point(197, 170);
            this.productSupplier.Name = "productSupplier";
            this.productSupplier.Size = new System.Drawing.Size(195, 27);
            this.productSupplier.TabIndex = 11;
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productQuantityLabel.Location = new System.Drawing.Point(36, 261);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(141, 23);
            this.productQuantityLabel.TabIndex = 12;
            this.productQuantityLabel.Text = "Product Quantity";
            this.productQuantityLabel.Click += new System.EventHandler(this.productQuantityLabel_Click);
            // 
            // productQuantity
            // 
            this.productQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productQuantity.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.productQuantity.Location = new System.Drawing.Point(197, 261);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(59, 27);
            this.productQuantity.TabIndex = 13;
            this.productQuantity.TextChanged += new System.EventHandler(this.productQuantity_TextChanged);
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productTypeLabel.Location = new System.Drawing.Point(36, 215);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(110, 23);
            this.productTypeLabel.TabIndex = 14;
            this.productTypeLabel.Text = "Product Type";
            // 
            // productType
            // 
            this.productType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productType.ForeColor = System.Drawing.SystemColors.Window;
            this.productType.FormattingEnabled = true;
            this.productType.Items.AddRange(new object[] {
            "Pill",
            "Injection",
            "Syrup",
            "Other"});
            this.productType.Location = new System.Drawing.Point(197, 214);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(195, 28);
            this.productType.TabIndex = 15;
            // 
            // productDiscount
            // 
            this.productDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productDiscount.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.productDiscount.Location = new System.Drawing.Point(197, 303);
            this.productDiscount.Name = "productDiscount";
            this.productDiscount.Size = new System.Drawing.Size(59, 27);
            this.productDiscount.TabIndex = 17;
            // 
            // productDiscountLabel
            // 
            this.productDiscountLabel.AutoSize = true;
            this.productDiscountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productDiscountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productDiscountLabel.Location = new System.Drawing.Point(36, 307);
            this.productDiscountLabel.Name = "productDiscountLabel";
            this.productDiscountLabel.Size = new System.Drawing.Size(142, 23);
            this.productDiscountLabel.TabIndex = 16;
            this.productDiscountLabel.Text = "Product Discount";
            // 
            // expiryDateLabel
            // 
            this.expiryDateLabel.AutoSize = true;
            this.expiryDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expiryDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiryDateLabel.Location = new System.Drawing.Point(36, 393);
            this.expiryDateLabel.Name = "expiryDateLabel";
            this.expiryDateLabel.Size = new System.Drawing.Size(96, 23);
            this.expiryDateLabel.TabIndex = 18;
            this.expiryDateLabel.Text = "Expiry Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 389);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 27);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProductButton.Location = new System.Drawing.Point(655, 402);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(133, 36);
            this.addProductButton.TabIndex = 20;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButtonHandler);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(516, 404);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 34);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonHandler);
            // 
            // product_Price
            // 
            this.product_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.product_Price.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.product_Price.Location = new System.Drawing.Point(197, 342);
            this.product_Price.Name = "product_Price";
            this.product_Price.Size = new System.Drawing.Size(59, 27);
            this.product_Price.TabIndex = 23;
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productPrice.Location = new System.Drawing.Point(36, 346);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(112, 23);
            this.productPrice.TabIndex = 22;
            this.productPrice.Text = "Product Price";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.errorMessage.Location = new System.Drawing.Point(303, 307);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(182, 25);
            this.errorMessage.TabIndex = 24;
            this.errorMessage.Text = "Please fill all inputs";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.backButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(633, 30);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 41);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonHandler);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.product_Price);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.expiryDateLabel);
            this.Controls.Add(this.productDiscount);
            this.Controls.Add(this.productDiscountLabel);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.productTypeLabel);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productSupplier);
            this.Controls.Add(this.productSupplierLabel);
            this.Controls.Add(this.productCode);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.addProductTitle);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductTitle;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.Label productSupplierLabel;
        private System.Windows.Forms.TextBox productSupplier;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.Label productTypeLabel;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.TextBox productDiscount;
        private System.Windows.Forms.Label productDiscountLabel;
        private System.Windows.Forms.Label expiryDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox product_Price;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button backButton;
    }
}