using ECommerce.API.Database;
using ECommerce.Models;

namespace ECommerce.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ECommerceContext _context;

        public UserRepository(ECommerceContext context)
        {
            _context = context;
        }

        public User Get(int id)
        {
            return _context.Users.Find(id)!;
        }

        public List<User> Get()
        {
            return _context.Users.OrderBy(x => x.Id).ToList();
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Users.Remove(Get(id));
            _context.SaveChanges();
        }
    }
}