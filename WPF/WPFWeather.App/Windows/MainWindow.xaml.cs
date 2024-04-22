using System.Windows;
using WPFWeather.App.Services;
using WPFWeather.App.ViewModels;

namespace WPFWeather.App.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WeatherViewModel viewModel = new WeatherViewModel(new WeatherDiskService());
            DataContext = viewModel;
        }
    }
}