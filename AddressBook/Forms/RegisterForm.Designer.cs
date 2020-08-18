namespace AddressBook {
    partial class RegisterForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearBotton = new System.Windows.Forms.Button();
            this.RegisterBottom = new System.Windows.Forms.Button();
            this.MailAddressText = new System.Windows.Forms.TextBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.CellPhoneNumText = new System.Windows.Forms.TextBox();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PostCodeLabel = new System.Windows.Forms.Label();
            this.PostCodeTextBox = new System.Windows.Forms.TextBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(700, 253);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 48;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ClearBotton
            // 
            this.ClearBotton.Location = new System.Drawing.Point(700, 213);
            this.ClearBotton.Name = "ClearBotton";
            this.ClearBotton.Size = new System.Drawing.Size(75, 23);
            this.ClearBotton.TabIndex = 47;
            this.ClearBotton.Text = "クリア";
            this.ClearBotton.UseVisualStyleBackColor = true;
            this.ClearBotton.Click += new System.EventHandler(this.ClearBotton_Click);
            // 
            // RegisterBottom
            // 
            this.RegisterBottom.Location = new System.Drawing.Point(587, 213);
            this.RegisterBottom.Name = "RegisterBottom";
            this.RegisterBottom.Size = new System.Drawing.Size(75, 23);
            this.RegisterBottom.TabIndex = 46;
            this.RegisterBottom.Text = "登録";
            this.RegisterBottom.UseVisualStyleBackColor = true;
            this.RegisterBottom.Click += new System.EventHandler(this.RegisterBottom_Click);
            // 
            // MailAddressText
            // 
            this.MailAddressText.Location = new System.Drawing.Point(338, 133);
            this.MailAddressText.Name = "MailAddressText";
            this.MailAddressText.Size = new System.Drawing.Size(437, 19);
            this.MailAddressText.TabIndex = 43;
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(263, 136);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(69, 12);
            this.MailAddressLabel.TabIndex = 42;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // CellPhoneNumText
            // 
            this.CellPhoneNumText.Location = new System.Drawing.Point(87, 172);
            this.CellPhoneNumText.Name = "CellPhoneNumText";
            this.CellPhoneNumText.Size = new System.Drawing.Size(129, 19);
            this.CellPhoneNumText.TabIndex = 41;
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Location = new System.Drawing.Point(25, 175);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(53, 12);
            this.CellPhoneLabel.TabIndex = 40;
            this.CellPhoneLabel.Text = "携帯電話";
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(87, 133);
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.Size = new System.Drawing.Size(129, 19);
            this.PhoneNumTextBox.TabIndex = 39;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(25, 136);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(29, 12);
            this.PhoneLabel.TabIndex = 38;
            this.PhoneLabel.Text = "電話";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(87, 93);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(550, 19);
            this.AddressText.TabIndex = 37;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(25, 96);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(29, 12);
            this.AddressLabel.TabIndex = 36;
            this.AddressLabel.Text = "住所";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(758, 35);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(17, 12);
            this.DayLabel.TabIndex = 34;
            this.DayLabel.Text = "日";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(689, 35);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(17, 12);
            this.MonthLabel.TabIndex = 33;
            this.MonthLabel.Text = "月";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(615, 35);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(17, 12);
            this.YearLabel.TabIndex = 31;
            this.YearLabel.Text = "年";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(545, 32);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(56, 19);
            this.YearTextBox.TabIndex = 30;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(481, 35);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(53, 12);
            this.BirthDateLabel.TabIndex = 29;
            this.BirthDateLabel.Text = "生年月日";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(87, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 19);
            this.NameTextBox.TabIndex = 28;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(27, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 27;
            this.NameLabel.Text = "氏名";
            // 
            // PostCodeLabel
            // 
            this.PostCodeLabel.AutoSize = true;
            this.PostCodeLabel.Location = new System.Drawing.Point(25, 65);
            this.PostCodeLabel.Name = "PostCodeLabel";
            this.PostCodeLabel.Size = new System.Drawing.Size(53, 12);
            this.PostCodeLabel.TabIndex = 49;
            this.PostCodeLabel.Text = "郵便番号";
            // 
            // PostCodeTextBox
            // 
            this.PostCodeTextBox.Location = new System.Drawing.Point(87, 58);
            this.PostCodeTextBox.Name = "PostCodeTextBox";
            this.PostCodeTextBox.Size = new System.Drawing.Size(129, 19);
            this.PostCodeTextBox.TabIndex = 50;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DisplayMember = "1";
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MonthComboBox.Location = new System.Drawing.Point(638, 31);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(45, 20);
            this.MonthComboBox.TabIndex = 51;
            // 
            // DayComboBox
            // 
            this.DayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayComboBox.Location = new System.Drawing.Point(712, 32);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(38, 20);
            this.DayComboBox.TabIndex = 52;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.PostCodeTextBox);
            this.Controls.Add(this.PostCodeLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearBotton);
            this.Controls.Add(this.RegisterBottom);
            this.Controls.Add(this.MailAddressText);
            this.Controls.Add(this.MailAddressLabel);
            this.Controls.Add(this.CellPhoneNumText);
            this.Controls.Add(this.CellPhoneLabel);
            this.Controls.Add(this.PhoneNumTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearBotton;
        private System.Windows.Forms.Button RegisterBottom;
        private System.Windows.Forms.TextBox MailAddressText;
        private System.Windows.Forms.Label MailAddressLabel;
        private System.Windows.Forms.TextBox CellPhoneNumText;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.TextBox PhoneNumTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PostCodeLabel;
        private System.Windows.Forms.TextBox PostCodeTextBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ComboBox DayComboBox;
    }
}