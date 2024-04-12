using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager
{
    public class UserService
    {
        private List<User> _userS;

        public UserService()
        {
            _userS = new List<User>();
            this.LoadData();
        }

        public void LoadData()
        {
            User User1 = new User(1, "Ariana@gmail.com", "grsthtdxr", 073643634);
            User User2 = new User(2, "Mahito@gmail.com", "hytdjdt", 076986789);
            User User3 = new User(3, "Arhandel@gmail.com", "jdftyjdf", 078756985);
            User User4 = new User(4, "Marinto@gmail.com", "gerges", 0797569567);
            User User5 = new User(5, "Alex@gmail.com", "jktfrk", 0756478);

            this._userS.Add(User1);
            this._userS.Add(User2);
            this._userS.Add(User3);
            this._userS.Add(User4);
            this._userS.Add(User5);
        }


    }
}
