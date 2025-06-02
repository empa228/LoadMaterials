namespace LoadOfMaterials
{
    partial class FormSelect
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
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            panelSelect = new Panel();
            comboBoxItems = new ComboBox();
            panelBottom.SuspendLayout();
            panelSelect.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonConfirm);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 82);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(800, 83);
            panelBottom.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(12, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(174, 57);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonConfirm.Location = new Point(613, 13);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(174, 57);
            buttonConfirm.TabIndex = 0;
            buttonConfirm.Text = "Подтвердить";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // panelSelect
            // 
            panelSelect.Controls.Add(comboBoxItems);
            panelSelect.Dock = DockStyle.Fill;
            panelSelect.Location = new Point(0, 0);
            panelSelect.Name = "panelSelect";
            panelSelect.Padding = new Padding(10);
            panelSelect.Size = new Size(800, 82);
            panelSelect.TabIndex = 3;
            // 
            // comboBoxItems
            // 
            comboBoxItems.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Items.AddRange(new object[] { "Работники", "Смены" });
            comboBoxItems.Location = new Point(13, 13);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(774, 40);
            comboBoxItems.TabIndex = 0;
            // 
            // FormSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 165);
            Controls.Add(panelSelect);
            Controls.Add(panelBottom);
            Name = "FormSelect";
            Text = "FormChoose";
            panelBottom.ResumeLayout(false);
            panelSelect.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonConfirm;
        private Panel panelSelect;
        private ComboBox comboBoxItems;
    }
}