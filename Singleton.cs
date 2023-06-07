using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton : ISubject
    {
        private static Singleton instance;
        private List<IObserver> observers = new List<IObserver>();

        private Singleton()
        {
            // Private constructor to prevent instantiation from outside the class
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public string GetUsername(string emailAddress)
        {
            int atIndex = emailAddress.IndexOf('@');
            return (atIndex > 0) ? emailAddress.Substring(0, atIndex) : string.Empty;
        }
    }
}
