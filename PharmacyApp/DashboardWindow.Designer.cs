
namespace PharmacyApp
{
    partial class DashboardWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboardTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalBalanceLabel = new System.Windows.Forms.Label();
            this.allCustomersTable = new System.Windows.Forms.DataGridView();
            this.allCustomersTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allProductsTable = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.allStaffMembersTable = new System.Windows.Forms.DataGridView();
            this.allStaffLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allCustomersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStaffMembersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardTitle
            // 
            this.dashboardTitle.AutoSize = true;
            this.dashboardTitle.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboardTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardTitle.Location = new System.Drawing.Point(441, 26);
            this.dashboardTitle.Name = "dashboardTitle";
            this.dashboardTitle.Size = new System.Drawing.Size(166, 41);
            this.dashboardTitle.TabIndex = 1;
            this.dashboardTitle.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(872, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Balance:";
            // 
            // totalBalanceLabel
            // 
            this.totalBalanceLabel.AutoSize = true;
            this.totalBalanceLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalBalanceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalBalanceLabel.Location = new System.Drawing.Point(1002, 23);
            this.totalBalanceLabel.Name = "totalBalanceLabel";
            this.totalBalanceLabel.Size = new System.Drawing.Size(24, 28);
            this.totalBalanceLabel.TabIndex = 7;
            this.totalBalanceLabel.Text = "0";
            // 
            // allCustomersTable
            // 
            this.allCustomersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allCustomersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allCustomersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allCustomersTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.allCustomersTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.allCustomersTable.Location = new System.Drawing.Point(29, 116);
            this.allCustomersTable.Name = "allCustomersTable";
            this.allCustomersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allCustomersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.allCustomersTable.RowHeadersWidth = 51;
            this.allCustomersTable.RowTemplate.Height = 29;
            this.allCustomersTable.Size = new System.Drawing.Size(1083, 115);
            this.allCustomersTable.TabIndex = 8;
            // 
            // allCustomersTitle
            // 
            this.allCustomersTitle.AutoSize = true;
            this.allCustomersTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allCustomersTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allCustomersTitle.Location = new System.Drawing.Point(39, 73);
            this.allCustomersTitle.Name = "allCustomersTitle";
            this.allCustomersTitle.Size = new System.Drawing.Size(168, 31);
            this.allCustomersTitle.TabIndex = 9;
            this.allCustomersTitle.Text = "All Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "All Products";
            // 
            // allProductsTable
            // 
            this.allProductsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.allProductsTable.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allProductsTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.allProductsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.allProductsTable.Location = new System.Drawing.Point(39, 300);
            this.allProductsTable.Name = "allProductsTable";
            this.allProductsTable.ReadOnly = true;
            this.allProductsTable.RowHeadersWidth = 25;
            this.allProductsTable.RowTemplate.Height = 29;
            this.allProductsTable.Size = new System.Drawing.Size(1073, 159);
            this.allProductsTable.TabIndex = 10;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.backButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Location = new System.Drawing.Point(39, 22);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(159, 37);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonHandler);
            // 
            // allStaffMembersTable
            // 
            this.allStaffMembersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.allStaffMembersTable.ColumnHeadersHeight = 29;
            this.allStaffMembersTable.Location = new System.Drawing.Point(52, 503);
            this.allStaffMembersTable.Name = "allStaffMembersTable";
            this.allStaffMembersTable.RowHeadersWidth = 51;
            this.allStaffMembersTable.RowTemplate.Height = 29;
            this.allStaffMembersTable.Size = new System.Drawing.Size(1060, 169);
            this.allStaffMembersTable.TabIndex = 26;
            // 
            // allStaffLabel
            // 
            this.allStaffLabel.AutoSize = true;
            this.allStaffLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allStaffLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allStaffLabel.Location = new System.Drawing.Point(39, 469);
            this.allStaffLabel.Name = "allStaffLabel";
            this.allStaffLabel.Size = new System.Drawing.Size(213, 31);
            this.allStaffLabel.TabIndex = 27;
            this.allStaffLabel.Text = "All Staff Members";
            // 
            // DashboardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1154, 684);
            this.Controls.Add(this.allStaffLabel);
            this.Controls.Add(this.allStaffMembersTable);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allProductsTable);
            this.Controls.Add(this.allCustomersTitle);
            this.Controls.Add(this.allCustomersTable);
            this.Controls.Add(this.totalBalanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboardTitle);
            this.Name = "DashboardWindow";
            this.Text = "DashboardWindow";
            ((System.ComponentModel.ISupportInitialize)(this.allCustomersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStaffMembersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalBalanceLabel;
        private System.Windows.Forms.DataGridView allCustomersTable;
        private System.Windows.Forms.Label allCustomersTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView allProductsTable;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView allStaffMembersTable;
        private System.Windows.Forms.Label allStaffLabel;
    }
}