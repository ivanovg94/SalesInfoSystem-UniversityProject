﻿using System;
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
        public ReportSal(DataGridView dt, double total_value, double total_discount)
        {
            InitializeComponent();

 ....
 textBox1.Text = total_discount.ToString();
            textBox2.Text = total_value.ToString();
        }
    }
}
