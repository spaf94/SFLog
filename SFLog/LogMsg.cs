using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLog
{
    public class LogMsg
    {
        /// <summary>
        /// Exceptions the message.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        public static string ExceptionMessage(Exception exception)
        {
            StringBuilder sbExceptionMessage = new StringBuilder();
            sbExceptionMessage.AppendLine(exception.Message);
            sbExceptionMessage.AppendLine(exception.StackTrace);

            return sbExceptionMessage.ToString();
        }
    }
}
