﻿using MIAS_CoolStorage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vici.CoolStorage;

namespace MIAS_CoolStorage
{
    public static class DB
    {
        public const string CONTEXT = "mias";

        public static void InitDB(string connectionString, string context)
        {
            CSConfig.SetDB(new CSDataProviderSqlServer(connectionString), context);
        }
    }
}
