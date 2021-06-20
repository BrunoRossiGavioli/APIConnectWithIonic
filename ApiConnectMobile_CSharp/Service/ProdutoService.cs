using ApiConnectMobile_CSharp.Interfaces.Repository;
using ApiConnectMobile_CSharp.Interfaces.Service;
using ApiConnectMobile_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnectMobile_CSharp.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _prodRepo;

        public ProdutoService(IProdutoRepository prodRepo)
        {
            _prodRepo = prodRepo;
        }

        public ICollection<ProdutoModel> GetAll()
        {
            return _prodRepo.GetAll();
        }

        public ProdutoModel GetOne(Guid id)
        {
            return _prodRepo.GetOne(id);
        }

        public string PostOne(ProdutoModel model)
        {
            return _prodRepo.PostOne(model);
        }

        public string PutOne(ProdutoModel model)
        {
            return _prodRepo.PutOne(model);
        }
        public string Delete(ProdutoModel model)
        {
            return _prodRepo.Delete(model);
        }
    }
}
