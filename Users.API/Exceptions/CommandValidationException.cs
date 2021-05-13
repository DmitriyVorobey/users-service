using System;

namespace User.API.ServiceLayer.Handlers
{
    [Serializable]
    internal class CommandValidationException : Exception
    {
        public CommandValidationException(string message) : base(message)
        {
        }
    }
}