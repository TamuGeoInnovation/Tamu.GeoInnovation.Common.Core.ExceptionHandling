namespace USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters
{
	/// <summary>
	/// Summary description for GeocodeParameterError.
	/// </summary>
	public class ParameterException : GeocodeException
	{
		public ParameterException(string message): 
			base (message)
		{
		}
	}
}
