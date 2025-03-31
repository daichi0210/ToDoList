using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Category
    {
        private string _tableName = "category_list";    // データベースのテーブル名

        private static Dictionary<string, string> _column = new Dictionary<string, string>()
        {
            {"CategoryName", "TEXT"},               // カテゴリ名
        };

        private string _categoryName;               // カテゴリ

        public Category()
        {
            var t = typeof(Category);
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

        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }

        // テーブルがない場合、作成
        public void SQLiteCreateTable()
        {
            // クエリを作成
            string query = "CREATE TABLE IF NOT EXISTS " + _tableName + "(";
            query += "Id INTEGER PRIMARY KEY, ";
            foreach (var v in this.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                query += v.Entry.Key + " " + v.Entry.Value;
                if ((this.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += ")";

            // クエリを実行
            SQLite sql = new SQLite();
            sql.ExecuteNonQuery(query);
        }

        // テーブルにデータを追加
        public void SQLiteInsert()
        {
            // クエリを作成
            string query = "INSERT INTO " + _tableName + "(";
            foreach (var v in this.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                query += v.Entry.Key;
                if ((this.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += ") VALUES (";
            foreach (var v in this.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                PropertyInfo pi = typeof(Task).GetProperty(v.Entry.Key);
                object value = pi.GetValue(this);
                query += "'" + value + "'";
                if ((this.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += ")";

            // テーブルがない場合、作成
            SQLiteCreateTable();

            // クエリを実行
            SQLite sql = new SQLite();
            sql.ExecuteNonQuery(query);
        }

        // テーブルのデータを更新
        public void SQLiteUpdate(int targetId)
        {
            // クエリを作成
            string query = "UPDATE " + _tableName + " SET ";
            foreach (var v in this.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                query += v.Entry.Key + " = ";
                PropertyInfo pi = typeof(Task).GetProperty(v.Entry.Key);
                object value = pi.GetValue(this);
                query += "'" + value + "'";
                if ((this.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += " WHERE ID = " + targetId.ToString();

            // クエリを実行
            SQLite sql = new SQLite();
            sql.ExecuteNonQuery(query);
        }

        // テーブルのデータを削除
        public void SQLiteDelete(int targetId)
        {
            // クエリを作成
            string query = "DELETE FROM " + _tableName + " WHERE ID = " + targetId.ToString();

            // クエリを実行
            SQLite sql = new SQLite();
            sql.ExecuteNonQuery(query);
        }

        // テーブルのデータを全て取得
        public DataTable SQLiteLoadTable()
        {
            // テーブルがなければ作成する
            this.SQLiteCreateTable();

            // クエリを作成
            string query = "SELECT * FROM " + _tableName;

            // テーブルがない場合、作成
            SQLiteCreateTable();

            // クエリを実行
            SQLite sql = new SQLite();
            DataTable dt = sql.AdapterFill(query);

            return dt;
        }
    }
}
