﻿using System;
using System.Text;
using System.Web.Script.Serialization;

namespace SFLog
{
    public class LogMsg
    {
        #region Members

        /// <summary>
        /// The java script serializer
        /// </summary>
        private static JavaScriptSerializer javaScriptSerializer = null;

        #endregion Members

        #region Properties

        /// <summary>
        /// Gets the java script serializer.
        /// </summary>
        /// <value>
        /// The java script serializer.
        /// </value>
        public static JavaScriptSerializer JavaScriptSerializer
        {
            get
            {
                if (javaScriptSerializer == null)
                {
                    javaScriptSerializer = new JavaScriptSerializer();
                }

                return javaScriptSerializer;
            }
        }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Gets the exception message.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        public static string GetExceptionMessage(Exception exception)
        {
            if (exception == null)
                return string.Empty;

            StringBuilder builder = new StringBuilder();
            Exception _exception = exception;
            builder.AppendLine(_exception.Message);

            while (_exception.InnerException != null)
            {
                _exception = _exception.InnerException;
                builder.AppendLine(_exception.Message);
            }

            builder.AppendLine(exception.StackTrace);
            return builder.ToString();
        }

        /// <summary>
        /// Gets the json string.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static string GetJSONString(object obj)
        {
            return (JavaScriptSerializer.Serialize(obj));
        }

        #endregion Public Methods
    }
}