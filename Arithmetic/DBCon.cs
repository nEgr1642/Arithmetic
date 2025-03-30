using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Arithmetic
{
    internal class DBCon
    {
        SqlConnection con1 = new SqlConnection(@"Data Source = DESKTOP-3JGAILD; Database = ArithmeticTasksDB; Integrated Security=true;");

        public void OpenCon()
        {
            if (con1.State == System.Data.ConnectionState.Closed)
            {
                con1.Open();
            }
        }
        public void CloseCon()
        {
            if (con1.State == System.Data.ConnectionState.Open)
            {
                con1.Close();
            }
        }
        public SqlConnection GetCon()
        {
            return con1;
        }
    }
}
