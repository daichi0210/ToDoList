namespace ToDoList
{
    partial class Settings
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
            textBoxCategory = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(12, 27);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(147, 23);
            textBoxCategory.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "カテゴリ";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(341, 363);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "保存";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(422, 363);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "キャンセル";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 398);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(textBoxCategory);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "設定";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCategory;
        private Label label1;
        private Button buttonSave;
        private Button buttonCancel;
    }
}