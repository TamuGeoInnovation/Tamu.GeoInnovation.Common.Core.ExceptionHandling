using System;

namespace USC.GISResearchLab.Common.Exceptions.Geocoding
{
    /// <summary>
    /// Summary description for GeocodeException.
    /// </summary>
    public class GeocodeException : Exception
    {
        public GeocodeException(string message, Exception e)
            :
            base(message, e)
        { }

        public GeocodeException(string message) :
            base(message)
        {
        }
    }
}
