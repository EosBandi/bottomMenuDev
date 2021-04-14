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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var mm = new topLevelMenu();
            var m = new topLevelMenuItem { Text = "Elso" };
            mm.topLevelMenuItems.Add(m);
            m = new topLevelMenuItem { Text = "Masodik" };
            mm.topLevelMenuItems.Add(m);
            m = new topLevelMenuItem { Text = "Harmadik" };
            mm.topLevelMenuItems.Add(m);
            m = new topLevelMenuItem { Text = "Negyedik" };
            mm.topLevelMenuItems.Add(m);
            m = new topLevelMenuItem { Text = "Otodik" };
            mm.topLevelMenuItems.Add(m);
            m = new topLevelMenuItem { Text = "Hatodik" };
            mm.topLevelMenuItems.Add(m);
            bottomMenu1.menu = mm;

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
