using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class UsernameExtractor
    {
        public string GetUsername(string emailAddress)
        {
            // Common steps in the algorithm
            int atIndex = emailAddress.IndexOf('@');
            string username = (atIndex > 0) ? emailAddress.Substring(0, atIndex) : string.Empty;

            // Hook method for subclasses to override
            string processedUsername = ProcessUsername(username);

            return processedUsername;
        }

        protected abstract string ProcessUsername(string username);
    }

}
