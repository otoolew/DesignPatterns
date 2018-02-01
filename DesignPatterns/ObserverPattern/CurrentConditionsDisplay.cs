using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _Temperature;
        private float _Humidity;
        private ISubject _WeatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            _Temperature = temp;
            _Humidity = humidity;
            Display();           
        }
        public void Display()
        {
            Console.WriteLine("Current Conditions: " + _Temperature + "F degrees and " + _Humidity + "% humidity");
        }
    }
}
