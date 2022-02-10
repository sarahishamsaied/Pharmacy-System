
namespace PharmacyApp
{
    partial class ViewProduct
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
            this.ViewProducts = new System.Windows.Forms.Label();
            this.productsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewProducts
            // 
            this.ViewProducts.AutoSize = true;
            this.ViewProducts.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewProducts.Location = new System.Drawing.Point(25, 25);
            this.ViewProducts.Name = "ViewProducts";
            this.ViewProducts.Size = new System.Drawing.Size(205, 38);
            this.ViewProducts.TabIndex = 0;
            this.ViewProducts.Text = "View Products";
            // 
            // productsTable
            // 
            this.productsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Location = new System.Drawing.Point(25, 77);
            this.productsTable.Name = "productsTable";
            this.productsTable.RowHeadersWidth = 51;
            this.productsTable.RowTemplate.Height = 29;
            this.productsTable.Size = new System.Drawing.Size(1117, 389);
            this.productsTable.TabIndex = 1;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1154, 495);
            this.Controls.Add(this.productsTable);
            this.Controls.Add(this.ViewProducts);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewProducts;
        private System.Windows.Forms.DataGridView productsTable;
    }
}