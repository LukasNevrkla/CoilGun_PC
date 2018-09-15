using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoilGun_PC.Model
{
    public class DB_connection_model
    {
        private static string _server_name = "PC_LUKY";

        public static string Server_name
        {
            get { return _server_name; }
            set { _server_name = value; }
        }

        private static string _DB_name= "Library";

        public static string DB_name
        {
            get { return _DB_name; }
            set { _DB_name = value; }
        }

        private static string _TB_name = "Books";

        public static string TB_name
        {
            get { return _TB_name; }
            set { _TB_name = value; }
        }
    }
}
