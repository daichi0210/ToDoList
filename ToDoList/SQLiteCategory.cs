using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class SQLiteCategory
    {
        // データベースのファイル名
        private string _databaseFileName = "Category.db";
        // テーブル名
        private string _tableName = "category_list";
        // データベースファイルへの接続文字列
        private string _connection;

        public SQLiteCategory()
        {
            // データベースファイルへの接続文字列を代入
            _connection = "Data Source=" + _databaseFileName + ";Version=3;";
        }

        // 結果を返さないクエリを実行する
        public void ExecuteNonQuery(string query)
        {
            // SQLiteの接続を開く
            using (var connection = new SQLiteConnection(_connection))
            {
                // データベース接続を開く
                connection.Open();

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    // SQL文を実行
                    cmd.ExecuteNonQuery();
                }

                // データベース接続を閉じる
                connection.Close();
            }
        }

        // テーブルがなければ作成する
        public void CreateTable()
        {
            // クエリを作成
            Category c = new Category();
            string query = "CREATE TABLE IF NOT EXISTS " + _tableName + "(";
            query += "Id INTEGER PRIMARY KEY, ";
            foreach (var v in c.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                query += v.Entry.Key + " " + v.Entry.Value;

                if ((c.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += ")";

            // SQL実行
            ExecuteNonQuery(query);
        }

        // データベースに追加する
        public void Insert(Category c)
        {
            // クエリを作成
            string query = "INSERT INTO " + _tableName + "(";
            foreach (var v in c.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                query += v.Entry.Key;

                if ((c.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += ") VALUES (";
            foreach (var v in c.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                PropertyInfo pi = typeof(Category).GetProperty(v.Entry.Key);
                object value = pi.GetValue(c);
                query += "'" + value + "'";

                if ((c.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += ")";

            // SQL実行
            ExecuteNonQuery(query);
        }

        // データベースを更新する
        public void Update(int targetId, Category c)
        {
            // クエリを作成
            string query = "UPDATE " + _tableName + " SET ";
            foreach (var v in c.Column.Select((Entry, Index) => new { Entry, Index }))
            {
                query += v.Entry.Key + " = ";

                PropertyInfo pi = typeof(Category).GetProperty(v.Entry.Key);
                object value = pi.GetValue(c);
                query += "'" + value + "'";

                if ((c.Column.Count - 1) - v.Index != 0)
                {
                    query += ", ";
                }
            }
            query += " WHERE ID = " + targetId.ToString();

            // SQL実行
            ExecuteNonQuery(query);
        }

        // データベースから削除する
        public void Delete(int targetId)
        {
            // クエリを作成
            string query = "DELETE FROM " + _tableName + " WHERE ID = " + targetId.ToString();

            // SQL実行
            ExecuteNonQuery(query);
        }

        // DataTableにデータを挿入するクエリを実行する
        public DataTable AdapterFill(string query)
        {
            DataTable dt = new DataTable();

            // SQLiteの接続を開く
            using (var connection = new SQLiteConnection(_connection))
            {
                // データベース接続を開く
                connection.Open();

                // DataTableにデータを挿入
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                // 接続を閉じる
                connection.Close();
            }

            return dt;
        }

        // データベースのテーブルを読み込む
        public DataTable LoadTable()
        {
            // テーブルがなければ作成する
            CreateTable();

            // クエリを作成
            string query = "SELECT * FROM " + _tableName;

            // SQL実行
            DataTable dt = AdapterFill(query);

            return dt;
        }
    }
}
