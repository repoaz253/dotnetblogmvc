using dotnetblog.Models;

namespace dotnetblog.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {

        void Update(Category obj);
        void Save();
    }
}
