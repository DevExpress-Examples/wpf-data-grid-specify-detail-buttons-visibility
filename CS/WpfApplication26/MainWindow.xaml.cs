using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace WpfApplication26
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid1.ItemsSource = new DataSource().Categories;
            
        }
    }

    [ValueConversion(typeof(object), typeof(bool))]
    public class MyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Obtaining the value to be converted 
            string categoryValue = (string)value;

            // Specifying values for which to show expand buttons
            string[] categories = new string[] { "First", "Third" };
            if (categories.Contains(categoryValue))
                return true;

            // Disable expand button if the value isn't in the list
            return false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
