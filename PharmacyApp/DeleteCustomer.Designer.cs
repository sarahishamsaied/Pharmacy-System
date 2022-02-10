
namespace PharmacyApp
{
    partial class DeleteCustomer
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
            this.deleteCustomerTitle = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.TextBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.cancelDeletion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteCustomerTitle
            // 
            this.deleteCustomerTitle.AutoSize = true;
            this.deleteCustomerTitle.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCustomerTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCustomerTitle.Location = new System.Drawing.Point(46, 33);
            this.deleteCustomerTitle.Name = "deleteCustomerTitle";
            this.deleteCustomerTitle.Size = new System.Drawing.Size(256, 41);
            this.deleteCustomerTitle.TabIndex = 1;
            this.deleteCustomerTitle.Text = "Delete Customer";
            // 
            // customerId
            // 
            this.customerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customerId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerId.Location = new System.Drawing.Point(207, 113);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(195, 27);
            this.customerId.TabIndex = 9;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerIdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerIdLabel.Location = new System.Drawing.Point(46, 114);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(106, 23);
            this.customerIdLabel.TabIndex = 8;
            this.customerIdLabel.Text = "Customer ID";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.deleteCustomerButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCustomerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCustomerButton.Location = new System.Drawing.Point(550, 355);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(182, 53);
            this.deleteCustomerButton.TabIndex = 22;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButtonHandler);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.statusMessage.Location = new System.Drawing.Point(443, 117);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(176, 23);
            this.statusMessage.TabIndex = 23;
            this.statusMessage.Text = "Cannot find customer";
            // 
            // cancelDeletion
            // 
            this.cancelDeletion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.cancelDeletion.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelDeletion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelDeletion.Location = new System.Drawing.Point(337, 355);
            this.cancelDeletion.Name = "cancelDeletion";
            this.cancelDeletion.Size = new System.Drawing.Size(182, 53);
            this.cancelDeletion.TabIndex = 24;
            this.cancelDeletion.Text = "Cancel";
            this.cancelDeletion.UseVisualStyleBackColor = false;
            this.cancelDeletion.Click += new System.EventHandler(this.cancelButtonHandler);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelDeletion);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.deleteCustomerTitle);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteCustomerTitle;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Label statusMessage;
        private System.Windows.Forms.Button cancelDeletion;
    }
}