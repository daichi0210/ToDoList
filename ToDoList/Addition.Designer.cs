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
            label6 = new Label();
            textBoxRemarks = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            dateTimePickerStartTime = new DateTimePicker();
            label4 = new Label();
            dateTimePickerScheduledExecutionDate = new DateTimePicker();
            label7 = new Label();
            textBoxLocation = new TextBox();
            label8 = new Label();
            comboBoxType = new ComboBox();
            label9 = new Label();
            comboBoxPriority = new ComboBox();
            label10 = new Label();
            dateTimePickerEventDate = new DateTimePicker();
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
            textBoxTaskName.Location = new Point(112, 41);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(170, 23);
            textBoxTaskName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "カテゴリ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "期限";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "公民館", "教育事業", "市民憲章", "自治連", "まちづくり", "駐連協", "安推協" });
            comboBoxCategory.Location = new Point(112, 70);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(90, 23);
            comboBoxCategory.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 276);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "備考";
            // 
            // button1
            // 
            button1.Location = new Point(112, 302);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "登録";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(207, 302);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 0;
            label6.Text = "開始時刻";
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Location = new Point(112, 273);
            textBoxRemarks.Name = "textBoxRemarks";
            textBoxRemarks.Size = new Size(170, 23);
            textBoxRemarks.TabIndex = 9;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(112, 99);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(121, 23);
            dateTimePickerDeadline.TabIndex = 3;
            // 
            // dateTimePickerStartTime
            // 
            dateTimePickerStartTime.Format = DateTimePickerFormat.Time;
            dateTimePickerStartTime.Location = new Point(112, 215);
            dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            dateTimePickerStartTime.Size = new Size(90, 23);
            dateTimePickerStartTime.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "実行予定日";
            // 
            // dateTimePickerScheduledExecutionDate
            // 
            dateTimePickerScheduledExecutionDate.Location = new Point(112, 157);
            dateTimePickerScheduledExecutionDate.Name = "dateTimePickerScheduledExecutionDate";
            dateTimePickerScheduledExecutionDate.Size = new Size(121, 23);
            dateTimePickerScheduledExecutionDate.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 0;
            label7.Text = "開催場所";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(112, 244);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(170, 23);
            textBoxLocation.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 15);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 0;
            label8.Text = "種別";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "タスク", "行事出席" });
            comboBoxType.Location = new Point(112, 12);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(90, 23);
            comboBoxType.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 131);
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
            comboBoxPriority.Location = new Point(112, 128);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(50, 23);
            comboBoxPriority.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 192);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 0;
            label10.Text = "開催日";
            // 
            // dateTimePickerEventDate
            // 
            dateTimePickerEventDate.Location = new Point(112, 186);
            dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            dateTimePickerEventDate.Size = new Size(121, 23);
            dateTimePickerEventDate.TabIndex = 6;
            // 
            // Addition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 336);
            Controls.Add(comboBoxType);
            Controls.Add(dateTimePickerEventDate);
            Controls.Add(dateTimePickerStartTime);
            Controls.Add(dateTimePickerScheduledExecutionDate);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxPriority);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxRemarks);
            Controls.Add(textBoxLocation);
            Controls.Add(textBoxTaskName);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
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
        private Label label6;
        private TextBox textBoxRemarks;
        private DateTimePicker dateTimePickerDeadline;
        private DateTimePicker dateTimePickerStartTime;
        private Label label4;
        private DateTimePicker dateTimePickerScheduledExecutionDate;
        private Label label7;
        private TextBox textBoxLocation;
        private Label label8;
        private ComboBox comboBoxType;
        private Label label9;
        private ComboBox comboBoxPriority;
        private Label label10;
        private DateTimePicker dateTimePickerEventDate;
    }
}