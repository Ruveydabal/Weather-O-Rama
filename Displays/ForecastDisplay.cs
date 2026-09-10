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
            // Set the field and register itself with the weatherdata subject
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
