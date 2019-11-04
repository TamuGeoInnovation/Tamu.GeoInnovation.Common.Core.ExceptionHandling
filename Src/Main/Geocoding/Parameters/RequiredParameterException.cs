namespace USC.GISResearchLab.Common.Exceptions.Geocoding.Parameters
{
    /// <summary>
    /// Summary description for RequiredParameterException.
    /// </summary>
    public class RequiredParameterException : ParameterException
    {
        public RequiredParameterException(string message) :
            base(message)
        {
        }
    }
}
