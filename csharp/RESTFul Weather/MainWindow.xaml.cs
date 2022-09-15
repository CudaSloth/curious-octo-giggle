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

namespace RESTFul_Weather
{
    /// <summary>
    /// View for the RESTful Weather app
    /// UI Interaction Logic should be placed here
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WeatherCore.getInstance().Start();
        }

        private void Button_Request(object sender, RoutedEventArgs e)
        {
            WeatherCore.getInstance().Get(LatText.Text, LonText.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            APIObject m = WeatherCore.getInstance().GetFromFile("API Restricted Response.txt");
            MessageBox.Show(m.lat, "Message", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            TZText.Text = m.timezone;
            UTCOffsetText.Text = m.timezone_offset;
            CurrTimeText.Text = m.current.dt;
            SunriseTimeText.Text = m.current.sunrise;
            SunsetTimeText.Text = m.current.sunset;
            AtmoPressText.Text = m.current.pressure;
            HumidityText.Text = m.current.humidity;
            DPText.Text = m.current.dew_point;
            CloudsText.Text = m.current.clouds;
            UVIText.Text = m.current.uvi;
            VisibilityText.Text = m.current.visibility;
            WindSpeedText.Text = m.current.wind_speed;
            WindGustText.Text = m.current.wind_gust;
            WindDirText.Text = m.current.wind_deg;
            SchemaText.Text = "Default/Kelvin";
            //RainText.Text = m.current.rain.one_h;
            //SnowText.Text = m.timezone;
            //ForecastText.Text = m.current.feels_like;
            TempRealText.Text = m.current.temp;
            TempFeelText.Text = m.current.feels_like;
        }
    }
}
