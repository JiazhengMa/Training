using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSystem.db
{
    public class Login
    {
        static public int LoginCheck(string user, string password)
        {
            Object count = SqlHelper.ExecScalar(string.Format("select type from UserTable where name = '{0}' and pass = '{1}'", user, password));
            if (count == null)
            {
                return -1;
            }
            return (int)count;
        }

        static public string GetID(string user, string password)
        {
            Object count = SqlHelper.ExecScalar(string.Format("select id from UserTable where name = '{0}' and pass = '{1}'", user, password));
            if (count == null)
            {
                return "";
            }
            return count.ToString();
        }
    }
}
 