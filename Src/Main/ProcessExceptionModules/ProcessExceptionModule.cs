using System;
using System.Data;
using USC.GISResearchLab.Common.Threading.ProgressStates;

namespace USC.GISResearchLab.Common.Exceptions.ProcessExceptionModules
{
    public class ProcessExceptionModule
    {
        #region Properties

        public string ProcessExceptionGuid { get; set; }
        public string UserGuid { get; set; }
        public string ServiceGuid { get; set; }
        public string DatabaseGuid { get; set; }
        public string TableGuid { get; set; }
        public string RecordId { get; set; }
        public string TransactionGuid { get; set; }
        public string ProcessGuid { get; set; }
        public ExceptionFatalityType ExceptionFatalityType { get; set; }
        public ExceptionOccuranceType ExceptionOccuranceType { get; set; }
        public Exception Exception { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionReason { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionStacktrace { get; set; }
        public int NumberOfErrors { get; set; }
        public int NumberOfRepeatedErrors { get; set; }


        #endregion


        public static new ProcessExceptionModule FromDataRow(DataRow dataRow)
        {
            ProcessExceptionModule ret = new ProcessExceptionModule();
            ret.ProcessExceptionGuid = Convert.ToString(dataRow["ProcessExceptionGuid"]);
            ret.UserGuid = Convert.ToString(dataRow["UserGuid"]);
            ret.ServiceGuid = Convert.ToString(dataRow["ServiceGuid"]);
            ret.DatabaseGuid = Convert.ToString(dataRow["DatabaseGuid"]);
            ret.TableGuid = Convert.ToString(dataRow["TableGuid"]);
            ret.RecordId = Convert.ToString(dataRow["RecordId"]);
            ret.TransactionGuid = Convert.ToString(dataRow["TransactionGuid"]);
            ret.ProcessGuid = Convert.ToString(dataRow["ProcessGuid"]);
            ret.ExceptionFatalityType = (ExceptionFatalityType)Enum.Parse(typeof(ExceptionFatalityType), Convert.ToString(dataRow["ExceptionFatalityType"]));
            ret.ExceptionOccuranceType = (ExceptionOccuranceType)Enum.Parse(typeof(ExceptionOccuranceType), Convert.ToString(dataRow["ExceptionOccuranceType"]));
            ret.ExceptionType = Convert.ToString(dataRow["ExceptionType"]);
            ret.ExceptionReason = Convert.ToString(dataRow["ExceptionReason"]);
            ret.ExceptionMessage = Convert.ToString(dataRow["ExceptionMessage"]);
            ret.ExceptionStacktrace = Convert.ToString(dataRow["ExceptionStacktrace"]);
            ret.NumberOfErrors = Convert.ToInt32(dataRow["NumberOfErrors"]);
            ret.NumberOfRepeatedErrors = Convert.ToInt32(dataRow["NumberOfRepeatedErrors"]);


            return ret;
        }

        public ProcessExceptionModule()
        {
        }


    }
}
