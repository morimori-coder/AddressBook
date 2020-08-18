using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System;

namespace AddressBook {
    class DataBase {

        private readonly string ID_COL = "id";
        private readonly string NAME_COL = "name";
        private readonly string BIRTH_YEAR_COL = "birth_year";
        private readonly string BIRTH_MONTH_COL = "birth_month";
        private readonly string BIRTH_DAY_COL = "birth_day";
        private readonly string POSTAL_CODE_COL = "postal_code";
        private readonly string ADDRESS_COL = "address";
        private readonly string PHONE_NUMBER_COL = "phone_number";
        private readonly string MAIL_ADDRESS_COL = "mail_address";
        private readonly string CELLPHONE_NUMBER_COL = "cellphone_number";


        /// <summary>
        /// コネクション
        /// </summary>
        public NpgsqlConnection connection { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// <paramref name="connectInfo"/>接続情報
        /// </summary>
        public DataBase(string connectInfo) {
            try {
                this.connection = new NpgsqlConnection(connectInfo);
                this.connection.Open();
            }
            catch (PostgresException ex) {
                throw ex;
            }
        }

        /// <summary>
        /// Select文を作成する
        /// </summary>
        /// <returns>作成したSelect文</returns>
        public string MakeSelectSQL(SearchForm serchForm) {
            var whereValues = new List<string>();

            if (serchForm.InNum != 0)
                whereValues.Add($"{this.ID_COL}={serchForm.InNum}");

            if (!string.IsNullOrEmpty(serchForm.InName))
                whereValues.Add($"{this.NAME_COL} like '%{serchForm.InName}%'");

            if (serchForm.InYear != 0)
                whereValues.Add($"{this.BIRTH_YEAR_COL} = {serchForm.InYear}");

            if (serchForm.InMonth != 0)
                whereValues.Add($"{this.BIRTH_MONTH_COL} = {serchForm.InMonth}");

            if (serchForm.InDay != 0)
                whereValues.Add($"{this.BIRTH_DAY_COL} = {serchForm.InDay}");

            if (!string.IsNullOrEmpty(serchForm.InPostalNum))
                whereValues.Add($"{this.POSTAL_CODE_COL} like '%{serchForm.InPostalNum}%'");

            if (!string.IsNullOrEmpty(serchForm.InAddress))
                whereValues.Add($"{this.ADDRESS_COL} like '%{serchForm.InAddress}%'");

            if (!string.IsNullOrEmpty(serchForm.InPhoneNum))
                whereValues.Add($"{this.PHONE_NUMBER_COL} like '%{serchForm.InPhoneNum}%'");

            if (!string.IsNullOrEmpty(serchForm.InMailAddress))
                whereValues.Add($"{this.MAIL_ADDRESS_COL} like '%{serchForm.InMailAddress}%'");

            if (!string.IsNullOrEmpty(serchForm.InCellPhoneNum))
                whereValues.Add($"{this.CELLPHONE_NUMBER_COL} like '%{serchForm.InCellPhoneNum}%'");

            string select = "select * from persons";
            string whereValue;

            if (whereValues.Count > 0)
                whereValue = select + " where " + string.Join(" and ", whereValues);
            else
                whereValue = select;

            whereValue += ";";

            return whereValue;
        }

        /// <summary>
        /// Select文を実行し結果を返す
        /// </summary>
        /// <param name="sql">SQL文</param>
        /// <returns>実行結果</returns>
        public List<List<string>> ExecuteSelectToDB(string sql) {

            var resultData = new List<List<string>>();

            try {
                using (var dataAdapter = new NpgsqlDataAdapter(sql, this.connection)) {

                    var dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    foreach (DataRow dataRow in dataSet.Tables[0].Rows) {

                        var rowComps = new List<string>();
                        for (int i = 0; i < dataRow.ItemArray.Length; i++) {
                            rowComps.Add($"{dataRow[i]}");
                        }

                        resultData.Add(rowComps);
                    }
                }
            }
            catch (Exception ex) {
                throw ex;
            }


            return resultData;
        }

        public string MakeInsertSQL(RegisterForm registerForm) {

            var targetColumNames = new StringBuilder();
            var columnvalues = new StringBuilder();

            // not null制約のカラム名
            targetColumNames.Append($"insert into persons({this.NAME_COL},{this.POSTAL_CODE_COL}" +
                $",{this.ADDRESS_COL}, {this.MAIL_ADDRESS_COL} ");

            // not null制約のカラム値
            columnvalues.Append($"values ('{registerForm.InName}', '{registerForm.InPostalNum}'," +
                $"'{registerForm.InAddress}', '{registerForm.InMailAddress}'");

            if (registerForm.InYear != 0) {
                targetColumNames.Append($",{this.BIRTH_YEAR_COL}");
                columnvalues.Append($",{registerForm.InYear}");
            }

            if (registerForm.InMonth != 0) {
                targetColumNames.Append($", {this.BIRTH_MONTH_COL}");
                columnvalues.Append($",{registerForm.InMonth}");
            }

            if (registerForm.InDay != 0) {
                targetColumNames.Append($", {this.BIRTH_DAY_COL}");
                columnvalues.Append($",{registerForm.InDay}");
            }

            if (!string.IsNullOrEmpty(registerForm.InPhoneNum)) {
                targetColumNames.Append($", {this.PHONE_NUMBER_COL}");
                columnvalues.Append($", '{registerForm.InPhoneNum}'");
            }


            if (!string.IsNullOrEmpty(registerForm.InCellPhoneNum)) {
                targetColumNames.Append($", {this.CELLPHONE_NUMBER_COL}");
                columnvalues.Append($", '{registerForm.InCellPhoneNum}'");
            }

            // into部分の括弧を閉じる
            targetColumNames.Append(")");
            // values部分の括弧を閉じる
            columnvalues.Append(");");

            return targetColumNames.ToString() + columnvalues.ToString();
        }

        /// <summary>
        /// DBにINSERT分を実行する
        /// </summary>
        /// <param name="sql">SQL文</param>
        public void ExecuteInsertToDB(string sql) {
            try {
                using (var command = new NpgsqlCommand(sql, this.connection)) {
                    var rowsaffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
