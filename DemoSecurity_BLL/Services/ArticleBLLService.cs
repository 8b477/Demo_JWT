using DemoSecurity_BLL.Interface;
using DemoSecurity_DAL.Entities;
using DemoSecurity_DAL.Interface;

namespace DemoSecurity_BLL.Services
{
    public class ArticleBLLService : IArticleBLLService
    {
        private readonly IArticleRepository _userRepo;
        public ArticleBLLService(IArticleRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public IEnumerable<Article> GetAll()
        {
            return _userRepo.GetAll();
        }

        public Article GetById(int id)
        {
            return _userRepo.GetById(id);
        }

        public Task Create(Article article)
        {
            return _userRepo.Create(article);
        }

        public bool Delete(int id)
        {
            return _userRepo.Delete(id);

        }
    }
}
