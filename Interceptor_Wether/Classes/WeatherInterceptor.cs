using Interceptor_Wether.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Classes
{
    
    class WeatherInterceptor : IWeatherInterceptor
    {
        
        
        public void interfaceUpdate(WeatherDataContext context)
        {

            
            context.getWeatherStationReference().RegisterObserver(context.getDisplayReference());
            context.getWeatherStationReference().SetMeasurement(context.getTemprature(), context.getHumidity(), context.getPressure());

            Console.WriteLine("New weather data received: Temperature=" + context.getTemprature()
            + " degrees Celsius, Humidity=" + context.getHumidity() + "%, Pressure=" + context.getPressure() + " hPa");

        }

        
    }
}
