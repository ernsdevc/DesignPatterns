using DesignPattern.Observer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Observer
{
    public class ObserverObject
    {
        private readonly List<IObserver> observers;

        public ObserverObject()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver(AppUser appUser)
        {
            observers.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
        }
    }
}
