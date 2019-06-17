using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample
{
    class Bowl<T>
    {
        public T value;
        public Bowl(T parameter)
        {
            this.value = parameter;
        }
    }
}
