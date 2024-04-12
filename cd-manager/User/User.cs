using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager.User
{
    public class User
    {
        private int _id;
        private string _email;
        private string _password;
        private string _phone;

        public User(int id, string email, string password, int phone)
        {
            _id = id;
            _email = email;
            _password = password;
            _id = id;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string UserInfo()
        {
            string text = " ";
            text += "Id" + Id + "\n";
            text += "Email " + Email + "\n";
            text += "Password " + Password + "\n";
            text += "Phone " + Phone + "\n";
            return text;
        }
    }
}
