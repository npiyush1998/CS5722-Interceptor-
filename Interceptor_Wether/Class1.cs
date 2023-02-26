using Interceptor_Wether.Interface;
using Interceptor_Wether.Service_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
           // WeatherDataContext context = new WeatherDataContext();
            Display display = new Display();
            WeatherDataUpdateDispatcherImpl dispatcher = new WeatherDataUpdateDispatcherImpl();         // Register the interceptor with the dispatcher
            IWeatherDataUpdateInterceptor interceptor = new LoggingWeatherDataUpdateInterceptor();
            dispatcher.RegisterWeatherDataUpdateInterceptor(interceptor);         // Register the display with the weather station
            weatherStation.RegisterObserver(display);         // Update the weather station readings
            weatherStation.SetMeasurement(25.0, 70.0, 1013.0);
            dispatcher.DispatchWeatherDataUpdate(weatherStation);
            weatherStation.SetMeasurement(26.0, 71.0, 1012.0);
            weatherStation.SetMeasurement(27.0, 72.0, 1011.0);
            Console.ReadLine();
        }
    }
}
