using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xyami.API.Helpers;
using Xyami.Core.DTOs;
using Xyami.Core.Entities;
using Xyami.Core.Interfaces.ServicesInterfaces;

namespace Xyami.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductServices _productServices;
        readonly IMapper _mapper;
        public ProductController(IProductServices productServices, IMapper mapper)
        {
            _productServices = productServices;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Registar")]
        public async Task<IActionResult> InsertAsync(ProductCreatDTO productCreatDTO)
        {

            try
            {
                var response = new Response();

                var productMapper = _mapper.Map<Product>(productCreatDTO);

                var product = await _productServices.Insert(productMapper);

                if (product == true)
                {
                    response.Good("Producto registado com sucesso");

                    return Ok(response);
                }
                else
                {
                    response.Bad("Ocorreu um erro ao registar a categoria");

                    return BadRequest(response);
                }
            }
            catch (Exception e)
            {
                var response = new Response();

                response.Bad("Erro: " + e.Message);
                return BadRequest(response);
            }
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var response = new Response();

                var product = await _productServices.GetAll();

                if (product.Count() != 0)
                {
                    var productMapper = _mapper.Map<IEnumerable<ProductDTO>>(product);

                    response.Good("Lista de productos", productMapper);

                    return Ok(response);
                }
                else
                {
                    response.Good("Lista vasia, não existe produtos");

                    return Ok(response);
                }
            }
            catch (Exception e)
            {
                var response = new Response();

                response.Bad("Erro: " + e.Message);
                return BadRequest(response);
            }
        }
    }
}
