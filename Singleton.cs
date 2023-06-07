using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton instance;

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

        public string GetUsername(string emailAddress)
        {
            int atIndex = emailAddress.IndexOf('@');
            return (atIndex > 0) ? emailAddress.Substring(0, atIndex) : string.Empty;
        }
    }
}
