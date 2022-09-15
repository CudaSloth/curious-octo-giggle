using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RESTFul_Weather
{
    /// <summary>
    /// Model for the RESTful Weather app
    /// Application Logic should be implemented here
    /// </summary>
    internal class WeatherCore :IModule, IRestful
    {
        private static WeatherCore _this;
        private WeatherEngine _weatherEngine;

        private WeatherCore()
        {
            _weatherEngine = WeatherEngine.getInstance();
        }

        public static WeatherCore getInstance()
        {
            if(_this == null)
            {
                _this = new WeatherCore();
            }
            return _this;
        }

        public void Finalise() => throw new NotImplementedException();

        public void Start()
        {
            _weatherEngine.Start();
            //MessageBox.Show("WeatherCore Started", "Message", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
        }

        public void Stop() => throw new NotImplementedException();

        public string getStringsAsString() //Deprecated, will remove, testing only
        {
            return _weatherEngine.getStringsAsString();
        }

        public void Get(string lat, string lon)
        {
            _weatherEngine.Get(lat, lon);
        }
        public APIObject GetFromFile(string filename)
        {
            return _weatherEngine.GetFromFile(filename);
        }
        public void Put() => throw new NotImplementedException();
        public void Delete() => throw new NotImplementedException();
        public void Post() => throw new NotImplementedException();
    }
}
