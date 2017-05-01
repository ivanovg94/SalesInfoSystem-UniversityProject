using System;
using System.Windows.Forms;

namespace exercise2
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        //private void treeView1_MouseMove(object sender, MouseEventArgs e)
        //{
        //         this.toolTip1.SetToolTip(
        //             this.treeView1, "За да изберете артикул, кликнте 2 пъти върху него!");
        //}

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in Application.OpenForms) //Организираме цикъл, за да обходим
                                                      //всички отворени форми в приложението
            {
                if (f.Name.Equals("salesInfoSys")) //Проверяваме дали името на отворената форма
                                              // е името на главната ни форма
                {
                    Control[] cntr = f.Controls.Find("ItemsGV", true);
                    //Търсим контрол с име„ItemsGV“

                    cntr[0].Tag = treeView1.SelectedNode.Text;
                    // Чрез property “Tag” може да вземете или да поставите обект,
                    //който съдържа данни за даден контрол. (в случая в Tag на
                    //ItemsGV поставяме избрания артикул от treeView)
                }
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
