using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // カテゴリ名を取得
            Category c = new Category();
            string words = c.SQLiteLoadTable();
            string wordList = words.Replace(",", "\r\n");
            textBoxCategory.Text = wordList;

            textBoxCategory.SelectionStart = 0;
            textBoxCategory.Multiline = true;
            textBoxCategory.Height = 300;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // カテゴリ名を追加
            Category c = new Category();
            c.SQLiteInsert(textBoxCategory.Text);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
