using System;
using System.Collections.Generic;
using aspnetDDD.Application.Dtos;
using aspnetDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aspnetDDD.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationSeviceProduto;

        public ProdutoController(IApplicationServiceProduto applicationSeviceProduto)
        {
            this._applicationSeviceProduto = applicationSeviceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationSeviceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid id)
        {
            return Ok(_applicationSeviceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto ProdutoDto)
        {
            try
            {
                if (ProdutoDto == null)
                {
                    return NotFound();
                }
                _applicationSeviceProduto.Add(ProdutoDto);
                return Ok("Produto cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto ProdutoDto)
        {
            try
            {
                if (ProdutoDto == null)
                {
                    return NotFound();
                }
                _applicationSeviceProduto.Update(ProdutoDto);
                return Ok("Produto atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProdutoDto ProdutoDto)
        {
            try
            {
                if (ProdutoDto == null)
                {
                    return NotFound();
                }
                _applicationSeviceProduto.Remove(ProdutoDto);
                return Ok("Cliente deletado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
