using System.Collections.Generic;
using CategoryService.Models;

namespace CategoryService.Data
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void Create(Category category);
        void Remove(Category category);
        bool SaveChanges();
    }
}