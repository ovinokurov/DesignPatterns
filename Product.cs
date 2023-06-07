using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Product : IProduct
    {
        public string GetUsername(string emailAddress)
        {
            int atIndex = emailAddress.IndexOf('@');
            return (atIndex > 0) ? emailAddress.Substring(0, atIndex) : string.Empty;
        }
    }

}
