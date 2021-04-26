using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMAIL_System
{
    class SQLLogin
    {
        public static IQueryable<LoginData> LOGIN(string email, string password)
        {
            LINQCLASSDataContext db = new LINQCLASSDataContext();
            var tmp = from log in db.LoginDatas
                      where log.Email == email && log.Pass == password
                      select log;
            return tmp;
        }
    }
}
