
namespace PharmacyApp
{
    partial class SellProduct
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
            this.sellProductTitle = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.buyerName = new System.Windows.Forms.TextBox();
            this.buyerNameLabel = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.priceErrorLabel = new System.Windows.Forms.Label();
            this.statusMessage = new System.Windows.Forms.Label();
            this.productCode = new System.Windows.Forms.TextBox();
            this.cannotFindProduct = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sellProductTitle
            // 
            this.sellProductTitle.AutoSize = true;
            this.sellProductTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellProductTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sellProductTitle.Location = new System.Drawing.Point(32, 23);
            this.sellProductTitle.Name = "sellProductTitle";
            this.sellProductTitle.Size = new System.Drawing.Size(188, 41);
            this.sellProductTitle.TabIndex = 2;
            this.sellProductTitle.Text = "Sell Product";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productCodeLabel.Location = new System.Drawing.Point(18, 104);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(115, 23);
            this.productCodeLabel.TabIndex = 8;
            this.productCodeLabel.Text = "Product Code";
            // 
            // buyerName
            // 
            this.buyerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.buyerName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buyerName.Location = new System.Drawing.Point(179, 151);
            this.buyerName.Name = "buyerName";
            this.buyerName.Size = new System.Drawing.Size(195, 27);
            this.buyerName.TabIndex = 11;
            // 
            // buyerNameLabel
            // 
            this.buyerNameLabel.AutoSize = true;
            this.buyerNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buyerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buyerNameLabel.Location = new System.Drawing.Point(18, 152);
            this.buyerNameLabel.Name = "buyerNameLabel";
            this.buyerNameLabel.Size = new System.Drawing.Size(104, 23);
            this.buyerNameLabel.TabIndex = 10;
            this.buyerNameLabel.Text = "Buyer Name";
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.sellButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sellButton.Location = new System.Drawing.Point(571, 362);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(182, 53);
            this.sellButton.TabIndex = 15;
            this.sellButton.Text = "Sell Product";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellProductButtonHandler);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(38, 362);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(182, 53);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonHandler);
            // 
            // priceErrorLabel
            // 
            this.priceErrorLabel.AutoSize = true;
            this.priceErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.priceErrorLabel.Location = new System.Drawing.Point(394, 198);
            this.priceErrorLabel.Name = "priceErrorLabel";
            this.priceErrorLabel.Size = new System.Drawing.Size(12, 20);
            this.priceErrorLabel.TabIndex = 17;
            this.priceErrorLabel.Text = ".";
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.statusMessage.Location = new System.Drawing.Point(515, 275);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(12, 20);
            this.statusMessage.TabIndex = 18;
            this.statusMessage.Text = ".";
            // 
            // productCode
            // 
            this.productCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productCode.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.productCode.Location = new System.Drawing.Point(179, 104);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(195, 27);
            this.productCode.TabIndex = 19;
            // 
            // cannotFindProduct
            // 
            this.cannotFindProduct.AutoSize = true;
            this.cannotFindProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.cannotFindProduct.Location = new System.Drawing.Point(411, 107);
            this.cannotFindProduct.Name = "cannotFindProduct";
            this.cannotFindProduct.Size = new System.Drawing.Size(12, 20);
            this.cannotFindProduct.TabIndex = 20;
            this.cannotFindProduct.Text = ".";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.printButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printButton.Location = new System.Drawing.Point(651, 24);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(120, 40);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButtonHandler);
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.cannotFindProduct);
            this.Controls.Add(this.productCode);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.priceErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyerName);
            this.Controls.Add(this.buyerNameLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.sellProductTitle);
            this.Name = "SellProduct";
            this.Text = "SellProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sellProductTitle;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox buyerName;
        private System.Windows.Forms.Label buyerNameLabel;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label priceErrorLabel;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.Label cannotFindProduct;
        private System.Windows.Forms.Button printButton;
    }
}