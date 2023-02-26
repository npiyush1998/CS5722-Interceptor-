using Interceptor_Wether.Service_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Interface
{
    interface IWeatherDataUpdateDispatcher
    {
        void RegisterWeatherDataUpdateInterceptor(IWeatherDataUpdateInterceptor interceptor);
        void RemoveWeatherDataUpdateInterceptor(IWeatherDataUpdateInterceptor interceptor);
        void DispatchWeatherDataUpdate(WeatherStation weatherStation);
    }
}
