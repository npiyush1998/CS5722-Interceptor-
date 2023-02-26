using Interceptor_Wether.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Interface
{
    interface IWeatherInterceptor
    {
        void interfaceUpdate(WeatherDataContext context);
    }
}
