﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace McNutsAPI.Exceptions
{
    [Serializable]
    public class InsufficientAmountPeanutsException : Exception,ISerializable
    {
        public InsufficientAmountPeanutsException(string message) : base(message)
        {

        }
    }
}
