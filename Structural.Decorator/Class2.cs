using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    public class DarkRoast : Beverage
    {
        public string description { get; set; }
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

       public override double cost()
        {
            throw new NotImplementedException();
        }
    }
}
