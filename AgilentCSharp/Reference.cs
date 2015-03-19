using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilentCSharp
{
    public class Reference<T>
    {
        T _contains;

        public Reference(T con)
        {
            _contains = con;
        }

        public T Contains
        {
            get { return _contains; }
            set { _contains = value; }
        }
    }
}
