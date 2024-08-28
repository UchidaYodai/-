using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class List : Form
    {
        private String empID;
        private String empName;
        private int selectedRowIndex = -1;

        public List()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロードしたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            OracleCommonClass.DisplayTableData(OracleCommonClass.DB_ConnectPass, "EMPLOYEES", EmployeeList);
            EmployeeList.Columns["EMP_ID"].HeaderText = "従業員ID";
            EmployeeList.Columns["EMP_NAME"].HeaderText = "氏名";
            EmployeeList.Columns["EMP_GENDER"].HeaderText = "性別";
            EmployeeList.Columns["EMP_BIRTH"].HeaderText = "生年月日";
            EmployeeList.Columns["EMP_PHONE"].HeaderText = "電話番号";
            EmployeeList.Columns["EMP_EMAIL"].HeaderText = "メールアドレス";
            EmployeeList.Columns["EMP_DEP"].HeaderText = "所属部署";
            EmployeeList.Columns["EMP_TYPE"].HeaderText = "雇用形態";
            EmployeeList.Columns["EMP_PHONETIC"].HeaderText = "フリガナ";
        }

        /// <summary>
        /// データグリッドビューのクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ヘッダー行がクリックされた場合は何もしない。eはクリックしたセルの情報
            if (e.RowIndex < 0)
            {
                return;
            }

            // クリックされた行のデータを取得する
            DataGridViewRow clickedRow = EmployeeList.Rows[e.RowIndex];

            // 必要なデータを取り出す（例として列名を使用）
            empID = clickedRow.Cells["EMP_ID"].Value.ToString(); // EmployeeID列の値
            empName = clickedRow.Cells["EMP_NAME"].Value.ToString() ;

            // 選択された行のインデックスを保存する
            selectedRowIndex = e.RowIndex;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(empID))
            {
                
                DataGridViewRow selectedRow = EmployeeList.Rows[selectedRowIndex];

                // UCの変数に格納

                UserClass UC = new UserClass();
                //IDに入力されているときのみ実行↓
                if (selectedRow.Cells["EMP_ID"] != null)
                {
                    UC.ID = selectedRow.Cells["EMP_ID"].Value.ToString();
                    UC.UserName = selectedRow.Cells["EMP_NAME"].Value.ToString();
                    UC.Phonetic = selectedRow.Cells["EMP_PHONETIC"].Value.ToString();
                    UC.Gender = CommonClass.BackGender(selectedRow.Cells["EMP_GENDER"].Value.ToString());
                    UC.Year = CommonClass.ExtractDateParts(selectedRow.Cells["EMP_BIRTH"].Value.ToString(), 1);
                    UC.Month = CommonClass.ExtractDateParts(selectedRow.Cells["EMP_BIRTH"].Value.ToString(), 2);
                    UC.Day = CommonClass.ExtractDateParts(selectedRow.Cells["EMP_BIRTH"].Value.ToString(), 3);
                    UC.Phone = selectedRow.Cells["EMP_PHONE"].Value.ToString();
                    UC.Email = selectedRow.Cells["EMP_EMAIL"].Value.ToString();
                    UC.Dep = CommonClass.BackDep(selectedRow.Cells["EMP_DEP"].Value.ToString());
                    UC.Type = selectedRow.Cells["EMP_TYPE"].Value.ToString();


                    //更新画面にUpdateをもって移動
                    Title frm = new Title(UC);
                    frm.sm = SaveMode.Update;
                    frm.ShowDialog();
                    OracleCommonClass.DisplayTableData(OracleCommonClass.DB_ConnectPass, "EMPLOYEES", EmployeeList);
                }
                else
                {
                    MessageBox.Show("データがありません", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("変更したい行をクリックしてください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// DB削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OracleCommonClass.DeleteEmployee(empID, empName);
            OracleCommonClass.DisplayTableData(OracleCommonClass.DB_ConnectPass, "EMPLOYEES", EmployeeList);
        }

        /// <summary>
        /// 登録フォームに移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Regist_Click(object sender, EventArgs e)
        {
            Title frm = new Title(null);
            frm.sm = SaveMode.New;
            frm.ShowDialog();
            OracleCommonClass.DisplayTableData(OracleCommonClass.DB_ConnectPass, "EMPLOYEES", EmployeeList);
        }

        private void EmployeeList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (EmployeeList.Columns[e.ColumnIndex].Name == "EMP_GENDER")
            {
                if (e.Value != null)
                {
                    // 値を確認して、表示するテキストを設定します
                    switch (e.Value.ToString())
                    {
                        case "M":
                            e.Value = "男性";
                            break;
                        case "F":
                            e.Value = "女性";
                            break;
                        case "O":
                            e.Value = "その他";
                            break;
                    }
                }
            }

            if (EmployeeList.Columns[e.ColumnIndex].Name == "EMP_DEP")
            {
                if (e.Value != null)
                {
                    // 値を確認して、表示するテキストを設定します
                    switch (e.Value.ToString())
                    {
                        case "I":
                            e.Value = "岩手";
                            break;
                        case "M":
                            e.Value = "宮城";
                            break;
                        case "T":
                            e.Value = "東京";
                            break;
                    }
                }
            }
        }
    }
}

