using CodeToGetherChallengeJanFeb.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeToGetherChallengeJanFeb.EntityFramework.EntityFramework
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options) { }
    }
}
