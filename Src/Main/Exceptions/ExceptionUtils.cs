using System;
using USC.GISResearchLab.Common.Utils.Files;
using USC.GISResearchLab.Common.Utils.Strings;

namespace USC.GISResearchLab.Common.Utils.Exceptions
{
    public class ExceptionUtils
    {
        public static string GetFullMessages(Exception e)
        {
            string ret = e.Message;
            Exception inner = e.InnerException;
            while (inner != null)
            {
                if (inner.Message != null && inner.Message != "")
                {
                    ret += Environment.NewLine;
                    ret += inner.Message;
                }
                inner = inner.InnerException;
            }
            return ret;
        }

        public static string PrepareErrorMessage2(Exception ex)
        {
            string[] l = null, a = null;
            if (ex.StackTrace != null)
                a = ex.StackTrace.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            else
                a = new string[0];
            string ret = ex.Message;

            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    l = a[i].Split(new string[1] { ") in " }, 2, StringSplitOptions.RemoveEmptyEntries);
                    l = l[1].Split(new string[1] { ":line " }, 2, StringSplitOptions.RemoveEmptyEntries);
                    a[i] = FileUtils.GetFileName(l[0]) + ":" + l[1];
                }
                catch
                {
                    a[i] = string.Empty;
                }
            }
            if (ex.InnerException != null) ret += Environment.NewLine + "Base: " + ex.GetBaseException().Message;
            ret += Environment.NewLine + "Stack: ";
            for (int i = 0; i < a.Length; i++) if (!StringUtils.IsEmpty(a[i])) ret += a[i] + ", ";
            if (ret.EndsWith(", ")) ret = ret.Substring(0, ret.Length - 2);
            if (ret.EndsWith(Environment.NewLine + "Stack: ")) ret = ret.Substring(0, ret.Length - 9);
            return ret;
        }

        public static string PrepareErrorMessage(Exception ex)
        {
            string[] l = null, a = null;
            if (ex.StackTrace != null)
            {
                a = ex.StackTrace.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                a = new string[0];
            }

            string ret = ex.Message;

            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    l = a[i].Split(new string[1] { ") in " }, 2, StringSplitOptions.RemoveEmptyEntries);
                    l = l[1].Split(new string[1] { ":line " }, 2, StringSplitOptions.RemoveEmptyEntries);
                    a[i] = FileUtils.GetFileName(l[0]) + ":" + l[1];
                }
                catch
                {
                    a[i] = string.Empty;
                }
            }

            if (ex.InnerException != null)
            {
                ret += Environment.NewLine + "Base: " + ex.GetBaseException().Message;
            }

            ret += Environment.NewLine + "Stack: ";

            for (int i = 0; i < a.Length; i++)
            {
                if (!StringUtils.IsEmpty(a[i]))
                {
                    ret += a[i] + ", ";
                }
            }

            if (ret.EndsWith(", "))
            {
                ret = ret.Substring(0, ret.Length - 2);
            }

            if (ret.EndsWith(Environment.NewLine + "Stack: "))
            {
                ret = ret.Substring(0, ret.Length - 9);
            }

            return ret;
        }
    }
}
