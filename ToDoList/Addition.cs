using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();

            // コンボボックスにカテゴリ名を追加
            Category c = new Category();
            string words = c.SQLiteLoadTable();
            string[] wordList = words.Split(",");
            foreach (string w in wordList)
            {
                comboBoxCategory.Items.Add(w);
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            // 未入力・未選択チェック
            CheckMissingEntries cme = new CheckMissingEntries();
            if (cme.NoInput(textBoxTaskName.Text, "タスク名"))
            {
                return;
            }
            if (cme.NoChoice(comboBoxCategory.Text, "カテゴリ"))
            {
                return;
            }
            if (cme.NoChoice(comboBoxPriority.Text, "優先度"))
            {
                return;
            }

            // 値を代入
            Task t = new Task();
            t.TaskName = textBoxTaskName.Text;          // タスク名
            t.Category = comboBoxCategory.Text;         // カテゴリ
            t.Deadline = dateTimePickerDeadline.Text;   // 期限
            t.Priority = comboBoxPriority.Text;         // 優先度
            t.ScheduledExecutionDate = dateTimePickerScheduledExecutionDate.Text;   // 実行予定日
            t.ScheduledExecutionTime = dateTimePickerScheduledExecutionTime.Text;   // 実行予定時刻
            t.Remarks = textBoxRemarks.Text;            // 備考

            // テーブルにデータを追加
            t.SQLiteInsert();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
