using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo("fi-FI");
            InitializeComponent();
        }

        //talteen
        private void Window_Closed(object sender, EventArgs e)
        {

            Properties.Settings.Default.Nimi = textBox.Text; 
            Properties.Settings.Default.Save();

        }

        //lue tiedot
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = Properties.Settings.Default.Nimi;

        }

        //lisää httpclient
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                // Call asynchronous network methods in a try/catch block to handle exceptions
                try
                {
                    HttpResponseMessage response = await client.GetAsync("http://www.hamk.fi/");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (responseBody.Length > 500)
                    {
                        textBlock.Text = responseBody.Substring(0, 500);
                    }


                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    //Console.WriteLine(responseBody);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", ex.Message);
                }
            }
        }
    }
}
