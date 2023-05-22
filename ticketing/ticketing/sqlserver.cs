using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace b3
{
    class sqlserver
    {
        public SqlConnection GetConn()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "data source=localhost\\sqlexpress; initial catalog=db_restoran; integrated security=true;";
            return Con;
        }
    }
}
