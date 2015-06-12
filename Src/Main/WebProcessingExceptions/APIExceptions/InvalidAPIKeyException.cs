using System;

namespace USC.GISResearchLab.Common.Core.Exceptions.WebProcessingExceptions.APIExceptions
{
    public class InvalidAPIKeyException : Exception
    {
        public InvalidAPIKeyException(string message)
            : base(message)
        {

        }
    }
}
