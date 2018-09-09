using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoilGun_PC.Model
{
    public class DB_connection_model
    {
        private static string _DB_name= "DB2";

        public static string DB_name
        {
            get { return _DB_name; }
            set { _DB_name = value; }
        }

        private static string _TB_name = "tb";

        public static string TB_name
        {
            get { return _TB_name; }
            set { _TB_name = value; }
        }
    }
}
