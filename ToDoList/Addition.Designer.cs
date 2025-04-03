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
            buttonRegistration = new Button();
            buttonCancel = new Button();
            textBoxRemarks = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            label9 = new Label();
            comboBoxPriority = new ComboBox();
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
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(97, 12);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(170, 23);
            textBoxTaskName.TabIndex = 1;
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
            label3.Text = "期限";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(97, 41);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(90, 23);
            comboBoxCategory.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "備考";
            // 
            // buttonRegistration
            // 
            buttonRegistration.Location = new Point(97, 157);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(75, 23);
            buttonRegistration.TabIndex = 10;
            buttonRegistration.Text = "登録";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(192, 157);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Location = new Point(97, 128);
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
            // Addition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 191);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRegistration);
            Controls.Add(comboBoxPriority);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxRemarks);
            Controls.Add(textBoxTaskName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addition";
            StartPosition = FormStartPosition.CenterParent;
            Text = "登録";
            Load += Addition_Load;
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
        private Button buttonRegistration;
        private Button buttonCancel;
        private TextBox textBoxRemarks;
        private DateTimePicker dateTimePickerDeadline;
        private Label label9;
        private ComboBox comboBoxPriority;
    }
}