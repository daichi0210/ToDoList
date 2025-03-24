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
            SQLiteTaskList stl = new SQLiteTaskList();
            dataGridViewTaskList.DataSource = stl.LoadTable();
        }
    }
}
