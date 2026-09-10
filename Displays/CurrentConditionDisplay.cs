using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class CurrentConditionDisplay : WeatherDisplay
    {
        public CurrentConditionDisplay(Subject weatherData) : base(weatherData) 
        { 
           
            
        }

        public override void Display()
        {
            Console.WriteLine("");
        }
    }
}
