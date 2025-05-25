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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelButtons = new Panel();
            buttonGraph = new Button();
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
            panelButtons.Controls.Add(buttonGraph);
            panelButtons.Controls.Add(buttonTable);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.RightToLeft = RightToLeft.Yes;
            panelButtons.Size = new Size(1209, 86);
            panelButtons.TabIndex = 0;
            // 
            // buttonGraph
            // 
            buttonGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGraph.Location = new Point(208, 13);
            buttonGraph.Name = "buttonGraph";
            buttonGraph.Size = new Size(189, 60);
            buttonGraph.TabIndex = 1;
            buttonGraph.Text = "Вывести график";
            buttonGraph.UseVisualStyleBackColor = true;
            buttonGraph.Click += buttonGraph_Click;
            // 
            // buttonTable
            // 
            buttonTable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTable.Location = new Point(13, 13);
            buttonTable.Name = "buttonTable";
            buttonTable.Size = new Size(189, 60);
            buttonTable.TabIndex = 0;
            buttonTable.Text = "Вывести таблицу";
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
        private Button buttonGraph;
        public DataGridView dataGridView;
    }
}
