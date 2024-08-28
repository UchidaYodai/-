using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Title : Form
    {
        public SaveMode sm;
        private UserClass UC;

        public Title(UserClass user)
        {
            InitializeComponent();
            UC = user;
        }

        private void Title_Load(object sender, EventArgs e)
        {

            if (sm == SaveMode.Update)
            {
                //テキストの変更
                Text = "編集画面";
                TitleLabel.Text = "編集フォーム";
                Confirm_button.Text = "編集";
                ID_textBox.ReadOnly = true;

                //データ表示
                ID_textBox.Text = UC.ID.ToString();
                Fullname_textBox.Text = UC.UserName;
                Phonetic_textBox.Text = UC.Phonetic.ToString();
                Gender_comboBox.SelectedItem = UC.Gender;
                Year_textBox.Text = UC.Year.ToString();
                Month_comboBox.SelectedItem = UC.Month.ToString();
                Day_comboBox.SelectedItem = UC.Day.ToString();
                Phone_textBox.Text = UC.Phone.ToString();
                Email_textBox.Text = UC.Email.ToString();
                Deployment_comboBox.SelectedItem = UC.Dep.ToString();
                Emp_status_comboBox.SelectedItem = UC.Type;

            }
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            //入力内容を取得
            string ID_textValue = ID_textBox.Text;
            string Fullname_textValue = Fullname_textBox.Text;
            string Phonetic_textValue = Phonetic_textBox.Text;
            string Gender_textValue = Gender_comboBox.Text;
            string Year_textValue = Year_textBox.Text;
            string Month_textValue = Month_comboBox.Text;
            string Day_textValue = Day_comboBox.Text;
            string DateOfBirth = Year_textBox.Text + "年" + Month_comboBox.Text + "月" + Day_comboBox.Text + "日";
            string Phone_textValue = Phone_textBox.Text;
            string Email_textValue = Email_textBox.Text;
            string Deployment_textValue = Deployment_comboBox.Text;
            string Emp_status_textValue = Emp_status_comboBox.Text;

            string Gender_Value = CommonClass.ChangeGender(Gender_textValue);
            string Birth_Value = Year_textBox.Text + Month_comboBox.Text + Day_comboBox.Text;
            string Deployment_Value = CommonClass.ChangeDeployment(Deployment_textValue);

            CommonClass.hasError = false;
            CommonClass.ErrorMessage(ID_textValue, CommonClass.IDItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Fullname_textValue, CommonClass.FullNameItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Phonetic_textValue, CommonClass.PhoneticItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Gender_textValue, CommonClass.GenderItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Year_textValue, CommonClass.YearItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Month_textValue, CommonClass.MonthItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Day_textValue, CommonClass.DayItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Phone_textValue, CommonClass.PhoneItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Email_textValue, CommonClass.EmailItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Deployment_textValue, CommonClass.DepItem);
            if (CommonClass.hasError) return;

            CommonClass.ErrorMessage(Emp_status_textValue, CommonClass.StatusItem);
            if (CommonClass.hasError) return;

            CommonClass.ValidateEmailFormat(Email_textBox);
            if (CommonClass.hasError) return;

            CommonClass.ValidateFullname(Fullname_textBox);
            if(CommonClass.hasError) return;

            CommonClass.ValidatePhoneticInput(Phonetic_textBox);
            if (CommonClass.hasError) return;



            //入力内容確認メッセージ
            string message = CommonClass.CheckInputText(ID_textValue, Fullname_textValue, Phonetic_textValue, Gender_textValue, DateOfBirth, Phone_textValue, Email_textValue, Deployment_textValue, Emp_status_textValue);

            DialogResult result = MessageBox.Show(message, "入力内容確認画面", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string sql;

                if (sm == SaveMode.Update)
                {
                    sql = OracleCommonClass.UpdateSql(ID_textValue, Fullname_textValue, Phonetic_textValue, Gender_Value, Year_textValue, Month_textValue, Day_textValue, Phone_textValue, Email_textValue, Deployment_Value, Emp_status_textValue);
                    OracleCommonClass.ExecuteSql(sql, OracleCommonClass.DB_ConnectPass);
                    this.Close();
                }
                else if(sm == SaveMode.New)
                {
                    sql = OracleCommonClass.InsertSql(ID_textValue, Fullname_textValue, Phonetic_textValue, Gender_Value, Birth_Value, Phone_textValue, Email_textValue, Deployment_Value, Emp_status_textValue);
                    OracleCommonClass.ExecuteSql(sql, OracleCommonClass.DB_ConnectPass);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// IDの入力制限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonClass.AllowOnlyNumbers(e);

        }

        /// <summary>
        /// IDゼロ埋め
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ID_textBox_Leave(object sender, EventArgs e)
        {
            string input = ID_textBox.Text;

            // 入力が5文字未満の場合、0で埋める
            if (input.Length >= 1 && input.Length < 5)
            {
                ID_textBox.Text = input.PadLeft(5, '0');
            }
        }


        /// <summary>
        /// 年の入力制限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Year_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonClass.AllowOnlyNumbers(e);
        }

        /// <summary>
        /// 電話番号の入力制限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonClass.AllowOnlyNumbers(e);
        }

        /// <summary>
        /// メールアドレスの入力制限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Email_textBox_Leave(object sender, EventArgs e)
        {
            CommonClass.ValidateEmailFormat(Email_textBox);
        }

        /// <summary>
        /// フリガナの入力制限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Phonetic_textBox_Leave(object sender, EventArgs e)
        {
            CommonClass.ValidatePhoneticInput(Phonetic_textBox);
        }
        
        /// <summary>
        /// 名前の入力制限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fullname_textBox_Leave(object sender, EventArgs e)
        {
            CommonClass.ValidateFullname(Fullname_textBox);
        }

        /// <summary>
        /// 年4桁固定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Year_textBox_Leave(object sender, EventArgs e)
        {
            if(Year_textBox.Text.Length < 4)
            {
                Year_textBox.Text = "";
            }
        }
    }
}
