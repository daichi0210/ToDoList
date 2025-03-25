using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class CheckMissingEntries
    {
        // 未入力チェック
        public bool NoInput(string value, string category)
        {
            if (value == String.Empty)
            {
                MessageBox.Show(category + "を入力してください。");
                return true;
            }

            return false;

        }

        // 未選択チェック

        public bool NoChoice(string value, string category)
        {
            if (value == String.Empty)
            {
                MessageBox.Show(category + "を選択してください。");
                return true;
            }

            return false;
        }
    }
}
