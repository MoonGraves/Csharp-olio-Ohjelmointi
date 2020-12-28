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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //avaa Window1
            //if(mywindow == null)
            Window1 mywindow = new Window1(); // tässä ikkunaluokan nimi=Window1
                                              //mywindow.Show(); // avaisi hakutyyppisen (modaalisen) ikkunan
                                              // mieluummin käytä   
            mywindow.textBox.Text = textBox.Text;
            if (mywindow.ShowDialog() == true)
            {
                textBox.Text = mywindow.textBox.Text;
            }
        }

        //file
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.Filter = "Text Files(*.txt)|*.txt|All Files (*.*)|*.*"; //mitkä ovat txt ja kaikki tiedostot 

            if (ofd.ShowDialog() == true)
            {
                string s = ofd.FileName;
                MessageBox.Show(s, "Otsikko", MessageBoxButton.OKCancel); //MessageBoxButton.OKCancel, MessageBoxImage.Hand, MessageBoxResult.Cancel, MessageBoxOptions.RightAlign.
            }
        }
    }
}
