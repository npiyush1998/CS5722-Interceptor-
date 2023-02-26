using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Service_Class
{
    class WeatherDataContext
    {

        public WeatherStation weatherStation; public WeatherDataContext(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }

        //public void setValue()
        //{

        //}
    }
}
