using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadOfMaterials.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace LoadOfMaterials
{
    public partial class FormMain : Form
    {
        private StatsContext? db;
        public static DateTime DateStart;
        public static DateTime DateEnd;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            FormDate formdate = new FormDate();
            formdate.Show();
            this.Hide();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new StatsContext();

            DateTime startDate = DateStart;
            DateTime endDate = DateEnd;

            var filteredData = this.db.LoadingMaterials
                .Where(lm => lm.TimeNum >= startDate && lm.TimeNum <= endDate)
                .ToList();

            // Вычисляем средние значения по выбранным колонкам
            double StoneAvg = filteredData.Any() ? filteredData.Average(lm => lm.Stone) : 0;
            double DolomiteAvg = filteredData.Any() ? filteredData.Average(lm => lm.Dolomite) : 0;
            double CokeAvg = filteredData.Any() ? filteredData.Average(lm => lm.Coke) : 0;

            // Создаем список для привязки и добавляем туда исходные данные
            var dataList = new List<LoadingMaterial>(filteredData);

            // Создаем "итоговую" строку с суммами
            var footerItem = new LoadingMaterial
            {
                BatchNr = 0,
                Stone = Math.Round(filteredData.Sum(lm => lm.Stone), 2),
                Dolomite = Math.Round(filteredData.Sum(lm => lm.Dolomite), 2),
                Coke = Math.Round(filteredData.Sum(lm => lm.Coke), 2)
            };

            dataList.Add(footerItem);

            // Привязка данных к DataGridView
            this.dataGridView.DataSource = new BindingList<LoadingMaterial>(dataList);

            // Настройка колонок (после привязки)
            dataGridView.Columns["TimeStr"].Visible = false;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["StoneSp"].Visible = false;
            dataGridView.Columns["DolomiteSp"].Visible = false;
            dataGridView.Columns["BriquetteSp"].Visible = false;
            dataGridView.Columns["CokeSp"].Visible = false;
            dataGridView.Columns["ReserveSp"].Visible = false;

            dataGridView.Columns["TimeNum"].HeaderText = "Дата";
            dataGridView.Columns["BatchNr"].HeaderText = "№";
            dataGridView.Columns["StoneRec"].HeaderText = "Рец. Камень";
            dataGridView.Columns["Stone"].HeaderText = $"Камень (среднее {StoneAvg:F2})";
            dataGridView.Columns["Dolomite"].HeaderText = $"Доломит (среднее {DolomiteAvg:F2})";
            dataGridView.Columns["Briquette"].HeaderText = "Брикеты";
            dataGridView.Columns["Reserve"].HeaderText = "Запас";
            dataGridView.Columns["CokeRec"].HeaderText = "Рец. Кокс";
            dataGridView.Columns["Coke"].HeaderText = $"Кокс (среднее {CokeAvg:F2})";

            // Форматирование числовых колонок для отображения двух знаков после запятой
            string[] numericColumns = { "Stone", "Dolomite", "Coke" };
            foreach (var colName in numericColumns)
            {
                if (dataGridView.Columns[colName] != null)
                {
                    dataGridView.Columns[colName].DefaultCellStyle.Format = "F2";
                }
            }

            // Обработчик для выделения строки с итогами
            this.dataGridView.RowPrePaint += DataGridView_RowPrePaint;
        }

        // Обработчик для выделения строки с итогами
        private void DataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGridView.Rows[e.RowIndex];

            if (row.Cells["BatchNr"].Value != null && row.Cells["BatchNr"].Value.Equals(0))
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow;
                row.DefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
                row.ReadOnly = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.ForeColor = Color.Black;
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {

        }
    }
}
