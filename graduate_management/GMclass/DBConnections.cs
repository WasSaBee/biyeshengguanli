using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace graduate_management.GMclass
{
    class DBConnections
    {
        public static SqlConnection conn()
        {
            return new SqlConnection(@"server=.;database=graduate_management;uid=sa;pwd=123456");
        }
    }
}
