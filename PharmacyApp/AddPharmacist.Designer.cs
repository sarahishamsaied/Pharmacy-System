
namespace PharmacyApp
{
    partial class AddPharmacist
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_cashier = new System.Windows.Forms.Button();
            this.genderbutton = new System.Windows.Forms.Label();
            this.male_button = new System.Windows.Forms.RadioButton();
            this.female_button = new System.Windows.Forms.RadioButton();
            this.cashier_address = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.cashier_phonenumber = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.pharmacist_id = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.pharmacist_Age = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.pharmacistNameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.shift = new System.Windows.Forms.ComboBox();
            this.shift_button = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.TextBox();
            this.bonus_button = new System.Windows.Forms.Label();
            this.workingHours = new System.Windows.Forms.TextBox();
            this.workinghours_button = new System.Windows.Forms.Label();
            this.salary_button = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.dateofHire = new System.Windows.Forms.DateTimePicker();
            this.dateofHire_button = new System.Windows.Forms.Label();
            this.speciality_ = new System.Windows.Forms.TextBox();
            this.speciality = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.cancel_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancel_button.Location = new System.Drawing.Point(489, 393);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(149, 45);
            this.cancel_button.TabIndex = 29;
            this.cancel_button.Text = "Cancel ";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_click);
            // 
            // add_cashier
            // 
            this.add_cashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.add_cashier.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.add_cashier.Location = new System.Drawing.Point(655, 393);
            this.add_cashier.Name = "add_cashier";
            this.add_cashier.Size = new System.Drawing.Size(133, 45);
            this.add_cashier.TabIndex = 28;
            this.add_cashier.Text = "Add Cashier";
            this.add_cashier.UseVisualStyleBackColor = false;
            this.add_cashier.Click += new System.EventHandler(this.add_button_click);
            // 
            // genderbutton
            // 
            this.genderbutton.AutoSize = true;
            this.genderbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.genderbutton.Location = new System.Drawing.Point(49, 387);
            this.genderbutton.Name = "genderbutton";
            this.genderbutton.Size = new System.Drawing.Size(57, 20);
            this.genderbutton.TabIndex = 27;
            this.genderbutton.Text = "Gender";
            // 
            // male_button
            // 
            this.male_button.AutoSize = true;
            this.male_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.male_button.Location = new System.Drawing.Point(312, 387);
            this.male_button.Name = "male_button";
            this.male_button.Size = new System.Drawing.Size(63, 24);
            this.male_button.TabIndex = 26;
            this.male_button.TabStop = true;
            this.male_button.Text = "Male";
            this.male_button.UseVisualStyleBackColor = true;
            // 
            // female_button
            // 
            this.female_button.AutoSize = true;
            this.female_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.female_button.Location = new System.Drawing.Point(179, 385);
            this.female_button.Name = "female_button";
            this.female_button.Size = new System.Drawing.Size(78, 24);
            this.female_button.TabIndex = 25;
            this.female_button.TabStop = true;
            this.female_button.Text = "Female";
            this.female_button.UseVisualStyleBackColor = true;
            // 
            // cashier_address
            // 
            this.cashier_address.AutoSize = true;
            this.cashier_address.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cashier_address.Location = new System.Drawing.Point(45, 275);
            this.cashier_address.Name = "cashier_address";
            this.cashier_address.Size = new System.Drawing.Size(62, 20);
            this.cashier_address.TabIndex = 24;
            this.cashier_address.Text = "Address";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.address.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.address.Location = new System.Drawing.Point(179, 286);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(149, 27);
            this.address.TabIndex = 23;
            // 
            // cashier_phonenumber
            // 
            this.cashier_phonenumber.AutoSize = true;
            this.cashier_phonenumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cashier_phonenumber.Location = new System.Drawing.Point(45, 239);
            this.cashier_phonenumber.Name = "cashier_phonenumber";
            this.cashier_phonenumber.Size = new System.Drawing.Size(108, 20);
            this.cashier_phonenumber.TabIndex = 22;
            this.cashier_phonenumber.Text = "Phone Number";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.number.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.number.Location = new System.Drawing.Point(179, 239);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(149, 27);
            this.number.TabIndex = 21;
            // 
            // pharmacist_id
            // 
            this.pharmacist_id.AutoSize = true;
            this.pharmacist_id.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pharmacist_id.Location = new System.Drawing.Point(45, 194);
            this.pharmacist_id.Name = "pharmacist_id";
            this.pharmacist_id.Size = new System.Drawing.Size(100, 20);
            this.pharmacist_id.TabIndex = 20;
            this.pharmacist_id.Text = "Pharmacist ID";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.id.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.id.Location = new System.Drawing.Point(179, 194);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(149, 27);
            this.id.TabIndex = 19;
            this.id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pharmacist_Age
            // 
            this.pharmacist_Age.AutoSize = true;
            this.pharmacist_Age.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pharmacist_Age.Location = new System.Drawing.Point(45, 134);
            this.pharmacist_Age.Name = "pharmacist_Age";
            this.pharmacist_Age.Size = new System.Drawing.Size(112, 20);
            this.pharmacist_Age.TabIndex = 18;
            this.pharmacist_Age.Text = "Pharmacist Age";
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.age.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.age.Location = new System.Drawing.Point(179, 134);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(149, 27);
            this.age.TabIndex = 17;
            // 
            // pharmacistNameLabel
            // 
            this.pharmacistNameLabel.AutoSize = true;
            this.pharmacistNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pharmacistNameLabel.Location = new System.Drawing.Point(44, 91);
            this.pharmacistNameLabel.Name = "pharmacistNameLabel";
            this.pharmacistNameLabel.Size = new System.Drawing.Size(125, 20);
            this.pharmacistNameLabel.TabIndex = 16;
            this.pharmacistNameLabel.Text = "Pharmacist Name";
            this.pharmacistNameLabel.Click += new System.EventHandler(this.pharmacistNameLabel_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.name.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.name.Location = new System.Drawing.Point(179, 91);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 27);
            this.name.TabIndex = 15;
            this.name.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // shift
            // 
            this.shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.shift.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.shift.FormattingEnabled = true;
            this.shift.Items.AddRange(new object[] {
            "From 8:00 AM - 3:00 PM ",
            "From 3:00 PM - 9:00 PM "});
            this.shift.Location = new System.Drawing.Point(179, 332);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(151, 28);
            this.shift.TabIndex = 30;
            // 
            // shift_button
            // 
            this.shift_button.AutoSize = true;
            this.shift_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.shift_button.Location = new System.Drawing.Point(45, 321);
            this.shift_button.Name = "shift_button";
            this.shift_button.Size = new System.Drawing.Size(39, 20);
            this.shift_button.TabIndex = 31;
            this.shift_button.Text = "Shift";
            // 
            // bonus
            // 
            this.bonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.bonus.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.bonus.Location = new System.Drawing.Point(538, 98);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(149, 27);
            this.bonus.TabIndex = 32;
            // 
            // bonus_button
            // 
            this.bonus_button.AutoSize = true;
            this.bonus_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bonus_button.Location = new System.Drawing.Point(405, 98);
            this.bonus_button.Name = "bonus_button";
            this.bonus_button.Size = new System.Drawing.Size(49, 20);
            this.bonus_button.TabIndex = 33;
            this.bonus_button.Text = "Bonus";
            // 
            // workingHours
            // 
            this.workingHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.workingHours.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.workingHours.Location = new System.Drawing.Point(538, 141);
            this.workingHours.Name = "workingHours";
            this.workingHours.Size = new System.Drawing.Size(149, 27);
            this.workingHours.TabIndex = 34;
            // 
            // workinghours_button
            // 
            this.workinghours_button.AutoSize = true;
            this.workinghours_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.workinghours_button.Location = new System.Drawing.Point(405, 141);
            this.workinghours_button.Name = "workinghours_button";
            this.workinghours_button.Size = new System.Drawing.Size(107, 20);
            this.workinghours_button.TabIndex = 35;
            this.workinghours_button.Text = "Working Hours";
            // 
            // salary_button
            // 
            this.salary_button.AutoSize = true;
            this.salary_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.salary_button.Location = new System.Drawing.Point(405, 194);
            this.salary_button.Name = "salary_button";
            this.salary_button.Size = new System.Drawing.Size(49, 20);
            this.salary_button.TabIndex = 36;
            this.salary_button.Text = "Salary";
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.salary.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.salary.Location = new System.Drawing.Point(538, 194);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(149, 27);
            this.salary.TabIndex = 37;
            // 
            // dateofHire
            // 
            this.dateofHire.Location = new System.Drawing.Point(538, 254);
            this.dateofHire.Name = "dateofHire";
            this.dateofHire.Size = new System.Drawing.Size(250, 27);
            this.dateofHire.TabIndex = 38;
            // 
            // dateofHire_button
            // 
            this.dateofHire_button.AutoSize = true;
            this.dateofHire_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateofHire_button.Location = new System.Drawing.Point(405, 259);
            this.dateofHire_button.Name = "dateofHire_button";
            this.dateofHire_button.Size = new System.Drawing.Size(93, 20);
            this.dateofHire_button.TabIndex = 39;
            this.dateofHire_button.Text = "Date Of Hire";
            // 
            // speciality_
            // 
            this.speciality_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.speciality_.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.speciality_.Location = new System.Drawing.Point(538, 318);
            this.speciality_.Name = "speciality_";
            this.speciality_.Size = new System.Drawing.Size(149, 27);
            this.speciality_.TabIndex = 40;
            // 
            // speciality
            // 
            this.speciality.AutoSize = true;
            this.speciality.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.speciality.Location = new System.Drawing.Point(405, 321);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(73, 20);
            this.speciality.TabIndex = 41;
            this.speciality.Text = "Speciality";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(152, 418);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(12, 20);
            this.errorMessage.TabIndex = 42;
            this.errorMessage.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 38);
            this.label1.TabIndex = 43;
            this.label1.Text = "Add Pharmacist";
            // 
            // AddPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.speciality_);
            this.Controls.Add(this.dateofHire_button);
            this.Controls.Add(this.dateofHire);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.salary_button);
            this.Controls.Add(this.workinghours_button);
            this.Controls.Add(this.workingHours);
            this.Controls.Add(this.bonus_button);
            this.Controls.Add(this.bonus);
            this.Controls.Add(this.shift_button);
            this.Controls.Add(this.shift);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_cashier);
            this.Controls.Add(this.genderbutton);
            this.Controls.Add(this.male_button);
            this.Controls.Add(this.female_button);
            this.Controls.Add(this.cashier_address);
            this.Controls.Add(this.address);
            this.Controls.Add(this.cashier_phonenumber);
            this.Controls.Add(this.number);
            this.Controls.Add(this.pharmacist_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pharmacist_Age);
            this.Controls.Add(this.age);
            this.Controls.Add(this.pharmacistNameLabel);
            this.Controls.Add(this.name);
            this.Name = "AddPharmacist";
            this.Text = "AddPharmacist";
            this.Load += new System.EventHandler(this.AddPharmacist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_cashier;
        private System.Windows.Forms.Label genderbutton;
        private System.Windows.Forms.RadioButton male_button;
        private System.Windows.Forms.RadioButton female_button;
        private System.Windows.Forms.Label cashier_address;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label cashier_phonenumber;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label pharmacist_id;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label pharmacist_Age;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label pharmacistNameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox shift;
        private System.Windows.Forms.Label shift_button;
        private System.Windows.Forms.TextBox bonus;
        private System.Windows.Forms.Label bonus_button;
        private System.Windows.Forms.TextBox workingHours;
        private System.Windows.Forms.Label workinghours_button;
        private System.Windows.Forms.Label salary_button;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.DateTimePicker dateofHire;
        private System.Windows.Forms.Label dateofHire_button;
        private System.Windows.Forms.TextBox speciality_;
        private System.Windows.Forms.Label speciality;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label label1;
    }
}