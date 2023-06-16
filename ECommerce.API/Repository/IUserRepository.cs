using ECommerce.Models;

namespace ECommerce.API.Repository
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
