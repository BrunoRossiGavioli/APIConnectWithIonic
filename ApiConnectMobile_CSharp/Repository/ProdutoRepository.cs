using ApiConnectMobile_CSharp.Data;
using ApiConnectMobile_CSharp.Interfaces.Repository;
using ApiConnectMobile_CSharp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnectMobile_CSharp.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApiConnectMobileContext _context;

        public ProdutoRepository(ApiConnectMobileContext context)
        {
            _context = context;
        }

        public ICollection<ProdutoModel> GetAll()
        {
            return _context.ProdutoModel.ToList();
        }

        public ProdutoModel GetOne(Guid id)
        {
            return _context.ProdutoModel.Find(id);
        }

        public string PostOne(ProdutoModel model)
        {
            try
            {
                _context.ProdutoModel.Add(model);
                _context.SaveChanges();
                return "";
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public string PutOne(ProdutoModel model)
        {
            try
            {
                _context.Entry(model).State = EntityState.Modified;
                _context.SaveChanges();
                return "";
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
        public string Delete(ProdutoModel model)
        {
            try
            {
                _context.ProdutoModel.Remove(model);
                _context.SaveChanges();
                return "";
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
    }
}
