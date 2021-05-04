
namespace FormUI
{
    partial class Dashboard
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
            this.PeopleFoundBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LastNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.FirstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.EmailAddressInsLabel = new System.Windows.Forms.Label();
            this.EmailAddressInsText = new System.Windows.Forms.TextBox();
            this.PhoneNumberInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundBox
            // 
            this.PeopleFoundBox.FormattingEnabled = true;
            this.PeopleFoundBox.ItemHeight = 25;
            this.PeopleFoundBox.Location = new System.Drawing.Point(17, 180);
            this.PeopleFoundBox.Name = "PeopleFoundBox";
            this.PeopleFoundBox.Size = new System.Drawing.Size(434, 129);
            this.PeopleFoundBox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(180, 22);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(235, 31);
            this.LastNameText.TabIndex = 1;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 22);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(162, 25);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "LastNameLabel";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(17, 97);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(106, 44);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LastNameInsLabel
            // 
            this.LastNameInsLabel.AutoSize = true;
            this.LastNameInsLabel.Location = new System.Drawing.Point(12, 368);
            this.LastNameInsLabel.Name = "LastNameInsLabel";
            this.LastNameInsLabel.Size = new System.Drawing.Size(109, 25);
            this.LastNameInsLabel.TabIndex = 5;
            this.LastNameInsLabel.Text = "LastName";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(180, 368);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(235, 31);
            this.lastNameInsText.TabIndex = 4;
            // 
            // FirstNameInsLabel
            // 
            this.FirstNameInsLabel.AutoSize = true;
            this.FirstNameInsLabel.Location = new System.Drawing.Point(12, 334);
            this.FirstNameInsLabel.Name = "FirstNameInsLabel";
            this.FirstNameInsLabel.Size = new System.Drawing.Size(110, 25);
            this.FirstNameInsLabel.TabIndex = 7;
            this.FirstNameInsLabel.Text = "FirstName";
            this.FirstNameInsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(180, 334);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(235, 31);
            this.firstNameInsText.TabIndex = 6;
            // 
            // EmailAddressInsLabel
            // 
            this.EmailAddressInsLabel.AutoSize = true;
            this.EmailAddressInsLabel.Location = new System.Drawing.Point(12, 403);
            this.EmailAddressInsLabel.Name = "EmailAddressInsLabel";
            this.EmailAddressInsLabel.Size = new System.Drawing.Size(150, 25);
            this.EmailAddressInsLabel.TabIndex = 11;
            this.EmailAddressInsLabel.Text = "Email Address";
            // 
            // EmailAddressInsText
            // 
            this.EmailAddressInsText.Location = new System.Drawing.Point(180, 403);
            this.EmailAddressInsText.Name = "EmailAddressInsText";
            this.EmailAddressInsText.Size = new System.Drawing.Size(235, 31);
            this.EmailAddressInsText.TabIndex = 10;
            // 
            // PhoneNumberInsLabel
            // 
            this.PhoneNumberInsLabel.AutoSize = true;
            this.PhoneNumberInsLabel.Location = new System.Drawing.Point(12, 437);
            this.PhoneNumberInsLabel.Name = "PhoneNumberInsLabel";
            this.PhoneNumberInsLabel.Size = new System.Drawing.Size(155, 25);
            this.PhoneNumberInsLabel.TabIndex = 9;
            this.PhoneNumberInsLabel.Text = "Phone Number";
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(180, 437);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(235, 31);
            this.phoneNumberInsText.TabIndex = 8;
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(140, 488);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(106, 44);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 561);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.EmailAddressInsLabel);
            this.Controls.Add(this.EmailAddressInsText);
            this.Controls.Add(this.PhoneNumberInsLabel);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.FirstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.LastNameInsLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PeopleFoundBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label LastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label FirstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label EmailAddressInsLabel;
        private System.Windows.Forms.TextBox EmailAddressInsText;
        private System.Windows.Forms.Label PhoneNumberInsLabel;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Button InsertRecordButton;
    }
}

