namespace USC.GISResearchLab.Common.Exceptions.Geocoding.Methods.UniformLot
{
	/// <summary>
	/// Summary description for NoAddressesException.
	/// </summary>
	public class NeitherSideAddressException: UniformLotException
	{
		public NeitherSideAddressException(string message) :
			base(message)
		{
		}
	}
}
