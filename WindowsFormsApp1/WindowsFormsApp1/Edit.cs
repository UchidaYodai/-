using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Edit : Form
    {
        //private List<string> employeeData;
        UserClass UC = new UserClass();

        /// <summary>
        /// UserClassを引数
        /// </summary>
        /// <param name="user"></param>
        public Edit(UserClass user)
        {
            InitializeComponent();
            //employeeData = data;
            UC = user;
            LoadEmployeeData();
        }

        /// <summary>
        /// 編集画面にデータを表示
        /// </summary>
        private void LoadEmployeeData()
        {

            ID_textBox.Text = UC.ID.ToString();
            Fullname_textBox.Text = UC.UserName;
            Phonetic_textBox.Text = UC.Phonetic.ToString();
            Gender_comboBox.SelectedItem = UC.Gender;
            Year_textBox.Text = UC.Year.ToString();
            Month_textBox.Text = UC.Month.ToString();
            Day_textBox.Text = UC.Day.ToString();
            Phone_textBox.Text = UC.Phone.ToString();
            Email_textBox.Text = UC.Email.ToString();
            Deployment_comboBox.SelectedItem = UC.Dep.ToString();
            Emp_status_comboBox.SelectedItem = UC.Type;
        }
    }
}
        //}

        //private void EditButton_Click(object sender, EventArgs e)
        //{
        //    // テキストボックスやコンボボックスから値を取得
        //    UC.ID = ID_textBox.Text;
        //    UC.UserName = Fullname_textBox.Text;
        //    UC.Phonetic = Phonetic_textBox.Text;
        //    UC.Gender = CommonClass.ChangeGender(Gender_comboBox.SelectedItem.ToString());
        //    UC.Year = Year_textBox.Text;
        //    UC.Month = Month_textBox.Text;
        //    UC.Day = Day_textBox.Text;
        //    UC.Phone = Phone_textBox.Text;
        //    UC.Email = Email_textBox.Text;
        //    UC.Dep = CommonClass.ChangeDeployment(Deployment_comboBox.SelectedItem.ToString());
        //    UC.Type = Emp_status_comboBox.SelectedItem.ToString();

//            string sql = "UPDATE EMPLOYEES SET ";
//                   sql += "EMP_ID = '" + UC.ID + "', ";
//                   sql += "EMP_NAME = '" + UC.UserName + "', ";
//                   sql += "EMP_PHONETIC = '" + UC.Phonetic + "', ";
//                   sql += "EMP_GENDER = '" + UC.Gender + "', ";
//                   sql += "EMP_BIRTH = TO_DATE('" + UC.Year + UC.Month + UC.Day + "', " + "'YYYY/MM/DD'),";
//                   sql += "EMP_PHONE = '" + UC.Phone + "', ";
//                   sql += "EMP_EMAIL = '" + UC.Email + "', ";
//                   sql += "EMP_TYPE = '" + UC.Type + "', ";
//                   sql += "EMP_DEP = '" + UC.Dep + "' ";
//                   sql += "WHERE EMP_ID = '" + UC.ID + "'";

//            // データベースを更新
//            OracleCommonClass.ExecuteSql(sql, OracleCommonClass.DB_ConnectPass);
//;            this.Close();
        //}
        ////社員IDの入力制限
        //private void ID_textBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    CommonClass.AllowOnlyNumbers(e);
        //}

        ////電話番号の入力制限
        //private void Phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    CommonClass.AllowNumbersAndHyphen(e);
        //}

        ////メールアドレスのフォーマットチェック
        //private void Email_textBox_Leave(object sender, EventArgs e)
        //{
        //    CommonClass.ValidateEmailFormat(Email_textBox);
        //}

        ////フリガナの入力制限
        //private void Phonetic_textBox_Leave(object sender, EventArgs e)
        //{
        //    CommonClass.ValidatePhoneticInput(Phonetic_textBox);
        //}

        //private void Fullname_textBox_Leave(object sender, EventArgs e)
        //{
        //    CommonClass.ValidateFullname(Fullname_textBox);
        //}
//    }
//}
