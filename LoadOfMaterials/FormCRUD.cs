using LoadOfMaterials.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadOfMaterials
{
    public partial class FormCRUD : Form
    {
        private StatsContext? db;
        public FormCRUD()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using (var selectForm = new FormSelect())
            {
                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    string selectedItem = selectForm.SelectedTable;

                    this.db = new StatsContext();

                    switch (selectedItem)
                    {
                        case "Workers":
                            this.db.Workers.Load();
                            this.dataGridView.DataSource = db.Workers.Local.ToBindingList();
                            dataGridView.Columns["WorkersShifts"].Visible = false;
                            break;
                        case "Shifts":
                            this.db.Shifts.Load();
                            this.dataGridView.DataSource = db.Shifts.Local.ToBindingList();
                            dataGridView.Columns["WorkersShifts"].Visible = false;
                            break;
                    }
                }
                else
                {
                    FormMain cancel = new FormMain();
                    cancel.Show();
                    this.Close();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохраняем все изменения в контексте
                db.SaveChanges();

                MessageBox.Show("Изменения успешно сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonEscape_Click(object sender, EventArgs e)
        {
            FormMain escape = new FormMain();
            escape.Show();
            this.Close();
        }
    }
}
