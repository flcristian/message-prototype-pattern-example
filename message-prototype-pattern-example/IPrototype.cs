using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message_prototype_pattern_example
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
