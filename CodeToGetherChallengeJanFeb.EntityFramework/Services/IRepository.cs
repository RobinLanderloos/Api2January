using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.EntityFramework.Services
{
    /*
     Made this from a service into a repository
     
     Repositories are more commonly used for handling data access.
     */
    public interface IRepository<T>
    {
        public Task<T> Get(int id);
        public Task<IEnumerable<T>> GetAll();
    }
}
