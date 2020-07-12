using System;

namespace Account.Exceptions.Entities
{
    class DomainException :  ApplicationException
    {
        public DomainException (string message) : base (message)
        {
           

        }
    }
}
