
namespace PharmacyApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerAge = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.customerNumber = new System.Windows.Forms.TextBox();
            this.customerId = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.patientName = new System.Windows.Forms.Label();
            this.customerAgeLabel = new System.Windows.Forms.Label();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.customerGender = new System.Windows.Forms.Label();
            this.customerFormTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveCustomerButton = new System.Windows.Forms.Button();
            this.cancelForm1Button = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customerName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerName.Location = new System.Drawing.Point(165, 72);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(195, 27);
            this.customerName.TabIndex = 4;
            // 
            // customerAge
            // 
            this.customerAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customerAge.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerAge.Location = new System.Drawing.Point(165, 125);
            this.customerAge.Name = "customerAge";
            this.customerAge.Size = new System.Drawing.Size(84, 27);
            this.customerAge.TabIndex = 5;
            this.customerAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // customerAddress
            // 
            this.customerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customerAddress.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerAddress.Location = new System.Drawing.Point(165, 187);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(195, 27);
            this.customerAddress.TabIndex = 6;
            // 
            // customerNumber
            // 
            this.customerNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customerNumber.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerNumber.Location = new System.Drawing.Point(165, 244);
            this.customerNumber.Name = "customerNumber";
            this.customerNumber.Size = new System.Drawing.Size(195, 27);
            this.customerNumber.TabIndex = 7;
            // 
            // customerId
            // 
            this.customerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.customerId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerId.Location = new System.Drawing.Point(165, 300);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(195, 27);
            this.customerId.TabIndex = 8;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.male.Location = new System.Drawing.Point(167, 346);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(63, 24);
            this.male.TabIndex = 9;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.female.Location = new System.Drawing.Point(259, 346);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(78, 24);
            this.female.TabIndex = 10;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // patientName
            // 
            this.patientName.AutoSize = true;
            this.patientName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.patientName.Location = new System.Drawing.Point(20, 75);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(116, 20);
            this.patientName.TabIndex = 11;
            this.patientName.Text = "Customer Name";
            this.patientName.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerAgeLabel
            // 
            this.customerAgeLabel.AutoSize = true;
            this.customerAgeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customerAgeLabel.Location = new System.Drawing.Point(14, 127);
            this.customerAgeLabel.Name = "customerAgeLabel";
            this.customerAgeLabel.Size = new System.Drawing.Size(103, 20);
            this.customerAgeLabel.TabIndex = 12;
            this.customerAgeLabel.Text = "Customer Age";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customerAddressLabel.Location = new System.Drawing.Point(14, 190);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(129, 20);
            this.customerAddressLabel.TabIndex = 13;
            this.customerAddressLabel.Text = "Customer Address";
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customerNumberLabel.Location = new System.Drawing.Point(20, 244);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(130, 20);
            this.customerNumberLabel.TabIndex = 14;
            this.customerNumberLabel.Text = "Customer Number";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerIdLabel.Location = new System.Drawing.Point(20, 303);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(91, 20);
            this.customerIdLabel.TabIndex = 15;
            this.customerIdLabel.Text = "Customer ID";
            // 
            // customerGender
            // 
            this.customerGender.AutoSize = true;
            this.customerGender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customerGender.Location = new System.Drawing.Point(20, 348);
            this.customerGender.Name = "customerGender";
            this.customerGender.Size = new System.Drawing.Size(124, 20);
            this.customerGender.TabIndex = 16;
            this.customerGender.Text = "Customer Gender";
            // 
            // customerFormTitle
            // 
            this.customerFormTitle.AutoSize = true;
            this.customerFormTitle.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerFormTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customerFormTitle.Location = new System.Drawing.Point(20, 25);
            this.customerFormTitle.Name = "customerFormTitle";
            this.customerFormTitle.Size = new System.Drawing.Size(229, 31);
            this.customerFormTitle.TabIndex = 17;
            this.customerFormTitle.Text = "Enter Customer Data";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 201);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // saveCustomerButton
            // 
            this.saveCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.saveCustomerButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveCustomerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveCustomerButton.Location = new System.Drawing.Point(555, 382);
            this.saveCustomerButton.Name = "saveCustomerButton";
            this.saveCustomerButton.Size = new System.Drawing.Size(182, 53);
            this.saveCustomerButton.TabIndex = 23;
            this.saveCustomerButton.Text = "Save";
            this.saveCustomerButton.UseVisualStyleBackColor = false;
            this.saveCustomerButton.Click += new System.EventHandler(this.saveButtonHandler);
            // 
            // cancelForm1Button
            // 
            this.cancelForm1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.cancelForm1Button.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelForm1Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelForm1Button.Location = new System.Drawing.Point(354, 382);
            this.cancelForm1Button.Name = "cancelForm1Button";
            this.cancelForm1Button.Size = new System.Drawing.Size(182, 53);
            this.cancelForm1Button.TabIndex = 24;
            this.cancelForm1Button.Text = "Cancel";
            this.cancelForm1Button.UseVisualStyleBackColor = false;
            this.cancelForm1Button.Click += new System.EventHandler(this.cancelButtonHandler);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.statusMessage.Location = new System.Drawing.Point(47, 399);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(12, 20);
            this.statusMessage.TabIndex = 25;
            this.statusMessage.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.cancelForm1Button);
            this.Controls.Add(this.saveCustomerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerFormTitle);
            this.Controls.Add(this.customerGender);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.customerNumberLabel);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.customerAgeLabel);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.customerNumber);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerAge);
            this.Controls.Add(this.customerName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox customerAge;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox customerNumber;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label patientName;
        private System.Windows.Forms.Label customerAgeLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label customerGender;
        private System.Windows.Forms.Label customerFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveCustomerButton;
        private System.Windows.Forms.Button cancelForm1Button;
        private System.Windows.Forms.Label statusMessage;
    }
}

