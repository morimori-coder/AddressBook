using AddressBook.Forms;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace AddressBook {
    public partial class SearchForm : CommonInForms {

        public MenuForm menuForm { get; private set; }

        /// <summary>
        /// 個人No.
        /// </summary>
        public int InNum { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="menu">メニュー画面</param>
        public SearchForm(MenuForm menu) {
            this.menuForm = menu;
            InitializeComponent();
            this.SearchForm_Load();
        }

        /// <summary>
        /// SearchFormのロード
        /// </summary>
        private void SearchForm_Load() {
            // ListViewコントロールの設定
            this.dataListView.View = View.Details;
            this.dataListView.GridLines = true;

            //カラムの設定
            dataListView.Columns.Add("ID");
            dataListView.Columns.Add("氏名");
            dataListView.Columns.Add("年");
            dataListView.Columns.Add("月");
            dataListView.Columns.Add("日");
            dataListView.Columns.Add("郵便番号");
            dataListView.Columns.Add("住所");
            dataListView.Columns.Add("電話");
            dataListView.Columns.Add("メールアドレス");
            dataListView.Columns.Add("携帯電話");

            dataListView.Columns[0].Width = 30; //ID
            dataListView.Columns[1].Width = 50; //氏名
            dataListView.Columns[2].Width = 40; //年
            dataListView.Columns[3].Width = 30; //月
            dataListView.Columns[4].Width = 30; //日
            dataListView.Columns[5].Width = 60; //郵便番号
            dataListView.Columns[6].Width = 200; //住所
            dataListView.Columns[7].Width = 90; //電話
            dataListView.Columns[8].Width = 90; //メールアドレス
            dataListView.Columns[9].Width = 90; //携帯電話
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
            this.NumTextBox.Text = "";
            this.NameTextBox.Text = "";
            this.YearTextBox.Text = "";
            this.MonthComboBox.SelectedIndex = -1;
            this.DayComboBox.SelectedIndex = -1;
            this.PostCodeTextBox.Text = "";
            this.AddressText.Text = "";
            this.PhoneNumTextBox.Text = "";
            this.MailAddressText.Text = "";
            this.CellPhoneNumText.Text = "";
            this.dataListView.Items.Clear();
        }

        /// <summary>
        /// フォームの入力内容を条件にDBに検索をする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBottom_Click(object sender, EventArgs e) {

            try {
                // 入力内容が不正なら処理を返す
                if (!this.CallFormatCheck())
                    return;

                this.SetBoxesValueToProp();

                // SQL文を作成
                string sql = Program.addressBook.database.MakeSelectSQL(this);

                // 検索を実行する
                List<List<string>> selectResult = Program.addressBook.database.ExecuteSelectToDB(sql);

                // 前回実行時の結果を削除
                this.dataListView.Items.Clear();

                // dataListViewに検索した結果を格納する
                foreach (List<string> list in selectResult) {
                    this.dataListView.Items.Add(new ListViewItem(list.ToArray()));
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        /// <summary>
        /// 各ボックスに入力された値をプロパティに格納する
        /// </summary>
        private void SetBoxesValueToProp() {
            if (!this.NumTextBox.Text.Equals(string.Empty))
                this.InNum = int.Parse(this.NumTextBox.Text);
            else
                this.InNum = 0;

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

        /// <summary>
        /// 各ボックスに入力された値の形式チェックを呼ぶ
        /// </summary>
        /// <returns></returns>
        private bool CallFormatCheck() {
            if (!this.CheckFormatYearTextBox(this.YearTextBox.Text)) {
                MessageBox.Show("誕生年の入力値が不正です", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!this.CheckFormatPostalCode(this.PostCodeTextBox.Text)) {
                MessageBox.Show("郵便番号の入力値が不正です", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!this.CheckIntegerNumTextBox()) {
                MessageBox.Show("No.の入力値が不正です", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CheckIntegerNumTextBox() {
            // 入力値が空文字の場合は郵便番号を検索条件にしないためtrueを返す(処理を継続したい)
            if (this.NumTextBox.Text.Equals(string.Empty))
                return true;

            int value = 0;
            if (int.TryParse(this.NumTextBox.Text, out value)) {
                return true;
            }

            return false;
        }
    }
}
