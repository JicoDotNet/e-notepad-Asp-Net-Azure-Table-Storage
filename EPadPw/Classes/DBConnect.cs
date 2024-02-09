﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace EPadPw.Classes
{
    //public class DBConnect
    //{
    //    public static object NoSqlConnection { get; } = WebConfigurationManager.AppSettings["NoSqlConnection"].ToString();
    //}
    /// <summary>
    /// Provides access to database connection settings.
    /// </summary>
    public static class DBConnect
    {
        /// <summary>
        /// Gets the connection string for the NoSqlConnection.
        /// </summary>
        public static string NoSqlConnection { get; }

        // Static constructor to initialize the static property
        static DBConnect()
        {
            // Retrieve connection string from web configuration
            NoSqlConnection = WebConfigurationManager.AppSettings["NoSqlConnection"];
        }
    }
}
