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
        // 編集対象
        private int _editTargetId = -1;

        public int EditTargetId
        {
            set
            {
                _editTargetId = value;
            }
        }

        public Addition()
        {
            InitializeComponent();
        }

        private void Addition_Load(object sender, EventArgs e)
        {
            // コンボボックスにカテゴリ名を追加
            Category c = new Category();
            string words = c.SQLiteLoadTable();
            string[] wordList = words.Split(",");
            foreach (string w in wordList)
            {
                comboBoxCategory.Items.Add(w);
            }

            // _editTargetId が -1 以外の場合、編集対象のデータを読み込む
            if (_editTargetId != -1)
            {
                // 使用者情報を取得
                Task t = new Task();
                DataTable dt = t.getSingleData(_editTargetId);

                // 使用者情報を代入
                textBoxTaskName.Text = dt.Rows[0]["TaskName"].ToString();       // タスク名
                comboBoxCategory.Text = dt.Rows[0]["Category"].ToString();      // カテゴリ
                dateTimePickerDeadline.Text = dt.Rows[0]["Deadline"].ToString();// 期限
                comboBoxPriority.Text = dt.Rows[0]["Priority"].ToString();      // 優先度
                dateTimePickerScheduledExecutionDate.Text = dt.Rows[0]["ScheduledExecutionDate"].ToString();    // 実行予定日
                dateTimePickerScheduledExecutionTime.Text = dt.Rows[0]["ScheduledExecutionTime"].ToString();    // 実行予定時刻
                textBoxRemarks.Text = dt.Rows[0]["Remarks"].ToString();         // 備考

                // 登録ボタンの Text を変更
                buttonRegistration.Text = "上書き保存";
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

            // _editTargetId が -1 以外の場合、編集対象のデータを更新する
            if (_editTargetId != -1)
            {
                // 上書き保存の確認メッセージ
                DialogResult result = MessageBox.Show("上書き保存しますか？", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // データを上書き保存
                    t.SQLiteUpdate(_editTargetId);
                }
                else
                {
                    return;
                }
            }
            else
            {
                // テーブルにデータを追加
                t.SQLiteInsert();
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
