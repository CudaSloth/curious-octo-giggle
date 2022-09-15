using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RESTFul_Weather
{
    /// <summary>
    /// Controller for the RESTful Weather app
    /// System and API logic should be placed here
    /// </summary>
    public class DataObject
    {
        public string Name { get; set; }
    }

    internal class WeatherEngine : IModule, IRestful
    {
        private static WeatherEngine _this;

        //For constructing the API request call
        private const string APIKey = "d932c2c2559957ffea7ce507620e5e69";
        private const string URL_1 = "https://api.openweathermap.org/data/2.5/onecall?";
        private const string URL_1a = "lat=";
        private const string URL_2 = "&lon=";
        private const string URL_3 = "&exclude=hourly,daily";
        private const string URL_4 = "&appid=";
        private string URL_Full = "";
        private List<string> urlParameters;


        HttpClient thisHttpClient;
        HttpResponseMessage thisHttpResponse;

        List<string> objectStrings;
        

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
        public void Get(string lat, string lon)
        {
            URL_Full = URL_1a + lat + URL_2 + lon + URL_4 + APIKey;
            thisHttpClient.BaseAddress = new Uri(URL_1);
            thisHttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            thisHttpResponse = thisHttpClient.GetAsync(URL_Full).Result;
            if(thisHttpResponse.IsSuccessStatusCode)
            {
                var dataObjects = thisHttpResponse.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                foreach (var d in dataObjects)
                {
                    objectStrings.Add(d.Name);
                    MessageBox.Show(d.Name, "Message", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                }    
            }
            MessageBox.Show(thisHttpResponse.ToString(), "Message", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
        }
        public void Post() => throw new NotImplementedException();
        public void Put() => throw new NotImplementedException();

        public void Start()
        {
            thisHttpClient = new HttpClient();
            objectStrings = new List<string>();
            urlParameters = new List<string>();
            MessageBox.Show("WeatherEngine Started", "Message", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
        }

        public void Stop() => throw new NotImplementedException();

        public string getStringsAsString()
        {
            string s = "";
            for(int i = 0; i < objectStrings.Count; ++i)
            {
                s += objectStrings.ElementAt(i).ToString();
            }
            return s;
        }
    }
}
