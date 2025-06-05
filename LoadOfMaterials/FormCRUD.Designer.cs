namespace LoadOfMaterials
{
    partial class FormCRUD
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelButtons = new Panel();
            buttonEscape = new Button();
            buttonSave = new Button();
            panelDB = new Panel();
            dataGridView = new DataGridView();
            panelButtons.SuspendLayout();
            panelDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonEscape);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.RightToLeft = RightToLeft.Yes;
            panelButtons.Size = new Size(1106, 90);
            panelButtons.TabIndex = 1;
            // 
            // buttonEscape
            // 
            buttonEscape.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEscape.Location = new Point(870, 12);
            buttonEscape.Name = "buttonEscape";
            buttonEscape.Size = new Size(223, 60);
            buttonEscape.TabIndex = 3;
            buttonEscape.Text = "Выйти на главную форму";
            buttonEscape.UseVisualStyleBackColor = true;
            buttonEscape.Click += buttonEscape_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(13, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(189, 60);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelDB
            // 
            panelDB.Controls.Add(dataGridView);
            panelDB.Dock = DockStyle.Fill;
            panelDB.Location = new Point(0, 90);
            panelDB.Name = "panelDB";
            panelDB.Padding = new Padding(10);
            panelDB.Size = new Size(1106, 646);
            panelDB.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(10, 10);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1086, 626);
            dataGridView.TabIndex = 0;
            // 
            // FormCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 736);
            Controls.Add(panelDB);
            Controls.Add(panelButtons);
            Name = "FormCRUD";
            Text = "Форма для редактирования таблиц";
            panelButtons.ResumeLayout(false);
            panelDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonSave;
        private Panel panelDB;
        public DataGridView dataGridView;
        private Button buttonEscape;
    }
}