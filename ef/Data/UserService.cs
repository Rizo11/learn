using efTest.Entity;

namespace efTest.Data
{
    public class UserService : IUserService
    {
        private readonly UserDataContext _context;

        public UserService(UserDataContext context)
        {
            _context = context;
        }
        
        public User GetUser(Guid id)
        {
            return _context.Users.Find(id);
        }

        public User GetUser(string name)
        {
            return _context.Users.FirstOrDefault(u => u.Name == name);
        }

        public User GetUser(string name, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Name == name && u.Password == password);
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }

        public void DeleteUser(Guid id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
