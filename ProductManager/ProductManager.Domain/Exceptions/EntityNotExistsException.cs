using System;

namespace ProductManager.Domain.Exceptions
{
    public class EntityNotExistsException : Exception
    {
        public EntityNotExistsException(string message = "No entity with the given ID was found")
          : base(message) { }
    }
}
