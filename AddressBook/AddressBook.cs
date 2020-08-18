using System;
using System.Windows.Forms;
using System.IO;

namespace AddressBook {
    /// <summary>
    /// メインプロセスになるクラス
    /// </summary>
    class AddressBook {

        /// <summary>
        /// 初期設定ファイル
        /// </summary>
        public IniFile inifile { get; private set; }

        /// <summary>
        /// DBクラス
        /// </summary>
        public DataBase database { get; private set; }

        public void MainProcess() {

            this.inifile = new IniFile(Directory.GetCurrentDirectory() + @"\iniFile.ini");

            try {
                this.database = new DataBase(this.inifile.LoginComand);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MenuForm());

            }
            catch (Exception ex) {
                throw ex;

            }
            finally {
                //接続は必ずCloseとDisposeする
                if (this.database != null && this.database.connection != null) {
                    this.database.connection.Close();
                    this.database.connection.Dispose();
                }
            }

        }
    }
}
