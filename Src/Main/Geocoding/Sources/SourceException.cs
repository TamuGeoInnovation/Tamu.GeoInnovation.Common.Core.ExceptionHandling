using System;

namespace USC.GISResearchLab.Common.Exceptions.Geocoding.Sources
{
	/// <summary>
	/// Summary description for SourceException.
	/// </summary>
	public class SourceException : GeocodeException
	{
        public SourceException(string message, Exception e)
            :
            base(message, e)
        { }

		public SourceException(string message) :
			base(message)
		{
		}
	}
}
