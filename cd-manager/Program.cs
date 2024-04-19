using cd_manager;
using cd_manager.Users;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();



        userService.AfisareUser();

        //userService.SaveData();
    }
}
