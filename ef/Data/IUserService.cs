using efTest.Entity;

namespace efTest.Data
{
    public interface IUserService
    {
        User GetUser(Guid id);
        User GetUser(string name);
        User GetUser(string name, string password);
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(Guid id);
    }
}