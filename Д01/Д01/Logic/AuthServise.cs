using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO.Model;

namespace DO.Logic
{
    public class AuthServise
    {
        private List<User>_users;
        public AuthServise()
        {
            _users = new List<User>()
            {
                new User("Login","Pass")
            };
        }
        public bool CheckData(string login,string pass) 
        {
            var user = _users.FirstOrDefault(u => u.Login == login && u.Pass == pass);
            if (user != null && user.Pass == pass )
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
