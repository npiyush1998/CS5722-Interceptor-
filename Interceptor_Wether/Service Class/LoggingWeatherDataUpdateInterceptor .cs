using Interceptor_Wether.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Service_Class
{
    class LoggingWeatherDataUpdateInterceptor : IWeatherDataUpdateInterceptor
    {
        public void OnWeatherDataUpdate(WeatherDataContext weatherData)
        {
            WeatherStation station = weatherData.weatherStation;
            Console.WriteLine("New weather data received: Temperature=" + station.temperature
            + " degrees Celsius, Humidity=" + station.humidity + "%, Pressure=" + station.pressure + " hPa");
        }
    }
}
