namespace AddressBook {
    partial class MenuForm {
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
            this.ShowSearchFormBotton = new System.Windows.Forms.Button();
            this.ShowRegisterFormBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowSearchFormBotton
            // 
            this.ShowSearchFormBotton.Location = new System.Drawing.Point(120, 106);
            this.ShowSearchFormBotton.Name = "ShowSearchFormBotton";
            this.ShowSearchFormBotton.Size = new System.Drawing.Size(135, 76);
            this.ShowSearchFormBotton.TabIndex = 0;
            this.ShowSearchFormBotton.Text = "検索画面表示";
            this.ShowSearchFormBotton.UseVisualStyleBackColor = true;
            this.ShowSearchFormBotton.Click += new System.EventHandler(this.ShowSearchFormBotton_Click);
            // 
            // ShowRegisterFormBotton
            // 
            this.ShowRegisterFormBotton.Location = new System.Drawing.Point(355, 106);
            this.ShowRegisterFormBotton.Name = "ShowRegisterFormBotton";
            this.ShowRegisterFormBotton.Size = new System.Drawing.Size(135, 76);
            this.ShowRegisterFormBotton.TabIndex = 1;
            this.ShowRegisterFormBotton.Text = "登録画面表示";
            this.ShowRegisterFormBotton.UseVisualStyleBackColor = true;
            this.ShowRegisterFormBotton.Click += new System.EventHandler(this.ShowRegisterFormBotton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 307);
            this.Controls.Add(this.ShowRegisterFormBotton);
            this.Controls.Add(this.ShowSearchFormBotton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowSearchFormBotton;
        private System.Windows.Forms.Button ShowRegisterFormBotton;
    }
}