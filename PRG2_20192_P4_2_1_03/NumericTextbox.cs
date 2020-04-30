using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG2_20192_P4_2_1_03
{
    [ToolboxBitmap(typeof(NumericTextBox), "PRG2_20192_P4_2_1_03 .numeric.ico")]
    public partial class NumericTextBox: TextBox
    {
        public NumericTextBox()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                try
                {
                    int.Parse(value);
                    base.Text = value;
                    return;
                }
                catch { }
                if (value == null)
                {
                    base.Text = value;
                    return;
                }
            }
        }

        public delegate void InvalidUserEntryEvent(Object sender, KeyPressEventArgs e);

    }
}
