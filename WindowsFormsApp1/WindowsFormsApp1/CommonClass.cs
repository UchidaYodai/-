using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CommonClass
    {

        public static String CheckInputText(String ID, String name, String phonetic, String gender, String birth, String phone, String Email, String dep, String status)
        {
            String message = "従業員ID　" + ID + "\n" +
                      "氏名　" + name + "\n" +
                      "フリガナ　" + phonetic + "\n" +
                      "性別　" + gender + "\n" +
                      "生年月日　" + birth + "\n" +
                      "電話番号　" + phone + "\n" +
                      "メールアドレス　" + Email + "\n" +
                      "所属部署　" + dep + "\n" +
                      "雇用形態　" + status;

            return message;
        }

        public static String ChangeGender(String Gender_Value)
        {
            if (Gender_Value == "男性")
            {
                Gender_Value = "M";     //male
            }
            else if (Gender_Value == "女性")
            {
                Gender_Value = "F";     //female
            }
            else if (Gender_Value == "その他")
            {
                Gender_Value = "O";     //other
            }
            else
            {
                Gender_Value = "";
            }

            return Gender_Value;
        }

        /// <summary>
        /// 部署をアルファベットに変更
        /// </summary>
        /// <param name="Deployment_Value"></param>
        /// <returns></returns>
        public static String ChangeDeployment(String Deployment_Value)
        {
            if (Deployment_Value == "岩手")
            {
                Deployment_Value = "I";
            }
            else if (Deployment_Value == "宮城")
            {
                Deployment_Value = "M";
            }
            else if (Deployment_Value == "東京")
            {
                Deployment_Value = "T";
            }
            else
            {
                Deployment_Value = "";
            }

            return Deployment_Value;
        }

        /// <summary>
        /// DBから受け取った性別データを日本語に変換
        /// </summary>
        /// <param name="Gender_Value"></param>
        /// <returns></returns>
        public static String BackGender(String Gender_Value)
        {
            if (Gender_Value == "M")
            {
                Gender_Value = "男性";
            }
            else if (Gender_Value == "F")
            {
                Gender_Value = "女性";
            }
            else
            {
                Gender_Value = "その他";
            }

            return Gender_Value;

        }

        /// <summary>
        /// DBから受け取った勤務地データを日本語に変換
        /// </summary>
        /// <param name="Dep_Value"></param>
        /// <returns></returns>
        public static String BackDep(String Dep_Value)
        {
            if (Dep_Value == "I")
            {
                Dep_Value = "岩手";
            }
            else if (Dep_Value == "M")
            {
                Dep_Value = "宮城";
            }
            else
            {
                Dep_Value = "東京";
            }

            return Dep_Value ;

        }


        /// <summary>
        /// 数字以外を入力できないようにする
        /// </summary>
        /// <param name="e"></param>
        public static void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return; // バックスペースを許可
            }

            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true; // 数字以外を無効化
            }
        }

        /// <summary>
        /// 電話番号用の入力制限
        /// </summary>
        /// <param name="e"></param>
        public static void AllowNumbersAndHyphen(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return; // バックスペースを許可
            }

            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // 数字とハイフン以外を無効化
            }
        }

        /// <summary>
        /// メールアドレスのフォーマットをチェック
        /// </summary>
        /// <param name="textBox"></param>
        public static void ValidateEmailFormat(TextBox textBox)
        {
            string emailPattern = @"^$|^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, emailPattern))
            {
                MessageBox.Show("メールアドレスが正しくありません。");
                textBox.Text = ""; // 無効なメールアドレスの場合はクリア
            }
        }

        /// <summary>
        /// フリガナ用の入力制限
        /// </summary>
        /// <param name="textBox"></param>
        public static void ValidatePhoneticInput(TextBox textBox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^\p{IsKatakana}*$") == false)
            {
                MessageBox.Show("カタカナ以外入力できません");
                textBox.Text = ""; // 全角カタカナ以外が入っていたらクリア
            }
        }

        public static void ValidateFullname(TextBox textBox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^[\p{IsCJKUnifiedIdeographs}\p{IsHiragana}\p{IsKatakana}]*$"))
            {
                MessageBox.Show("名前に使用できない文字が使われています。");
                // テキストボックスをクリア
                textBox.Text = "";
            }
        }

        /// <summary>
        /// YYYY年MM月DD日形式から年月日を分けて取得する
        /// </summary>
        /// <param name="date"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string ExtractDateParts(string date,int n)
        {
            // 正規表現で日付部分のみを抽出
            Regex regex = new Regex(@"^(\d{4})/(\d{2})/(\d{2})");
            Match match = regex.Match(date);

            // 年、月、日をそれぞれ抽出して返す
            string year = match.Groups[n].Value;

            return (year);
        }

        public static String IDItem = "ID";
        public static String FullNameItem = "氏名";
        public static String PhoneticItem = "フリガナ";
        public static String GenderItem = "性別";
        public static String YearItem = "生年";
        public static String MonthItem = "生月";
        public static String DayItem = "生日";
        public static String PhoneItem = "電話番号";
        public static String EmailItem = "メールアドレス";
        public static String DepItem = "所属部署";
        public static String StatusItem = "雇用形態";

        public static bool hasError = false;

        public static void ErrorMessage(String BoxItem, String Item)
        {
            if (hasError)
            {
                return; // 既にエラーが発生している場合は、以降のチェックをスキップ
            }

            if (string.IsNullOrWhiteSpace(BoxItem))
            {
                MessageBox.Show(Item + "を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasError = true; // エラーが発生したことを記録
            }
        }
    }
}
