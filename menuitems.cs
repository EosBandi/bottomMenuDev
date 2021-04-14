using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTable
{
    public class menuItem
    {
        public string Text;
        public Color TextColor;
        public Color BackColor;
        public Image Pic;
        public EventHandler Clicked;
    }


    public class topLevelMenuItem : menuItem
    {
        public List<menuItem> menuItems = new List<menuItem>();
    }

    public class topLevelMenu
    {
        public List<topLevelMenuItem> topLevelMenuItems = new List<topLevelMenuItem>();
    }
}
