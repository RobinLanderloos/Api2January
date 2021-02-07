using CodeToGetherChallengeJanFeb.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.EntityFramework.Services
{
    public class GenericDataService<T> : IService<T> where T : BaseModel
    {
        public DbContext context;

        public GenericDataService(DbContext context)
        {
            this.context = context;
        }

        public async Task<T> Get(int id)
        {
            return await context.Set<T>().FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
