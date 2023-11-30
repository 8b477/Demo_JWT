using DemoSecurity_DAL.Entities;


namespace DemoSecurity_DAL.Interface
{
    public interface IArticleRepository
    {
        Task Create(Article article);
        IEnumerable<Article> GetAll();
        Article GetById(int id);
        bool Delete(int id);
    }
}
