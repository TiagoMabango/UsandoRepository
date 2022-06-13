using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xyami.Core;
using Xyami.Core.Entities;
using Xyami.Core.Interfaces.RepositoryInterfaces;

namespace Xyami.Infrastruture.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public Task<bool> Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var categorys = await _context.Categories
                .AsNoTracking()
                .Include(x=>x.Families)
                .ToListAsync();

            return categorys;
        }

        public async Task<Category> GetById(long Id)
        {
            var categorys = await _context.Categories.FindAsync(Id);
            return categorys;
        }

        public async Task<bool> Insert(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception e)
            {
                throw new Exception("Erro: "+e);
            }
        }

        public async Task<bool> Update(Category category)
        {
            try
            {
                var categoryFind = await GetById(category.CategoryId);

                if (categoryFind is not null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
