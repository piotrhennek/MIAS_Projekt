﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic.Repository
{
    public interface IDbConnection
    {
        List<long> RunQuery(string query, int replies);
    }
}
