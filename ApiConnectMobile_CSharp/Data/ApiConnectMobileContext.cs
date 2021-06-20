using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiConnectMobile_CSharp.Models;

namespace ApiConnectMobile_CSharp.Data
{
    public class ApiConnectMobileContext : DbContext
    {
        public ApiConnectMobileContext (DbContextOptions<ApiConnectMobileContext> options)
            : base(options)
        {
        }

        public DbSet<ApiConnectMobile_CSharp.Models.ProdutoModel> ProdutoModel { get; set; }
    }
}
