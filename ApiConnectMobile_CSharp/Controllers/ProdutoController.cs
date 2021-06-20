using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiConnectMobile_CSharp.Data;
using ApiConnectMobile_CSharp.Models;
using ApiConnectMobile_CSharp.Interfaces.Service;

namespace ApiConnectMobile_CSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService clienteService)
        {
            _produtoService = clienteService;
        }

        // GET: api/Produto
        [HttpGet]
        public ICollection<ProdutoModel> GetProdutoModel()
        {
            return _produtoService.GetAll();
        }

        // GET: api/Produto/5
        [HttpGet("{id}")]
        public ActionResult<ProdutoModel> GetProdutoModel(Guid id)
        {
            var clienteModel = _produtoService.GetOne(id);

            if (clienteModel == null)
                return NotFound();

            return clienteModel;
        }

        // PUT: api/Produto/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutProdutoModel(Guid id, ProdutoModel produtomodel)
        {
            if (id != produtomodel.Id)
                return BadRequest();

            return Ok(_produtoService.PutOne(produtomodel));
        }

        // POST: api/Produto
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult<ProdutoModel> PostProdutoModel(ProdutoModel clienteModel)
        {
            _produtoService.PostOne(clienteModel);

            return CreatedAtAction("GetProdutoModel", new { id = clienteModel.Id }, clienteModel);
        }

        // DELETE: api/Produto/5
        [HttpDelete("{id}")]
        public ActionResult<ProdutoModel> DeleteProdutoModel(Guid id)
        {
            var clienteModel = _produtoService.GetOne(id);
            if (clienteModel == null)
                return NotFound();

            _produtoService.Delete(clienteModel);

            return clienteModel;
        }
    }
}
