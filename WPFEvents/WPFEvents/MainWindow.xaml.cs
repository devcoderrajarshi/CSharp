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

namespace WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_MyOtherClick;        //creating and attaching custom event handler
        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            MyotherLabel.Content = "Hello again";
        }

        private void button_Click(object sender, RoutedEventArgs e)         //argument is attached with event in the markup language
        {
            MyLabel.Content = "Hello World";
        }
    }
}
