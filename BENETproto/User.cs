using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    class User
    {
        static string Username;
        static string Password;
        public static string username
        {
            get
            {
                return Username;
            }
            set
            {
                Username = value;
            }
        }
        public static string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
}
