using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Category
    {
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
    }
}
