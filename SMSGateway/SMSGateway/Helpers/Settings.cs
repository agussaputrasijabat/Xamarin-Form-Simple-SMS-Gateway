﻿using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SMSGateway
{
    public class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string MySQLServer
        {
            get => AppSettings.GetValueOrDefault(nameof(MySQLServer), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(MySQLServer), value);
        }

        public static string MySQLUser
        {
            get => AppSettings.GetValueOrDefault(nameof(MySQLUser), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(MySQLUser), value);
        }

        public static string MySQLPassword
        {
            get => AppSettings.GetValueOrDefault(nameof(MySQLPassword), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(MySQLPassword), value);
        }

        public static string MySQLDatabase
        {
            get => AppSettings.GetValueOrDefault(nameof(MySQLDatabase), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(MySQLDatabase), value);
        }
    }
}
