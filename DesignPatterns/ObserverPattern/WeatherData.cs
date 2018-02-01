using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    /// <summary>
    /// The WeatherData class
    /// Contains all methods for performing basic weather data functions.
    /// </summary>
    /// <remarks>
    /// This class can Get and Set the Temperature, Humidity, and Pressure of any object subscribed
    /// </remarks>
    class WeatherData : ISubject
    {
        private ArrayList _Observers;

        private float _Temperature;
        private float _Humidity;
        private float _Pressure;

        public WeatherData()
        {
            _Observers = new ArrayList();
        }
        public float GetTemperature()
        {
            return _Temperature;
        }

        public void SetTemperature(int value)
        {
            _Temperature = value;
        }
       
        public float GetHumidity()
        {
            return _Humidity;
        }

        public void SetHumidity(int value)
        {
            _Humidity = value;
        }
        /// <summary>
        /// Gets the value of Pressure
        /// </summary>
        /// <returns>
        /// The Pressure
        /// </returns>
        public float GetPressure()
        {
            return _Pressure;
        }

        public void SetPressure(int value)
        {
            _Pressure = value;
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void RegisterObserver(IObserver o)
        {
            _Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = _Observers.IndexOf(o);
            if (i >= 0)
            {
                _Observers.RemoveAt(i);
            }
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _Temperature = temperature;
            _Humidity = humidity;
            _Pressure = pressure;
            MeasurementsChanged();
        }
        
        /// <summary>
        /// Notifies each observer in the ArrayList
        /// </summary>
        public void NotifyObservers()
        {
            for (int i = 0; i < _Observers.Count; i++)
            {
                IObserver observer = (IObserver)_Observers[i]; // retrieve Object from Array at Index
                observer.Update(_Temperature, _Humidity, _Pressure);
            }
        }
        // OTHER WeatherData Methods Here
    }
}
