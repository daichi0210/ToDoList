using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Task
    {
        private string _tableName = "task_list";    // データベースのテーブル名

        private static Dictionary<string, string> _column = new Dictionary<string, string>()
        {
            {"Category", "TEXT"},               // カテゴリ
            {"TaskName", "TEXT"},               // タスク名
            {"Remarks", "TEXT"},                // 備考
            {"Deadline", "TEXT"},               // 期限
            {"Priority", "TEXT"},               // 優先度
            {"ScheduledExecutionDate", "TEXT"}, // 実行予定日
            {"ScheduledExecutionTime", "TEXT"}, // 実行予定時刻
        };

        private string _category;               // カテゴリ
        private string _taskName;               // タスク名
        private string _remarks;                // 備考
        private string _deadline;               // 期限
        private string _priority;               // 優先度
        private string _scheduledExecutionDate; // 実行予定日
        private string _scheduledExecutionTime; // 実行予定時刻

        public Task()
        {
            var t = typeof(Task);
            foreach (var f in t.GetFields())
            {
                var n = f.Name;
                var v = f.GetValue(t);
                MessageBox.Show(string.Format("フィールド名：{0}, 値：{1}", n, v));
            }
        }

        public Dictionary<string, string> Column
        {
            get { return _column; }
        }

        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
        public string ScheduledExecutionDate
        {
            get { return _scheduledExecutionDate; }
            set { _scheduledExecutionDate = value; }
        }
        public string ScheduledExecutionTime
        {
            get { return _scheduledExecutionTime; }
            set { _scheduledExecutionTime = value; }
        }
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        public string CreateTableQuery()
        {
            // クエリを作成
            //Task t = new Task();
            string query = "CREATE TABLE IF NOT EXISTS " + _tableName + "(";
            query += "Id INTEGER PRIMARY KEY, ";
            //foreach (var v in t.Column.Select((Entry, Index) => new {
            foreach (var v in this.Column.Select((Entry, Index) => new {Entry, Index}))
            {
                query += v.Entry.Key + " " + v.Entry.Value;

                //if ((t.Column.Count - 1) - v.Index != 0)
                if ((this.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += ")";

            return query;
        }
    }
}
