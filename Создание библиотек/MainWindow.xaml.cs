using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
using Newtonsoft.Json;
using JSON;
using static Создание_библиотек.MainWindow;

namespace Создание_библиотек
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string name;
        public MainWindow()
        {
            InitializeComponent();
        }

        public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 6556,
                Summary = "ЧТО-ТО"
            };
            Class1.JsonSeri(weatherForecast);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<WeatherForecast> item = new List<WeatherForecast> { };
            var weatherForecast = Class1.JsonDeseri<WeatherForecast>();
            item.Add(weatherForecast);
            MyDataGrid.ItemsSource = item;
        }
    }
}
