using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyami.Core.Entities;
using Xyami.Core.Interfaces.RepositoryInterfaces;
using Xyami.Core.Interfaces.ServicesInterfaces;

namespace Xyami.Services.Services
{
    public class CategoryServices: ICategoryServices
    {
        readonly ICategoryRepository _categoryRepository;

        public CategoryServices(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var categorys = await _categoryRepository.GetAll();

            return categorys;
        }

        public async Task<Category> GetById(long Id)
        {
            var category = await _categoryRepository.GetById(Id);

            return category;
        }

        public async Task<bool> Insert(Category category)
        {
            if(category.Designaction.Equals(""))
            {
                throw new Exception("A descrição é um campo obrigatório");
            }

            var categoryInsert = await _categoryRepository.Insert(category);
            
            if(categoryInsert)
            {
                return true;
            }
            return false;
        }

        public Task<bool> Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
