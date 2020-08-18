namespace AddressBook {
    partial class SearchForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.dataListView = new System.Windows.Forms.ListView();
            this.NumLabel = new System.Windows.Forms.Label();
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.CellPhoneNumText = new System.Windows.Forms.TextBox();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.MailAddressText = new System.Windows.Forms.TextBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.SearchBottom = new System.Windows.Forms.Button();
            this.ClearBotton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.PostCodeLabel = new System.Windows.Forms.Label();
            this.PostCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dataListView
            // 
            this.dataListView.HideSelection = false;
            this.dataListView.Location = new System.Drawing.Point(24, 207);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(748, 308);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(22, 21);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(21, 12);
            this.NumLabel.TabIndex = 1;
            this.NumLabel.Text = "No.";
            // 
            // NumTextBox
            // 
            this.NumTextBox.Location = new System.Drawing.Point(84, 18);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(100, 19);
            this.NumTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(230, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "氏名";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(265, 18);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 19);
            this.NameTextBox.TabIndex = 4;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(478, 21);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(53, 12);
            this.BirthDateLabel.TabIndex = 5;
            this.BirthDateLabel.Text = "生年月日";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(542, 18);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(56, 19);
            this.YearTextBox.TabIndex = 6;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(612, 21);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(17, 12);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "年";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(686, 21);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(17, 12);
            this.MonthLabel.TabIndex = 9;
            this.MonthLabel.Text = "月";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(755, 21);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(17, 12);
            this.DayLabel.TabIndex = 10;
            this.DayLabel.Text = "日";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(84, 79);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(550, 19);
            this.AddressText.TabIndex = 13;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(22, 82);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(29, 12);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "住所";
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(84, 119);
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.Size = new System.Drawing.Size(129, 19);
            this.PhoneNumTextBox.TabIndex = 15;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(22, 122);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(29, 12);
            this.PhoneLabel.TabIndex = 14;
            this.PhoneLabel.Text = "電話";
            // 
            // CellPhoneNumText
            // 
            this.CellPhoneNumText.Location = new System.Drawing.Point(84, 158);
            this.CellPhoneNumText.Name = "CellPhoneNumText";
            this.CellPhoneNumText.Size = new System.Drawing.Size(129, 19);
            this.CellPhoneNumText.TabIndex = 17;
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Location = new System.Drawing.Point(22, 161);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(53, 12);
            this.CellPhoneLabel.TabIndex = 16;
            this.CellPhoneLabel.Text = "携帯電話";
            // 
            // MailAddressText
            // 
            this.MailAddressText.Location = new System.Drawing.Point(335, 119);
            this.MailAddressText.Name = "MailAddressText";
            this.MailAddressText.Size = new System.Drawing.Size(437, 19);
            this.MailAddressText.TabIndex = 19;
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(260, 122);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(69, 12);
            this.MailAddressLabel.TabIndex = 18;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // SearchBottom
            // 
            this.SearchBottom.Location = new System.Drawing.Point(584, 175);
            this.SearchBottom.Name = "SearchBottom";
            this.SearchBottom.Size = new System.Drawing.Size(75, 23);
            this.SearchBottom.TabIndex = 22;
            this.SearchBottom.Text = "検索";
            this.SearchBottom.UseVisualStyleBackColor = true;
            this.SearchBottom.Click += new System.EventHandler(this.SearchBottom_Click);
            // 
            // ClearBotton
            // 
            this.ClearBotton.Location = new System.Drawing.Point(697, 175);
            this.ClearBotton.Name = "ClearBotton";
            this.ClearBotton.Size = new System.Drawing.Size(75, 23);
            this.ClearBotton.TabIndex = 23;
            this.ClearBotton.Text = "クリア";
            this.ClearBotton.UseVisualStyleBackColor = true;
            this.ClearBotton.Click += new System.EventHandler(this.ClearBotton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(697, 524);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "戻る";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.MonthComboBox.Location = new System.Drawing.Point(635, 18);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(45, 20);
            this.MonthComboBox.TabIndex = 25;
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
            this.DayComboBox.Location = new System.Drawing.Point(709, 18);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(38, 20);
            this.DayComboBox.TabIndex = 26;
            // 
            // PostCodeLabel
            // 
            this.PostCodeLabel.AutoSize = true;
            this.PostCodeLabel.Location = new System.Drawing.Point(22, 52);
            this.PostCodeLabel.Name = "PostCodeLabel";
            this.PostCodeLabel.Size = new System.Drawing.Size(53, 12);
            this.PostCodeLabel.TabIndex = 27;
            this.PostCodeLabel.Text = "郵便番号";
            // 
            // PostCodeTextBox
            // 
            this.PostCodeTextBox.Location = new System.Drawing.Point(84, 49);
            this.PostCodeTextBox.Name = "PostCodeTextBox";
            this.PostCodeTextBox.Size = new System.Drawing.Size(129, 19);
            this.PostCodeTextBox.TabIndex = 28;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.PostCodeTextBox);
            this.Controls.Add(this.PostCodeLabel);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearBotton);
            this.Controls.Add(this.SearchBottom);
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
            this.Controls.Add(this.NumTextBox);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.dataListView);
            this.Name = "SearchForm";
            this.Text = "住所録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox PhoneNumTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox CellPhoneNumText;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.TextBox MailAddressText;
        private System.Windows.Forms.Label MailAddressLabel;
        private System.Windows.Forms.Button SearchBottom;
        private System.Windows.Forms.Button ClearBotton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.Label PostCodeLabel;
        private System.Windows.Forms.TextBox PostCodeTextBox;
    }
}

