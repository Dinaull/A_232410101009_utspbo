using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uts.apss.core;

namespace uts.apss.Context
{
    internal class KontakContext : DataBase
    {
        private static string table = "admin";
        public static DataTable All()
        {
            string query = @"
            SELECT
            m.id,
            m.username,
            m.password,";


        }
    }
}
