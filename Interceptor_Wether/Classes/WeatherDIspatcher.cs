using Interceptor_Wether.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Classes
{
    class WeatherDIspatcher : IWeatherDispatcher
    {
        private List<IWeatherInterceptor> interceptors; public WeatherDIspatcher()
        {
            interceptors = new List<IWeatherInterceptor>();
        }
        public void RegisterWeatherDataUpdateInterceptor(IWeatherInterceptor interceptor)
        {
            interceptors.Add(interceptor);
        }
        public void RemoveWeatherDataUpdateInterceptor(IWeatherInterceptor interceptor)
        {
            interceptors.Remove(interceptor);
        }
        public void DispatchWeatherDataUpdate(WeatherDataContext context)
        {
            //WeatherDataContext context = new WeatherDataContext(weatherStation);
            foreach (IWeatherInterceptor interceptor in interceptors)
            {
                interceptor.interfaceUpdate(context);
            }
        }
    }
}
