
namespace PharmacyApp
{
    partial class ViewCustomers
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
            this.viewCustomersTitle = new System.Windows.Forms.Label();
            this.customersTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // viewCustomersTitle
            // 
            this.viewCustomersTitle.AutoSize = true;
            this.viewCustomersTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewCustomersTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewCustomersTitle.Location = new System.Drawing.Point(29, 37);
            this.viewCustomersTitle.Name = "viewCustomersTitle";
            this.viewCustomersTitle.Size = new System.Drawing.Size(246, 41);
            this.viewCustomersTitle.TabIndex = 0;
            this.viewCustomersTitle.Text = "View Customers";
            // 
            // customersTable
            // 
            this.customersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Location = new System.Drawing.Point(29, 107);
            this.customersTable.Name = "customersTable";
            this.customersTable.RowHeadersWidth = 51;
            this.customersTable.RowTemplate.Height = 29;
            this.customersTable.Size = new System.Drawing.Size(1107, 381);
            this.customersTable.TabIndex = 1;
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1148, 500);
            this.Controls.Add(this.customersTable);
            this.Controls.Add(this.viewCustomersTitle);
            this.Name = "ViewCustomers";
            this.Text = "ViewCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewCustomersTitle;
        private System.Windows.Forms.DataGridView customersTable;
    }
}