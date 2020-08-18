using Npgsql;
using System;
using System.Windows.Forms;

namespace AddressBook {
    static class Program {

        public static AddressBook addressBook { get; private set; }

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            try {
                Program.addressBook = new AddressBook();
                addressBook.MainProcess();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
