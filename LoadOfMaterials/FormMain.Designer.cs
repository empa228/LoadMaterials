namespace LoadOfMaterials
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelButtons = new Panel();
            buttonCRUD = new Button();
            buttonTable = new Button();
            panelDB = new Panel();
            dataGridView = new DataGridView();
            panelButtons.SuspendLayout();
            panelDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCRUD);
            panelButtons.Controls.Add(buttonTable);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.RightToLeft = RightToLeft.Yes;
            panelButtons.Size = new Size(1209, 86);
            panelButtons.TabIndex = 0;
            // 
            // buttonCRUD
            // 
            buttonCRUD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCRUD.Location = new Point(208, 13);
            buttonCRUD.Name = "buttonCRUD";
            buttonCRUD.Size = new Size(345, 60);
            buttonCRUD.TabIndex = 1;
            buttonCRUD.Text = "Перейти в форму для редактирования таблиц";
            buttonCRUD.UseVisualStyleBackColor = true;
            buttonCRUD.Click += buttonCRUD_Click;
            // 
            // buttonTable
            // 
            buttonTable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTable.Location = new Point(13, 13);
            buttonTable.Name = "buttonTable";
            buttonTable.Size = new Size(189, 60);
            buttonTable.TabIndex = 0;
            buttonTable.Text = "Вывести данные";
            buttonTable.UseVisualStyleBackColor = true;
            buttonTable.Click += buttonTable_Click;
            // 
            // panelDB
            // 
            panelDB.Controls.Add(dataGridView);
            panelDB.Dock = DockStyle.Fill;
            panelDB.Location = new Point(0, 86);
            panelDB.Name = "panelDB";
            panelDB.Padding = new Padding(10);
            panelDB.Size = new Size(1209, 735);
            panelDB.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(10, 10);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(1189, 715);
            dataGridView.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 821);
            Controls.Add(panelDB);
            Controls.Add(panelButtons);
            Name = "FormMain";
            Text = "FormMain";
            panelButtons.ResumeLayout(false);
            panelDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button buttonTable;
        private Panel panelDB;
        public DataGridView dataGridView;
        private Button buttonCRUD;
    }
}
