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
        public ToDoList()
        {
            InitializeComponent();

            LoadTaskList();
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
            //checkedListBoxUserSelection.Items.Clear();
            //dataGridViewTaskList.EndEdit();
            //★エラー
            dataGridViewTaskList.Rows.Clear();

            SQLiteTaskList stl = new SQLiteTaskList();
            dataGridViewTaskList.DataSource = stl.LoadTable();


            // IdとNameを辞書で管理
            /*
            var userInfo = new Dictionary<int, string>();
            userInfo = uld.getUserInfo();
            */

            /*
            foreach (string name in userInfo.Values)
            {
                checkedListBoxUserSelection.Items.Add(name);
            }
            */
        }
    }
}
