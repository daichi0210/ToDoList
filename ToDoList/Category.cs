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
        private string _columnName = "CategoryName";    // カラム名

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
        public void SQLiteInsert(string words)
        {
            // テーブルがない場合、作成
            SQLiteCreateTable();
            
            // テーブルのデータをすべて削除
            SQLiteDeleteTable();

            // クエリを作成
            string[] wordList = words.Replace("\r\n", "\n").Split(new[]{ '\n', '\r' });
            foreach (string w in wordList)
            {
                string query = "INSERT INTO " + _tableName + "(" + _columnName + ") VALUES(";
                query += "'" + w + "')";
                //MessageBox.Show(w);
                //MessageBox.Show(query);

                // クエリを実行
                SQLite sql = new SQLite();
                sql.ExecuteNonQuery(query);
            }

            /*
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

            // クエリを実行
            SQLite sql = new SQLite();
            sql.ExecuteNonQuery(query);
            */
        }

        /*
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
        */

        /*
        // テーブルのデータを削除
        public void SQLiteDelete(int targetId)
        {
            // クエリを作成
            string query = "DELETE FROM " + _tableName + " WHERE ID = " + targetId.ToString();

            // クエリを実行
            SQLite sql = new SQLite();
            sql.ExecuteNonQuery(query);
        }
        */

        // テーブルのデータを全て削除
        public void SQLiteDeleteTable()
        {
            // クエリを作成
            string query = "DELETE FROM " + _tableName;

            // クエリを実行
            SQLite sql = new SQLite();
            sql.ExecuteNonQuery(query);
        }

        // テーブルのデータを全て取得
        public string SQLiteLoadTable()
        {
            // テーブルがなければ作成する
            SQLiteCreateTable();

            // クエリを作成
            string query = "SELECT " + _columnName +" FROM " + _tableName;

            // クエリを実行
            SQLite sql = new SQLite();
            DataTable dt = sql.AdapterFill(query);

            string data = "";
            int count = 0;
            foreach (DataRow dr in dt.Rows)
            {
                data += dr[_columnName];
                if ((dt.Rows.Count - 1) - count != 0)
                {
                    data += ",";
                }
                count++;
            }

            return data;
        }

        /*
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
        */
    }
}
