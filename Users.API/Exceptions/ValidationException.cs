using System;

namespace Users.API.ServiceLayer.Handlers
{
    [Serializable]
    internal class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }
    }
}