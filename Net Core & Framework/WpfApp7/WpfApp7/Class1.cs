using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp7
{
    class Class1 : Canvas
    {
        int x = 100, y = 100;

        public void SetXY(int _x, int _y)
        {
            x = _x;
            y = _y;
            InvalidateVisual();


        }

        protected override void OnRender(DrawingContext dc)
        {
            dc.DrawRectangle(Brushes.Yellow,
                new Pen(Brushes.Black, 3),
                new Rect(0, 0, 200, 200));

            dc.DrawEllipse(Brushes.Black, //täytäväri
                new Pen(Brushes.Black, 3), 
                new Point(x, y), 50, 50); //sijainti

            dc.DrawText(
                new FormattedText("Hello Universe",
                System.Globalization.CultureInfo.GetCultureInfo("en-us"),
                FlowDirection.LeftToRight, new Typeface("Arial"), 24.0, Brushes.Blue),
                new Point(100, 100));
        }
    }
}
