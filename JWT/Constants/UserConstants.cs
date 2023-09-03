using JWT.Models;

namespace JWT.Constants
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {Username = "jperez", Password = "123456", Rol = "administrador", EmailAddress = "jperez@gmail", FirstName ="Juan", LastName ="Perez"},
            new UserModel() {Username = "cgonzalesf", Password = "123456", Rol = "coordinador", EmailAddress = "cgonzales@gmail", FirstName ="cesar", LastName ="gonzalez"}
        };
    }
}
