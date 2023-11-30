using DemoSecurity_DAL.Entities;

namespace DemoSecurity_BLL.Interface
{
    public interface IUserBLLService
    {
        void Register(string nickname, string password, string email);
        User Login(string email, string password);
        IEnumerable<User> GetUsers();
    }
}