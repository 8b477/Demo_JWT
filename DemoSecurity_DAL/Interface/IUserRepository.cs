using DemoSecurity_DAL.Entities;

namespace DemoSecurity_DAL.Interface
{
    public interface IUserRepository
    {
        string CheckPassword(string email);
        IEnumerable<User> GetUsers();
        User Login(string email);
        void Register(string nickname, string password, string email);
    }
}