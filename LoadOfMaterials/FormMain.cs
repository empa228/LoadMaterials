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

            var filteredData = this.db.LoadingMaterials.Where(lm => lm.TimeNum >= startDate && lm.TimeNum <= endDate).ToList();

            // Привязка к DataGridView
            this.dataGridView.DataSource = new BindingList<LoadingMaterial>(filteredData);

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
            dataGridView.Columns["Stone"].HeaderText = "Камень";
            dataGridView.Columns["Dolomite"].HeaderText = "Доломит";
            dataGridView.Columns["Briquette"].HeaderText = "Брикеты";
            dataGridView.Columns["Reserve"].HeaderText = "Запас";
            dataGridView.Columns["CokeRec"].HeaderText = "Рец. Кокс";
            dataGridView.Columns["Coke"].HeaderText = "Кокс";
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
