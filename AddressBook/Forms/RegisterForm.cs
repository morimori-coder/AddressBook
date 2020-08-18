using AddressBook.Forms;
using System;
using System.Windows.Forms;

namespace AddressBook {
    public partial class RegisterForm : CommonInForms {

        public MenuForm menuForm { get; private set; }

        public RegisterForm(MenuForm menu) {
            InitializeComponent();
            this.menuForm = menu;
        }

        private void BackButton_Click(object sender, EventArgs e) {
            this.menuForm.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// 表示内容をすべてクリアする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBotton_Click(object sender, EventArgs e) {
            this.NameTextBox.Text = "";
            this.YearTextBox.Text = "";
            this.MonthComboBox.SelectedIndex = -1;
            this.DayComboBox.SelectedIndex = -1;
            this.PostCodeTextBox.Text = "";
            this.AddressText.Text = "";
            this.PhoneNumTextBox.Text = "";
            this.MailAddressText.Text = "";
            this.CellPhoneNumText.Text = "";
        }

        /// <summary>
        /// フォームの入力内容でDBにデータを登録する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBottom_Click(object sender, EventArgs e) {
            // 入力内容が不正なら処理を返す
            if (!this.CallFormatCheck())
                return;

            this.SetBoxesValueToProp();

            string sql = Program.addressBook.database.MakeInsertSQL(this);

            Program.addressBook.database.ExecuteInsertToDB(sql);
        }

        /// <summary>
        /// 各ボックスに入力された値の形式チェックを呼ぶ
        /// </summary>
        /// <returns></returns>
        private bool CallFormatCheck() {

            if (this.NameTextBox.Text.Equals(string.Empty)) {
                MessageBox.Show("氏名を入力してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!this.CheckFormatYearTextBox(this.YearTextBox.Text)) {
                MessageBox.Show("誕生年の入力値が不正です", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!this.CheckFormatPostalCode(this.PostCodeTextBox.Text) |
                    this.PostCodeTextBox.Text.Equals(string.Empty)) {
                MessageBox.Show("郵便番号の入力値が空欄または不正です", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.AddressText.Text.Equals(string.Empty)) {
                MessageBox.Show("住所を入力してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.PhoneNumTextBox.Text.Equals(string.Empty) & this.CellPhoneNumText.Text.Equals(string.Empty)) {
                MessageBox.Show("固定電話または携帯電話の番号を入力してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.MailAddressText.Text.Equals(string.Empty)) {
                MessageBox.Show("メールアドレスを入力してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 各ボックスに入力された値をプロパティに格納する
        /// </summary>
        private void SetBoxesValueToProp() {
            this.InName = this.NameTextBox.Text;

            if (!this.YearTextBox.Text.Equals(string.Empty))
                this.InYear = int.Parse(this.YearTextBox.Text);
            else
                this.InYear = 0;

            if (!this.MonthComboBox.Text.Equals(string.Empty))
                this.InMonth = int.Parse(this.MonthComboBox.Text);
            else
                this.InMonth = 0;

            if (!this.DayComboBox.Text.Equals(string.Empty))
                this.InDay = int.Parse(this.DayComboBox.Text);
            else
                this.InDay = 0;

            this.InPostalNum = this.PostCodeTextBox.Text;

            this.InAddress = this.AddressText.Text;

            this.InPhoneNum = this.PhoneNumTextBox.Text;

            this.InMailAddress = this.MailAddressText.Text;

            this.InCellPhoneNum = this.CellPhoneNumText.Text;
        }
    }
}
