using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvOil.Business.Exceptions;

public class OilNotFound : Exception
{
    public OilNotFound(string message) : base(message)
    {
    }
}
