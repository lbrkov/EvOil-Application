using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvOil.Business.Exceptions;

public class UserAlreadyExist : Exception
{
    public UserAlreadyExist(string message) : base(message)
    {
    }
}
