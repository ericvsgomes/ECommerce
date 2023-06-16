using ECommerce.Models;

namespace ECommerce.API.Repository
{
    public class UserRepository : IUserRepository
    {
        public static List<User> _db = new List<User>();

        public User GetUser(int id)
        {
            return _db.Find(x => x.Id == id)!;
        }

        public List<User> GetUsers()
        {
            return _db;
        }

        public void Add(User user)
        {
            _db.Add(user);
        }

        public void Update(User user)
        {
            _db.Remove(GetUser(user.Id));
            _db.Add(user);
        }

        public void Delete(int id)
        {
            _db.Remove(GetUser(id));
        }
    }
}