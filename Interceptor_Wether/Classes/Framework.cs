using Interceptor_Wether.Classes;
using Interceptor_Wether.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Classes
{
    class Framework
    {

        public void eventTrigger(double temprature, double humidity, double pressure)
        {
            WeatherDataContext context = new WeatherDataContext(temprature, humidity, pressure);
            WeatherDIspatcher dispatcher = new WeatherDIspatcher();
            IWeatherInterceptor interceptor = new WeatherInterceptor();
            dispatcher.RegisterWeatherDataUpdateInterceptor(interceptor);
            dispatcher.DispatchWeatherDataUpdate(context);
        }
    }
}
