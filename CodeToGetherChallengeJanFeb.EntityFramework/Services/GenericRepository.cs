using CodeToGetherChallengeJanFeb.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.EntityFramework.Services
{
    public class GenericRepository<T> : IRepository<T> where T : BaseModel
    {
        private readonly DbContext context;

        public GenericRepository(DbContext context)
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
