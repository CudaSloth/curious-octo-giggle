using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTFul_Weather
{
    internal class Weather
    {
        public Weather()
        {

        }
        public string id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    internal class Rain
    {
        public Rain()
        {

        }
        public string one_h { get; set; }
    }

    internal class Minutely
    {
        public Minutely()
        {

        }
        public string dt { get; set; }
        public string precipitation { get; set; }
    }
    internal class Daily
    {
        public Daily()
        {

        }
        public string dt { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string moonrise { get; set; }
        public string moonset { get; set; }
        public string moon_phase { get; set; }
        public Temp temp { get; set; }
        public Feels_like feels_like { get; set; }
        public string pressure { get; set; }
        public string humidity { get; set; }
        public string dew_point { get; set; }
        public string wind_speed { get; set; }
        public string wind_deg { get; set; }
        public Weather weather { get; set; }
        public string clouds { get; set; }
        public string pop { get; set; }
        public string rain { get; set; }
        public string uvi { get; set; }
    }

    internal class Temp
    {
        public Temp()
        {

        }
        public string day { get; set; }
        public string min { get; set; }
        public string max { get; set; }
        public string night { get; set; }
        public string eve { get; set; }
        public string morn { get; set; }
    }

    internal class Feels_like
    {
        public Feels_like()
        {

        }
        public string day { get; set; }
        public string night { get; set; }
        public string eve { get; set; }
        public string morn { get; set; }
    }

    internal class Hourly
    {
        public Hourly()
        {

        }
        public string dt { get; set; }
        public string temp { get; set; }
        public string feels_like { get; set; }
        public string pressure { get; set; }
        public string humidity { get; set; }
        public string dew_point { get; set; }
        public string uvi { get; set; }
        public string clouds { get; set; }
        public string visibility { get; set; }
        public string wind_speed { get; set; }
        public string wind_deg { get; set; }
        public string wind_gust { get; set; }
        public Weather weather { get; set; }
        public string pop { get; set; }
    }

    internal class Current
    {
        public Current()
        {

        }
        public string dt { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string temp { get; set; }
        public string feels_like { get; set; }
        public string pressure { get; set; }
        public string humidity { get; set; }
        public string dew_point { get; set; }
        public string uvi { get; set; }
        public string clouds { get; set; }
        public string visibility { get; set; }
        public string wind_speed { get; set; }
        public string wind_deg { get; set; }
        public string wind_gust { get; set; }
        public Weather weather { get; set; }
        public Rain rain { get; set; }
    }

    internal class Alerts
    {
        public Alerts()
        {

        }
        public string sender_name { get; set; }
        public string m_event { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string description { get; set; }
        public string tags { get; set; }
    }

    internal class APIObject 
    {
        public Current current;
        public APIObject()
        {
            current = new Current();
        }
        public string lat { get; set; }
        public string lon { get; set; }
        public string timezone { get; set; }
        public string timezone_offset { get; set; }
        public Current getCurrent() { return current; }
    }
}
