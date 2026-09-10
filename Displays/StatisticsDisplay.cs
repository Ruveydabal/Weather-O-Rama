using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : WeatherDisplay

    {
        private List <float> sumTemperature = new List<float> ();
        private float maxTemp = int.MinValue;
        private float minTemp = int.MaxValue;
        private int countUpdated = 0;
        public StatisticsDisplay(Subject weatherData) : base(weatherData) 
        { 
           
        }

        public override void Display()
        {
            if (Temprature > maxTemp)
            {
                maxTemp = Temprature;
            }

            if(Temprature < minTemp || countUpdated == 0 && minTemp == 0)
            {
                minTemp = Temprature;
            }

            sumTemperature.Add(Temprature);
            countUpdated++;
            Console.WriteLine($"Avg/max/min: {sumTemperature}/{maxTemp}/{minTemp}");
        }
    }
}
