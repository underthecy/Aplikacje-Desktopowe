using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homelogpro
{
    public class UsersRepository
    {
        public List<User> User {  get; set; }

        public UsersRepository()
        {
            User = new List<User>();
            User.Add(new User { Login = "admin", Password = "admin" });
            User.Add(new User { Login = "Chillguy123", Password = "ilovemacaronies" });
        }

    }
}
