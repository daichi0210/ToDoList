namespace ToDoList
{
    partial class ToDoList
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
            buttonAddition = new Button();
            dataGridViewTaskList = new DataGridView();
            buttonSettings = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskList).BeginInit();
            SuspendLayout();
            // 
            // buttonAddition
            // 
            buttonAddition.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddition.Location = new Point(12, 415);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(75, 23);
            buttonAddition.TabIndex = 0;
            buttonAddition.Text = "追加";
            buttonAddition.UseVisualStyleBackColor = true;
            buttonAddition.Click += buttonAddition_Click;
            // 
            // dataGridViewTaskList
            // 
            dataGridViewTaskList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTaskList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTaskList.Location = new Point(12, 12);
            dataGridViewTaskList.Name = "dataGridViewTaskList";
            dataGridViewTaskList.Size = new Size(776, 397);
            dataGridViewTaskList.TabIndex = 1;
            dataGridViewTaskList.CellValueChanged += dataGridViewTaskList_CellValueChanged;
            // 
            // buttonSettings
            // 
            buttonSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSettings.Location = new Point(713, 415);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 0;
            buttonSettings.Text = "設定";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Location = new Point(93, 415);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "削除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridViewTaskList);
            Controls.Add(buttonSettings);
            Controls.Add(buttonAddition);
            Name = "ToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDoList";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTaskList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddition;
        private DataGridView dataGridViewTaskList;
        private Button buttonSettings;
        private Button buttonDelete;
    }
}