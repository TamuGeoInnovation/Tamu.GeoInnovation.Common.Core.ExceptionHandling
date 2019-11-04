using System;

namespace USC.GISResearchLab.Common.Exceptions.Geocoding.Sources
{
    /// <summary>
    /// Summary description for RawSegmentException.
    /// </summary>
    public class RawSegmentException : SourceException
    {

        public RawSegmentException(string message, Exception e)
            :
            base(message, e)
        { }

        public RawSegmentException(string message) :
            base(message)
        {
        }
    }
}
