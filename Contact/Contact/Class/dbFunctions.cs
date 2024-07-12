using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Contact.Class
{
    internal class dbFunctions
    {
        public static string ConnectionStringSQLite
        {
            get
            {
                string database = AppDomain.CurrentDomain.BaseDirectory +
                    "\\Database\\Contact.s3db";
                string connectionString =
                    @"Data Sourse=" + Path.GetFullPath(database);
                return connectionString;
            }
        }
    }
}
