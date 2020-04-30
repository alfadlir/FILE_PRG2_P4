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
    [ToolboxBitmap(typeof(VerticalLabel), "!PRG2_20192_P4_2_1_03.VerticalLabel.ico")]
    public partial class VerticalLabel : Control
    {
        public VerticalLabel()
        {
            InitializeComponent();
        }

        private string labelText;
        // Overriding text  Property
        // adding attribut for text property ini design
        [Category("verticalLabel"), Description("Text is displayed in container")]
        public override string Text
        {
            get
            {
                return labelText;
            }
            set
            {
                labelText = value;
                Invalidate();
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float sngControlWidth;
            float sngControlHeight;

            float sngTransformX;
            float sngTransformY;

            Color labelColor = new Color();
            Pen labelBorderPen = new Pen(labelColor, 0);
            SolidBrush labelBackColorBrush = new SolidBrush(labelColor);
            SolidBrush labelForeColorBrush = new SolidBrush(base.ForeColor);

            if (this.DesignMode)
                base.ResizeRedraw = true;
            base.OnPaint(e);

            sngControlWidth = this.Width;
            sngControlHeight = this.Height;

            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, sngControlWidth, sngControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, sngControlWidth, sngControlHeight);

            // set the translate point for the graphics object - the new (0,0) location
            sngTransformX = 0;
            sngTransformY = sngControlHeight;

            // translate the origin used for rotation and drawing
            e.Graphics.TranslateTransform(sngTransformX, sngTransformY);

            // set the rotation angle for vertical text
            e.Graphics.RotateTransform(270);

            // draw the text on the control
            e.Graphics.DrawString(labelText, Font, labelForeColorBrush, 0, 0);
        }
    }
}
