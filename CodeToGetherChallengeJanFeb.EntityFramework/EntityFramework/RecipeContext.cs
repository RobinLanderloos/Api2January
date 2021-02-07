using CodeToGetherChallengeJanFeb.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToGetherChallengeJanFeb.EntityFramework.EntityFramework
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options) { }
    }
}
