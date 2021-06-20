using ApiConnectMobile_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnectMobile_CSharp.Interfaces.Service
{
    public interface IProdutoService
    {
        public ICollection<ProdutoModel> GetAll();

        public string PostOne(ProdutoModel model);

        public ProdutoModel GetOne(Guid id);

        public string PutOne(ProdutoModel model);

        public string Delete(ProdutoModel model);
    }
}
