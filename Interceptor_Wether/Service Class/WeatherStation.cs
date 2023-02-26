using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Service_Class
{
    class WeatherStation
    {
        public double temperature;
        public double humidity;
        public double pressure;
        public List<Display> observers; public WeatherStation()
        {
            temperature = 0.0;
            humidity = 0.0;
            pressure = 0.0;
            observers = new List<Display>();
        }
        public void SetMeasurement(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }
        private void NotifyObservers()
        {
            foreach (Display observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
        public void RegisterObserver(Display observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(Display observer)
        {
            observers.Remove(observer);
        }
    }
}
