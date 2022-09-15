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
            TZText.Text = WeatherCore.getInstance().getStringsAsString();
        }
    }
}
