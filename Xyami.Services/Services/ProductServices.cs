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
    public class ProductServices : IProductServices
    {
        readonly IProductRepository _productRepository;
        readonly IFamilyServices _familyServices;
        public ProductServices(IProductRepository productRepository, IFamilyServices familyServices)
        {
            _productRepository = productRepository;
            _familyServices = familyServices;
        }
        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _productRepository.GetAll();
            return products;
        }

        public async Task<Product> GetById(long Id)
        {
            var product = await _productRepository.GetById(Id);
            return product;
        }

        public async Task<bool> Insert(Product product)
        {
            var family = await _familyServices.GetById(product.FamilyId);

            if(family is not null)
            {
                if(product.Name.Equals(""))
                {
                    throw new Exception("Nome é um campo obrigatório");
                }

                product.DateInsert = DateTime.Now;
                product.State = true;

                var productInsert = await _productRepository.Insert(product);

                if(productInsert)
                {
                    return true;
                }
                return false;

            }
            else
            {
                throw new Exception("Família inexistente");
            }
        }

        public Task<bool> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
