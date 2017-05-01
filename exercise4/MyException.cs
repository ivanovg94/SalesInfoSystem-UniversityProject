using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise4
{
    class MyException : Exception
    {
        public MyException(string str)
        {
            MessageBox.Show("User defined exception: " + str);
        }
    }
}
