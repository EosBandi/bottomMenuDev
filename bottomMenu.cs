using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testTable
{
    public partial class bottomMenu : UserControl
    {

        public topLevelMenu menu;

        public bottomMenu()
        {
            InitializeComponent();
        }

        public void redraw()
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            if (menu == null) return;

            var buttonCount = menu.topLevelMenuItems.Count();

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0x26, 0x27, 0x28)), 0, 0, this.Width, this.Height);

            if (buttonCount == 0) return;

            var s = this.Width / buttonCount;
            for (int i = 0; i<buttonCount; i++)
            {
                e.Graphics.DrawLine(new Pen(Brushes.White, 2), i * s, 0, i * s, this.Height);

            }
            e.Graphics.DrawLine(new Pen(Brushes.White, 2), this.Width, 0, this.Width, this.Height);

            for (int i = 0;i<buttonCount; i++)
            {

                using (Font font1 = new Font("Arial", this.Height/3.5f, FontStyle.Bold, GraphicsUnit.Point))
                {
                    Rectangle rect1 = new Rectangle(i*s, 0, s, this.Height);

                    // Create a StringFormat object with the each line of text, and the block
                    // of text centered on the page.
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    // Draw the text and the surrounding rectangle.
                    e.Graphics.DrawString(menu.topLevelMenuItems[i].Text, font1, Brushes.White, rect1, stringFormat);
                }
            }
        }

    }
}
