using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace exercise4
{
    public partial class salesInfoSys : Form
    {
        int salesCount = 0;
        double totalDiscount = 0;
        double totalPrice = 0;
        int euroSalesCount = 0;
        double euroTotalDiscount = 0;
        double euroTotalPrice = 0;


        Item item1 = new Item("Артикул 1", 5, "лева");
        Item item2 = new Item("Артикул 2", 10, "euro");
        Item item3 = new Item("Артикул 3", 15, "лева");
        Item empty = new Item("нов",null,"");




        List<Item> items = new List<Item>();




        public salesInfoSys()
        {
            InitializeComponent();
        }

        private void salesInfoSys_Load(object sender, EventArgs e)
        {
            newSaleButton.Enabled = false;

            items.Add(empty);

            items.Add(item1);
            items.Add(item2);
            items.Add(item3);


            itemCb.SelectedIndex = -1;
            currencyCb.SelectedIndex = 0;
            currencyCb.Enabled = true;

            unitPriceTb.Enabled = false;
            currencyCb.Enabled = false;

            itemCb.Items.Add(item1.name);
            itemCb.Items.Add(item2.name);
            itemCb.Items.Add(item3.name);
            itemCb.Items.Add(empty.name);








        }

        private void newSaleButton_Click(object sender, EventArgs e)
        {
            itemCb.SelectedIndex = -1;
            currencyCb.SelectedIndex = 0;

            unitPriceTb.Clear();
            quantityTb.Clear();
            discountTb.Clear();
            priceTb.Clear();

            dateDTP.Enabled = false;
            totalButton.Enabled = true;
            newSaleButton.Enabled = false;
            discountLabel.ForeColor = Color.Black;
            MessageBox.Show("Въвеждане на данни за нова продажба");

        }

        private void totalButton_Click(object sender, EventArgs e)
        {

            if (!IsValidInput(quantityTb) || !IsValidInput(unitPriceTb) || !IsValidSelection(itemCb) || !IsValidSelection(currencyCb))
            {
                return;
            }

            int quantity = int.Parse(quantityTb.Text);

            if (currencyCb.SelectedIndex == 0)
            {
                double unitPrice = double.Parse(unitPriceTb.Text);
                double price = unitPrice * quantity;
                double discount = 0;
                if (price > 100)
                {
                    discount = 0.10 * price;
                    price = price - discount;
                    discountLabel.ForeColor = Color.Red;
                }
                discountTb.Text = discount.ToString();
                priceTb.Text = price.ToString();

                salesCount++;
                totalDiscount += discount;
                totalPrice += price;
            }
            else if (currencyCb.SelectedIndex == 1)
            {
                double euroUnitPrice = double.Parse(unitPriceTb.Text);
                double euroPrice = euroUnitPrice * quantity;
                double euroDiscount = 0;
                if (euroPrice > 100 * 0.511292)
                {
                    euroDiscount = 0.10 * euroPrice;
                    euroPrice = euroPrice - euroDiscount;
                    discountLabel.ForeColor = Color.Red;
                }

                discountTb.Text = euroDiscount.ToString();
                priceTb.Text = euroPrice.ToString();

                euroSalesCount++;
                euroTotalDiscount += euroDiscount;
                euroTotalPrice += euroPrice;
            }

            dataLog.Items.Add(new ListViewItem(new string[]
            {
                Convert.ToString(dateDTP.Value),
                itemCb.Text, unitPriceTb.Text,
                quantityTb.Text, discountTb.Text,
                priceTb.Text,
                currencyCb.Text
            }));

            dateDTP.Enabled = false;
            totalButton.Enabled = false;
            newSaleButton.Enabled = true;
            MessageBox.Show("Изчисляване на отстъпка и обща стойност за текущо въведена продажба");
        }



        private void endButton_Click(object sender, EventArgs e)
        {
            if (endButton.Text.Equals("Приключване"))
            {
                salesCountTb.Text = salesCount.ToString();
                totalDiscountTb.Text = totalDiscount.ToString();
                totalPriceTb.Text = totalPrice.ToString();

                euroSalesCountTb.Text = euroSalesCount.ToString();
                euroTotalDiscountTb.Text = euroTotalDiscount.ToString();
                euroTotalPriceTb.Text = euroTotalPrice.ToString();

                endButton.Text = "Нова операция";
                newSaleButton.Enabled = false;
                totalButton.Enabled = true;
                itemCb.Enabled = false;
                //   unitPriceTb.Enabled = false;
                quantityTb.Enabled = false;

                if (totalDiscount > 0)
                {
                    totalDiscountLabel.ForeColor = Color.Red;
                }


                MessageBox.Show("Приключване на въвеждане на продажби и изчисляване на обща отстъпка и стойност за всички въведени продажби");
            }
            else if (endButton.Text.Equals("Нова операция"))
            {
                salesCount = 0;
                totalDiscount = 0;
                totalPrice = 0;

                euroSalesCount = 0;
                euroTotalDiscount = 0;
                euroTotalPrice = 0;

                salesCountTb.Clear();
                totalDiscountTb.Clear();
                totalPriceTb.Clear();

                euroSalesCountTb.Clear();
                euroTotalDiscountTb.Clear();
                euroTotalPriceTb.Clear();

                itemCb.SelectedIndex = -1;
                currencyCb.SelectedIndex = 0;

                unitPriceTb.Clear();
                quantityTb.Clear();
                discountTb.Clear();
                priceTb.Clear();
                endButton.Text = "Приключване";
                totalButton.Enabled = true;
                itemCb.Enabled = true;
                //   unitPriceTb.Enabled = true;
                quantityTb.Enabled = true;
                dateDTP.Enabled = true;
                totalDiscountLabel.ForeColor = Color.Black;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изход от приложението");
            this.Close();
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

        private void itemCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemCb.SelectedIndex != -1 && itemCb.SelectedItem.ToString() == "нов")
            {
                unitPriceTb.Enabled = true;
                currencyCb.Enabled = true;
                itemCb.SelectedIndex = -1;
                unitPriceTb.Clear();
                currencyCb.SelectedIndex = -1;


            }
            else if (itemCb.SelectedIndex != -1 && itemCb.SelectedItem.ToString() != "нов")
            {
                var selected = items.FirstOrDefault(x => x.name == itemCb.SelectedItem.ToString());

                unitPriceTb.Text = selected.unitPrice.ToString();
                currencyCb.SelectedItem = selected.currency;
                unitPriceTb.Enabled = false;
                currencyCb.Enabled = false;

            }
        }
    }
}
