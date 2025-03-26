using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        bool dataGridViewStatus = false;

        public ToDoList()
        {
            InitializeComponent();

            LoadTaskList();

            dataGridViewStatus = true;
        }

        private void dataGridViewTaskList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStatus)
            {
                // 選択されている行のIDの値を取得
                int targetIndex = dataGridViewTaskList.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridViewTaskList.Rows[targetIndex];
                var idValue = selectedRow.Cells["Id"].Value;
                int targetId = Int32.Parse(idValue.ToString());

                // 編集した行の値を代入
                Task t = new Task();
                t.TaskName = selectedRow.Cells["TaskName"].Value.ToString();    // タスク名
                t.Category = selectedRow.Cells["Category"].Value.ToString();    // カテゴリ
                t.Deadline = selectedRow.Cells["Deadline"].Value.ToString();    // 期限
                t.Priority = selectedRow.Cells["Priority"].Value.ToString();    // 優先度
                t.ScheduledExecutionDate = selectedRow.Cells["ScheduledExecutionDate"].Value.ToString();    // 実行予定日
                t.ScheduledExecutionTime = selectedRow.Cells["ScheduledExecutionTime"].Value.ToString();    // 実行予定時刻
                t.Remarks = selectedRow.Cells["Remarks"].Value.ToString();      // 備考

                // データベースを更新
                SQLiteTaskList stl = new SQLiteTaskList();
                stl.Update(targetId, t);
            }
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            Addition a = new Addition();
            a.ShowDialog();

            LoadTaskList();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
        }

        public void LoadTaskList()
        {
            SQLiteTaskList stl = new SQLiteTaskList();
            dataGridViewTaskList.DataSource = stl.LoadTable();

            // 列ヘッダーの文字列を変更する
            int columnCount = 0;
            string cellValue = "";
            while (columnCount < dataGridViewTaskList.ColumnCount)
            {
                switch (dataGridViewTaskList.Columns[columnCount].HeaderCell.Value)
                {
                    case "Id":
                        break;
                    case "TaskName":
                        cellValue = "タスク名";
                        break;
                    case "Category":
                        cellValue = "カテゴリ";
                        break;
                    case "Deadline":
                        cellValue = "期限";
                        break;
                    case "Priority":
                        cellValue = "優先度";
                        break;
                    case "ScheduledExecutionDate":
                        cellValue = "実行予定日";
                        break;
                    case "ScheduledExecutionTime":
                        cellValue = "実行予定時刻";
                        break;
                    case "Remarks":
                        cellValue = "備考";
                        break;
                    default:
                        cellValue = "";
                        break;
                }

                if (cellValue != "")
                {
                    dataGridViewTaskList.Columns[columnCount].HeaderCell.Value = cellValue;
                }

                columnCount++;
            }

            // Idの列を非表示
            dataGridViewTaskList.Columns["Id"].Visible = false;

            // 列の幅を自動調停
            dataGridViewTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 『タスク』列の最小幅を指定
            dataGridViewTaskList.Columns["TaskName"].MinimumWidth = 200;

            // 『備考』列を自動調整
            dataGridViewTaskList.Columns["Remarks"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 行を並び替える
            DataGridViewColumn sortColumn = dataGridViewTaskList.Columns[5];
            ListSortDirection sortDirection = ListSortDirection.Ascending;
            dataGridViewTaskList.Sort(sortColumn, sortDirection);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int targetIndex = -1;

            // 選択されている行を取得
            targetIndex = dataGridViewTaskList.CurrentCell.RowIndex;

            //★初期状態で一行目が選択されているので不要？
            if (targetIndex == -1)
            {
                // 削除の確認メッセージ
                MessageBox.Show("削除するデータを選択してください。");
            }
            //★すべてのデータを削除することができない…。
            else
            {
                // 選択されている行のIDの値を取得
                DataGridViewRow selectedRow = dataGridViewTaskList.Rows[targetIndex];
                var idValue = selectedRow.Cells["Id"].Value;
                int targetId = Int32.Parse(idValue.ToString());

                // 削除の確認メッセージ
                DialogResult result = MessageBox.Show("選択されたデータを削除しますか？", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // データを削除
                    SQLiteTaskList stl = new SQLiteTaskList();
                    stl.Delete(targetId);
                }

                // 使用者一覧情報を読み込む
                LoadTaskList();
            }
        }
    }
}
