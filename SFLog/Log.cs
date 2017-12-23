﻿using System;
using System.IO;

namespace SFLog
{
    public class Log
    {
        #region Constants

        private const string DebugTag = "DEBUG";
        private const string ErrorTag = "ERROR";
        private const string InfoTag = "INFO ";
        private const string WarnTag = "WARN ";

        #endregion Constants

        #region Members

        private static string logFile = null;
        private static string logFileName = null;
        private static string logsPath = null;

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
                    logFileName = string.Format("log_{0}.log", DateTime.Today.ToString("yyyyMMdd"));
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
                    logsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
                }

                return logsPath;
            }
        }

        #endregion Properties

        #region Public Methods

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
            WriteLogMessage(ErrorTag, type.FullName, method, LogMsg.ExceptionMessage(exception));
        }

        /// <summary>
        /// Errors the specified class object.
        /// </summary>
        /// <param name="classObject">The class object.</param>
        /// <param name="method">The method.</param>
        /// <param name="exception">The exception.</param>
        public static void Error(object classObject, string method, Exception exception)
        {
            WriteLogMessage(ErrorTag, classObject.GetType().FullName, method, LogMsg.ExceptionMessage(exception));
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
                Console.WriteLine(LogMsg.ExceptionMessage(exception));
            }
        }

        #endregion Private Methods
    }
}