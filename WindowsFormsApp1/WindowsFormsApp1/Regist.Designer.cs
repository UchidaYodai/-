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
            this.label14 = new System.Windows.Forms.Label();
            this.Phonetic_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Deployment_comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Emp_status_comboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Year_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Day_comboBox = new System.Windows.Forms.ComboBox();
            this.Month_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gender_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fullname_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(118, 958);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 56;
            this.label14.Text = "雇用形態";
            // 
            // Phonetic_textBox
            // 
            this.Phonetic_textBox.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Phonetic_textBox.Location = new System.Drawing.Point(111, 422);
            this.Phonetic_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phonetic_textBox.Name = "Phonetic_textBox";
            this.Phonetic_textBox.Size = new System.Drawing.Size(200, 31);
            this.Phonetic_textBox.TabIndex = 55;
            this.Phonetic_textBox.Leave += new System.EventHandler(this.Phonetic_textBox_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(108, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 24);
            this.label13.TabIndex = 54;
            this.label13.Text = "フリガナ";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 848);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 52;
            this.label12.Text = "所属部署";
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
            this.Phone_textBox.MaxLength = 14;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 745);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 24);
            this.label10.TabIndex = 48;
            this.label10.Text = "メールアドレス";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "電話番号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "日";
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
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "年";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "生年月日";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "性別";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "氏名（フルネーム）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "社員ID";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "登録フォーム";
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
            this.ClientSize = new System.Drawing.Size(956, 1270);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Phonetic_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Deployment_comboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.Emp_status_comboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Year_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Day_comboBox);
            this.Controls.Add(this.Month_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fullname_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirm_button);
            this.Name = "Title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新規登録画面";
            this.Load += new System.EventHandler(this.Title_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Phonetic_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Deployment_comboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox Emp_status_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Year_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Day_comboBox;
        private System.Windows.Forms.ComboBox Month_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Gender_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fullname_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Button Confirm_button;
        public System.Windows.Forms.Label label1;
    }
}