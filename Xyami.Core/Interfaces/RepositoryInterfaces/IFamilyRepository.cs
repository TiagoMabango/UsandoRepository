using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyami.Core.Entities;

namespace Xyami.Core.Interfaces.RepositoryInterfaces
{
    public interface IFamilyRepository
    {
        Task<bool> Insert(Family family);
        Task<bool> Update(Family family);
        Task<bool> Delete(long id);
        Task<IEnumerable<Family>> GetAll();
        Task<Family> GetById(long Id);
    }
}
