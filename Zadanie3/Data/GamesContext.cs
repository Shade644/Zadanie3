using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zadanie3.Models;

namespace Zadanie3.Data
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options)
            : base(options)
        {
        }

        public DbSet<Zadanie3.Models.Games> Games { get; set; }
    }
}
