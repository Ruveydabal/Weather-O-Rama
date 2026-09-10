using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : WeatherDisplay 
    {
        public ForecastDisplay(Subject weatherData) : base(weatherData) 
        { 
            
        }

        public override void Display()
        {
            if (Temprature > 25 &&  Humidity < 50)
            {
                Console.WriteLine("Mooi weer komt er aan!");

            }
            else
            {
                Console.WriteLine("Trek je paraplu's uit de kast!");
            }

        }
    }
}
