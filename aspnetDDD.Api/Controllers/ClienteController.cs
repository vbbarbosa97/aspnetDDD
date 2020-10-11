using System;
using System.Collections.Generic;
using aspnetDDD.Application.Dtos;
using aspnetDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aspnetDDD.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationSeviceCliente;

        public ClienteController(IApplicationServiceCliente applicationSeviceCliente)
        {
            this._applicationSeviceCliente = applicationSeviceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationSeviceCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_applicationSeviceCliente.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                _applicationSeviceCliente.Add(clienteDto);
                return Ok("Cliente cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                _applicationSeviceCliente.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                {
                    return NotFound();
                }
                _applicationSeviceCliente.Remove(clienteDto);
                return Ok("Cliente deletado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
