using ECommerce.Models;

namespace ECommerce.API.Repositories
{
    public interface IUserRepository
    {
        List<User> Get();
        User Get(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
