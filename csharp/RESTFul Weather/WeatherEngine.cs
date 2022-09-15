using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RESTFul_Weather
{
    /// <summary>
    /// Controller for the RESTful Weather app
    /// System and API logic should be placed here
    /// </summary>
    internal class WeatherEngine : IModule, IRestful
    {
        private static WeatherEngine _this;

        private WeatherEngine()
        {

        }

        public static WeatherEngine getInstance()
        {
            if (_this == null)
            {
                _this = new WeatherEngine();
            }
            return _this;
        }

        public void Delete() => throw new NotImplementedException();
        public void Finalise() => throw new NotImplementedException();
        public void Get() => throw new NotImplementedException();
        public void Post() => throw new NotImplementedException();
        public void Put() => throw new NotImplementedException();

        public void Start()
        {
            MessageBox.Show("WeatherEngine Started", "Message", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
        }

        public void Stop() => throw new NotImplementedException();
    }
}
