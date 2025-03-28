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
            string[] category = ["教育事業", "公民館"];

            textBoxCategory.Multiline = true;
            textBoxCategory.Height = 300;

            string Categories = "";
            int count = 0;
            foreach (string c in category)
            {
                if (count < category.Length - 1)
                {
                    Categories += c + "\r\n";
                }
                else
                {
                    Categories += c;
                }
                count++;
            }

            textBoxCategory.Text = Categories;
            MessageBox.Show(Categories);
            textBoxCategory.SelectionStart = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SQLiteCategory sc = new SQLiteCategory();
/*            foreach (string c in _category)
            {
                sc.ExecuteNonQuery("DELETE FROM category_table");
            }
*/
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
