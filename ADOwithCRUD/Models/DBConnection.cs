using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ADOwithCRUD.Models
{
    public class dbConnection
    {
        public SqlConnection Connection;
        public dbConnection()
        {
            Connection = new SqlConnection(DBConfig.ConnectionStr);
        }
    }
}
