using ECommerceWebsite.Models;

namespace ECommerceWebsite.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUser();
        User GetUserById(int id);
        int AddUser(User user);
        int UpdateUser(User user);
        int DeleteUser(int id);
    }
}
