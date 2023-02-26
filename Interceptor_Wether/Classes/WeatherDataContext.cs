using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Classes
{
    class WeatherDataContext
    {
        private double tempertature;
        private double humidity;
        private double pressure;


        private WeatherStation station = new WeatherStation();
        private Display display = new Display();

        public WeatherDataContext(double tempertature, double humidity, double pressure )
        {
            this.tempertature = tempertature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public double getTemprature()
        {
            return tempertature;
        }
        public double getPressure()
        {
            return pressure;
        }
        public double getHumidity()
        {
            return humidity;
        }

        public WeatherStation getWeatherStationReference()
        {
            return station;
        }

        public Display getDisplayReference()
        {
            return display;
        }
    }
}
