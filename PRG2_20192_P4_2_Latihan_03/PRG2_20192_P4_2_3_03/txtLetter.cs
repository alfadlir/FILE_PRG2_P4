using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20192_P4_2_3_03
{
    public partial class txtLetter : UserControl
    {
        public txtLetter()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public String Text
        {
            get 
            { 
                return textBox1.Text; 
            }
            set 
            { 
                textBox1.Text = value; 
            }
        }
    }
}
