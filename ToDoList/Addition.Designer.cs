namespace ToDoList
{
    partial class Addition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxCategory = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            dateTimePickerStartTime = new DateTimePicker();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "タスク名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "カテゴリ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "日付";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(86, 41);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 156);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "備考";
            // 
            // button1
            // 
            button1.Location = new Point(248, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "登録";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(248, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 105);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "時刻";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 1;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(86, 70);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(121, 23);
            dateTimePickerDeadline.TabIndex = 5;
            // 
            // dateTimePickerStartTime
            // 
            dateTimePickerStartTime.Location = new Point(86, 99);
            dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            dateTimePickerStartTime.Size = new Size(121, 23);
            dateTimePickerStartTime.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(86, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "必達";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Addition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 232);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePickerStartTime);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addition";
            Text = "Addition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxCategory;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox2;
        private DateTimePicker dateTimePickerDeadline;
        private DateTimePicker dateTimePickerStartTime;
        private CheckBox checkBox1;
    }
}