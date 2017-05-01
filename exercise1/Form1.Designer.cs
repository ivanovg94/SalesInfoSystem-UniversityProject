namespace exercise1
{
    partial class frm1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.tellTb = new System.Windows.Forms.MaskedTextBox();
            this.birthplaceTb = new System.Windows.Forms.TextBox();
            this.savePersonalButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fnTb = new System.Windows.Forms.MaskedTextBox();
            this.groupCb = new System.Windows.Forms.ComboBox();
            this.specialityCb = new System.Windows.Forms.ComboBox();
            this.saveUniButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.redCollor = new System.Windows.Forms.RadioButton();
            this.greenColor = new System.Windows.Forms.RadioButton();
            this.blackColor = new System.Windows.Forms.RadioButton();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savePersonalButton);
            this.groupBox1.Controls.Add(this.birthplaceTb);
            this.groupBox1.Controls.Add(this.tellTb);
            this.groupBox1.Controls.Add(this.nameTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лични данни:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име, Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Месторождение - населено място:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(127, 13);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(200, 20);
            this.nameTb.TabIndex = 3;
            // 
            // tellTb
            // 
            this.tellTb.Location = new System.Drawing.Point(227, 45);
            this.tellTb.Mask = "(999) 000-000000";
            this.tellTb.Name = "tellTb";
            this.tellTb.Size = new System.Drawing.Size(100, 20);
            this.tellTb.TabIndex = 4;
            // 
            // birthplaceTb
            // 
            this.birthplaceTb.Location = new System.Drawing.Point(227, 76);
            this.birthplaceTb.Name = "birthplaceTb";
            this.birthplaceTb.Size = new System.Drawing.Size(100, 20);
            this.birthplaceTb.TabIndex = 5;
            // 
            // savePersonalButton
            // 
            this.savePersonalButton.Location = new System.Drawing.Point(27, 102);
            this.savePersonalButton.Name = "savePersonalButton";
            this.savePersonalButton.Size = new System.Drawing.Size(300, 23);
            this.savePersonalButton.TabIndex = 6;
            this.savePersonalButton.Text = "Запиши лични данни";
            this.savePersonalButton.UseVisualStyleBackColor = true;
            this.savePersonalButton.Click += new System.EventHandler(this.savePersonalButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveUniButton);
            this.groupBox2.Controls.Add(this.specialityCb);
            this.groupBox2.Controls.Add(this.groupCb);
            this.groupBox2.Controls.Add(this.fnTb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Университетски данни";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Факултетен номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Група:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Направление:";
            // 
            // fnTb
            // 
            this.fnTb.Location = new System.Drawing.Point(144, 13);
            this.fnTb.Mask = "0000000";
            this.fnTb.Name = "fnTb";
            this.fnTb.Size = new System.Drawing.Size(121, 20);
            this.fnTb.TabIndex = 3;
            // 
            // groupCb
            // 
            this.groupCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupCb.FormattingEnabled = true;
            this.groupCb.Items.AddRange(new object[] {
            "1536",
            "1537"});
            this.groupCb.Location = new System.Drawing.Point(144, 44);
            this.groupCb.Name = "groupCb";
            this.groupCb.Size = new System.Drawing.Size(121, 21);
            this.groupCb.TabIndex = 4;
            // 
            // specialityCb
            // 
            this.specialityCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialityCb.FormattingEnabled = true;
            this.specialityCb.Items.AddRange(new object[] {
            "Разработка и проектиране на бизнес информационни системи",
            "Анализ и проектиране на бизнес информационни системи"});
            this.specialityCb.Location = new System.Drawing.Point(144, 75);
            this.specialityCb.Name = "specialityCb";
            this.specialityCb.Size = new System.Drawing.Size(121, 21);
            this.specialityCb.TabIndex = 5;
            // 
            // saveUniButton
            // 
            this.saveUniButton.Location = new System.Drawing.Point(41, 110);
            this.saveUniButton.Name = "saveUniButton";
            this.saveUniButton.Size = new System.Drawing.Size(178, 23);
            this.saveUniButton.TabIndex = 6;
            this.saveUniButton.Text = "Запиши университетски данни";
            this.saveUniButton.UseVisualStyleBackColor = true;
            this.saveUniButton.Click += new System.EventHandler(this.saveUniButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(12, 174);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(340, 140);
            this.dataTextBox.TabIndex = 2;
            this.dataTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.changeColorButton);
            this.groupBox3.Controls.Add(this.blackColor);
            this.groupBox3.Controls.Add(this.greenColor);
            this.groupBox3.Controls.Add(this.redCollor);
            this.groupBox3.Location = new System.Drawing.Point(371, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 140);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // redCollor
            // 
            this.redCollor.AutoSize = true;
            this.redCollor.Location = new System.Drawing.Point(10, 19);
            this.redCollor.Name = "redCollor";
            this.redCollor.Size = new System.Drawing.Size(60, 17);
            this.redCollor.TabIndex = 0;
            this.redCollor.TabStop = true;
            this.redCollor.Text = "червен";
            this.redCollor.UseVisualStyleBackColor = true;
            // 
            // greenColor
            // 
            this.greenColor.AutoSize = true;
            this.greenColor.Location = new System.Drawing.Point(10, 43);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(55, 17);
            this.greenColor.TabIndex = 1;
            this.greenColor.TabStop = true;
            this.greenColor.Text = "зелен";
            this.greenColor.UseVisualStyleBackColor = true;
            // 
            // blackColor
            // 
            this.blackColor.AutoSize = true;
            this.blackColor.Location = new System.Drawing.Point(10, 67);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(54, 17);
            this.blackColor.TabIndex = 2;
            this.blackColor.TabStop = true;
            this.blackColor.Text = "черен";
            this.blackColor.UseVisualStyleBackColor = true;
            // 
            // changeColorButton
            // 
            this.changeColorButton.Location = new System.Drawing.Point(10, 90);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(104, 44);
            this.changeColorButton.TabIndex = 3;
            this.changeColorButton.Text = "Смяна на цвят на текста";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.IndianRed;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(542, 264);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 43);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Изчисти всички полета";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 332);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Упражнение 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button savePersonalButton;
        private System.Windows.Forms.TextBox birthplaceTb;
        private System.Windows.Forms.MaskedTextBox tellTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveUniButton;
        private System.Windows.Forms.ComboBox specialityCb;
        private System.Windows.Forms.ComboBox groupCb;
        private System.Windows.Forms.MaskedTextBox fnTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox dataTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.RadioButton blackColor;
        private System.Windows.Forms.RadioButton greenColor;
        private System.Windows.Forms.RadioButton redCollor;
        private System.Windows.Forms.Button clearButton;
    }
}

