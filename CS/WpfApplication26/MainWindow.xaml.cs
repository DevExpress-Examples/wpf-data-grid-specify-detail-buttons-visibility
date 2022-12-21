using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace WpfApplication26 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = DataSource.GetCategories();
        }
    }

    [ValueConversion(typeof(object), typeof(bool))]
    public class MyConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            // Obtain the value to be converted:
            string categoryValue = (string)value;

            // Specify values for which to show expand buttons:
            string[] categories = new string[] { "First", "Third" };
            if (categories.Contains(categoryValue))
                return true;

            // Disable expand buttons if the value is not in the list:
            return false;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return null;
        }
    }
}
