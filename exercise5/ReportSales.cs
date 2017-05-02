using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise2
{

    public partial class ReportSales : Form
    {

        public ReportSales()
        {
            InitializeComponent();
        }


        public ReportSales(object dts, double total_value, double total_discount)
        {
            InitializeComponent();

            ItemsGV.DataSource = dts;
            textBox1.Text = total_discount.ToString();
            textBox2.Text = total_value.ToString();

            ItemsGV.Columns[0].HeaderText = "Артикул";
            ItemsGV.Columns[1].HeaderText = "Ед. цена";
            ItemsGV.Columns[2].HeaderText = "Количество";
            ItemsGV.Columns[3].HeaderText = "Отстъпка";
            ItemsGV.Columns[4].HeaderText = "Стойност";
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
