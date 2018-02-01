using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
