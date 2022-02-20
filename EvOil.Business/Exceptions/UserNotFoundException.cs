using System;
namespace EvOil.Business.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException(string message) : base(message)
    {
    }
}
