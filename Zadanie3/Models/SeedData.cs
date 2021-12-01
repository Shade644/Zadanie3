using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zadanie3.Data;
using System;
using System.Linq;

namespace Zadanie3.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GamesContext>>()))
            {
                
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }

                
                context.SaveChanges();
            }
        }
    }
}