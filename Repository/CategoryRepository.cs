using dotnetblog.Data;
using dotnetblog.Models;
using dotnetblog.Repository.IRepository;
using System.Linq.Expressions;

namespace dotnetblog.Repository
{
    public class CategoryRepository :Repository<Category> ,ICategoryRepository
    {

        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context) : base(context) 
        {
            _context = context;
            
        }

        public void Save()
        {
           _context.SaveChanges();
        }


        public void Update(Category obj)
        {
           _context.Categories.Update(obj);
        }
    }
}

//5 16 12