using ECommerce.Models;

namespace ECommerce.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static List<User> _db = new List<User>();

        public User Get(int id)
        {
            return _db.Find(x => x.Id == id)!;
        }

        public List<User> Get()
        {
            return _db;
        }

        public void Add(User user)
        {
            _db.Add(user);
        }

        public void Update(User user)
        {
            _db.Remove(Get(user.Id));
            _db.Add(user);
        }

        public void Delete(int id)
        {
            _db.Remove(Get(id));
        }
    }
}