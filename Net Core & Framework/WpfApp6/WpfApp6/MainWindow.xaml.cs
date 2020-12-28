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

namespace WpfApp6
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

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
        Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.ShowDialog();
            Title = System.IO.Path.GetFileName(ofd.FileName);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange
                //= new TextRange(RichTextBox.Document.ContentStart, RichTextBox.Document.ContentEnd);
                = new TextRange(RichTextBox.Selection.Start, RichTextBox.Selection.End);

            TextBlock.Inlines.Clear();
            TextBlock.Inlines.Add("Eka rivi\n");
            TextBlock.Inlines.Add(new Run(textRange.Text) { Foreground = Brushes.Blue });
            TextBlock.Inlines.Add("Viimeinen rivi");
        }
    }
}
