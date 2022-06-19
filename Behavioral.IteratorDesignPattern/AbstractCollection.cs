using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.IteratorDesignPattern
{
    interface AbstractCollection
    {
        Iterator CreateIterator();
    }
}
