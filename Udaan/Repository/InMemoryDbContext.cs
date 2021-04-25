using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udaan.Model;

namespace Udaan.Repository
{
    public class InMemoryDbContext:DbContext
    {
        public InMemoryDbContext(DbContextOptions<InMemoryDbContext> options) : base(options)
        {

        }

        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
