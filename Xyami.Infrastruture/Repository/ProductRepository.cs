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
    public class ProductRepository : IProductRepository
    {
        readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            try
            {
                var products = await _context.Products
                .Include(x => x.Family)
                .ThenInclude(x => x.Category)
                .AsNoTracking()
                .ToListAsync();

                return products;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Product> GetById(long Id)
        {
            try
            {
                var product = await _context.Products.FindAsync(Id);
                return product;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> Insert(Product product)
        {
            try
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Task<bool> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
