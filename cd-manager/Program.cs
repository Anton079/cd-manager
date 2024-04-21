using cd_manager;
using cd_manager.Users;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();

        User UserTest = new User(6, "Salahat@gmail.com", "gdhgehe", 07641341);


        userService.AddUser(UserTest);





        userService.SaveData();


    }
}
