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
    public partial class FormDate : Form
    {
        public FormDate()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            FormMain.DateStart = dateTimePickerStart.Value;
            FormMain.DateEnd = dateTimePickerEnd.Value;
            FormMain refresher = new FormMain();
            refresher.Show();
            this.Close();
        }
    }
}
