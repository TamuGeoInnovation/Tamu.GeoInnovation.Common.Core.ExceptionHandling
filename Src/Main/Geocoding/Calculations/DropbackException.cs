using System;

namespace USC.GISResearchLab.Common.Exceptions.Geocoding.Calculations
{
	/// <summary>
	/// Summary description for DropbackDirectionException.
	/// </summary>
	public class DropbackException : GeocodeException
	{
        public DropbackException(string message, Exception e)
            :
            base(message, e)
        { }

        public DropbackException(string message)
            :
			base(message)
		{}
	}
}
