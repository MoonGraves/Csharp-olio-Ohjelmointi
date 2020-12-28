using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Media.Animation;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double x = 0;
        //int y= 0;

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            x = Canvas.GetLeft(RingBlue);
            x += 20;
            Canvas.SetLeft(RingBlue, x);


            x = Canvas.GetLeft(RingBlack);
            x += 20;
            Canvas.SetLeft(RingBlack, x);

            x = Canvas.GetTop(RingRed);
            x += 20;
            Canvas.SetTop(RingRed, x);

            x = Canvas.GetTop(RingOrange);
            x += 20;
            Canvas.SetTop(RingOrange, x);

            x = Canvas.GetTop(RingGreen);
            x += 20;
            Canvas.SetTop(RingGreen, x);

            //Animation button, joka leveytyy oikealle josta palaa takaisin alkuperäiseen muotoon
            //timespan mukaan josta palautuu 5:ssä sekunnissa
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.To = 50;
            widthAnimation.From = 400;
            widthAnimation.Duration = TimeSpan.FromSeconds(5);


            myButton.BeginAnimation(WidthProperty, widthAnimation);
        }

        //Extrat määräiset neliöt tulevat

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = rectangle.Height = 20;
            rectangle.Fill = Brushes.Red;
            myCanvas.Children.Add(rectangle);

            Canvas.SetLeft(rectangle, e.GetPosition(myCanvas).X);
            Canvas.SetTop(rectangle, e.GetPosition(myCanvas).Y);
        }

        //luokkan canvas onrender
        private void Class1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
