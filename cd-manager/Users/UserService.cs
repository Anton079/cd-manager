using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd_manager.Users
{
    public class UserService
    {
        private List<User> _userS;

        public UserService()
        {
            _userS = new List<User>();
            LoadData();
        }

        //preluarea de date
        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(this.GetFilePath()))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                       
                        User user   = new User(line);
                        this._userS.Add(user);
                    }

                }
            } 
            
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public int FindUserById(int id)
        {
            for(int i = 0; i < _userS.Count; i++)
            {
                if (_userS[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddUser(User user)
        {
            if(FindUserById(user.Id) == -1)
            {
                this._userS.Add(user);
                return true;
            }
            return false;
        }

        public void AfisareUser()
        {
            foreach(User x in _userS)
            {
                Console.WriteLine(x.UserInfo());
            }
        }




        //sa iau file ul
        private String GetFilePath()
        {

            string cureentDirecory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(cureentDirecory, "data");

            string file = Path.Combine(folder, "users");

            return file;
        }

        //functie ca sa salvez tot
        public string ToSaveAll()
        {
            String save = "";

            for (int i = 0; i < _userS.Count-1; i++)
            {
                save += _userS[i].ToSave() + "\n";
            }

             save += _userS[_userS.Count - 1].ToSave();

            return save;
        }

        // functia de salvare in file
        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.GetFilePath()))
                {                   
                    sw.Write(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void GenerateNr()
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 10000000);
        }
    }
}
