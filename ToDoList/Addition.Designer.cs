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
            textBoxTaskName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxCategory = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBoxRemarks = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            label4 = new Label();
            dateTimePickerScheduledExecutionDate = new DateTimePicker();
            label9 = new Label();
            comboBoxPriority = new ComboBox();
            dateTimePickerScheduledExecutionTime = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "タスク名";
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(97, 41);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(170, 23);
            textBoxTaskName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
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
            label3.Text = "期限";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "公民館", "教育事業", "外出", "研修", "市民憲章", "自治連", "まちづくり", "駐連協", "安推協" });
            comboBoxCategory.Location = new Point(97, 12);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(90, 23);
            comboBoxCategory.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "備考";
            // 
            // button1
            // 
            button1.Location = new Point(97, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "登録";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(192, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Location = new Point(97, 186);
            textBoxRemarks.Name = "textBoxRemarks";
            textBoxRemarks.Size = new Size(170, 23);
            textBoxRemarks.TabIndex = 9;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(97, 70);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(121, 23);
            dateTimePickerDeadline.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 134);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "実行予定日";
            // 
            // dateTimePickerScheduledExecutionDate
            // 
            dateTimePickerScheduledExecutionDate.Location = new Point(97, 128);
            dateTimePickerScheduledExecutionDate.Name = "dateTimePickerScheduledExecutionDate";
            dateTimePickerScheduledExecutionDate.Size = new Size(121, 23);
            dateTimePickerScheduledExecutionDate.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 102);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 0;
            label9.Text = "優先度";
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "必達", "高", "中", "低" });
            comboBoxPriority.Location = new Point(97, 99);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(50, 23);
            comboBoxPriority.TabIndex = 4;
            // 
            // dateTimePickerScheduledExecutionTime
            // 
            dateTimePickerScheduledExecutionTime.Format = DateTimePickerFormat.Time;
            dateTimePickerScheduledExecutionTime.Location = new Point(97, 157);
            dateTimePickerScheduledExecutionTime.Name = "dateTimePickerScheduledExecutionTime";
            dateTimePickerScheduledExecutionTime.Size = new Size(90, 23);
            dateTimePickerScheduledExecutionTime.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 163);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 0;
            label6.Text = "実行予定時刻";
            // 
            // Addition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 251);
            Controls.Add(dateTimePickerScheduledExecutionTime);
            Controls.Add(dateTimePickerScheduledExecutionDate);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxPriority);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxRemarks);
            Controls.Add(textBoxTaskName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addition";
            Text = "Addition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTaskName;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxCategory;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox textBoxRemarks;
        private DateTimePicker dateTimePickerDeadline;
        private Label label4;
        private DateTimePicker dateTimePickerScheduledExecutionDate;
        private Label label9;
        private ComboBox comboBoxPriority;
        private DateTimePicker dateTimePickerScheduledExecutionTime;
        private Label label6;
    }
}