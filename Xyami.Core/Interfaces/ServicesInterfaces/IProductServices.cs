using System.Collections.Generic;
using System.Threading.Tasks;
using Xyami.Core.Entities;

namespace Xyami.Core.Interfaces.ServicesInterfaces
{
    public interface IProductServices
    {
        Task<bool> Insert(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(long id);
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(long Id);
    }
}
