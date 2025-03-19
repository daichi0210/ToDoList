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
            dataGridView1 = new DataGridView();
            buttonSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAddition
            // 
            buttonAddition.Location = new Point(687, 415);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(75, 23);
            buttonAddition.TabIndex = 0;
            buttonAddition.Text = "追加";
            buttonAddition.UseVisualStyleBackColor = true;
            buttonAddition.Click += buttonAddition_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 324);
            dataGridView1.TabIndex = 1;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(513, 415);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 0;
            buttonSettings.Text = "設定";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSettings);
            Controls.Add(buttonAddition);
            Name = "ToDoList";
            Text = "ToDoList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddition;
        private DataGridView dataGridView1;
        private Button buttonSettings;
    }
}