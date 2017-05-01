using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void savePersonalButton_Click(object sender, EventArgs e)
        {
            // Read tha values of textboxes (not necessarily but more readable)
            string names = nameTb.Text;
            string tellNum = tellTb.Text;
            string birthPlace = birthplaceTb.Text;

            // Enter this data to reachtextbox
            dataTextBox.Text += $"ЛИЧНИ ДАННИ\n{names}\n{tellNum}\n{birthPlace}\n\n";

           
        }

        private void saveUniButton_Click(object sender, EventArgs e)
        {
            // Read tha values of textboxes (not necessarily but more readable)
            string fn = fnTb.Text;
            string group = groupCb.Text;
            string speciality = specialityCb.Text;

            // Enter this data to reachtextbox
            dataTextBox.Text += $"УНИВЕРСИТЕТСКИ ДАННИ\n{fn}\n{group}\n{speciality}\n\n";

        


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear text boxes             
            nameTb.Clear();
            tellTb.Clear();
            birthplaceTb.Clear();

            // Clear text boxes             
            fnTb.Clear();
            groupCb.SelectedIndex = -1;
            specialityCb.SelectedIndex = -1;
        }

        private void changeColorButton_Click(object sender, EventArgs e)
        {
            if (greenColor.Checked)
                dataTextBox.ForeColor = Color.Green;
            else if (redCollor.Checked)
                dataTextBox.ForeColor = Color.Red;
            else if (blackColor.Checked)
                dataTextBox.ForeColor = Color.Black;
        }
    }
}
