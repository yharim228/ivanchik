using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class UserModel
    {

        public string Login { get; set; }
        public string Pass { get; set; }

        public UserModel(string login, string pass)

        {
            Login = login;
            Pass = pass;
        }
    }
}
