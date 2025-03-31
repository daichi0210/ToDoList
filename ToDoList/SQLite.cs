using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace ToDoList
{
    class SQLite
    {
        // データベースのファイル名
        private string _databaseFileName = "TaskList.db";
        // データベースファイルへの接続文字列
        private string _connection;

        public SQLite()
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
    }
}
