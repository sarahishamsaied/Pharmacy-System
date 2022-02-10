
namespace PharmacyApp
{
    partial class StaffMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMenu));
            this.cashierButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.pharmacistButton = new System.Windows.Forms.Button();
            this.staffMenuLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewAllStaffMembers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cashierButton
            // 
            this.cashierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.cashierButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cashierButton.Location = new System.Drawing.Point(83, 157);
            this.cashierButton.Name = "cashierButton";
            this.cashierButton.Size = new System.Drawing.Size(142, 41);
            this.cashierButton.TabIndex = 0;
            this.cashierButton.Text = "Cashier";
            this.cashierButton.UseVisualStyleBackColor = false;
            this.cashierButton.Click += new System.EventHandler(this.cashierButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.managerButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.managerButton.Location = new System.Drawing.Point(83, 226);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(142, 41);
            this.managerButton.TabIndex = 1;
            this.managerButton.Text = "Manager";
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.managerButton_click);
            // 
            // pharmacistButton
            // 
            this.pharmacistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.pharmacistButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.pharmacistButton.Location = new System.Drawing.Point(83, 292);
            this.pharmacistButton.Name = "pharmacistButton";
            this.pharmacistButton.Size = new System.Drawing.Size(142, 41);
            this.pharmacistButton.TabIndex = 2;
            this.pharmacistButton.Text = "Pharmacist";
            this.pharmacistButton.UseVisualStyleBackColor = false;
            this.pharmacistButton.Click += new System.EventHandler(this.pharmacistButton_click);
            // 
            // staffMenuLabel
            // 
            this.staffMenuLabel.AutoSize = true;
            this.staffMenuLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staffMenuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.staffMenuLabel.Location = new System.Drawing.Point(83, 65);
            this.staffMenuLabel.Name = "staffMenuLabel";
            this.staffMenuLabel.Size = new System.Drawing.Size(163, 38);
            this.staffMenuLabel.TabIndex = 3;
            this.staffMenuLabel.Text = "Staff Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // viewAllStaffMembers
            // 
            this.viewAllStaffMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.viewAllStaffMembers.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.viewAllStaffMembers.Location = new System.Drawing.Point(83, 356);
            this.viewAllStaffMembers.Name = "viewAllStaffMembers";
            this.viewAllStaffMembers.Size = new System.Drawing.Size(142, 41);
            this.viewAllStaffMembers.TabIndex = 5;
            this.viewAllStaffMembers.Text = "View All Staff";
            this.viewAllStaffMembers.UseVisualStyleBackColor = false;
            this.viewAllStaffMembers.Click += new System.EventHandler(this.viewAllStaffButtonHandler);
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewAllStaffMembers);
            this.Controls.Add(this.staffMenuLabel);
            this.Controls.Add(this.pharmacistButton);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.cashierButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StaffMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cashierButton;
        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button pharmacistButton;
        private System.Windows.Forms.Label staffMenuLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewAllStaffMembers;
    }
}

