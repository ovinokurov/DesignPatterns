using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ProductFactory
    {
        public IProduct CreateProduct()
        {
            return new Product();
        }
    }

}
