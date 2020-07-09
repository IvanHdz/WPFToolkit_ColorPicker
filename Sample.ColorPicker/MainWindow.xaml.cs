using System.Windows;
using System.Windows.Media;

namespace Sample.ColorPicker
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            colorPicker1.IsOpen = true;
            colorPicker1.SelectedColor = Colors.Red;
            colorPicker1.ShowDropDownButton = true;

            colorPicker2.IsOpen = false;
        }

        private void ColorPicker1_SelectedColorChanged_1(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            textBlock1.Foreground = new SolidColorBrush((Color)colorPicker1.SelectedColor);
            var r = colorPicker1.SelectedColor.Value.ScR;
            var g = colorPicker1.SelectedColor.Value.ScG;
            var b = colorPicker1.SelectedColor.Value.ScB;

            var r2 = colorPicker1.SelectedColor.Value.R;
            var g2 = colorPicker1.SelectedColor.Value.G;
            var b2 = colorPicker1.SelectedColor.Value.B;
        }

        private void ColorPicker2_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            textBlock1.Background = new SolidColorBrush((Color)colorPicker2.SelectedColor);
        }
    }
}