using Interceptor_Wether.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Service_Class
{
    class WeatherDataUpdateDispatcherImpl : IWeatherDataUpdateDispatcher
    {
        private List<IWeatherDataUpdateInterceptor> interceptors; public WeatherDataUpdateDispatcherImpl()
        {
            interceptors = new List<IWeatherDataUpdateInterceptor>();
        }
        public void RegisterWeatherDataUpdateInterceptor(IWeatherDataUpdateInterceptor interceptor)
        {
            interceptors.Add(interceptor);
        }
        public void RemoveWeatherDataUpdateInterceptor(IWeatherDataUpdateInterceptor interceptor)
        {
            interceptors.Remove(interceptor);
        }
        public void DispatchWeatherDataUpdate(WeatherStation weatherStation)
        {
            WeatherDataContext context = new WeatherDataContext(weatherStation);
            foreach (IWeatherDataUpdateInterceptor interceptor in interceptors)
            {
                interceptor.OnWeatherDataUpdate(context);
            }
        }
    }
}
