using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    public static class AuthInfo
    {
        public static string UserName { get; private set; }
        public static string UserSurname { get; private set; }
        public static string UserClass { get; private set; }

        public static void SetAuthenticatedUser(string userName, string userSurname, string userClass)
        {
            UserName = userName;
            UserSurname = userSurname;
            UserClass = userClass;
        }
    }
}
