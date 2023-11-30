
using DemoSecurity_DAL.Entities;

namespace DemoSecurity_BLL.Interface
{
    public interface IArticleBLLService
    {
        Task Create(Article article);
        bool Delete(int id);
        IEnumerable<Article> GetAll();
        Article GetById(int id);
    }
}