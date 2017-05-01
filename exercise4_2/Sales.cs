using exercise2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace exercise4_2
{
    public partial class salesInfoSys : Form
    {
        int salesCount = 0;
        double totalDiscount = 0;
        double totalPrice = 0;
        int euroSalesCount = 0;
        double euroTotalDiscount = 0;
        double euroTotalPrice = 0;

        public salesInfoSys()
        {
            InitializeComponent();
        }

        private void salesInfoSys_Load(object sender, EventArgs e)
        {
            
        }

       
        private bool IsValidInput(TextBox tb)
        {
            string tbName = tb.Name == "quantityTb" ? "количество" : "ед.цена";

            if (tb.Text == "")
            {
                MessageBox.Show($"Моля, попълнете стойност в поле {tbName}!");
                return false;
            }

            else if (IsNumber(tb.Text) == false)
            {
                MessageBox.Show($"Моля, въведете валидно число в поле {tbName}!");
                return false;
            }

            else if (IsNumber(tb.Text) == true && Convert.ToInt32(tb.Text) < 0)
            {
                MessageBox.Show($"Моля, попълнете Положителна стойност в поле {tbName}!");
                return false;
            }

            return true;
        }

        private bool IsValidSelection(ComboBox cb)
        {
            string cbName = cb.Name == "itemCb" ? "артикул" : "валута";
            if (cb.Text == "")
            {
                MessageBox.Show($"Моля, изберете {cbName}!");
                return false;
            }
            return true;
        }

        public static bool IsNumber(string aNumber)
        {
            double temp_big_int;
            var is_number = double.TryParse(aNumber, out temp_big_int);
            return is_number;
        }



        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изход от приложението");
            this.Close();
        }

        private void новаПродажбаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTb.Clear();
            dateDTP.Value = DateTimePicker.MinimumDateTime;

            salesCountTb.Clear();
            totalDiscountTb.Clear();
            totalPriceTb.Clear();

            euroSalesCountTb.Clear();
            euroTotalDiscountTb.Clear();
            euroTotalPriceTb.Clear();
            ItemsGV.Rows.Clear();
        }

        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSales form = new AllSales();
            form.Show();
        }

        private void артикулиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items form = new Items();
            form.Show();
        }

        private void ItemsGv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow;
            double price;
            double cnt;
            double unitPrice;
            double currentPrice;
            double discount;
            double euroUnitPrice;
            double euroPrice;
            double euroDiscount;
            currentRow = ItemsGV.CurrentRow.Index;

            if (ItemsGV.CurrentRow.Cells[1].Value != null && ItemsGV.CurrentRow.Cells[2].Value != null)
            {
                price = Convert.ToDouble(ItemsGV.CurrentRow.Cells[1].Value);
                cnt = Convert.ToDouble(ItemsGV.CurrentRow.Cells[2].Value);

                if (currencyCb.SelectedIndex == 0)
                {
                     unitPrice = Convert.ToDouble(ItemsGV.CurrentRow.Cells[1].Value);
                     currentPrice = unitPrice * cnt;
                     discount = 0;
                    if (currentPrice > 100)
                    {
                        discount = 0.10 * currentPrice;
                        currentPrice = currentPrice - discount;
                    }

                    salesCount++;
                    totalDiscount += discount;
                    totalPrice += currentPrice;
                    ItemsGV.CurrentRow.Cells[3].Value = discount;
                    ItemsGV.CurrentRow.Cells[4].Value = currentPrice;
                    salesCountTb.Text = salesCount.ToString();
                    totalDiscountTb.Text = totalDiscount.ToString();
                    totalPriceTb.Text = totalPrice.ToString();
                }
                else if (currencyCb.SelectedIndex == 1)
                {
                     euroUnitPrice = Convert.ToDouble(ItemsGV.CurrentRow.Cells[1].Value);
                     euroPrice = euroUnitPrice * cnt;
                     euroDiscount = 0;
                    if (euroPrice > 100 * 0.511292)
                    {
                        euroDiscount = 0.10 * euroPrice;
                        euroPrice = euroPrice - euroDiscount;
                    }

                    euroSalesCount++;
                    euroTotalDiscount += euroDiscount;
                    euroTotalPrice += euroPrice;
                    ItemsGV.CurrentRow.Cells[3].Value = euroDiscount;
                    ItemsGV.CurrentRow.Cells[4].Value = euroPrice;
                    euroSalesCountTb.Text = euroSalesCount.ToString();
                    euroTotalDiscountTb.Text = euroTotalDiscount.ToString();
                    euroTotalPriceTb.Text = euroTotalPrice.ToString();
                }
            }
        }

        private void ClientTb_Validating(object sender, CancelEventArgs e)
        {
            if (ClientTb.Text == "")
            {
                errorProvider1.SetError(ClientTb, "Моля, попълнете стойност");
                e.Cancel = true;
            }
        }
        private void ClientTb_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(ClientTb, "");
        }
    }
}
