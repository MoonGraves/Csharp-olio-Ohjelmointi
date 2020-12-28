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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
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
        int y = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            x = Canvas.GetLeft(ellipse1);           
            x += 20;
            Canvas.SetLeft(ellipse1, x);


        }

       
        private void OmaCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Canvas.SetLeft(ellipse1, e.GetPosition(omaCanvas).X - ellipse1.Width/2); //ja .y

            Rectangle rectangle = new Rectangle();
            rectangle.Width = rectangle.Height = 20;
            rectangle.Fill = Brushes.Red; // väri
            myCanvas.Children.Add(rectangle);
            //sijainti
            Canvas.SetLeft(rectangle, e.GetPosition(myCanvas).X);
            Canvas.SetTop(rectangle, e.GetPosition(myCanvas).Y);
        }

        //Undo
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (myCanvas.Children.Count > 0)
            {
                myCanvas.Children.RemoveAt(myCanvas.Children.Count - 1);
            }
        }

        private void MyCanvas_MouseLeftButton(object sender, MouseButtonEventArgs e)
        {
            myCanvas.SetXY((int)e.GetPosition(myCanvas).X),
                           (int)e.GetPosition(myCanvas).Y);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation();
            a.From = 50;
            a.To = 700;
            a.EasingFunction = EasingMode.EaseInOut;
            a.Duration = new Duration(TimeSpan.Parse("0:0:5"));
            ellipse1.BeginAnimation(Canvas.LeftProperty, a);
        }
    }
}
