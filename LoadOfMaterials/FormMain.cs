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
        public static DateTime DateStart { get; set; }
        public static DateTime DateEnd { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            FormDate formdate = new FormDate();
            formdate.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new StatsContext();

            var filteredData = this.db.LoadingMaterials.Where(lm => lm.TimeNum >= DateStart && lm.TimeNum <= DateEnd).ToList();

            // Привязка к DataGridView
            this.dataGridView.DataSource = new BindingList<LoadingMaterial>(filteredData);

            //this.db.LoadingMaterials.Load();
            //this.dataGridView.DataSource = db.LoadingMaterials.Local.ToBindingList();
        }
    }
}
