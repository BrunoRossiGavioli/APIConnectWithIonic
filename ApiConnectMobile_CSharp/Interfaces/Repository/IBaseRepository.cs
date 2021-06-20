using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConnectMobile_CSharp.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public ICollection<T> GetAll();

        public string PostOne(T model);

        public T GetOne(Guid id);

        public string PutOne(T model);

        public string Delete(T model);
    }
}
