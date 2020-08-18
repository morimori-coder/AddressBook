using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AddressBook.Forms {
    /// <summary>
    /// 検索画面と登録画面で同じ処理をさせたいためのクラス
    /// </summary>
    public class CommonInForms : Form {

        // 各項目の入力された値
        public string InName { get; protected set; }
        public int InYear { get; protected set; }
        public int InMonth { get; protected set; }
        public int InDay { get; protected set; }
        public string InPostalNum { get; protected set; }
        public string InAddress { get; protected set; }
        public string InPhoneNum { get; protected set; }
        public string InMailAddress { get; protected set; }
        public string InCellPhoneNum { get; protected set; }

        /// <summary>
        /// 「年」テキストボックスの値の形式をチェックする
        /// </summary>
        /// <param name="yearText">年</param>
        /// <returns>true:OK false:NG</returns>
        public bool CheckFormatYearTextBox(string yearText) {
            // 入力値が空文字の場合は誕生年を検索条件にしないためtrueを返す(処理を継続したい)
            if (yearText.Equals(string.Empty))
                return true;

            bool isMatch = Regex.IsMatch(yearText, @"^[0-9]{4}$");
            return isMatch;
        }

        /// <summary>
        /// 「郵便番号」テキストボックスの値の形式をチェックする
        /// </summary>
        /// <param name="postalCode">郵便番号</param>
        /// <returns></returns>
        public bool CheckFormatPostalCode(string postalCode) {
            // 入力値が空文字の場合は郵便番号を検索条件にしないためtrueを返す(処理を継続したい)
            if (postalCode.Equals(string.Empty))
                return true;

            bool isMatch = Regex.IsMatch(postalCode, @"^[0-9]{3}-[0-9]{4}$");
            return isMatch;
        }
    }
}
