using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Menut11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo("sv-SE");
            InitializeComponent();
        }
        //Exit
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Open
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            if (ofd.ShowDialog() == true)
                textBox.Text = File.ReadAllText(ofd.FileName);
            ofd.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
           
        }


        // Copy
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            textBox.Copy();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window1 mywindow = new Window1();
            if (mywindow.ShowDialog() == true)
            {
                textBox.FontSize = Convert.ToDouble(mywindow.textBox.Text);
            }
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
               
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";
                if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument flowDocument = new FlowDocument();
                flowDocument.PagePadding = new Thickness(50);
                flowDocument.Blocks.Add(new Paragraph(new Run(textBox.Text)));

                printDialog.PrintDocument((((IDocumentPaginatorSource)flowDocument).DocumentPaginator), "Using Paginator");
            }
        }

        //paste

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            textBox.Paste();
        }
    }
}
