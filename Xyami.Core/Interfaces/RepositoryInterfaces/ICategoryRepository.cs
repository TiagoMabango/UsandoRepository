using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xyami.Core.Entities;

namespace Xyami.Core.Interfaces.RepositoryInterfaces
{
    public interface ICategoryRepository
    {
        Task<bool> Insert(Category category);
        Task<bool> Update(Category category);
        Task<bool> Delete(long id);
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(long Id);
    }
}
