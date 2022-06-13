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
    public class FamilyServices : IFamilyServices
    {
        readonly IFamilyRepository _familyRepository;
        readonly ICategoryServices _categoryServices;
        public FamilyServices(IFamilyRepository familyRepository, ICategoryServices categoryServices)
        {
            _familyRepository = familyRepository;
            _categoryServices = categoryServices;
        }
        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Family>> GetAll()
        {
            var families = await _familyRepository.GetAll();

            return families;
        }

        public async Task<Family> GetById(long Id)
        {
            var family = await _familyRepository.GetById(Id);
            return family;
        }

        public async Task<bool> Insert(Family family)
        {
            var category = await _categoryServices.GetById(family.CategoryId);

            if(category is not null)
            {
                if(family.Designaction.Equals(""))
                {
                    throw new Exception("A designação não pode ser nula");
                }  
                
                var familyInsert = await _familyRepository.Insert(family);

                if (familyInsert)
                {
                    return true;
                }
                return false;
            }
            else
            {
                throw new Exception("Categoria inexistente");
            }
        }

        public Task<bool> Update(Family family)
        {
            throw new NotImplementedException();
        }
    }
}
