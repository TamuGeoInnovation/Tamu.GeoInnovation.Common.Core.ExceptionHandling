using System;

namespace USC.GISResearchLab.Common.Core.Exceptions.WebProcessingExceptions.APIExceptions
{
    public class QuotaExceededException : Exception
    {
        public QuotaExceededException(string message)
            : base(message)
        {

        }
    }
}
