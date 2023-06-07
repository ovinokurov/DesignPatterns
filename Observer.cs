using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Observer : IObserver
    {
        private string username;

        public void Update(string message)
        {
            username = GetUsername(message);
        }

        public string GetUsername(string emailAddress)
        {
            int atIndex = emailAddress.IndexOf('@');
            return (atIndex > 0) ? emailAddress.Substring(0, atIndex) : string.Empty;
        }

        public string GetUsername()
        {
            return username;
        }
    }
}
