using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class CategoryController : ControllerBase
    {
        readonly ICategoryServices _categoryServices;
        readonly IMapper _mapper;
        public CategoryController(ICategoryServices categoryServices, IMapper mapper)
        {
            _categoryServices = categoryServices;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Registar")]
        public async Task<IActionResult> InsertAsync(CategoryDTO dto)
        {

            try
            {
                var response = new Response();

                var categoryMapper = _mapper.Map<Category>(dto);

                var category = await _categoryServices.Insert(categoryMapper);

                if (category == true)
                {
                    response.Good("Categoria registada com sucesso");

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

                var category = await _categoryServices.GetAll();

                if (category.Count()!=0)
                {
                    var categoryMapper = _mapper.Map<IEnumerable<CategoryDTOAll>>(category);

                    response.Good("Lista de categorias", categoryMapper);

                    return Ok(response);
                }
                else
                {
                    response.Good("Lista vasia, não existe categorias");

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
