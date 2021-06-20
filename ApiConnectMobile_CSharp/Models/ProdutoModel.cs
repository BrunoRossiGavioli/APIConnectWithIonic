using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnectMobile_CSharp.Models
{
    [Table("Produto")]
    public class ProdutoModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public bool Marcado { get; set; }
    }
}
