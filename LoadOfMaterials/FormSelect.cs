using LoadOfMaterials.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadOfMaterials
{
    public partial class FormSelect : Form
    {
        public string SelectedTable { get; private set; } = "Workers"; // по умолчанию

        public FormSelect()
        {
            InitializeComponent();
        }

            private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.SelectedItem != null)
            {
                string selectedItem = comboBoxItems.SelectedItem.ToString();

                if (selectedItem == "Работники")
                {
                    SelectedTable = "Workers";
                }
                else if (selectedItem == "Смены")
                {
                    SelectedTable = "Shifts";
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите элемент");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
