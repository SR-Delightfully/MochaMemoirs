using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MochaMemoirs.Model
{
    internal class Theme
    {
        public string Name { get; set; }
        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public Color Accent1 { get; set; }
        public Color Accent2 { get; set; }

        public Theme(string name, Color bg, Color fg, Color a1, Color a2)
        {
            Name = name;
            BackgroundColor = bg;
            ForegroundColor = fg;
            Accent1 = a1;
            Accent2 = a2;
        }
    }
}
