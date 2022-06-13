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
    public class FamilyController : ControllerBase
    {
        readonly IFamilyServices _familyServices;
        readonly IMapper _mapper;
        public FamilyController(IFamilyServices familyServices, IMapper mapper)
        {
            _familyServices = familyServices;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Registar")]
        public async Task<IActionResult> InsertAsync(FamilyCreatDTO familyCreatDTO)
        {

            try
            {
                var response = new Response();

                var familyMapper = _mapper.Map<Family>(familyCreatDTO);

                var family = await _familyServices.Insert(familyMapper);

                if (family)
                {
                    response.Good("Família registada com sucesso");

                    return Ok(response);
                }
                else
                {
                    response.Bad("Ocorreu um erro ao registar família");

                    return BadRequest(response);
                }
            }
            catch (Exception e)
            {
                var response = new Response();

                response.Bad(e.Message);
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


                var families = await _familyServices.GetAll();

                if (families.Count() !=0)
                {
                    var familiesMapper = _mapper.Map<IEnumerable<FamilyDTO>>(families);

                    response.Good("Lista de famílias", familiesMapper);

                    return Ok(response);
                }
                else
                {
                    response.Good("Lista vasia, não existe famílias");

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
