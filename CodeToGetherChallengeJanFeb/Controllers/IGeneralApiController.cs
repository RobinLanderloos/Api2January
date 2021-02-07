using CodeToGetherChallengeJanFeb.EntityFramework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.Controllers
{
    public interface IGeneralApiController<T> where T : BaseModel
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(int id);
    }
}
