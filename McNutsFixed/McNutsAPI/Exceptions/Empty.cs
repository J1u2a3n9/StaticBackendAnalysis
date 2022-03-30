using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McNutsAPI.Exceptions
{
    public class EmptyBase : Exception
    {
        public EmptyBase(string message) : base(message)
        {
            

        }
    }
}
