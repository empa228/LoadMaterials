namespace LoadOfMaterials
{
    partial class FormDate
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
            panelFill = new Panel();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            labelEndDate = new Label();
            labelStartDate = new Label();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            panelFill.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dateTimePickerEnd);
            panelFill.Controls.Add(dateTimePickerStart);
            panelFill.Controls.Add(labelEndDate);
            panelFill.Controls.Add(labelStartDate);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 275);
            panelFill.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerEnd.Location = new Point(23, 144);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 33);
            dateTimePickerEnd.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerStart.Location = new Point(23, 38);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 33);
            dateTimePickerStart.TabIndex = 4;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEndDate.Location = new Point(13, 116);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(413, 25);
            labelEndDate.TabIndex = 2;
            labelEndDate.Text = "Введите конечную дату в указанном формате:";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStartDate.Location = new Point(13, 10);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(423, 25);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "Введите начальную дату в указанном формате:";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonConfirm);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 192);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(800, 83);
            panelBottom.TabIndex = 1;
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
            // FormDate
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 275);
            Controls.Add(panelBottom);
            Controls.Add(panelFill);
            Name = "FormDate";
            Text = "FormDate";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelBottom;
        private Label labelStartDate;
        private Button buttonCancel;
        private Button buttonConfirm;
        private Label labelEndDate;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
    }
}