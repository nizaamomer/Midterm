using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class connection
    {
        public static SqlConnection conn = null;
        public void dbconnect()
        {
            conn = new SqlConnection("Data Source=NIZAM-PC\\NIZAM;Initial Catalog=forlogin;Integrated Security=True");
            conn.Open();    
        }
        public void dbClose()
        {
            conn.Close();       
        }
    }
}
