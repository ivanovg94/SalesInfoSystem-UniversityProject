namespace exercise4
{
    partial class salesInfoSys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitPriceTb = new System.Windows.Forms.TextBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.discountTb = new System.Windows.Forms.TextBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.newSaleButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.euroTotalPriceTb = new System.Windows.Forms.TextBox();
            this.euroTotalDiscountTb = new System.Windows.Forms.TextBox();
            this.euroSalesCountTb = new System.Windows.Forms.TextBox();
            this.totalPriceTb = new System.Windows.Forms.TextBox();
            this.totalDiscountTb = new System.Windows.Forms.TextBox();
            this.salesCountTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalDiscountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemCb = new System.Windows.Forms.ComboBox();
            this.currencyCb = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.dataLog = new System.Windows.Forms.ListView();
            this.dataCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitpriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discountCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currencyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ед. цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(12, 118);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(56, 13);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.Text = "Отстъпка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Стойност";
            // 
            // unitPriceTb
            // 
            this.unitPriceTb.Location = new System.Drawing.Point(113, 58);
            this.unitPriceTb.Name = "unitPriceTb";
            this.unitPriceTb.Size = new System.Drawing.Size(134, 20);
            this.unitPriceTb.TabIndex = 6;
            this.toolTip1.SetToolTip(this.unitPriceTb, "Десетично Число. Задължителна стойност.");
            // 
            // quantityTb
            // 
            this.quantityTb.Location = new System.Drawing.Point(113, 85);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(134, 20);
            this.quantityTb.TabIndex = 7;
            this.toolTip1.SetToolTip(this.quantityTb, "Реално число. Задължителна стойност.");
            // 
            // discountTb
            // 
            this.discountTb.Location = new System.Drawing.Point(113, 111);
            this.discountTb.Name = "discountTb";
            this.discountTb.ReadOnly = true;
            this.discountTb.Size = new System.Drawing.Size(134, 20);
            this.discountTb.TabIndex = 8;
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(113, 137);
            this.priceTb.Name = "priceTb";
            this.priceTb.ReadOnly = true;
            this.priceTb.Size = new System.Drawing.Size(134, 20);
            this.priceTb.TabIndex = 9;
            // 
            // newSaleButton
            // 
            this.newSaleButton.Location = new System.Drawing.Point(413, 28);
            this.newSaleButton.Name = "newSaleButton";
            this.newSaleButton.Size = new System.Drawing.Size(145, 23);
            this.newSaleButton.TabIndex = 10;
            this.newSaleButton.Text = "Нова продажба";
            this.newSaleButton.UseVisualStyleBackColor = true;
            this.newSaleButton.Click += new System.EventHandler(this.newSaleButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(413, 53);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(145, 23);
            this.totalButton.TabIndex = 11;
            this.totalButton.Text = "Тотал";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(413, 108);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(145, 23);
            this.endButton.TabIndex = 12;
            this.endButton.Text = "Приключване";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(413, 134);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Изход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.euroTotalPriceTb);
            this.groupBox1.Controls.Add(this.euroTotalDiscountTb);
            this.groupBox1.Controls.Add(this.euroSalesCountTb);
            this.groupBox1.Controls.Add(this.totalPriceTb);
            this.groupBox1.Controls.Add(this.totalDiscountTb);
            this.groupBox1.Controls.Add(this.salesCountTb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.totalDiscountLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тотал";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "лева";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "euro";
            // 
            // euroTotalPriceTb
            // 
            this.euroTotalPriceTb.Location = new System.Drawing.Point(401, 39);
            this.euroTotalPriceTb.Name = "euroTotalPriceTb";
            this.euroTotalPriceTb.ReadOnly = true;
            this.euroTotalPriceTb.Size = new System.Drawing.Size(100, 20);
            this.euroTotalPriceTb.TabIndex = 8;
            // 
            // euroTotalDiscountTb
            // 
            this.euroTotalDiscountTb.Location = new System.Drawing.Point(204, 39);
            this.euroTotalDiscountTb.Name = "euroTotalDiscountTb";
            this.euroTotalDiscountTb.ReadOnly = true;
            this.euroTotalDiscountTb.Size = new System.Drawing.Size(100, 20);
            this.euroTotalDiscountTb.TabIndex = 7;
            // 
            // euroSalesCountTb
            // 
            this.euroSalesCountTb.Location = new System.Drawing.Point(6, 39);
            this.euroSalesCountTb.Name = "euroSalesCountTb";
            this.euroSalesCountTb.ReadOnly = true;
            this.euroSalesCountTb.Size = new System.Drawing.Size(100, 20);
            this.euroSalesCountTb.TabIndex = 6;
            // 
            // totalPriceTb
            // 
            this.totalPriceTb.Location = new System.Drawing.Point(401, 65);
            this.totalPriceTb.Name = "totalPriceTb";
            this.totalPriceTb.ReadOnly = true;
            this.totalPriceTb.Size = new System.Drawing.Size(100, 20);
            this.totalPriceTb.TabIndex = 5;
            // 
            // totalDiscountTb
            // 
            this.totalDiscountTb.Location = new System.Drawing.Point(204, 65);
            this.totalDiscountTb.Name = "totalDiscountTb";
            this.totalDiscountTb.ReadOnly = true;
            this.totalDiscountTb.Size = new System.Drawing.Size(100, 20);
            this.totalDiscountTb.TabIndex = 4;
            // 
            // salesCountTb
            // 
            this.salesCountTb.Location = new System.Drawing.Point(6, 65);
            this.salesCountTb.Name = "salesCountTb";
            this.salesCountTb.ReadOnly = true;
            this.salesCountTb.Size = new System.Drawing.Size(100, 20);
            this.salesCountTb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Обща стойност";
            // 
            // totalDiscountLabel
            // 
            this.totalDiscountLabel.AutoSize = true;
            this.totalDiscountLabel.Location = new System.Drawing.Point(228, 19);
            this.totalDiscountLabel.Name = "totalDiscountLabel";
            this.totalDiscountLabel.Size = new System.Drawing.Size(56, 13);
            this.totalDiscountLabel.TabIndex = 1;
            this.totalDiscountLabel.Text = "Отстъпка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Брой продажби";
            // 
            // itemCb
            // 
            this.itemCb.FormattingEnabled = true;
            this.itemCb.Location = new System.Drawing.Point(113, 31);
            this.itemCb.Name = "itemCb";
            this.itemCb.Size = new System.Drawing.Size(134, 21);
            this.itemCb.TabIndex = 15;
            this.toolTip1.SetToolTip(this.itemCb, "Име на артикула. Задължително поле.");
            this.itemCb.SelectedIndexChanged += new System.EventHandler(this.itemCb_SelectedIndexChanged);
            // 
            // currencyCb
            // 
            this.currencyCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyCb.FormattingEnabled = true;
            this.currencyCb.Items.AddRange(new object[] {
            "лева",
            "euro"});
            this.currencyCb.Location = new System.Drawing.Point(253, 58);
            this.currencyCb.Name = "currencyCb";
            this.currencyCb.Size = new System.Drawing.Size(52, 21);
            this.currencyCb.TabIndex = 16;
            this.toolTip1.SetToolTip(this.currencyCb, "Вид валута.");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Дата";
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(113, 5);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(134, 20);
            this.dateDTP.TabIndex = 18;
            // 
            // dataLog
            // 
            this.dataLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataCol,
            this.itemCol,
            this.unitpriceCol,
            this.quantityCol,
            this.discountCol,
            this.priceCol,
            this.currencyCol});
            this.dataLog.Location = new System.Drawing.Point(12, 293);
            this.dataLog.Name = "dataLog";
            this.dataLog.Size = new System.Drawing.Size(556, 97);
            this.dataLog.TabIndex = 19;
            this.dataLog.UseCompatibleStateImageBehavior = false;
            this.dataLog.View = System.Windows.Forms.View.Details;
            // 
            // dataCol
            // 
            this.dataCol.Text = "Дата";
            this.dataCol.Width = 82;
            // 
            // itemCol
            // 
            this.itemCol.Text = "Артикул";
            this.itemCol.Width = 82;
            // 
            // unitpriceCol
            // 
            this.unitpriceCol.Text = "Ед. цена";
            this.unitpriceCol.Width = 85;
            // 
            // quantityCol
            // 
            this.quantityCol.Text = "Количество";
            this.quantityCol.Width = 83;
            // 
            // discountCol
            // 
            this.discountCol.Text = "Отстъпка";
            this.discountCol.Width = 85;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Стойност";
            this.priceCol.Width = 89;
            // 
            // currencyCol
            // 
            this.currencyCol.Text = "Валута";
            // 
            // salesInfoSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 413);
            this.Controls.Add(this.dataLog);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.currencyCb);
            this.Controls.Add(this.itemCb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.newSaleButton);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.discountTb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.unitPriceTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "salesInfoSys";
            this.Text = "Информационна система \"Продажби\"";
            this.Load += new System.EventHandler(this.salesInfoSys_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unitPriceTb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.TextBox discountTb;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.Button newSaleButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalPriceTb;
        private System.Windows.Forms.TextBox totalDiscountTb;
        private System.Windows.Forms.TextBox salesCountTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalDiscountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox itemCb;
        private System.Windows.Forms.ComboBox currencyCb;
        private System.Windows.Forms.TextBox euroTotalPriceTb;
        private System.Windows.Forms.TextBox euroTotalDiscountTb;
        private System.Windows.Forms.TextBox euroSalesCountTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.ListView dataLog;
        private System.Windows.Forms.ColumnHeader dataCol;
        private System.Windows.Forms.ColumnHeader itemCol;
        private System.Windows.Forms.ColumnHeader unitpriceCol;
        private System.Windows.Forms.ColumnHeader quantityCol;
        private System.Windows.Forms.ColumnHeader discountCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        private System.Windows.Forms.ColumnHeader currencyCol;
    }
}

