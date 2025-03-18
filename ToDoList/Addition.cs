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
    public partial class Addition: Form
    {
        public Addition()
        {
            InitializeComponent();

            comboBoxCategory.Items.Add("教育事業");
            comboBoxCategory.Items.Add("公民館");
            comboBoxCategory.Items.Add("自治連");
            comboBoxCategory.Items.Add("安推協");
            comboBoxCategory.Items.Add("駐連協");
            comboBoxCategory.Items.Add("その他");




        }
    }
}
