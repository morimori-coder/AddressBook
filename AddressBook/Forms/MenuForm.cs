using System;
using System.Windows.Forms;

namespace AddressBook {
    public partial class MenuForm : Form {
        public MenuForm() {
            InitializeComponent();
        }

        private void ShowSearchFormBotton_Click(object sender, EventArgs e) {
            var searchForm = new SearchForm(this);
            searchForm.Show();
            this.Enabled = false;
        }

        private void ShowRegisterFormBotton_Click(object sender, EventArgs e) {
            var registerForm = new RegisterForm(this);
            registerForm.Show();
            this.Enabled = false;
        }
    }
}
