namespace WindowsFormsApp1
{
    partial class Title
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.Phonetic_textBox = new System.Windows.Forms.TextBox();
            this.FuriganaLabel = new System.Windows.Forms.Label();
            this.Deployment_comboBox = new System.Windows.Forms.ComboBox();
            this.DepLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Emp_status_comboBox = new System.Windows.Forms.ComboBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.Year_textBox = new System.Windows.Forms.TextBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.Day_comboBox = new System.Windows.Forms.ComboBox();
            this.Month_comboBox = new System.Windows.Forms.ComboBox();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.EmpIDLabel = new System.Windows.Forms.Label();
            this.Fullname_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(118, 958);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(106, 24);
            this.TypeLabel.TabIndex = 56;
            this.TypeLabel.Text = "雇用形態";
            // 
            // Phonetic_textBox
            // 
            this.Phonetic_textBox.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Phonetic_textBox.Location = new System.Drawing.Point(111, 422);
            this.Phonetic_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phonetic_textBox.Name = "Phonetic_textBox";
            this.Phonetic_textBox.Size = new System.Drawing.Size(569, 31);
            this.Phonetic_textBox.TabIndex = 55;
            this.Phonetic_textBox.Leave += new System.EventHandler(this.Phonetic_textBox_Leave);
            // 
            // FuriganaLabel
            // 
            this.FuriganaLabel.AutoSize = true;
            this.FuriganaLabel.Location = new System.Drawing.Point(108, 395);
            this.FuriganaLabel.Name = "FuriganaLabel";
            this.FuriganaLabel.Size = new System.Drawing.Size(78, 24);
            this.FuriganaLabel.TabIndex = 54;
            this.FuriganaLabel.Text = "フリガナ";
            // 
            // Deployment_comboBox
            // 
            this.Deployment_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Deployment_comboBox.FormattingEnabled = true;
            this.Deployment_comboBox.Items.AddRange(new object[] {
            "岩手",
            "宮城",
            "東京"});
            this.Deployment_comboBox.Location = new System.Drawing.Point(114, 875);
            this.Deployment_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deployment_comboBox.Name = "Deployment_comboBox";
            this.Deployment_comboBox.Size = new System.Drawing.Size(242, 32);
            this.Deployment_comboBox.TabIndex = 53;
            // 
            // DepLabel
            // 
            this.DepLabel.AutoSize = true;
            this.DepLabel.Location = new System.Drawing.Point(113, 848);
            this.DepLabel.Name = "DepLabel";
            this.DepLabel.Size = new System.Drawing.Size(106, 24);
            this.DepLabel.TabIndex = 52;
            this.DepLabel.Text = "所属部署";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-133, -39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 24);
            this.label11.TabIndex = 51;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(112, 771);
            this.Email_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(568, 31);
            this.Email_textBox.TabIndex = 50;
            this.Email_textBox.Leave += new System.EventHandler(this.Email_textBox_Leave);
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Location = new System.Drawing.Point(114, 686);
            this.Phone_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phone_textBox.MaxLength = 11;
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(320, 31);
            this.Phone_textBox.TabIndex = 49;
            this.Phone_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_textBox_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Emp_status_comboBox
            // 
            this.Emp_status_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Emp_status_comboBox.FormattingEnabled = true;
            this.Emp_status_comboBox.Items.AddRange(new object[] {
            "正社員",
            "パート",
            "アルバイト"});
            this.Emp_status_comboBox.Location = new System.Drawing.Point(114, 984);
            this.Emp_status_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Emp_status_comboBox.Name = "Emp_status_comboBox";
            this.Emp_status_comboBox.Size = new System.Drawing.Size(242, 32);
            this.Emp_status_comboBox.TabIndex = 57;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(112, 745);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(138, 24);
            this.EmailLabel.TabIndex = 48;
            this.EmailLabel.Text = "メールアドレス";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(114, 660);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(242, 24);
            this.PhoneLabel.TabIndex = 47;
            this.PhoneLabel.Text = "電話番号（ハイフン無し）";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(588, 601);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(34, 24);
            this.DayLabel.TabIndex = 46;
            this.DayLabel.Text = "日";
            // 
            // Year_textBox
            // 
            this.Year_textBox.Location = new System.Drawing.Point(112, 599);
            this.Year_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Year_textBox.MaxLength = 4;
            this.Year_textBox.Name = "Year_textBox";
            this.Year_textBox.Size = new System.Drawing.Size(131, 31);
            this.Year_textBox.TabIndex = 45;
            this.Year_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_textBox_KeyPress);
            this.Year_textBox.Leave += new System.EventHandler(this.Year_textBox_Leave);
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(413, 600);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(34, 24);
            this.MonthLabel.TabIndex = 44;
            this.MonthLabel.Text = "月";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(248, 601);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(34, 24);
            this.YearLabel.TabIndex = 43;
            this.YearLabel.Text = "年";
            // 
            // Day_comboBox
            // 
            this.Day_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Day_comboBox.FormattingEnabled = true;
            this.Day_comboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            this.Day_comboBox.Location = new System.Drawing.Point(473, 598);
            this.Day_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Day_comboBox.Name = "Day_comboBox";
            this.Day_comboBox.Size = new System.Drawing.Size(110, 32);
            this.Day_comboBox.TabIndex = 42;
            // 
            // Month_comboBox
            // 
            this.Month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Month_comboBox.FormattingEnabled = true;
            this.Month_comboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.Month_comboBox.Location = new System.Drawing.Point(301, 598);
            this.Month_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Month_comboBox.Name = "Month_comboBox";
            this.Month_comboBox.Size = new System.Drawing.Size(107, 32);
            this.Month_comboBox.TabIndex = 41;
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Location = new System.Drawing.Point(112, 572);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(106, 24);
            this.BirthLabel.TabIndex = 40;
            this.BirthLabel.Text = "生年月日";
            // 
            // Gender_comboBox
            // 
            this.Gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender_comboBox.FormattingEnabled = true;
            this.Gender_comboBox.Items.AddRange(new object[] {
            "男性",
            "女性",
            "その他"});
            this.Gender_comboBox.Location = new System.Drawing.Point(112, 512);
            this.Gender_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gender_comboBox.Name = "Gender_comboBox";
            this.Gender_comboBox.Size = new System.Drawing.Size(242, 32);
            this.Gender_comboBox.TabIndex = 39;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(112, 486);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(58, 24);
            this.GenderLabel.TabIndex = 38;
            this.GenderLabel.Text = "性別";
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Location = new System.Drawing.Point(107, 306);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(178, 24);
            this.FullnameLabel.TabIndex = 37;
            this.FullnameLabel.Text = "氏名（フルネーム）";
            // 
            // EmpIDLabel
            // 
            this.EmpIDLabel.AutoSize = true;
            this.EmpIDLabel.Location = new System.Drawing.Point(107, 198);
            this.EmpIDLabel.Name = "EmpIDLabel";
            this.EmpIDLabel.Size = new System.Drawing.Size(80, 24);
            this.EmpIDLabel.TabIndex = 36;
            this.EmpIDLabel.Text = "社員ID";
            // 
            // Fullname_textBox
            // 
            this.Fullname_textBox.Location = new System.Drawing.Point(107, 332);
            this.Fullname_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fullname_textBox.Name = "Fullname_textBox";
            this.Fullname_textBox.Size = new System.Drawing.Size(575, 31);
            this.Fullname_textBox.TabIndex = 35;
            this.Fullname_textBox.Leave += new System.EventHandler(this.Fullname_textBox_Leave);
            // 
            // ID_textBox
            // 
            this.ID_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ID_textBox.Location = new System.Drawing.Point(107, 224);
            this.ID_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_textBox.MaxLength = 5;
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.ShortcutsEnabled = false;
            this.ID_textBox.Size = new System.Drawing.Size(575, 31);
            this.ID_textBox.TabIndex = 34;
            this.ID_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_textBox_KeyPress);
            this.ID_textBox.Leave += new System.EventHandler(this.ID_textBox_Leave);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(323, 88);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(130, 24);
            this.TitleLabel.TabIndex = 33;
            this.TitleLabel.Text = "登録フォーム";
            // 
            // Confirm_button
            // 
            this.Confirm_button.Location = new System.Drawing.Point(677, 916);
            this.Confirm_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(240, 109);
            this.Confirm_button.TabIndex = 32;
            this.Confirm_button.Text = "登録";
            this.Confirm_button.UseVisualStyleBackColor = true;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 1330);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.Phonetic_textBox);
            this.Controls.Add(this.FuriganaLabel);
            this.Controls.Add(this.Deployment_comboBox);
            this.Controls.Add(this.DepLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.Emp_status_comboBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.Year_textBox);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.Day_comboBox);
            this.Controls.Add(this.Month_comboBox);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.Gender_comboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.EmpIDLabel);
            this.Controls.Add(this.Fullname_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Confirm_button);
            this.Name = "Title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新規登録画面";
            this.Load += new System.EventHandler(this.Title_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox Phonetic_textBox;
        private System.Windows.Forms.Label FuriganaLabel;
        private System.Windows.Forms.ComboBox Deployment_comboBox;
        private System.Windows.Forms.Label DepLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox Emp_status_comboBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.TextBox Year_textBox;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox Day_comboBox;
        private System.Windows.Forms.ComboBox Month_comboBox;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label EmpIDLabel;
        private System.Windows.Forms.TextBox Fullname_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Button Confirm_button;
        public System.Windows.Forms.Label TitleLabel;
    }
}