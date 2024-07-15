using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringImages.Model
{
    internal class dbFunctions
    {
        public static string ConnectionStringSQLite
        {
            get
            {
                string database =
                AppDomain.CurrentDomain.BaseDirectory +
               "\\Database\\Contact.s3db";
                string connectionString =
                @"Data Source=" + Path.GetFullPath(database);
                return connectionString;
            }
        }
    }
}
