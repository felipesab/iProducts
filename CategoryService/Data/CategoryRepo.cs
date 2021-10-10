using System;
using System.Collections.Generic;
using System.Linq;
using CategoryService.Models;

namespace CategoryService.Data
{
    public class CategoryRepo : ICategoryRepo
    {
        private AppDbContext _context { get; }
        
        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public void Create(Category category)
        {
            if(category == null)
            {
                throw new ArgumentNullException(nameof(category)); 
            }

            _context.Categories.Add(category);
        }

        public void Remove(Category category)
        {
            if(category == null)
            {
                throw new ArgumentNullException(nameof(category)); 
            }
            
            _context.Categories.Remove(category);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}