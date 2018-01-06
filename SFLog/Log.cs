using System;
using System.IO;

namespace SFLog
{
    public class Log
    {
        #region Constants

        /// <summary>
        /// The debug tag
        /// </summary>
        private const string DebugTag = "DEBUG";

        /// <summary>
        /// The error tag
        /// </summary>
        private const string ErrorTag = "ERROR";

        /// <summary>
        /// The information tag
        /// </summary>
        private const string InfoTag = "INFO ";

        /// <summary>
        /// The warn tag
        /// </summary>
        private const string WarnTag = "WARN ";

        #endregion Constants

        #region Members

        /// <summary>
        /// The log file
        /// </summary>
        private static string logFile = null;

        /// <summary>
        /// The log file name
        /// </summary>
        private static string logFileName = null;

        /// <summary>
        /// The logs path
        /// </summary>
        private static string logsPath = null;

        /// <summary>
        /// The temporary log file name
        /// </summary>
        private static string tempLogFileName = "log";

        /// <summary>
        /// The temporary logs folder name
        /// </summary>
        private static string tempLogsFolderName = "logs";

        #endregion Members

        #region Properties

        /// <summary>
        /// Gets the string date.
        /// </summary>
        /// <value>
        /// The string date.
        /// </value>
        public static string StringDate
        {
            get
            {
                return DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Gets the log file.
        /// </summary>
        /// <value>
        /// The log file.
        /// </value>
        private static string LogFile
        {
            get
            {
                if (string.IsNullOrWhiteSpace(logFile))
                {
                    logFile = Path.Combine(LogsPath, LogFileName);
                }

                return logFile;
            }
        }

        /// <summary>
        /// Gets the name of the log file.
        /// </summary>
        /// <value>
        /// The name of the log file.
        /// </value>
        private static string LogFileName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(logFileName))
                {
                    logFileName = string.Format("{0}_{1}.log", tempLogFileName, DateTime.Today.ToString("yyyyMMdd"));
                }

                return logFileName;
            }
        }

        /// <summary>
        /// Gets the logs path.
        /// </summary>
        /// <value>
        /// The logs path.
        /// </value>
        private static string LogsPath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(logsPath))
                {
                    logsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tempLogsFolderName);
                }

                return logsPath;
            }
        }

        #endregion Properties

        #region Public Methods

        #region Set

        /// <summary>
        /// Sets the name of the log file.
        /// </summary>
        /// <param name="logFileName">Name of the log file.</param>
        public static void SetLogFileName(string logFileName)
        {
            tempLogFileName = logFileName;
        }

        /// <summary>
        /// Sets the name of the logs folder.
        /// </summary>
        /// <param name="logsFolderName">Name of the logs folder.</param>
        public static void SetLogsFolderName(string logsFolderName)
        {
            tempLogsFolderName = logsFolderName;
        }

        #endregion Set

        #region Debug

        /// <summary>
        /// Debugs the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <param name="message">The message.</param>
        public static void Debug(Type type, string method, string message)
        {
            WriteLogMessage(DebugTag, type.FullName, method, message);
        }

        /// <summary>
        /// Debugs the specified class object.
        /// </summary>
        /// <param name="classObject">The class object.</param>
        /// <param name="method">The method.</param>
        /// <param name="message">The message.</param>
        public static void Debug(object classObject, string method, string message)
        {
            WriteLogMessage(DebugTag, classObject.GetType().FullName, method, message);
        }

        #endregion Debug

        #region Error

        /// <summary>
        /// Errors the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <param name="exception">The exception.</param>
        public static void Error(Type type, string method, Exception exception)
        {
            WriteLogMessage(ErrorTag, type.FullName, method, LogMsg.GetExceptionMessage(exception));
        }

        /// <summary>
        /// Errors the specified class object.
        /// </summary>
        /// <param name="classObject">The class object.</param>
        /// <param name="method">The method.</param>
        /// <param name="exception">The exception.</param>
        public static void Error(object classObject, string method, Exception exception)
        {
            WriteLogMessage(ErrorTag, classObject.GetType().FullName, method, LogMsg.GetExceptionMessage(exception));
        }

        #endregion Error

        #region Info

        /// <summary>
        /// Informations the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <param name="message">The message.</param>
        public static void Info(Type type, string method, string message)
        {
            WriteLogMessage(InfoTag, type.FullName, method, message);
        }

        /// <summary>
        /// Informations the specified class object.
        /// </summary>
        /// <param name="classObject">The class object.</param>
        /// <param name="method">The method.</param>
        /// <param name="message">The message.</param>
        public static void Info(object classObject, string method, string message)
        {
            WriteLogMessage(InfoTag, classObject.GetType().FullName, method, message);
        }

        #endregion Info

        #region Warn

        /// <summary>
        /// Warns the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <param name="message">The message.</param>
        public static void Warn(Type type, string method, string message)
        {
            WriteLogMessage(WarnTag, type.FullName, method, message);
        }

        /// <summary>
        /// Warns the specified class object.
        /// </summary>
        /// <param name="classObject">The class object.</param>
        /// <param name="method">The method.</param>
        /// <param name="message">The message.</param>
        public static void Warn(object classObject, string method, string message)
        {
            WriteLogMessage(WarnTag, classObject.GetType().FullName, method, message);
        }

        #endregion Warn

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Writes the log message.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <param name="type">The type.</param>
        /// <param name="method">The method.</param>
        /// <param name="message">The message.</param>
        private static void WriteLogMessage(string level, string type, string method, string message)
        {
            try
            {
                string log = string.Format("{0} | {1} | {2} | {3} | {4}", StringDate, level, type, method, message);

                if (!Directory.Exists(LogsPath))
                {
                    Directory.CreateDirectory(LogsPath);
                }

                using (StreamWriter streamWriter = File.AppendText(LogFile))
                {
                    streamWriter.WriteLine(log);
                    Console.WriteLine(log);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(LogMsg.GetExceptionMessage(exception));
            }
        }

        #endregion Private Methods
    }
}