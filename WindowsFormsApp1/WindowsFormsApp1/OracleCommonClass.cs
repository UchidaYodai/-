using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    internal class OracleCommonClass
    {

        public static String DB_ConnectPass = "User ID=MSS; Password=MSS; Data Source=XE";

        /// <summary>
        /// sql実行
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="DB_connect"></param>
        public static void ExecuteSql(String sql, String DB_ConnectPass)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection())
                {
                    conn.ConnectionString = DB_ConnectPass;
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(sql))
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("完了しました。", "実行完了");
                    }
                }
            }
            catch (OracleException ex)
            {
                StringBuilder errorMessage = new StringBuilder();
                if (ex.Number == 1)
                {
                    MessageBox.Show("このIDは既に使われています。", "登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (ex.InnerException != null)
                {
                    errorMessage.AppendLine("内部例外メッセージ: " + ex.InnerException.Message);
                    errorMessage.AppendLine("内部例外スタックトレース: " + ex.InnerException.StackTrace);
                }
            }
        }

        /// <summary>
        /// 各要素からInsert文を作成
        /// </summary>
        /// <param name="ID">ユーザーID</param>
        /// <param name="name"></param>
        /// <param name="phonetic"></param>
        /// <param name="gender"></param>
        /// <param name="birth"></param>
        /// <param name="phone"></param>
        /// <param name="Email"></param>
        /// <param name="dep"></param>
        /// <param name="status"></param>
        /// <remarks>この関数はデータを登録する関数です</remarks>
        /// <returns>InsertするSQLを返却します</returns>
        public static String InsertSql(String ID, String name, String phonetic, String gender, String birth, String phone, String Email, String dep, String type)
        {
            String sql;
            sql = "INSERT INTO EMPLOYEES (EMP_ID, EMP_NAME, EMP_PHONETIC, EMP_GENDER, EMP_BIRTH, EMP_PHONE, EMP_EMAIL, EMP_DEP, EMP_TYPE) VALUES (";
            sql += "'" + ID + "', ";  //従業員ID
            sql += "'" + name + "', ";  //名前（漢字） 
            sql += "'" + phonetic + "', ";  // フリガナ
            sql += "'" + gender + "', ";  // 性別
            sql += "'" + birth + "', ";  // 生年月日
            sql += "'" + phone + "', ";  // 電話番号
            sql += "'" + Email + "', ";  // メールアドレス
            sql += "'" + dep + "', ";  // 勤務地
            sql += "'" + type + "' "; //雇用形態
            sql += ")";

            return sql;
        }

        public static String UpdateSql(String ID, String name, String phonetic, String gender, String year, String month, String day, String phone, String Email, String dep, String type)
        {
            string sql = "UPDATE EMPLOYEES SET ";
            sql += "EMP_ID = '" + ID + "', ";
            sql += "EMP_NAME = '" + name + "', ";
            sql += "EMP_PHONETIC = '" + phonetic + "', ";
            sql += "EMP_GENDER = '" + gender + "', ";
            sql += "EMP_BIRTH = TO_DATE('" + year + month + day + "', " + "'YYYYMMDD'),";
            sql += "EMP_PHONE = '" + phone + "', ";
            sql += "EMP_EMAIL = '" + Email + "', ";
            sql += "EMP_TYPE = '" + type + "', ";
            sql += "EMP_DEP = '" + dep + "' ";
            sql += "WHERE EMP_ID = '" + ID + "'" ;

            return sql;
        }


        /// <summary>
        /// DataGridView表示
        /// </summary>
        /// <param name="DB_ConnectPass"></param>
        /// <param name="tableName"></param>
        /// <param name="dataGridView"></param>
        public static void DisplayTableData(string DB_ConnectPass, string tableName, DataGridView dataGridView)
        {
            string connectionString = DB_ConnectPass;
            string sql = $"SELECT * FROM {tableName}";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(sql, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = null;
                        dataGridView.DataSource = dataTable;
                        dataGridView.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("従業員一覧を表示できませんでした。: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Delete文作成から実行までの処理
        /// </summary>
        /// <param name="empID"></param>
        /// <param name="empName"></param>
        public static void DeleteEmployee(string empID, string empName)
        {
            if (!string.IsNullOrEmpty(empID))
            {
                String message = "ID" + empID + "(" + empName + ")" + "の行を削除してもよろしいですか";

                DialogResult result = MessageBox.Show(message, "削除確認画面", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string sql = "DELETE FROM EMPLOYEES WHERE EMP_ID = " + empID;

                    ExecuteSql(sql, OracleCommonClass.DB_ConnectPass);
                }
            }
            else
            {
                MessageBox.Show("削除したい行をクリックしてください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}