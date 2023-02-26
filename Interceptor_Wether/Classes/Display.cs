using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether.Classes
{
    public class Display
    {
        private double temperature;
        private double humidity;
        private double pressure; public Display()
        {
            temperature = 0.0;
            humidity = 0.0;
            pressure = 0.0;
        }
        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            DisplayData();
        }
        private void DisplayData()
        {
            Console.WriteLine("Current Outside Temperature: " + temperature + " degrees Celsius");
            Console.WriteLine("Current Humidity: " + humidity + "%");
            Console.WriteLine("Current Pressure: " + pressure + " hPa");
        }
    }
}
