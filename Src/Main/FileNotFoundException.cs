using System;

namespace USC.GISResearchLab.Common.Exceptions
{
    public class FileNotFoundException : Exception
    {
        public FileNotFoundException()
        {
        }

        public FileNotFoundException(string message)
            : base(message)
        {
        }
    }
}
