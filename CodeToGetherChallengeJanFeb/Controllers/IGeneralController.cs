using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.Controllers
{
    public interface IGeneralController<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(int id);
    }
}
