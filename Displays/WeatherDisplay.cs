using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal abstract class WeatherDisplay : Observer 
    {

        private float temprature;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public float Temprature {get {return temprature;  } }
        public float Humidity {get { return humidity; } }
        public float Pressure { get { return pressure; } }
        public WeatherDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure) 
        { 
            this.temprature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();

        }

        public abstract void Display();
    }
}
