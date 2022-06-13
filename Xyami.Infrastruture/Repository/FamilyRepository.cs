using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xyami.Core;
using Xyami.Core.Entities;
using Xyami.Core.Interfaces.RepositoryInterfaces;

namespace Xyami.Infrastruture.Repository
{
    public class FamilyRepository : IFamilyRepository
    {
        readonly DataContext _context;
        public FamilyRepository(DataContext context)
        {
            _context = context;
        }
        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Family>> GetAll()
        {
            try
            {
              var familys = await  _context.Families
                    .AsNoTracking()
                    .Include(x=>x.Category)
                    .ToListAsync();

                return familys;
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e.Message);
            }
        }

        public async Task<Family> GetById(long Id)
        {
            try
            {
                var family = await _context.Families.FindAsync(Id);
                return family;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> Insert(Family family)
        {
            try
            {
                _context.Families.Add(family);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception e)
            {
                throw new Exception("Erro: "+e.Message);
            }
        }

        public Task<bool> Update(Family category)
        {
            throw new NotImplementedException();
        }
    }
}
