﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLib;

namespace MochaMemoirs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var language = ConfigurationManager.AppSettings["language"];

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            IDatabaseService database = new DatabaseSystem(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "database.db"));
            
            // database.createUsersTable();
            // database.createBooksTable();
            // database.createGenresTable();
            // database.createBookGenresTable();
            // database.createUserLibrariesTable();
            // database.createUserLibraryBooksTable();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MochaMemoirsForm(database));
        }
    }
}
