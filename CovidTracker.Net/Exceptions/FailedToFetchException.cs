using System;

namespace CovidTracker.Net.Exceptions
{
    public class FailedToFetchException : Exception
    {
        public FailedToFetchException() : base()
        {
            
        }

        public FailedToFetchException(string message) : base(message)
        {
            
        }

        public FailedToFetchException(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}