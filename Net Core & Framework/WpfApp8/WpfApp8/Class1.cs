using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace WpfApp8
{
    class Class1 : Canvas
    {
        int x = 100, y = 100;

        public void SetXY(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        protected override void OnRender(DrawingContext dc)
        {
            dc.DrawEllipse(Brushes.Silver, 
                new Pen(Brushes.Black, 3), 
                new Point(x, y), 50, 50);
        }
    }
}
