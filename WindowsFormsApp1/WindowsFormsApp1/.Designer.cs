using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    partial class List
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
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RegistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeList
            // 
            this.EmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Location = new System.Drawing.Point(21, 107);
            this.EmployeeList.MultiSelect = false;
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.RowHeadersWidth = 82;
            this.EmployeeList.RowTemplate.Height = 33;
            this.EmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeList.Size = new System.Drawing.Size(2121, 740);
            this.EmployeeList.TabIndex = 0;
            this.EmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.EmployeeList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.EmployeeList_CellFormatting);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.TitleLabel.Location = new System.Drawing.Point(12, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(362, 55);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "従業員一覧";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.DeleteButton.Location = new System.Drawing.Point(21, 870);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(302, 100);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.EditButton.Location = new System.Drawing.Point(372, 870);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(304, 100);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "編集";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RegistButton
            // 
            this.RegistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RegistButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.RegistButton.Location = new System.Drawing.Point(723, 870);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(304, 100);
            this.RegistButton.TabIndex = 4;
            this.RegistButton.Text = "登録";
            this.RegistButton.UseVisualStyleBackColor = true;
            this.RegistButton.Click += new System.EventHandler(this.Regist_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2154, 1107);
            this.Controls.Add(this.RegistButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EmployeeList);
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "従業員DB";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EmployeeList;
        private Label TitleLabel;
        private Button DeleteButton;
        private Button EditButton;
        private Button RegistButton;
    }
}